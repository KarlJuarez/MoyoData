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
    public partial class EditarProductos : Form
    {
        BaseDeDatos conexion = new BaseDeDatos();
        Producto producto;
        public EditarProductos(Producto producto)
        {
            InitializeComponent();
            conexion = new BaseDeDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            MySqlDataReader mySqlDataReader = null;
            string consulta = "select * from usuarios";
            if (conexion.Conectar() != null)
            {
                MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                mySqlCommand.Connection = conexion.Conectar();
                MessageBox.Show("Si se conectó, pero aun no tiene datos");
                /*
                while (mySqlDataReader.Read())
                {
                    //                                 El valor de la fila que se desea obtener.
                    result = mySqlDataReader.GetString("");
                }*/

            }else
            {
                MessageBox.Show("Error al conectar.");
            }
        }
    }
}
