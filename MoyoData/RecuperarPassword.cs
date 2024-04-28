using MoyoData.Models;
using MySql.Data.MySqlClient;
using Mysqlx;
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
    public partial class RecuperarPassword : Form
    {
        int contador = 0;
        BaseDeDatos conexion = new BaseDeDatos();
        string consulta;
        public RecuperarPassword()
        {
            InitializeComponent();
        }

        private void BtnRecuperarPassword_Click(object sender, EventArgs e)
        {
            // Validación
            if (TbxRecuperarNombres.Text == "")
            {
                MessageBox.Show("Ingrese un nombre.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TbxRespuestaRecuperarPassword.Text == "")
            {
                MessageBox.Show("Ingrese un respuesta.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Variables para ingresar usuario.
            string nombreUsuario = TbxRecuperarNombres.Text;
            string password;
            string respuesta = Encriptar(TbxRespuestaRecuperarPassword.Text);

            //Validación.
            if (conexion.Conectar() == null)
            {
                MessageBox.Show("Error al conectar la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("No se encontró el usuario.");
                mySqlDataReader.Close();
                return;
                
            }

            if (contador>=3)
            {
                MessageBox.Show("Se ha quedado sin intentos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
