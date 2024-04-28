using MoyoData.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MoyoData
{
    public partial class EditarProductos : Form
    {
        BaseDeDatos conexion = new BaseDeDatos();
        Producto producto;
        string consulta;
        string buscarCategoria;
        public EditarProductos(Producto producto)
        {
            InitializeComponent();
            SeleccionarCategorias();
            SeleccionarUnidadMedida();
            this.producto = producto;
            TbxProductoEditarProducto.Text = producto.producto;
            NumUDCantidadEditarProducto.Value = producto.cantidadProducto;
            NumUDStockEditarProducto.Value = producto.stock;
            NumUDLimiteEditarProducto.Value = producto.limteProducto;
            CbxUnidadesMedidasEditarProducto.SelectedIndex = producto.unidadMedida - 1;
            CbxCategoriasEditarProducto.SelectedIndex = BuscarCategoria(producto.tipoProducto);
            IngresarTipoProductos();
            CbxTipoProductoEditarProducto.SelectedIndex = BuscarIndiceTipoProducto(producto.tipoProducto);//
        }

        //--------------------------------
        // Importación para arrastrar
        // ventana
        //--------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
            int wparam, int lparam);

        //----------------------
        // Cerrar formulario
        //----------------------
        private void PbxCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //----------------------------------
        // Arrastrar ventana
        //----------------------------------
        private void PnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region Botón para editar producto
        //----------------------
        // Editar producto
        //----------------------
        private void BtnEditarProducto_Click(object sender, EventArgs e)
        {
            //Validación.
            if (TbxProductoEditarProducto.Text == "")
            {
                MessageBox.Show("Ingrese un producto");
                return;
            }

            if (NumUDCantidadEditarProducto.Value <= 0)
            {
                MessageBox.Show("Ingrese un número para la cantidad del producto.");
                return;
            }

            if (NumUDStockEditarProducto.Value <= 0)
            {
                MessageBox.Show("Ingrese un número para el stock.");
                return;
            }

            if (NumUDLimiteEditarProducto.Value <= 0)
            {
                MessageBox.Show("Ingrese un número para el límite al sacar el producto.");
                return;
            }

            if (CbxUnidadesMedidasEditarProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una unidad de medida.");
                return;
            }

            if (CbxCategoriasEditarProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoría.");
                return;
            }

            if (CbxTipoProductoEditarProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de producto.");
                return;
            }

            if (NumUDCantidadEditarProducto.Value > NumUDStockEditarProducto.Value)
            {
                MessageBox.Show("Ingrese una cantidad menor al stock para poder actualizar");
                return;
            }

            int categoria = CbxCategoriasEditarProducto.SelectedIndex + 1;
            int idTipoProducto;
            int idUnidadMedida = CbxUnidadesMedidasEditarProducto.SelectedIndex + 1;

            MySqlDataReader mySqlDataReader = null;
            string buscar = "Select idTipoProducto from tTiposproductos where TipoProducto = '" + CbxTipoProductoEditarProducto.SelectedItem + "'  AND TCategorias_idCategoria = " + categoria;

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
            Producto productoActualizado = new Producto(TbxProductoEditarProducto.Text, Convert.ToInt32(NumUDStockEditarProducto.Value), Convert.ToInt32(NumUDCantidadEditarProducto.Value), Convert.ToInt32(NumUDLimiteEditarProducto.Value), idUnidadMedida, idTipoProducto);

            //Variables para la base de datos.
            string consulta = "Update tproductos Set NombreProducto = '" + productoActualizado.producto
                                                + "', Stock = " + productoActualizado.stock
                                                + ", CantidadProducto = " + productoActualizado.cantidadProducto
                                                + ", LimiteSacarProducto = " + productoActualizado.limteProducto
                                                + ", TUnidadesMedidas_idUnidadMedida = " + idUnidadMedida.ToString()
                                                + ", TTiposProductos_idTipoProducto = " + idTipoProducto.ToString()
                                                + " where NombreProducto = '" + producto.producto + "'"; 
                MySqlCommand mySqlCommandInsertar = new MySqlCommand(consulta);
                mySqlCommandInsertar.Connection = conexion.Conectar();
                mySqlCommandInsertar.ExecuteNonQuery();
                MessageBox.Show("Se ha actualizado el producto");
            this.Close();
        }
        #endregion

        #region Buscar categoria
        //----------------------
        // Buscar categoría
        //----------------------
        private int BuscarCategoria(int id)
        {
            MySqlDataReader mySqlDataReader = null;
            int categoria;
            consulta = "Select Tcategorias_idCategoria from TTiposProductos where idTipoProducto = " + id;

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                return -1;
            }
            mySqlDataReader.Read();
            categoria = Convert.ToInt32(mySqlDataReader["Tcategorias_idCategoria"]) - 1;
            mySqlDataReader.Close();
            return categoria;
        }
        #endregion

        #region Buscar en índice el tipo de producto
        //------------------------------------------
        // Buscar en índice el tipo de producto
        //------------------------------------------
        private int BuscarIndiceTipoProducto(int idtipoProducto)
        {
            MySqlDataReader mySqlDataReader = null;
            string buscar = "Select TipoProducto from tTiposproductos where idTipoProducto = '" + idtipoProducto.ToString() + "'";

            //Generación de las consultas para buscar si existe el nombre.
            MySqlCommand mySqlCommandBuscar = new MySqlCommand(buscar);
            mySqlCommandBuscar.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommandBuscar.ExecuteReader();
            mySqlDataReader.Read();

            string tipoProducto = mySqlDataReader["tipoProducto"].ToString();
            mySqlDataReader.Close();

            for (int i = 0; i < CbxTipoProductoEditarProducto.Items.Count; i++)
            {
                // Comprueba si el contenido del elemento en el índice actual coincide con el contenido buscado
                if (CbxTipoProductoEditarProducto.Items[i].ToString() == tipoProducto)
                {
                    return i;
                }
            }

            MessageBox.Show("No se encontró el índice.");
            return -1;
        }
        #endregion

        #region Mostrar las categorias
        //---------------------------------------------------------------------
        //Función para mostrar las categorías
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
                CbxCategoriasEditarProducto.Items.Add(mySqlDataReader["Categoria"].ToString());
            }

            mySqlDataReader.Close();
        }
        #endregion

        #region Seleccionar unidades de medida
        //---------------------------------------------------------------------
        //Función para seleccionar unidades de medida
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
                CbxUnidadesMedidasEditarProducto.Items.Add(mySqlDataReader["UnidadMedida"].ToString());
            }

            mySqlDataReader.Close();
        }
        #endregion

        //-----------------------------
        //
        //-----------------------------
        private void CbxCategoriasEditarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            IngresarTipoProductos();
        }

        #region Ingresar tipo de producto
        //-----------------------------
        // Ingresar tipo de producto
        //-----------------------------
        private void IngresarTipoProductos()
        {
            //Limpiamos el combobox.
            CbxTipoProductoEditarProducto.DataSource = null;
            CbxTipoProductoEditarProducto.Items.Clear();
            CbxTipoProductoEditarProducto.Text = "";

            MySqlDataReader mySqlDataReader = null;
            int categoriaSeleccionada = (CbxCategoriasEditarProducto.SelectedIndex + 1);
            consulta = "Select TipoProducto from TTiposProductos Where TCategorias_idCategoria = " + categoriaSeleccionada;

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron tipos de productos con esa categoría");
                return;
            }

            while (mySqlDataReader.Read())
            {
                CbxTipoProductoEditarProducto.Items.Add(mySqlDataReader["TipoProducto"].ToString());
            }

            mySqlDataReader.Close();
        }
        #endregion

        #region Validación de campos
        //-----------------------------------------------------
        // Resaltar cuando el puntero entra del
        // Textbox EditarProducto
        //-----------------------------------------------------
        private void TbxProductoEditarProducto_Enter(object sender, EventArgs e)
        {
            if (TbxProductoEditarProducto.Text == "Escribe aquí")
            {
                TbxProductoEditarProducto.Text = "";
                TbxProductoEditarProducto.ForeColor = Color.Black;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero sale del
        // Textbox EditarProducto
        //-----------------------------------------------------
        private void TbxProductoEditarProducto_Leave(object sender, EventArgs e)
        {
            if (TbxProductoEditarProducto.Text == "Escribe aquí")
            {
                TbxProductoEditarProducto.Text = "";
                TbxProductoEditarProducto.ForeColor = Color.DimGray;
            }
        }

        //-----------------------------------------------------
        // Validar que el campo de TbxProductoEditarProducto
        // sólo admita la entrada de letras y números
        //-----------------------------------------------------
        private void TbxProductoEditarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 126) || (e.KeyChar == 156) || (e.KeyChar == 158) || (e.KeyChar == 159) || (e.KeyChar >= 166 && e.KeyChar <= 180) || (e.KeyChar >= 184 && e.KeyChar <= 197) || (e.KeyChar >= 200 && e.KeyChar <= 209) || (e.KeyChar == 213) || (e.KeyChar >= 217 && e.KeyChar <= 223) || (e.KeyChar >= 230 && e.KeyChar <= 232) || (e.KeyChar >= 236 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo puede ingresar letras y números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        #endregion

    }
}
