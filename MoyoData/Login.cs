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

namespace MoyoData
{
    public partial class Login : Form
    {
        private BaseDeDatos conexion;
        public Usuario usuario;
        public Login()
        {
            InitializeComponent();
            conexion = new BaseDeDatos();
        }

        //---------------------------------------------------------------------
        //Botón para iniciar sesión.
        //---------------------------------------------------------------------
        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            string resultado = "";
            string nombreUsuario = TbxCorreo.Text;
            string password = TbxPassword.Text;
            string rol = "";
            MySqlDataReader mySqlDataReader = null;
            string consulta = "Select * from tusuarios where Usuario = '" + nombreUsuario + "'";

            if (conexion.Conectar() != null)
            {
                MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                mySqlCommand.Connection = conexion.Conectar();
                mySqlDataReader = mySqlCommand.ExecuteReader();

                if (!mySqlDataReader.HasRows)
                {
                    mySqlDataReader = null;
                    MessageBox.Show("No se encontraron resultados.");
                }
                else
                {
                    while (mySqlDataReader.Read())
                    {
                        usuario = new Usuario(mySqlDataReader["usuario"].ToString(), mySqlDataReader["password"].ToString(), mySqlDataReader["troles_idrol"].ToString());
                        if (password == usuario.password)
                        {
                            if (usuario.rol == "1")
                            { 
                                MessageBox.Show("Validación exitosa.");
                                PaginaPrincipal paginaPrincipal = new PaginaPrincipal(usuario);
                                paginaPrincipal.Show();
                            }
                            else
                            {
                                MessageBox.Show("Usted no es administrador.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Constraseña incorrecta.");
                        }                        
                        
                    }
                }
            }
            else 
            {
                MessageBox.Show("Ayudaaaaaaaaaaaaaa");
            }
        }
    }
}
