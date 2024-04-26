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
    public partial class AgregarProducto : Form
    {
        BaseDeDatos conexion;
        string consulta;
        string buscarCategoria;
        public AgregarProducto()
        {
            InitializeComponent();
            conexion = new BaseDeDatos();
            SeleccionarCategorias();
            SeleccionarUnidadMedida();
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
                CbxCategoriasAgregarProducto.Items.Add(mySqlDataReader["Categoria"].ToString());
            }

            mySqlDataReader.Close();
        }

        //---------------------------------------------------------------------
        //Función para mostrar las categorías.
        //---------------------------------------------------------------------
        private void SeleccionarUnidadMedida()
        {
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select UnidadMedida from TUnidadesMedidas";

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron unidades de medida");
                return;
            }

            while (mySqlDataReader.Read())
            {
                CbxUnidadesMedidasAgregarProducto.Items.Add(mySqlDataReader["UnidadMedida"].ToString());
            }

            mySqlDataReader.Close();
        }

        //---------------------------------------------------------------------
        //Botón para agregar un producto.
        //---------------------------------------------------------------------

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            //Validación.
            if (TbxProductoAgregarProducto.Text == "")
            {
                MessageBox.Show("Ingrese un producto");
                return;
            }

            if (NumUDCantidadAgregarProducto.Value <= 0)
            {
                MessageBox.Show("Ingrese un número para el stock.");
                return;
            }

            if (NumUDLimiteAgregarProducto.Value <= 0)
            {
                MessageBox.Show("Ingrese un número para el límite al sacar el producto.");
                return;
            }

            if (CbxUnidadesMedidasAgregarProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una unidad de medida.");
                return;
            }

            if (CbxCategoriasAgregarProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoría.");
                return;
            }

            if (CbxTipoProductoAgregarProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de producto.");
                return;
            }

            int categoria = CbxCategoriasAgregarProducto.SelectedIndex + 1;
            int idTipoProducto;
            int idUnidadMedida = CbxUnidadesMedidasAgregarProducto.SelectedIndex + 1;

            MySqlDataReader mySqlDataReader = null;
            string buscar = "Select idTipoProducto from tTiposproductos where TipoProducto = '" + CbxTipoProductoAgregarProducto.SelectedItem + "'  AND TCategorias_idCategoria = " + categoria;

            //Generación de las consultas para buscar si existe el nombre.
            MySqlCommand mySqlCommandBuscar = new MySqlCommand(buscar);
            mySqlCommandBuscar.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommandBuscar.ExecuteReader();

            if (mySqlDataReader.Read())
            {
                idTipoProducto = Convert.ToInt32(mySqlDataReader["idTipoProducto"].ToString());
            }
            else
            {
                MessageBox.Show("No se encontró el id del producto.");
                return;
            }
            mySqlDataReader.Close();


            //Variables.
            Producto producto = new Producto(TbxProductoAgregarProducto.Text, Convert.ToInt32(NumUDCantidadAgregarProducto.Value), Convert.ToInt32(NumUDCantidadAgregarProducto.Value), Convert.ToInt32(NumUDLimiteAgregarProducto.Value), idUnidadMedida, idTipoProducto);

            //Variables para la base de datos.
            string consulta = "Insert Into tproductos (NombreProducto, Stock, CantidadProducto, LimiteSacarProducto, " +
                              "TUnidadesMedidas_idUnidadMedida, TTiposProductos_idTipoProducto) " +
                              "Values ('" + producto.producto + "', " + producto.stock.ToString() + ", '" + producto.cantidadProducto + "', " + producto.limteProducto + ", " +
                              "" + producto.unidadMedida + ", " + producto.tipoProducto + ")";
            buscar = "Select * from tproductos where NombreProducto = '" + producto.producto + "'";

            //Generación de las consultas para buscar si existe el nombre.
            mySqlCommandBuscar = new MySqlCommand(buscar);
            mySqlCommandBuscar.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommandBuscar.ExecuteReader();

            if (mySqlDataReader.HasRows)
            {
                MessageBox.Show("Registro fallido. Nombre de producto ya existente.");
                mySqlDataReader.Close();
            }
            else
            {
                mySqlDataReader.Close();
                MySqlCommand mySqlCommandInsertar = new MySqlCommand(consulta);
                mySqlCommandInsertar.Connection = conexion.Conectar();
                mySqlCommandInsertar.ExecuteNonQuery();
                MessageBox.Show("Se ha registrado el producto");
            }
        }

        private void CbxCategoriasAgregarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpiamos el combobox.
            CbxTipoProductoAgregarProducto.DataSource = null;
            CbxTipoProductoAgregarProducto.Items.Clear();
            CbxTipoProductoAgregarProducto.Text = "";

            MySqlDataReader mySqlDataReader = null;
            int categoriaSeleccionada = CbxCategoriasAgregarProducto.SelectedIndex + 1;
            consulta = "Select TipoProducto from TTiposProductos Where TCategorias_idCategoria = " + categoriaSeleccionada;

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron tipos de productos con esa caategoría");
                return;
            }

            while (mySqlDataReader.Read())
            {
                CbxTipoProductoAgregarProducto.Items.Add(mySqlDataReader["TipoProducto"].ToString());
            }

            mySqlDataReader.Close();
        }
    }
}

