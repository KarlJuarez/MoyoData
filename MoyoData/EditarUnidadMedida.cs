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
    public partial class EditarUnidadMedida : Form
    {
        UnidadMedida unidadMedida;
        BaseDeDatos conexion = new BaseDeDatos();

        public EditarUnidadMedida(UnidadMedida unidadMedida)
        {
            InitializeComponent();
            this.unidadMedida = unidadMedida;
            TbxUnidadMedida.Text = unidadMedida.unidadMedida;
        }

        private void BtnActualizarUnidadMedida_Click(object sender, EventArgs e)
        {
            //Validación.
            if (TbxUnidadMedida.Text == "")
            {
                MessageBox.Show("Ingrese una unidad de medida");
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
            MessageBox.Show("Se ha actualizado el producto");
            this.Close();
        }
    }
}
