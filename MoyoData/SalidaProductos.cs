using MoyoData.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoyoData
{
    public partial class SalidaProductos : Form
    {
        //-----------------------------------//
        // ATRIBUTOS
        //-----------------------------------//
        BaseDeDatos conexion = new BaseDeDatos();
        string consulta;
        List<Producto> productos = new List<Producto>();
        List <Usuario> usuarios = new List<Usuario>();
        List<Rol> roles = new List<Rol>();
        Usuario usuario;
        string idRol;

        //-----------------------
        // Constructor
        //-----------------------
        public SalidaProductos(Usuario usuario)
        {
            InitializeComponent();
            SeleccionarProductos();
            SeleccionarUsuarios();
            CargarDatos();
            SeleccionarRoles();
            DgvSalidaProductos.Columns[1].ReadOnly = true;
            DgvSalidaProductos.Columns[2].ReadOnly = true;
            DgvSalidaProductos.Columns[3].ReadOnly = true;
            DgvSalidaProductos.Columns[4].ReadOnly = true;
            DgvSalidaProductos.Columns[5].ReadOnly = true;
            this.usuario = usuario;
            idRol = roles.Find(p => p.rol == "Administrador").id.ToString();

            if (this.usuario.rol != idRol)
            {
                BtnSalidaProductoEliminar.Dispose();
            }
        }

        //--------------------
        // Cerrar formulario
        //--------------------
        private void PbxCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Función para seleccionar roles
        //-----------------------
        // Seleccionar roles
        //-----------------------
        private void SeleccionarRoles()
        {
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select * from TRoles";
            Rol rol;

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron roles", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            while (mySqlDataReader.Read())
            {
                rol = new Rol(Convert.ToInt32(mySqlDataReader["idRol"].ToString()), mySqlDataReader["Rol"].ToString());
                roles.Add(rol);
            }

            mySqlDataReader.Close();
        }
        #endregion

        #region Función para seleccionar productos
        //-------------------------
        // Seleccionar productos
        //-------------------------
        private void SeleccionarProductos()
        {
            MySqlDataReader mySqlDataReader = null;
            Producto producto;
            consulta = "Select * from TProductos";

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron productos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            while (mySqlDataReader.Read())
            {
                producto = new Producto(Convert.ToInt32(mySqlDataReader["idProducto"]), mySqlDataReader["NombreProducto"].ToString());
                productos.Add(producto);
            }
            mySqlDataReader.Close();
        }
        #endregion

        #region Función para seleccionar usuarios
        //-----------------------------
        // Seleccionar usuarios
        //-----------------------------
        private void SeleccionarUsuarios()
        {
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select * from TUsuarios";
            Usuario usuario;

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron usuarios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            while (mySqlDataReader.Read())
            {
                usuario = new Usuario(Convert.ToInt32(mySqlDataReader["idUsuario"].ToString()), mySqlDataReader["usuario"].ToString());
                usuarios.Add(usuario);
            }
            mySqlDataReader.Close();
        }
        #endregion

        #region Función para cargar datos en DgvSalidaProductos
        //----------------------------------------
        // Cargar datos en DgvSalidaProductos
        //----------------------------------------
        private void CargarDatos()
        {
            DgvSalidaProductos.Rows.Clear();
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select * from TProductos_has_TSalidaProductos";
            int id;
            Producto producto;
            string fecha;
            Usuario usuario;

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron salidas de productos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            while (mySqlDataReader.Read())
            {
                id = Convert.ToInt32(mySqlDataReader["TSalidaProductos_idSalidaProducto"]);
                producto = productos.Find(p => p.Id == Convert.ToInt32(mySqlDataReader["TProductos_idProducto"]));
                DgvSalidaProductos.Rows.Add(false, id, "", "", producto.producto,
                                            mySqlDataReader["CantidadProducto"]);
            }

            mySqlDataReader.Close();

            consulta = "Select * from TSalidaProductos";

            mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                id = Convert.ToInt32(mySqlDataReader["idSalidaProducto"]);
                fecha = mySqlDataReader["FechaExpedicion"].ToString();
                usuario = usuarios.Find(p => p.id == Convert.ToInt32(mySqlDataReader["TUsuarios_idUsuario"]));
                foreach (DataGridViewRow row in DgvSalidaProductos.Rows)
                {
                    if (id == Convert.ToInt32(DgvSalidaProductos.Rows[row.Index].Cells["ColumID"].Value))
                    {
                        DgvSalidaProductos.Rows[row.Index].Cells["ColumFecha"].Value = fecha;
                        DgvSalidaProductos.Rows[row.Index].Cells["ColumUsuario"].Value = usuario.usuario;
                    }
                }
            }
            mySqlDataReader.Close();
        }
        #endregion

        #region Botón para agregar salida de producto
        //-----------------------------
        // Agregar salida de producto
        //-----------------------------
        private void BtnSalidaProductoAgregar_Click(object sender, EventArgs e)
        {
            AgregarSalidaProducto agregarSalidaProducto = new AgregarSalidaProducto();
            agregarSalidaProducto.ShowDialog();
            CargarDatos();
        }
        #endregion

        #region Botón para eliminar salida de producto
        //-------------------------------
        // Eliminar salida de producto
        //-------------------------------
        private void BtnSalidaProductoEliminar_Click(object sender, EventArgs e)
        {
            int id;
            int totalSeleccion = DgvSalidaProductos.Rows.Cast<DataGridViewRow>().
                Where(p => Convert.ToBoolean(p.Cells["ColumSeleccion"].Value)).Count();
            if (totalSeleccion <= 0)
            {
                MessageBox.Show("Seleccione alguna salida de productos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("¿Quiéres borrar la salida del producto?"
                , "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            foreach (DataGridViewRow row in DgvSalidaProductos.Rows)
            {
                if (Convert.ToBoolean(row.Cells["ColumSeleccion"].Value))
                {
                    id = Convert.ToInt32(row.Cells["ColumID"].Value);

                    consulta = "Delete from TProductos_has_TSalidaProductos where TSalidaProductos_idSalidaProducto = " + id.ToString();
                    MySqlCommand mySqlCommandBorrarSalidaProductos = new MySqlCommand(consulta);
                    mySqlCommandBorrarSalidaProductos.Connection = conexion.Conectar();
                    mySqlCommandBorrarSalidaProductos.ExecuteNonQuery();

                    consulta = "Delete from TSalidaProductos where idSalidaProducto = " + id.ToString();
                    MySqlCommand mySqlCommandBorrar = new MySqlCommand(consulta);
                    mySqlCommandBorrar.Connection = conexion.Conectar();
                    mySqlCommandBorrar.ExecuteNonQuery();

                }
            }
            CargarDatos();
            MessageBox.Show("Se ha borrado las salidas de productos", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
