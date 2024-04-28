using MoyoData.Models;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace MoyoData
{
    public partial class Login : Form
    {
        //----------------------
        // ATRIBUTOS
        //----------------------
        private BaseDeDatos conexion;
        public Usuario usuario;

        //-----------------------
        // Constructor
        //-----------------------
        public Login()
        {
            InitializeComponent();
            conexion = new BaseDeDatos();
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

        #region Botón para iniciar sesión
        //-------------------------------
        // Botón para iniciar sesión
        //-------------------------------
        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Validación
            if (TbxUsuario.Text == "Usuario")
            {
                MessageBox.Show("Ingrese un usuario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TbxPassword.Text == "Contraseña")
            {
                MessageBox.Show("Ingrese la contraseña", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (conexion.Conectar () == null)
            {
                MessageBox.Show("Error al conectar la base de datos.");
                return;
            }
                
            //Entidades a usar.
            string nombreUsuario = TbxUsuario.Text;
            string password = GenerarSHA1(TbxPassword.Text);
            //string rol = ""; Se tiene planeado tener distintas vistas dependiendo el rol.
            MySqlDataReader mySqlDataReader = null;
            string consulta = "Select * from tusuarios where Usuario = '" + nombreUsuario + "'";

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron resultados.");
                return;
            }
            
            while (mySqlDataReader.Read())
            {
                usuario = new Usuario(mySqlDataReader["usuario"].ToString(), mySqlDataReader["password"].ToString(), mySqlDataReader["troles_idrol"].ToString());

                if (password != usuario.password)
                {
                    MessageBox.Show("Constraseña incorrecta.");
                    mySqlDataReader.Close();
                    return;
                }

                if (usuario.rol == "1")
                {
                    MessageBox.Show("Validación exitosa.");
                    mySqlDataReader.Close();
                    VentanaInicio VentanaInicio = new VentanaInicio(usuario);
                    this.Hide();
                    VentanaInicio.ShowDialog();
                    return;
                }
                else
                {
                    MessageBox.Show("Usted no es administrador.");
                    mySqlDataReader.Close();
                    return;
                }
            }
        }
        #endregion

        #region Cifrar cotraseña
        //---------------------------------------------------------------------
        //Función que cifra la contraseña.
        //---------------------------------------------------------------------
        private string GenerarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] resultado;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            resultado = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < resultado.Length; i++)
            {
                if (resultado[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(resultado[i].ToString("x"));
            }

            return sb.ToString();
        }
        #endregion

        #region Movimiento de la ventana
        //--------------------------------
        // Cerrar ventana
        //--------------------------------
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //--------------------------------
        // Minimizar ventana
        //--------------------------------
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //--------------------------------
        // Arratrar ventana
        //--------------------------------
        // En formulario
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // En panel
        private void panelIzquierdo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Validación de diseño de campos textboxes para iniciar sesion
        //-----------------------------------------------------
        // Resaltar cuando el puntero entra del
        // Textbox Usuario
        //-----------------------------------------------------
        private void TbxUsuario_Enter(object sender, EventArgs e)
        {
            if(TbxUsuario.Text == "Usuario")
            {
                TbxUsuario.Text = "";
                TbxUsuario.ForeColor = Color.Black;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero sale del
        // Textbox Usuario
        //-----------------------------------------------------
        private void TbxUsuario_Leave(object sender, EventArgs e)
        {
            if (TbxUsuario.Text == "")
            {
                TbxUsuario.Text = "Usuario";
                TbxUsuario.ForeColor= Color.DimGray;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero entra del
        // Textbox Password
        //-----------------------------------------------------
        private void TbxPassword_Enter(object sender, EventArgs e)
        {
            if(TbxPassword.Text == "Contraseña")
            {
                TbxPassword.Text = "";
                TbxPassword.ForeColor = Color.Black;
                TbxPassword.UseSystemPasswordChar = true;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero sale del
        // Textbox Password
        //-----------------------------------------------------
        private void TbxPassword_Leave(object sender, EventArgs e)
        {
            if (TbxPassword.Text == "")
            {
                TbxPassword.Text = "Contraseña";
                TbxPassword.ForeColor = Color.DimGray;
                TbxPassword.UseSystemPasswordChar = false;
            }
        }

        //-----------------------------------------------------
        // Validar que el campo de TbxUsuario
        // sólo admita la entrada de letras
        //-----------------------------------------------------
        private void TbxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 163) || (e.KeyChar >= 165 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo puede ingresar letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //-----------------------------------------------------
        // Validar que el campo de TbxUsuario
        // sólo admita la entrada de letras y números
        //-----------------------------------------------------
        private void TbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo puede ingresar letras y números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        #endregion
    }
}
