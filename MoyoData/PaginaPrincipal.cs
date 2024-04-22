using MoyoData.Models;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MoyoData
{
    public partial class PaginaPrincipal : System.Windows.Forms.Form
    {
        bool sidebarExpand = false;

        Usuario usuario;
        BaseDeDatos conexion;
        public PaginaPrincipal()

        {
            //this.usuario = usuario;
            InitializeComponent();
            sidebar.Width = sidebar.MinimumSize.Width;
            //MessageBox.Show(usuario.usuario);
            conexion = new BaseDeDatos();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
            var coords = new Point(PnlFondo.Location.X, PnlFondo.Location.Y);
            coords.X = sidebar.Location.X + sidebar.Width + 12;
            PnlFondo.Location = coords;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start(); 
        }
        
        private void BtnTrabajador_Click(object sender, EventArgs e)
        {
            //Variables para ingresar usuario.
            string nombreUsuario = TxtNombre.Text + " " + TxtApellido.Text;
            string password = GenerarSHA1(TxtPassword.Text);
            string conPassword = GenerarSHA1(TxtConfirmarPassword.Text);

            //Validación.
            if (conPassword != password)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            if (conexion.Conectar() == null)
            {
                MessageBox.Show("Error al conectar la base de datos.");
                return;
            }

            //Variables para la base de datos.
            MySqlDataReader mySqlDataReader = null;
            string consulta = "Insert Into tusuarios (usuario, password, troles_idrol) " +
                "Values ('" + nombreUsuario + "', '" + password + "', 1)";
            string buscar = "Select * from tusuarios where Usuario = '" + nombreUsuario + "'";
            
            //Generación de las consultas para buscar si existe el nombre.
            MySqlCommand mySqlCommandBuscar = new MySqlCommand(buscar);
            mySqlCommandBuscar.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommandBuscar.ExecuteReader();

            if (mySqlDataReader.HasRows)
            {
                MessageBox.Show("Registro fallido. Nombre de usuario ya existente.");
                mySqlDataReader.Close();
            }
            else
            {
                mySqlDataReader.Close();
                MySqlCommand mySqlCommandInsertar = new MySqlCommand(consulta);
                mySqlCommandInsertar.Connection = conexion.Conectar();
                mySqlCommandInsertar.ExecuteNonQuery();
                MessageBox.Show("Se ha registrado el usuario");
            }
        }

        //---------------------------------------------------------------------
        //Función que cifra la contraseña.
        //---------------------------------------------------------------------
        private string GenerarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding ();
            byte[] data = enc.GetBytes (cadena);
            byte[] resultado;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider ();

            resultado = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < resultado.Length; i++)
            {
                if (resultado[i]<16)
                {
                    sb.Append("0");
                }
                sb.Append(resultado[i].ToString("x"));
            }

            return sb.ToString(); 
        }
    }
}
