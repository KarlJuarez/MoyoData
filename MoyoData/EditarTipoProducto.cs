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
        List<Categoria> categorias = new List<Categoria>();
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
            Categoria categoria = categorias.Find(p => p.categoria == CbxCategoriaTipoProducto.SelectedItem.ToString());


            //Variables.
            TipoProducto tipoProductoActualizado = new TipoProducto(tipoProducto.id, tipoProductoNombre, categoria.id);
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
            consulta = "Select * from TCategorias";
            Categoria categoria;

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron categorías", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
