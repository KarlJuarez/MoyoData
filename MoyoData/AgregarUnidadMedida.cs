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
    public partial class AgregarUnidadMedida : Form
    {
        BaseDeDatos conexion;
        string consulta;
        public AgregarUnidadMedida()
        {
            InitializeComponent();
            conexion = new BaseDeDatos();
        }

        private void BtnAgregarUnidadMedida_Click(object sender, EventArgs e)
        {
            //Validación.
            if (TbxUnidadMedida.Text == "")
            {
                MessageBox.Show("Ingrese una unidad de medida");
                return;
            }

            string UnidadMedida = TbxUnidadMedida.Text;

            MySqlDataReader mySqlDataReader = null;
            string buscar = "Select * from TUnidadesMedidas where UnidadMedida = '" + UnidadMedida + "'";

            //Generación de las consultas para buscar si existe el nombre.
            MySqlCommand mySqlCommandBuscar = new MySqlCommand(buscar);
            mySqlCommandBuscar.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommandBuscar.ExecuteReader();

            if (mySqlDataReader.HasRows)
            {
                MessageBox.Show("La unidad de medida ya existe.");
                return;
            }

            mySqlDataReader.Close();

            //Variables para la base de datos.
            string consulta = "Insert Into tUnidadesMedidas (UnidadMedida) " +
                              "Values ('" + UnidadMedida + "')";
            MySqlCommand mySqlCommandInsertar = new MySqlCommand(consulta);
            mySqlCommandInsertar.Connection = conexion.Conectar();
            mySqlCommandInsertar.ExecuteNonQuery();
            MessageBox.Show("Se ha registrado la unidad de medida");
            this.Close();
        }
    }
}
