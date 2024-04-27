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
    public partial class AgregarTipoProducto : Form
    {
        BaseDeDatos conexion;
        string consulta;
        public AgregarTipoProducto()
        {
            InitializeComponent();
            conexion = new BaseDeDatos();
            SeleccionarCategorias();
        }

        private void BtnAgregarTipoProducto_Click(object sender, EventArgs e)
        {
            //Validación.
            if (TbxTipoProducto.Text == "")
            {
                MessageBox.Show("Ingrese un tipo de producto.");
                return;
            }
            if (CbxCategoriaTipoProducto.SelectedIndex <= -1)
            {
                MessageBox.Show("Ingrese una cateporía.");
                return;
            }

            string tipoProducto = TbxTipoProducto.Text;
            int idTipoProducto = CbxCategoriaTipoProducto.SelectedIndex +1 ;

            MySqlDataReader mySqlDataReader = null;
            string buscar = "Select * from TTiposProductos where TipoProducto = '" + tipoProducto + "' AND  TCategorias_idCategoria =" + idTipoProducto;

            //Generación de las consultas para buscar si existe el nombre.
            MySqlCommand mySqlCommandBuscar = new MySqlCommand(buscar);
            mySqlCommandBuscar.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommandBuscar.ExecuteReader();

            if (mySqlDataReader.HasRows)
            {
                MessageBox.Show("El tipo de producto ya existe.");
                return;
            }

            mySqlDataReader.Close();

            //Variables para la base de datos.
            string consulta = "Insert Into TTiposProductos (TipoProducto, TCategorias_idCategoria) " +
                              "Values ('" + tipoProducto + "', "+ idTipoProducto.ToString() + ")";
            MySqlCommand mySqlCommandInsertar = new MySqlCommand(consulta);
            mySqlCommandInsertar.Connection = conexion.Conectar();
            mySqlCommandInsertar.ExecuteNonQuery();
            MessageBox.Show("Se ha registrado el tipo de producto");
            this.Close();
        }

        private void SeleccionarCategorias()
        {
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select categoria from TCategorias";

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron categorías");
                return;
            }

            while (mySqlDataReader.Read())
            {
                CbxCategoriaTipoProducto.Items.Add(mySqlDataReader["Categoria"].ToString());
            }

            mySqlDataReader.Close();
        }
    }
}
