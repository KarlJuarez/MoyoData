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


namespace MoyoData
{
    public partial class AgregarProducto : Form
    {
        //-----------------------------------//
        // ATRIBUTOS
        //-----------------------------------//
        BaseDeDatos conexion;
        string consulta;
        List<Categoria> categorias = new List<Categoria>();
        List<UnidadMedida>unidadMedidas = new List<UnidadMedida>();

        //-----------------------
        // Constructor
        //-----------------------
        public AgregarProducto()
        {
            InitializeComponent();
            conexion = new BaseDeDatos();
            SeleccionarCategorias();
            SeleccionarUnidadMedida();
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

        //-----------------------------
        // Cerrar formulario
        //-----------------------------
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

        #region Mostrar categorias
        //---------------------------------------------------------------------
        // Mostrar las categorías
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
                CbxCategoriasAgregarProducto.Items.Add(categoria.categoria);
                categorias.Add(categoria);
            }

            mySqlDataReader.Close();
        }
        #endregion

        #region Mostrar unidades de medida
        //---------------------------------------------------------------------
        // Mostrar las unidades de medida
        //---------------------------------------------------------------------
        private void SeleccionarUnidadMedida()
        {
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select * from TUnidadesMedidas";
            UnidadMedida unidadMedida;

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron unidades de medida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            while (mySqlDataReader.Read())
            {
                unidadMedida = new UnidadMedida(Convert.ToInt32(mySqlDataReader["idUnidadMedida"].ToString()), mySqlDataReader["UnidadMedida"].ToString());
                CbxUnidadesMedidasAgregarProducto.Items.Add(unidadMedida.unidadMedida);
                unidadMedidas.Add(unidadMedida);
            }

            mySqlDataReader.Close();
        }
        #endregion

        #region Botón para agregar un producto 
        //---------------------------------------------------------------------
        // Agregar un producto.
        //---------------------------------------------------------------------
        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            //Validación.
            if (TbxProductoAgregarProducto.Text == "")
            {
                MessageBox.Show("Ingrese un producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (NumUDCantidadAgregarProducto.Value <= 0)
            {
                MessageBox.Show("Ingrese un número para el stock.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (NumUDLimiteAgregarProducto.Value <= 0)
            {
                MessageBox.Show("Ingrese un número para el límite al sacar el producto.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (CbxUnidadesMedidasAgregarProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una unidad de medida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (CbxCategoriasAgregarProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoría.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (CbxTipoProductoAgregarProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de producto.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Categoria categoria = categorias.Find(p => p.categoria == CbxCategoriasAgregarProducto.SelectedItem.ToString());
            int idTipoProducto;
            UnidadMedida unidadMedida = unidadMedidas.Find(p => p.unidadMedida == CbxUnidadesMedidasAgregarProducto.SelectedItem.ToString());

            MySqlDataReader mySqlDataReader = null;
            string buscar = "Select idTipoProducto from tTiposproductos where TipoProducto = '" + CbxTipoProductoAgregarProducto.SelectedItem + "'  AND TCategorias_idCategoria = " + categoria.id;

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
                MessageBox.Show("No se encontró el id del producto.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            mySqlDataReader.Close();


            //Variables.
            Producto producto = new Producto(TbxProductoAgregarProducto.Text, Convert.ToInt32(NumUDCantidadAgregarProducto.Value), Convert.ToInt32(NumUDCantidadAgregarProducto.Value), Convert.ToInt32(NumUDLimiteAgregarProducto.Value), unidadMedida.id , idTipoProducto);

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

            // Validación
            if (mySqlDataReader.HasRows)
            {
                MessageBox.Show("Nombre de producto ya existente", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mySqlDataReader.Close();
            }
            else
            {
                mySqlDataReader.Close();
                MySqlCommand mySqlCommandInsertar = new MySqlCommand(consulta);
                mySqlCommandInsertar.Connection = conexion.Conectar();
                mySqlCommandInsertar.ExecuteNonQuery();
                MessageBox.Show("Se ha registrado el producto", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }
        #endregion

        #region Cambiar index para el combobox categorias agregar producto
        //---------------------------------------------
        // Cambiar index para el combobox categorias
        // agregar producto
        //---------------------------------------------
        private void CbxCategoriasAgregarProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Limpiar el combobox.
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
                MessageBox.Show("No se encontraron tipos de productos con esa caategoría", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            while (mySqlDataReader.Read())
            {
                CbxTipoProductoAgregarProducto.Items.Add(mySqlDataReader["TipoProducto"].ToString());
            }

            mySqlDataReader.Close();
        }
        #endregion

        #region Validación de campos
        //-----------------------------------------------------
        // Validar que el campo de TbxProductoAgregarProducto
        // sólo admita la entrada de letras y números
        //-----------------------------------------------------
        private void TbxProductoAgregarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo puede ingresar letras y números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero entra del
        // Textbox Producto
        //-----------------------------------------------------
        private void TbxProductoAgregarProducto_Enter(object sender, EventArgs e)
        {
            if (TbxProductoAgregarProducto.Text == "Escribe aquí")
            {
                TbxProductoAgregarProducto.Text = "";
                TbxProductoAgregarProducto.ForeColor = Color.Black;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero entra del
        // Textbox Producto
        //-----------------------------------------------------
        private void TbxProductoAgregarProducto_Leave(object sender, EventArgs e)
        {
            if (TbxProductoAgregarProducto.Text == "")
            {
                TbxProductoAgregarProducto.Text = "Escribe aquí";
                TbxProductoAgregarProducto.ForeColor = Color.DimGray;
            }
        }

        #endregion

    }
}

