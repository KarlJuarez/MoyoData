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
    public partial class AgregarCategoria : Form
    {
        //-----------------------------------//
        // ATRIBUTOS
        //-----------------------------------//
        BaseDeDatos conexion;

        //-----------------------
        // Constructor
        //-----------------------
        public AgregarCategoria()
        {
            InitializeComponent();
            conexion = new BaseDeDatos();
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

        #region Botón para actualizar producto
        //-----------------------------
        // Actualizar producto
        //-----------------------------
        private void BtnActualizarCategoria_Click(object sender, EventArgs e)
        {
            //Validación.
            if (TbxCategoria.Text == "")
            {
                MessageBox.Show("Ingrese una unidad de medida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("La categoría ya existe", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            mySqlDataReader.Close();

            //Variables para la base de datos.
            string consulta = "Insert Into tCategorias (Categoria) " +
                              "Values ('" + categoria + "')";
            MySqlCommand mySqlCommandInsertar = new MySqlCommand(consulta);
            mySqlCommandInsertar.Connection = conexion.Conectar();
            mySqlCommandInsertar.ExecuteNonQuery();
            MessageBox.Show("Se ha registrado la categoría", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
