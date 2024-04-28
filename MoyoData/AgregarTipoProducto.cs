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
        List<Categoria> categorias = new List<Categoria>();
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
            Categoria categoria = categorias.Find(p => p.categoria == CbxCategoriaTipoProducto.SelectedItem.ToString());

            MySqlDataReader mySqlDataReader = null;
            string buscar = "Select * from TTiposProductos where TipoProducto = '" + tipoProducto + "' AND  TCategorias_idCategoria =" + categoria.id;

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
                              "Values ('" + tipoProducto + "', "+ categoria.id.ToString() + ")";
            MySqlCommand mySqlCommandInsertar = new MySqlCommand(consulta);
            mySqlCommandInsertar.Connection = conexion.Conectar();
            mySqlCommandInsertar.ExecuteNonQuery();
            MessageBox.Show("Se ha registrado el tipo de producto");
            this.Close();
        }

        private void SeleccionarCategorias()
        {
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select * from TCategorias";
            Categoria categoria;

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
                categoria = new Categoria(Convert.ToInt32(mySqlDataReader["idCategoria"].ToString()), mySqlDataReader["Categoria"].ToString());
                CbxCategoriaTipoProducto.Items.Add(categoria.categoria);
                categorias.Add(categoria);
            }

            mySqlDataReader.Close();
        }
    }
}
