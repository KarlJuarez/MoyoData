﻿using MoyoData.Models;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MoyoData
{
    public partial class PaginaPrincipal : System.Windows.Forms.Form
    {
        Usuario usuario;
        BaseDeDatos conexion;
        public PaginaPrincipal(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            MessageBox.Show(usuario.usuario);
            conexion = new BaseDeDatos();
        }

        private void BtnTrabajador_Click(object sender, EventArgs e)
        {
            int result;
            string nombreUsuario = TxtNombre.Text + " " + TxtApellido.Text;
            string password = TxtPassword.Text;
            //string rol = "";
            MySqlDataReader mySqlDataReader = null;
            string consulta = "Insert Into tusuarios (usuario, password, troles_idrol) " +
                "Values ('"+ nombreUsuario +"', '" + password +"', 1)";
            string buscar = "Select * from tusuarios where Usuario = '" + nombreUsuario +"'";

            if (conexion.Conectar() != null)
            {
                MySqlCommand mySqlCommandBuscar = new MySqlCommand(buscar);
                mySqlCommandBuscar.Connection = conexion.Conectar();
                mySqlDataReader = mySqlCommandBuscar.ExecuteReader();

                if (mySqlDataReader.HasRows)
                {
                    
                    MessageBox.Show("Registro fallido. Nombre de usuario ya existente.");
                    while (mySqlDataReader.Read())
                    {
                        Usuario usuarioNuevo = new Usuario(mySqlDataReader["usuario"].ToString(), mySqlDataReader["password"].ToString(), mySqlDataReader["troles_idrol"].ToString());
                        MessageBox.Show(usuarioNuevo.usuario.ToString());                        
                    }
                    mySqlDataReader.Close();
                }
                else
                {
                    mySqlDataReader.Close();
                    MySqlCommand mySqlCommandInsertar = new MySqlCommand(consulta);
                    mySqlCommandInsertar.Connection = conexion.Conectar();
                    result = mySqlCommandInsertar.ExecuteNonQuery();
                    MessageBox.Show(result.ToString());
                }
            }
            else
            {
                MessageBox.Show("Error al conectar la base de datos.");
            }
        }
    }
}
