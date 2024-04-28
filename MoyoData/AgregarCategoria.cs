using MoyoData.Models;
using MySql.Data.MySqlClient;
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
    public partial class AgregarCategoria : Form
    {
        BaseDeDatos conexion;
        public AgregarCategoria()
        {
            InitializeComponent();
            conexion = new BaseDeDatos();
        }

        private void BtnActualizarCategoria_Click(object sender, EventArgs e)
        {
            //Validación.
            if (TbxCategoria.Text == "")
            {
                MessageBox.Show("Ingrese una unidad de medida");
                return;
            }

            string categoria = TbxCategoria.Text;

            MySqlDataReader mySqlDataReader = null;
            string buscar = "Select * from TCategorias where categoria = '" + categoria + "'";

            //Generación de las consultas para buscar si existe el nombre.
            MySqlCommand mySqlCommandBuscar = new MySqlCommand(buscar);
            mySqlCommandBuscar.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommandBuscar.ExecuteReader();

            if (mySqlDataReader.HasRows)
            {
                MessageBox.Show("La categoría ya existe.");
                return;
            }

            mySqlDataReader.Close();

            //Variables para la base de datos.
            string consulta = "Insert Into tCategorias (Categoria) " +
                              "Values ('" + categoria + "')";
            MySqlCommand mySqlCommandInsertar = new MySqlCommand(consulta);
            mySqlCommandInsertar.Connection = conexion.Conectar();
            mySqlCommandInsertar.ExecuteNonQuery();
            MessageBox.Show("Se ha registrado la categoría.");
            this.Close();
        }
    }
}
