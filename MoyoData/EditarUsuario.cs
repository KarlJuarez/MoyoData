using MoyoData.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoyoData
{
    public partial class EditarUsuario : Form
    {
        Usuario usuario;
        string consulta;
        BaseDeDatos conexion = new BaseDeDatos();
        List<Rol> roles = new List<Rol>();
        public EditarUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            TbxEditarNombres.Text = usuario.usuario;
            SeleccionarRoles();
            CbxEditarRol.SelectedIndex = roles.Find(p=> p.rol == usuario.rol).id -1;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            // Validación
            if (TbxEditarNombres.Text == "")
            {
                MessageBox.Show("Ingrese un nombre.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Validación.
            if (TbxEditarPassword.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TbxRespuestaRecuperarPassword.Text == "")
            {
                MessageBox.Show("Ingrese un respuesta.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Validación.
            if (CbxEditarRol.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un rol.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Variables para ingresar usuario.
            string nombreUsuario = TbxEditarNombres.Text;
            string password = Encriptar(TbxEditarPassword.Text);
            string respuesta = Encriptar(TbxRespuestaRecuperarPassword.Text);
            Rol rol = roles.Find(p=>p.rol == CbxEditarRol.SelectedItem.ToString());

            //Validación.
            if (conexion.Conectar() == null)
            {
                MessageBox.Show("Error al conectar la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (password != usuario.password)
            {
                MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            password = Encriptar(TbxPasswordNueva.Text);
            //Variables para la base de datos.
            consulta = "Update tusuarios  SET Usuario = '" + nombreUsuario
                                        + "', Password = '" + password
                                        + "', Respuesta = '" + respuesta
                                        + "', TRoles_idRol = " + rol.rol
                                        + " where Usuario = '" + usuario.usuario + "'";

            MySqlCommand mySqlCommandInsertar = new MySqlCommand(consulta);
            mySqlCommandInsertar.Connection = conexion.Conectar();
            mySqlCommandInsertar.ExecuteNonQuery();
            MessageBox.Show("Se ha registrado el usuario", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

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
                CbxEditarRol.Items.Add(rol.rol);
                roles.Add(rol);
            }

            mySqlDataReader.Close();
        }
        private string Encriptar(string mensaje)
        {
            string hash = "moyodata";
            byte[] data = UTF8Encoding.UTF8.GetBytes(mensaje);

            MD5 md5 = MD5.Create();
            TripleDES TripleDES = TripleDES.Create();

            TripleDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            TripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = TripleDES.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return Convert.ToBase64String(result);
        }

    }
}
