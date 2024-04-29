using MoyoData.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoyoData
{
    public partial class EditarUsuario : Form
    {
        //-----------------------------------//
        // ATRIBUTOS
        //-----------------------------------//
        Usuario usuario;
        string consulta;
        BaseDeDatos conexion = new BaseDeDatos();
        List<Rol> roles = new List<Rol>();

        //-----------------------
        // Constructor
        //-----------------------
        public EditarUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            TbxEditarNombres.Text = usuario.usuario;
            SeleccionarRoles();
            CbxEditarRol.SelectedIndex = roles.Find(p=> p.rol == usuario.rol).id -1;
        }

        //--------------------------------
        // Importación para arrastrar
        // ventana
        //--------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
            int wparam, int lparam);

        //-----------------------------
        // Cerrar formulario
        //-----------------------------
        private void PbxCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //---------------------
        // Arrastrar ventana
        //---------------------
        private void PnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region Botón para editar usuario
        //-----------------------
        // Editar usuario
        //-----------------------
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            // Validación
            if (TbxEditarNombres.Text == "")
            {
                MessageBox.Show("Ingrese un nombre", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Validación.
            if (TbxEditarPassword.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TbxRespuestaRecuperarPassword.Text == "")
            {
                MessageBox.Show("Ingrese un respuesta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Validación.
            if (CbxEditarRol.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un rol", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("Error al conectar la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (password != usuario.password)
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        #endregion

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
                CbxEditarRol.Items.Add(rol.rol);
                roles.Add(rol);
            }

            mySqlDataReader.Close();
        }
        #endregion

        #region Función para encriptar contraseña y respuesta para recuperar contraseña
        //-----------------------
        // Encriptar
        //-----------------------
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
        #endregion

        #region Validación de campos

        // TbxEditarNombres

        //-----------------------------------------------------
        // Resaltar cuando el puntero entra del
        // Textbox EditarNombres
        //-----------------------------------------------------
        private void TbxEditarNombres_Enter(object sender, EventArgs e)
        {
            if (TbxEditarNombres.Text == "Escribe aquí")
            {
                TbxEditarNombres.Text = "";
                    TbxEditarNombres.ForeColor = Color.Black;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero sale del
        // Textbox EditarNombres
        //-----------------------------------------------------
        private void TbxEditarNombres_Leave(object sender, EventArgs e)
        {
            if (TbxEditarNombres.Text == "")
            {
                TbxEditarNombres.Text = "Escribe aquí";
                TbxEditarNombres.ForeColor = Color.DimGray;
            }
        }

        //-----------------------------------------------------
        // Validar que el campo de TbxEditarNombres
        // sólo admita la entrada de letras
        //-----------------------------------------------------
        private void TbxEditarNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo puede ingresar letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        // TbxEditarPassword

        //-----------------------------------------------------
        // Resaltar cuando el puntero entra del
        // Textbox TbxEditarPassword
        //-----------------------------------------------------
        private void TbxEditarPassword_Enter(object sender, EventArgs e)
        {
            if (TbxEditarPassword.Text == "Escribe aquí")
            {
                TbxEditarPassword.Text = "";
                TbxEditarPassword.ForeColor = Color.Black;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero sale del
        // Textbox TbxEditarPassword
        //-----------------------------------------------------
        private void TbxEditarPassword_Leave(object sender, EventArgs e)
        {
            if (TbxEditarPassword.Text == "")
            {
                TbxEditarPassword.Text = "Escribe aquí";
                TbxEditarPassword.ForeColor = Color.DimGray;
            }
        }

        //-----------------------------------------------------
        // Validar que el campo de TbxEditarPassword
        // sólo admita la entrada de letras y números
        //-----------------------------------------------------
        private void TbxEditarPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo puede ingresar letras y números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        // TbxPasswordNueva

        //-----------------------------------------------------
        // Resaltar cuando el puntero entra del
        // Textbox TbxPasswordNueva
        //-----------------------------------------------------
        private void TbxPasswordNueva_Enter(object sender, EventArgs e)
        {
            if (TbxPasswordNueva.Text == "Escribe aquí")
            {
                TbxPasswordNueva.Text = "";
                TbxPasswordNueva.ForeColor = Color.Black;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero sale del
        // Textbox TbxPasswordNueva
        //-----------------------------------------------------
        private void TbxPasswordNueva_Leave(object sender, EventArgs e)
        {
            if (TbxPasswordNueva.Text == "")
            {
                TbxPasswordNueva.Text = "Escribe aquí";
                TbxPasswordNueva.ForeColor = Color.DimGray;
            }
        }

        //-----------------------------------------------------
        // Validar que el campo de TbxPasswordNueva
        // sólo admita la entrada de letras y números
        //-----------------------------------------------------
        private void TbxPasswordNueva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo puede ingresar letras y números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        // TbxRespuestaRecuperarPassword

        //-----------------------------------------------------
        // Resaltar cuando el puntero entra del
        // Textbox TbxRespuestaRecuperarPassword
        //-----------------------------------------------------
        private void TbxRespuestaRecuperarPassword_Enter(object sender, EventArgs e)
        {
            if (TbxRespuestaRecuperarPassword.Text == "Escribe aquí")
            {
                TbxRespuestaRecuperarPassword.Text = "";
                TbxRespuestaRecuperarPassword.ForeColor = Color.Black;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero sale del
        // Textbox TbxRespuestaRecuperarPassword
        //-----------------------------------------------------
        private void TbxRespuestaRecuperarPassword_Leave(object sender, EventArgs e)
        {
            if (TbxRespuestaRecuperarPassword.Text == "")
            {
                TbxRespuestaRecuperarPassword.Text = "Escribe aquí";
                TbxRespuestaRecuperarPassword.ForeColor = Color.DimGray;
            }
        }

        //-----------------------------------------------------
        // Validar que el campo de TbxRespuestaRecuperarPassword
        // sólo admita la entrada de letras
        //-----------------------------------------------------
        private void TbxRespuestaRecuperarPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo puede ingresar letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        #endregion
    }
}
