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
    public partial class EditarUnidadMedida : Form
    {
        //-----------------------------------//
        // ATRIBUTOS
        //-----------------------------------//
        UnidadMedida unidadMedida;
        BaseDeDatos conexion = new BaseDeDatos();

        //-----------------------
        // Constructor
        //-----------------------
        public EditarUnidadMedida(UnidadMedida unidadMedida)
        {
            InitializeComponent();
            this.unidadMedida = unidadMedida;
            TbxUnidadMedida.Text = unidadMedida.unidadMedida;
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

        #region Botón para actualizar unidad de medida
        //------------------------------
        // Actualizar unidad de medida
        //------------------------------
        private void BtnActualizarUnidadMedida_Click(object sender, EventArgs e)
        {
            //Validación.
            if (TbxUnidadMedida.Text == "")
            {
                MessageBox.Show("Ingrese una unidad de medida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string unidadMedidaNombre = TbxUnidadMedida.Text;


            //Variables.
            UnidadMedida unidadActualizado = new UnidadMedida(unidadMedida.id, unidadMedidaNombre);
            //Variables para la base de datos.
            string consulta = "Update tunidadesmedidas Set UnidadMedida = '" + unidadActualizado.unidadMedida
                                                + "' where idUnidadMedida = " + unidadActualizado.id.ToString();
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
        // Textbox UnidadMedida
        //-----------------------------------------------------
        private void TbxUnidadMedida_Enter(object sender, EventArgs e)
        {
            if (TbxUnidadMedida.Text == "Escribe aquí")
            {
                TbxUnidadMedida.Text = "";
                TbxUnidadMedida.ForeColor = Color.Black;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero sale del
        // Textbox UnidadMedida
        //-----------------------------------------------------
        private void TbxUnidadMedida_Leave(object sender, EventArgs e)
        {
            if (TbxUnidadMedida.Text == "")
            {
                TbxUnidadMedida.Text = "Escribe aquí";
                TbxUnidadMedida.ForeColor = Color.DimGray;
            }
        }

        //-----------------------------------------------------
        // Validar que el campo de TbxUnidadMedida
        // sólo admita la entrada de letras
        //-----------------------------------------------------
        private void TbxUnidadMedida_KeyPress(object sender, KeyPressEventArgs e)
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
