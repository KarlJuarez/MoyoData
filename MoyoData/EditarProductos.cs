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
    }
}
