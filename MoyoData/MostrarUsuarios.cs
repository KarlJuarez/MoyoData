using MoyoData.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        //Atrobutos
        string consulta;
        BaseDeDatos conexion = new BaseDeDatos();
        List<string> roles = new List<string>();
        public MostrarUsuarios()
        {
            InitializeComponent();
            CargarRoles();
            CargarUsuarios();
        }

        //----------------------
        // Cerrar formulario
        //----------------------
        private void PbxCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                MessageBox.Show("No se encontraron categorías");
                return;
            }

            while (mySqlDataReader.Read())
            {
                roles.Add(mySqlDataReader["Rol"].ToString());
            }

            mySqlDataReader.Close();
        }

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
                MessageBox.Show("No se encontraron usuario.");
                return;
            }

            while (mySqlDataReader.Read())
            {
                DgvUsuarios.Rows.Add(mySqlDataReader["idUsuario"].ToString(), mySqlDataReader["Usuario"].ToString(), mySqlDataReader["Password"].ToString(), roles[Convert.ToInt32(mySqlDataReader["TRoles_idRol"]) - 1], false);
            }

            mySqlDataReader.Close();
        }


        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar();
            registrar.ShowDialog();
            ActualizarUsuarios();
        }

        private void BtnEliminarUsuario_Click(object sender, EventArgs e)
        {
            int id;
            int totalSeleccion = DgvUsuarios.Rows.Cast<DataGridViewRow>().
                Where(p => Convert.ToBoolean(p.Cells["ColumSeleccionUsuarios"].Value)).Count();
            if (totalSeleccion <= 0)
            {
                MessageBox.Show("Seleccione algún usuario.");
                return;
            }

            DialogResult result = MessageBox.Show("¿Quiéres borrar los usuarios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            foreach (DataGridViewRow row in DgvUsuarios.Rows)
            {
                if (Convert.ToBoolean(row.Cells["ColumSeleccionUsuarios"].Value))
                {
                    id = Convert.ToInt32(row.Cells["ColumIDUsuarios"].Value);
                    consulta = "Delete from TUsuarios where idusuario = " + id.ToString();
                    MySqlCommand mySqlCommandBorrar = new MySqlCommand(consulta);
                    mySqlCommandBorrar.Connection = conexion.Conectar();
                    mySqlCommandBorrar.ExecuteNonQuery();

                }
            }
            ActualizarUsuarios();
            MessageBox.Show("Se ha borrado los usuarios.");
        }

        private void BtnEditarUsuario_Click(object sender, EventArgs e)
        {
            MySqlDataReader mySqlDataReader = null;
            Usuario usuario;
            int id;
            int totalSeleccion = DgvUsuarios.Rows.Cast<DataGridViewRow>().
                Where(p => Convert.ToBoolean(p.Cells["ColumSeleccionUsuarios"].Value)).Count();
            if (totalSeleccion <= 0)
            {
                MessageBox.Show("Seleccione algún usuario.");
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

        private void ActualizarUsuarios()
        {
            DgvUsuarios.Rows.Clear();
            CargarUsuarios();
        }

    }
}
