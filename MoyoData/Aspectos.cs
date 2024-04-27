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
    public partial class Aspectos : Form
    {
        //Atrobutos
        string consulta;
        BaseDeDatos conexion = new BaseDeDatos();
        List<string> categorias = new List<string>();

        public Aspectos()
        {
            InitializeComponent();
            CargarCategorias();
            CargarTiposProductos();
            CargarUnidadesMedidas();
        }

        //------------------------
        // Cerrar formulario
        //------------------------
        private void PbxCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCategorias()
        {
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select * from TCategorias";

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron categorías");
                return;
            }

            while (mySqlDataReader.Read())
            {
                DgvCategorias.Rows.Add(mySqlDataReader["idCategoria"].ToString(), mySqlDataReader["Categoria"].ToString(), false);
                categorias.Add(mySqlDataReader["Categoria"].ToString());
            }

            mySqlDataReader.Close();
        }

        private void CargarTiposProductos()
        {
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select * from TTiposProductos";

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron tipos de productos.");
                return;
            }

            while (mySqlDataReader.Read())
            {
                DgvTiposProductos.Rows.Add(mySqlDataReader["idTipoProducto"].ToString(), mySqlDataReader["TipoProducto"].ToString(), categorias[Convert.ToInt32(mySqlDataReader["TCategorias_idCategoria"])-1]);
            }

            mySqlDataReader.Close();
        }

        private void CargarUnidadesMedidas()
        {
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select * from TUnidadesMedidas";

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron unidades de medida");
                return;
            }

            while (mySqlDataReader.Read())
            {
                DgvUnidadesDeMedida.Rows.Add(mySqlDataReader["idUnidadMedida"].ToString(), mySqlDataReader["UnidadMedida"].ToString(), false);
            }

            mySqlDataReader.Close();
        }

        private void BtnAgregarCategoria_Click(object sender, EventArgs e)
        {
            AgregarCategoria agregarCategoria = new AgregarCategoria();
            agregarCategoria.ShowDialog();
            ActualizarCategorias();
        }

        private void BtnEditarCategoria_Click(object sender, EventArgs e)
        {
            MySqlDataReader mySqlDataReader = null;
            Categoria categoria;
            int id;
            int totalSeleccion = DgvCategorias.Rows.Cast<DataGridViewRow>().
                Where(p => Convert.ToBoolean(p.Cells["ColumSeleccionCategorias"].Value)).Count();
            if (totalSeleccion <= 0)
            {
                MessageBox.Show("Seleccione alguna unidad de medida.");
                return;
            }

            foreach (DataGridViewRow row in DgvCategorias.Rows)
            {
                if (Convert.ToBoolean(row.Cells["ColumSeleccionCategorias"].Value))
                {
                    id = Convert.ToInt32(row.Cells["ColumIDCategorias"].Value);
                    consulta = "Select * from TCategorias where idCategoria = " + id.ToString();
                    MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                    mySqlCommand.Connection = conexion.Conectar();
                    mySqlDataReader = mySqlCommand.ExecuteReader();
                    mySqlDataReader.Read();

                    categoria = new Categoria(id, mySqlDataReader["Categoria"].ToString());

                    mySqlDataReader.Close();
                    EditarCategoria editarCategoria = new EditarCategoria(categoria);
                    editarCategoria.ShowDialog();
                }
            }

            ActualizarCategorias();
        }

        private void ActualizarCategorias()
        {
            DgvCategorias.Rows.Clear();
            CargarCategorias();
        }

        private void BtnAgregarTipoPorducto_Click(object sender, EventArgs e)
        {
            AgregarTipoProducto agregarTipoProducto = new AgregarTipoProducto();
            agregarTipoProducto.ShowDialog();
            ActualizarTablaTipoProducto();
        }

        private void BtnEditarTipoProducto_Click(object sender, EventArgs e)
        {
            MySqlDataReader mySqlDataReader = null;
            TipoProducto tipoProducto;
            int id;
            int totalSeleccion = DgvTiposProductos.Rows.Cast<DataGridViewRow>().
                Where(p => Convert.ToBoolean(p.Cells["ColumSeleccionTiposProductos"].Value)).Count();
            if (totalSeleccion <= 0)
            {
                MessageBox.Show("Seleccione algún tipo de producto.");
                return;
            }

            foreach (DataGridViewRow row in DgvTiposProductos.Rows)
            {
                if (Convert.ToBoolean(row.Cells["ColumSeleccionTiposProductos"].Value))
                {
                    id = Convert.ToInt32(row.Cells["ColumIDTiposProductos"].Value);
                    consulta = "Select * from TTiposProductos where idTipoProducto = " + id.ToString();
                    MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                    mySqlCommand.Connection = conexion.Conectar();
                    mySqlDataReader = mySqlCommand.ExecuteReader();
                    mySqlDataReader.Read();

                    tipoProducto = new TipoProducto(id, mySqlDataReader["TipoProducto"].ToString(), Convert.ToInt32(mySqlDataReader["TCategorias_idCategoria"]));

                    mySqlDataReader.Close();
                    EditarTipoProducto editarTipoProducto = new EditarTipoProducto(tipoProducto);
                    editarTipoProducto.ShowDialog();
                }
            }

            ActualizarTablaTipoProducto();
        }

        private void ActualizarTablaTipoProducto()
        {
            DgvTiposProductos.Rows.Clear();
            CargarTiposProductos();
        }

        private void BtnAgregarUnidadDeMedida_Click(object sender, EventArgs e)
        {
            AgregarUnidadMedida agregarUnidadMedida = new AgregarUnidadMedida();
            agregarUnidadMedida.ShowDialog();
            ActualizarMedidas();
        }

        private void BtnEditarUnidadDeMedida_Click(object sender, EventArgs e)
        {
            MySqlDataReader mySqlDataReader = null;
            UnidadMedida unidadMedida;
            int id;
            int totalSeleccion = DgvUnidadesDeMedida.Rows.Cast<DataGridViewRow>().
                Where(p => Convert.ToBoolean(p.Cells["ColumSeleccionUnidadesMedidas"].Value)).Count();
            if (totalSeleccion <= 0)
            {
                MessageBox.Show("Seleccione alguna unidad de medida.");
                return;
            }

            foreach (DataGridViewRow row in DgvUnidadesDeMedida.Rows)
            {
                if (Convert.ToBoolean(row.Cells["ColumSeleccionUnidadesMedidas"].Value))
                {
                    id = Convert.ToInt32(row.Cells["ColumIDUnidadesMedidas"].Value);
                    consulta = "Select * from TUnidadesMedidas where idUnidadMedida = " + id.ToString();
                    MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                    mySqlCommand.Connection = conexion.Conectar();
                    mySqlDataReader = mySqlCommand.ExecuteReader();
                    mySqlDataReader.Read();

                    unidadMedida = new UnidadMedida(id, mySqlDataReader["UnidadMedida"].ToString());
                    
                    mySqlDataReader.Close();
                    EditarUnidadMedida editarUnidadMedida = new EditarUnidadMedida(unidadMedida);
                    editarUnidadMedida.ShowDialog();
                }
            }

            ActualizarMedidas();
        }

        private void ActualizarMedidas()
        {
            DgvUnidadesDeMedida.Rows.Clear();
            CargarUnidadesMedidas();
        }
    }
}
