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
    public partial class EditarTipoProducto : Form
    {

        TipoProducto tipoProducto;
        BaseDeDatos conexion = new BaseDeDatos();
        string consulta;
        public EditarTipoProducto(TipoProducto tipoProducto)
        {
            InitializeComponent();
            this.tipoProducto = tipoProducto;
            SeleccionarCategorias();
            TbxTipoProducto.Text = this.tipoProducto.tipoProducto;
            CbxCategoriaTipoProducto.SelectedIndex = this.tipoProducto.categoria - 1;
        }

        private void BtnActualizarTipoProducto_Click(object sender, EventArgs e)
        {
            //Validación.
            if (TbxTipoProducto.Text == "")
            {
                MessageBox.Show("Ingrese un producto");
                return;
            }

            if (CbxCategoriaTipoProducto.SelectedIndex <= -1)
            {
                MessageBox.Show("Ingrese una categoría");
                return;
            }

            string tipoProductoNombre = TbxTipoProducto.Text;


            //Variables.
            TipoProducto tipoProductoActualizado = new TipoProducto(tipoProducto.id, tipoProductoNombre, CbxCategoriaTipoProducto.SelectedIndex+1);
            //Variables para la base de datos.
            string consulta = "Update TTiposProductos Set TipoProducto = '" + tipoProductoActualizado.tipoProducto 
                                                + "' , TCategorias_idCategoria = " + tipoProductoActualizado.categoria.ToString()
                                                + " where idTipoProducto = " + tipoProducto.id.ToString();
            MySqlCommand mySqlCommandInsertar = new MySqlCommand(consulta);
            mySqlCommandInsertar.Connection = conexion.Conectar();
            mySqlCommandInsertar.ExecuteNonQuery();
            MessageBox.Show("Se ha actualizado el tipo producto");
            this.Close();
        }

        //---------------------------------------------------------------------
        //Función para mostrar las categorías.
        //---------------------------------------------------------------------
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
