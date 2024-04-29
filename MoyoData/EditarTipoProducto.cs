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
    public partial class EditarTipoProducto : Form
    {
        //-----------------------------------//
        // ATRIBUTOS
        //-----------------------------------//
        TipoProducto tipoProducto;
        BaseDeDatos conexion = new BaseDeDatos();
        string consulta;
        List<Categoria> categorias = new List<Categoria>();

        //-----------------------
        // Constructor
        //-----------------------
        public EditarTipoProducto(TipoProducto tipoProducto)
        {
            InitializeComponent();
            this.tipoProducto = tipoProducto;
            SeleccionarCategorias();
            TbxTipoProducto.Text = this.tipoProducto.tipoProducto;
            CbxCategoriaTipoProducto.SelectedIndex = this.tipoProducto.categoria - 1;
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

        //---------------------
        // Arrastrar ventana
        //---------------------
        private void PnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region Botón para actualizar el tipo de producto
        //--------------------------------
        // Actualizar tipo de producto
        //--------------------------------
        private void BtnActualizarTipoProducto_Click(object sender, EventArgs e)
        {
            //Validación.
            if (TbxTipoProducto.Text == "")
            {
                MessageBox.Show("Ingrese un producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (CbxCategoriaTipoProducto.SelectedIndex <= -1)
            {
                MessageBox.Show("Ingrese una categoría", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            MessageBox.Show("Se ha actualizado el tipo producto", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        #endregion

        #region Función para seleccionar categorías
        //---------------------------------------------------------------------
        //Función para seleccionar las categorías
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
        #endregion

        #region Validación de campos
        //-----------------------------------------------------
        // Resaltar cuando el puntero entra del
        // Textbox TipoProducto
        //-----------------------------------------------------
        private void TbxTipoProducto_Enter(object sender, EventArgs e)
        {
            if (TbxTipoProducto.Text == "Escribe aquí")
            {
                TbxTipoProducto.Text = "";
                TbxTipoProducto.ForeColor = Color.Black;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero sale del
        // Textbox TipoProducto
        //-----------------------------------------------------
        private void TbxTipoProducto_Leave(object sender, EventArgs e)
        {
            if (TbxTipoProducto.Text == "")
            {
                TbxTipoProducto.Text = "Escribe aquí";
                TbxTipoProducto.ForeColor = Color.DimGray;
            }
        }

        //-----------------------------------------------------
        // Validar que el campo de TbxCategoria
        // sólo admita la entrada de letras
        //-----------------------------------------------------
        private void TbxTipoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo puede ingresar letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        #endregion
    }
}
