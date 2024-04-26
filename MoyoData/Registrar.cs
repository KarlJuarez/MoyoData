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
    public partial class Registrar : Form
    {
        //------------------------------//
        // ATRIBUTOS
        //------------------------------//
        string consulta;
        BaseDeDatos conexion = new BaseDeDatos();
        Usuario usuario;

        public Registrar()
        {
            InitializeComponent();
            SeleccionarRoles();
        }

        //--------------------------
        // Cerrar formulario
        //--------------------------
        private void PbxCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //--------------------------
        // Registrar usuario
        //--------------------------
        private void BtnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            //Validación.
            if (TbxRegistrarNombres.Text == "")
            {
                MessageBox.Show("Ingrese un nombre.");
                return;
            }

            //Validación.
            if (TbxRegistrarApellidos.Text == "")
            {
                MessageBox.Show("Ingrese un apellido.");
                return;
            }

            //Validación.
            if (TbxRegistrarPassword.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña.");
                return;
            }


            //Validación.
            if (CbxRegistrarRol.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un rol.");
                return;
            }

            //Variables para ingresar usuario.
            string nombreUsuario = TbxRegistrarNombres.Text + " " + TbxRegistrarApellidos.Text;
            string password = GenerarSHA1(TbxRegistrarPassword.Text);
            int rol = CbxRegistrarRol.SelectedIndex + 1;

            //Validación.
            if (conexion.Conectar() == null)
            {
                MessageBox.Show("Error al conectar la base de datos.");
                return;
            }

            //Variables para la base de datos.
            MySqlDataReader mySqlDataReader = null;
            consulta = "Insert Into tusuarios (usuario, password, troles_idrol) " +
                       "Values ('" + nombreUsuario + "', '" + password + "', " + rol + " )";
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
        //---------------------------------------------------------------------
        //Función para mostrar las categorías.
        //---------------------------------------------------------------------
        private void SeleccionarRoles()
        {
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select rol from TRoles";

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron roles");
                return;
            }

            while (mySqlDataReader.Read())
            {
                CbxRegistrarRol.Items.Add(mySqlDataReader["Rol"].ToString());
            }

            mySqlDataReader.Close();
        }

    }
}
