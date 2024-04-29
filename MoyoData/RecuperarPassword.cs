using MoyoData.Models;
using MySql.Data.MySqlClient;
using Mysqlx;
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
    public partial class RecuperarPassword : Form
    {
        //-----------------------------------//
        // ATRIBUTOS
        //-----------------------------------//
        int contador = 0;
        BaseDeDatos conexion = new BaseDeDatos();
        string consulta;

        //-----------------------
        // Constructor
        //-----------------------
        public RecuperarPassword()
        {
            InitializeComponent();
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

        #region Botón para recuperar contraseña
        //------------------------
        // Recuperar sontraseña
        //------------------------
        private void BtnRecuperarPassword_Click(object sender, EventArgs e)
        {
            // Validación
            if (TbxRecuperarNombres.Text == "")
            {
                MessageBox.Show("Ingrese un nombre", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TbxRespuestaRecuperarPassword.Text == "")
            {
                MessageBox.Show("Ingrese un respuesta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Variables para ingresar usuario.
            string nombreUsuario = TbxRecuperarNombres.Text;
            string password;
            string respuesta = Encriptar(TbxRespuestaRecuperarPassword.Text);

            //Validación.
            if (conexion.Conectar() == null)
            {
                MessageBox.Show("Error al conectar la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Variables para la base de datos.
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select * FROM tusuarios where Usuario = '" + nombreUsuario + "'";
            //Generación de las consultas para buscar si existe el nombre.
            MySqlCommand mySqlCommandBuscar = new MySqlCommand(consulta);
            mySqlCommandBuscar.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommandBuscar.ExecuteReader();

            if (!mySqlDataReader.Read())
            {
                MessageBox.Show("No se encontró el usuario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mySqlDataReader.Close();
                return;
                
            }

            if (contador>=3)
            {
                MessageBox.Show("Se ha quedado sin intentos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mySqlDataReader.Close();
                this.Close();
                return;
            }

            if (respuesta != mySqlDataReader["Respuesta"].ToString())
            {
                contador += 1;
                MessageBox.Show("Respuesta incorrecta. Intento " + contador.ToString()+ " de 3.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mySqlDataReader.Close();
                return;
            }

            password = Desencriptar(mySqlDataReader["Password"].ToString());

            MessageBox.Show("La contraseña es: "+ password, "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mySqlDataReader.Close();

            this.Close();
        }
        #endregion

        #region Función para encriptar contraseña
        //-----------------------
        // Encriptar contraseña
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

        #region Función para encriptar contraseña
        //-----------------------
        // Encriptar contraseña
        //-----------------------
        private string Desencriptar(string mensajeEn)
        {
            string hash = "moyodata";
            byte[] data = Convert.FromBase64String(mensajeEn);

            MD5 md5 = MD5.Create();
            TripleDES TripleDES = TripleDES.Create();

            TripleDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            TripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = TripleDES.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return UTF8Encoding.UTF8.GetString(result);
        }
        #endregion

        #region Validación de campos
        // TbxRecuperarNombres

        //-----------------------------------------------------
        // Resaltar cuando el puntero entra del
        // Textbox TbxRecuperarNombres
        //-----------------------------------------------------
        private void TbxRecuperarNombres_Enter(object sender, EventArgs e)
        {
            if (TbxRecuperarNombres.Text == "Escribe aquí")
            {
                TbxRecuperarNombres.Text = "";
                TbxRecuperarNombres.ForeColor = Color.Black;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero sale del
        // Textbox TbxRecuperarNombres
        //-----------------------------------------------------
        private void TbxRecuperarNombres_Leave(object sender, EventArgs e)
        {
            if (TbxRecuperarNombres.Text == "")
            {
                TbxRecuperarNombres.Text = "Escribe aquí";
                TbxRecuperarNombres.ForeColor = Color.DimGray;
            }
        }

        //-----------------------------------------------------
        // Validar que el campo de TbxRecuperarNombres
        // sólo admita la entrada de letras
        //-----------------------------------------------------
        private void TbxRecuperarNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo puede ingresar letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
