using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoyoData.Models
{
    internal class BaseDeDatos
    {
        private string servidor = "localhost";
        private string bd = "MoyoData";
        private string usuario = "root";
        private string password = "";
        private MySqlConnection conexion;
        private string cadenaConexion;

        public BaseDeDatos()
        {
            cadenaConexion = "Database="+ bd + "; DataSource="+ servidor + "; User Id=" + usuario + "password=" + password;
        }

        public MySqlConnection Conectar()
        {
            try
            {
                if (conexion == null)
                {
                    conexion = new MySqlConnection(cadenaConexion);
                    conexion.Open();
                }
                MessageBox.Show("Conexión exitosa.");
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return conexion;
        }
    }
}
