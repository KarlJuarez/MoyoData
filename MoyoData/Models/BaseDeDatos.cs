using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoyoData.Models
{
    //---------------------------------------------------------------------
    //Clase para la conexión de la Base de Datos.
    //---------------------------------------------------------------------
    internal class BaseDeDatos
    {
        private string servidor = "localhost";
        private string bd = "moyodata";
        private string usuario = "root";
        private string password = "";
        private MySqlConnection conexion;
        private string cadenaConexion;

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public BaseDeDatos()
        {
            cadenaConexion = "Database=" + bd + "; DataSource=" + servidor + "; User Id=" + usuario + "; password=" + password;
        }

        //---------------------------------------------------------------------
        //Función que se conecta a la base de datos.
        //---------------------------------------------------------------------
        public MySqlConnection Conectar()
        {
            try
            {
                if (conexion == null)
                {
                    conexion = new MySqlConnection(cadenaConexion);
                    conexion.Open();
                }
            }
            catch (MySqlException e)
            {
                return null;
            }
            return conexion;
        }
    }
}
