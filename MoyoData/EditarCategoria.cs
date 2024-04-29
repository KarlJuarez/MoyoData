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
    public partial class EditarCategoria : Form
    {
        //-----------------------------------//
        // ATRIBUTOS
        //-----------------------------------//
        Categoria categoria;
        BaseDeDatos conexion = new BaseDeDatos();

        //-----------------------
        // Constructor
        //-----------------------
        public EditarCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            TbxCategoria.Text = categoria.categoria;
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

        #region Botón para actualizar la categoría
        //-----------------------
        // Actualizar categoría
        //-----------------------
        private void BtnActualizarCategoria_Click(object sender, EventArgs e)
        {
            //Validación.
            if (TbxCategoria.Text == "")
            {
                MessageBox.Show("Ingrese una categoria", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string categoriaNombre = TbxCategoria.Text;


            //Variables.
            Categoria categoriaActualizada = new Categoria(categoria.id, categoriaNombre);
            //Variables para la base de datos.
            string consulta = "Update tcategorias Set categoria = '" + categoriaActualizada.categoria
                                                + "' where idcategoria = " + categoria.id.ToString();
            MySqlCommand mySqlCommandInsertar = new MySqlCommand(consulta);
            mySqlCommandInsertar.Connection = conexion.Conectar();
            mySqlCommandInsertar.ExecuteNonQuery();
            MessageBox.Show("Se ha actualizado el producto", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        #endregion

        #region Validación de campos
        //-----------------------------------------------------
        // Resaltar cuando el puntero entra del
        // Textbox Categoria
        //-----------------------------------------------------
        private void TbxCategoria_Enter(object sender, EventArgs e)
        {
            if (TbxCategoria.Text == "Escribe aquí")
            {
                TbxCategoria.Text = "";
                TbxCategoria.ForeColor = Color.Black;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero sale del
        // Textbox Categoria
        //-----------------------------------------------------
        private void TbxCategoria_Leave(object sender, EventArgs e)
        {
            if (TbxCategoria.Text == "")
            {
                TbxCategoria.Text = "Escribe aquí";
                TbxCategoria.ForeColor = Color.DimGray;
            }
        }

        //-----------------------------------------------------
        // Validar que el campo de TbxCategoria
        // sólo admita la entrada de letras
        //-----------------------------------------------------
        private void TbxCategoria_KeyPress(object sender, KeyPressEventArgs e)
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
