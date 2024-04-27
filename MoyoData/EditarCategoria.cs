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
    public partial class EditarCategoria : Form
    {
        Categoria categoria;
        BaseDeDatos conexion = new BaseDeDatos();
        public EditarCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            TbxCategoria.Text = categoria.categoria;
        }

        private void BtnActualizarCategoria_Click(object sender, EventArgs e)
        {
            //Validación.
            if (TbxCategoria.Text == "")
            {
                MessageBox.Show("Ingrese una categoria.");
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
            MessageBox.Show("Se ha actualizado el producto");
            this.Close();
        }
    }
}
