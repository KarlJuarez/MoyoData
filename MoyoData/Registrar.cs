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
    public partial class Registrar : Form
    {
        //------------------------------//
        // ATRIBUTOS
        //------------------------------//
        string consulta;
        BaseDeDatos conexion = new BaseDeDatos();
        Usuario usuario;
        List<Rol> roles = new List<Rol>();
        public Registrar()
        {
            InitializeComponent();
            SeleccionarRoles();
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

        //--------------------------
        // Cerrar formulario
        //--------------------------
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

        #region Botón para registrar usuario
        //--------------------------
        // Registrar usuario
        //--------------------------
        private void BtnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            // Validación
            if (TbxRegistrarNombres.Text == "")
            {
                MessageBox.Show("Ingrese un nombre.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Validación.
            if (TbxRegistrarApellidos.Text == "")
            {
                MessageBox.Show("Ingrese un apellido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Validación.
            if (TbxRegistrarPassword.Text == "")
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
            if (CbxRegistrarRol.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un rol.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Variables para ingresar usuario.
            string nombreUsuario = TbxRegistrarNombres.Text + " " + TbxRegistrarApellidos.Text;
            string password = Encriptar(TbxRegistrarPassword.Text);
            string respuesta = Encriptar(TbxRespuestaRecuperarPassword.Text);
            Rol rol = roles.Find(p=> p.rol == CbxRegistrarRol.SelectedItem.ToString());

            //Validación.
            if (conexion.Conectar() == null)
            {
                MessageBox.Show("Error al conectar la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Variables para la base de datos.
            MySqlDataReader mySqlDataReader = null;
            consulta = "Insert Into tusuarios (usuario, password, respuesta, troles_idrol) " +
                       "Values ('" + nombreUsuario + "', '" + password + "', '" + respuesta + "' ," + rol.id + " )";
            string buscar = "Select * from tusuarios where Usuario = '" + nombreUsuario + "'";
            //Generación de las consultas para buscar si existe el nombre.
            MySqlCommand mySqlCommandBuscar = new MySqlCommand(buscar);
            mySqlCommandBuscar.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommandBuscar.ExecuteReader();

            if (mySqlDataReader.HasRows)
            {
                MessageBox.Show("Nombre de usuario ya existente.", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mySqlDataReader.Close();
            }
            else
            {
                mySqlDataReader.Close();
                MySqlCommand mySqlCommandInsertar = new MySqlCommand(consulta);
                mySqlCommandInsertar.Connection = conexion.Conectar();
                mySqlCommandInsertar.ExecuteNonQuery();
                MessageBox.Show("Se ha registrado el usuario", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }
        #endregion

        #region Cifrar contraseña
        //---------------------------------------------------------------------
        //Función que cifra la contraseña.
        //---------------------------------------------------------------------
        private string Encriptar(string mensaje) {
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

        #region Mostrar roles
        //---------------------------------------------------------------------
        //Función para mostrar las categorías.
        //---------------------------------------------------------------------
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
                CbxRegistrarRol.Items.Add(rol.rol);
                roles.Add(rol);
            }

            mySqlDataReader.Close();
        }
        #endregion

        #region Validación de campos

        // TbxRegistrarNombres

        //-----------------------------------------------------
        // Resaltar cuando el puntero entra del
        // Textbox RegistrarNombres
        //-----------------------------------------------------
        private void TbxRegistrarNombres_Enter(object sender, EventArgs e)
        {
            if (TbxRegistrarNombres.Text == "Escribe aquí")
            {
                TbxRegistrarNombres.Text = "";
                TbxRegistrarNombres.ForeColor = Color.Black;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero sale del
        // Textbox RegistrarNombres
        //-----------------------------------------------------
        private void TbxRegistrarNombres_Leave(object sender, EventArgs e)
        {
            if (TbxRegistrarNombres.Text == "")
            {
                TbxRegistrarNombres.Text = "Escribe aquí";
                TbxRegistrarNombres.ForeColor = Color.DimGray;
            }
        }

        //-----------------------------------------------------
        // Validar que el campo de TbxRegistrarNombres
        // sólo admita la entrada de letras
        //-----------------------------------------------------
        private void TbxRegistrarNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo puede ingresar letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        // TbxRegistrarApellidos

        //-----------------------------------------------------
        // Resaltar cuando el puntero entra del
        // Textbox RegistrarApellidos
        //-----------------------------------------------------
        private void TbxRegistrarApellidos_Enter(object sender, EventArgs e)
        {
            if (TbxRegistrarApellidos.Text == "Escribe aquí")
            {
                TbxRegistrarApellidos.Text = "";
                TbxRegistrarApellidos.ForeColor = Color.Black;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero sale del
        // Textbox RegistrarApellidos
        //-----------------------------------------------------
        private void TbxRegistrarApellidos_Leave(object sender, EventArgs e)
        {
            if (TbxRegistrarApellidos.Text == "")
            {
                TbxRegistrarApellidos.Text = "Escribe aquí";
                TbxRegistrarApellidos.ForeColor = Color.DimGray;
            }
        }

        //-----------------------------------------------------
        // Validar que el campo de TbxRegistrarApellidos
        // sólo admita la entrada de letras
        //-----------------------------------------------------
        private void TbxRegistrarApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo puede ingresar letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }   
        }

        // TbxRegistrarPassword

        //-----------------------------------------------------
        // Resaltar cuando el puntero entra del
        // Textbox RegistrarPassword
        //-----------------------------------------------------
        private void TbxRegistrarPassword_Enter(object sender, EventArgs e)
        {
            if (TbxRegistrarPassword.Text == "Escribe aquí")
            {
                TbxRegistrarPassword.Text = "";
                TbxRegistrarPassword.ForeColor = Color.Black;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero sale del
        // Textbox RegistrarPassword
        //-----------------------------------------------------
        private void TbxRegistrarPassword_Leave(object sender, EventArgs e)
        {
            if (TbxRegistrarPassword.Text == "")
            {
                TbxRegistrarPassword.Text = "Escribe aquí";
                TbxRegistrarPassword.ForeColor = Color.DimGray;
            }
        }

        //-----------------------------------------------------
        // Validar que el campo de TbxRegistrarApellidos
        // sólo admita la entrada de letras y números
        //-----------------------------------------------------
        private void TbxRegistrarPassword_KeyPress(object sender, KeyPressEventArgs e)
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
        // Textbox RespuestaRecuperarPassword
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
        // Textbox RespuestaRecuperarPassword
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
        // Validar que el campo de TbxRegistrarApellidos
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
