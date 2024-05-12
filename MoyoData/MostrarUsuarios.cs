using MoyoData.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoyoData
{
    public partial class MostrarUsuarios : Form
    {
        //-----------------------------------//
        // ATRIBUTOS
        //-----------------------------------//
        string consulta;
        BaseDeDatos conexion = new BaseDeDatos();
        List<string> roles = new List<string>();

        //-----------------------
        // Constructor
        //-----------------------
        public MostrarUsuarios()
        {
            InitializeComponent();
            CargarRoles();
            CargarUsuarios();
            DgvUsuarios.Columns[1].ReadOnly = true;
            DgvUsuarios.Columns[2].ReadOnly = true;
            DgvUsuarios.Columns[3].ReadOnly = true;
            DgvUsuarios.Columns[4].ReadOnly = true;
        }

        //----------------------
        // Cerrar formulario
        //----------------------
        private void PbxCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Función para cargar roles
        //-----------------------
        // Cargar roles
        //-----------------------
        private void CargarRoles()
        {
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select * from TRoles";

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron categorías", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            while (mySqlDataReader.Read())
            {
                roles.Add(mySqlDataReader["Rol"].ToString());
            }

            mySqlDataReader.Close();
        }
        #endregion

        #region Función para cargar usuarios
        //-----------------------
        // Cargar usuarios
        //-----------------------
        private void CargarUsuarios()
        {
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select * from TUsuarios";

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron usuarios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            while (mySqlDataReader.Read())
            {
                DgvUsuarios.Rows.Add(false, mySqlDataReader["idUsuario"].ToString(), mySqlDataReader["Usuario"].ToString(), mySqlDataReader["Password"].ToString(), roles[Convert.ToInt32(mySqlDataReader["TRoles_idRol"]) - 1]);
            }

            mySqlDataReader.Close();
        }
        #endregion

        #region Botón para agregar usuario
        //-----------------------
        // Agregar usuario
        //-----------------------
        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar();
            registrar.ShowDialog();
            ActualizarUsuarios();
        }
        #endregion

        #region Botón para eliminar usuario
        //-----------------------
        // Eliminar usuario
        //-----------------------
        private void BtnEliminarUsuario_Click(object sender, EventArgs e)
        {
            int id;
            List<int> idSalidaProducto = new List<int>();
            List<int> idEntradaProducto = new List<int>();
            int totalSeleccion = DgvUsuarios.Rows.Cast<DataGridViewRow>().
                Where(p => Convert.ToBoolean(p.Cells["ColumSeleccionUsuarios"].Value)).Count();
            if (totalSeleccion <= 0)
            {
                MessageBox.Show("Seleccione algún usuario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("¿Quiéres borrar los usuarios? \n Se borrarán todas las salidas y entradas de productos relacionados al usuario.", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            foreach (DataGridViewRow row in DgvUsuarios.Rows)
            {
                if (Convert.ToBoolean(row.Cells["ColumSeleccionUsuarios"].Value))
                {
                    MySqlCommand mySqlCommand = new MySqlCommand();
                    if (row.Cells["ColumRolUsuarios"].Value.ToString() == "Administrador")
                    {
                        int idrol = roles.IndexOf(Convert.ToString(row.Cells["ColumRolUsuarios"].Value)) + 1;

                        consulta = "Select Count(*) from TUsuarios where TRoles_idrol = " + idrol;

                        mySqlCommand = new MySqlCommand(consulta);
                        mySqlCommand.Connection = conexion.Conectar();
                        int NumeroFilas = Convert.ToInt32( mySqlCommand.ExecuteScalar());

                        if (NumeroFilas <= 1)
                        {
                            MessageBox.Show("Único usuario administrador.\nDebe existir por lo menos un administrador", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    id = Convert.ToInt32(row.Cells["ColumIDUsuarios"].Value);

                    consulta = "Select * from TSalidaProductos where TUsuarios_idUsuario = " + id;
                    mySqlCommand = new MySqlCommand(consulta);
                    mySqlCommand.Connection = conexion.Conectar();
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                    if (mySqlDataReader.HasRows)
                    {
                        while (mySqlDataReader.Read())
                        {
                            idSalidaProducto.Add(Convert.ToInt32(mySqlDataReader["idSalidaProducto"]));
                        }
                    }
                    mySqlDataReader.Close();

                    for (int i = 0; i < idSalidaProducto.Count; i++)
                    {
                        consulta = "Delete from TProductos_has_TSalidaProductos where TSalidaProductos_idSalidaProducto = " + idSalidaProducto[i].ToString();
                        MySqlCommand mySqlCommandBorrarSalidaProductos = new MySqlCommand(consulta);
                        mySqlCommandBorrarSalidaProductos.Connection = conexion.Conectar();
                        mySqlCommandBorrarSalidaProductos.ExecuteNonQuery();

                        consulta = "Delete from TSalidaProductos where idSalidaProducto = " + idSalidaProducto[i].ToString();
                        mySqlCommandBorrarSalidaProductos = new MySqlCommand(consulta);
                        mySqlCommandBorrarSalidaProductos.Connection = conexion.Conectar();
                        mySqlCommandBorrarSalidaProductos.ExecuteNonQuery();
                    }

                    consulta = "Select * from TEntradaProductos where TUsuarios_idUsuario = " + id;

                    mySqlCommand = new MySqlCommand(consulta);
                    mySqlCommand.Connection = conexion.Conectar();
                    mySqlDataReader = mySqlCommand.ExecuteReader();

                    if (mySqlDataReader.HasRows)
                    {
                        while (mySqlDataReader.Read())
                        {
                            idEntradaProducto.Add(Convert.ToInt32(mySqlDataReader["idEntradaProducto"]));
                        }
                    }

                    mySqlDataReader.Close();

                    for (int i = 0; i < idEntradaProducto.Count; i++)
                    {
                        consulta = "Delete from TEntradaProductos_has_TProductos where TEntradaProductos_idEntradaProducto = " + idEntradaProducto[i].ToString();
                        MySqlCommand mySqlCommandBorrarSalidaProductos = new MySqlCommand(consulta);
                        mySqlCommandBorrarSalidaProductos.Connection = conexion.Conectar();
                        mySqlCommandBorrarSalidaProductos.ExecuteNonQuery();

                        consulta = "Delete from TEntradaProductos where idEntradaProducto = " + idEntradaProducto[i].ToString();
                        mySqlCommandBorrarSalidaProductos = new MySqlCommand(consulta);
                        mySqlCommandBorrarSalidaProductos.Connection = conexion.Conectar();
                        mySqlCommandBorrarSalidaProductos.ExecuteNonQuery();
                    }

                    consulta = "Delete from TUsuarios where idusuario = " + id.ToString();
                    MySqlCommand mySqlCommandBorrar = new MySqlCommand(consulta);
                    mySqlCommandBorrar.Connection = conexion.Conectar();
                    mySqlCommandBorrar.ExecuteNonQuery();
                }
            }
            ActualizarUsuarios();
            MessageBox.Show("Se ha borrado los usuarios", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Botón para editar usuario
        //-----------------------
        // Editar usuario
        //-----------------------
        private void BtnEditarUsuario_Click(object sender, EventArgs e)
        {
            MySqlDataReader mySqlDataReader = null;
            Usuario usuario;
            int id;
            int totalSeleccion = DgvUsuarios.Rows.Cast<DataGridViewRow>().
                Where(p => Convert.ToBoolean(p.Cells["ColumSeleccionUsuarios"].Value)).Count();
            if (totalSeleccion <= 0)
            {
                MessageBox.Show("Seleccione algún usuario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (DataGridViewRow row in DgvUsuarios.Rows)
            {
                if (Convert.ToBoolean(row.Cells["ColumSeleccionUsuarios"].Value))
                {
                    id = Convert.ToInt32(row.Cells["ColumIDUsuarios"].Value);
                    consulta = "Select * from TUsuarios where idUsuario = " + id.ToString();
                    MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                    mySqlCommand.Connection = conexion.Conectar();
                    mySqlDataReader = mySqlCommand.ExecuteReader();
                    mySqlDataReader.Read();

                    usuario = new Usuario(mySqlDataReader["Usuario"].ToString(), mySqlDataReader["Password"].ToString(), roles[Convert.ToInt32(mySqlDataReader["TRoles_idRol"])-1]);

                    mySqlDataReader.Close();
                    EditarUsuario editarUsuario = new EditarUsuario(usuario);
                    editarUsuario.ShowDialog();
                }
            }

            ActualizarUsuarios();
        }
        #endregion

        #region Función para actualizar usuarios
        //-----------------------
        // Actualizar usuarios
        //-----------------------
        private void ActualizarUsuarios()
        {
            DgvUsuarios.Rows.Clear();
            CargarUsuarios();
        }
        #endregion
    }
}
