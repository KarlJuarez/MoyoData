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
        //-----------------------------------//
        // ATRIBUTOS
        //-----------------------------------//
        string consulta;
        BaseDeDatos conexion = new BaseDeDatos();
        List<string> categorias = new List<string>();
        List<Rol> roles = new List<Rol>();
        Usuario usuario;
        string idRol;

        //-----------------------
        // Constructor
        //-----------------------
        public Aspectos(Usuario usuario)
        {
            InitializeComponent();
            CargarCategorias();
            CargarTiposProductos();
            CargarUnidadesMedidas();
            SeleccionarRoles();
            this.usuario = usuario;
            idRol = roles.Find(p => p.rol == "Administrador").id.ToString();

            if (this.usuario.rol != idRol)
            {
                BtnAgregarCategoria.Dispose();
                BtnEditarCategoria.Dispose();
                BtnAgregarTipoPorducto.Dispose();
                BtnEditarTipoProducto.Dispose();
                BtnAgregarUnidadDeMedida.Dispose();
                BtnEditarUnidadDeMedida.Dispose();
            }
        }

        //------------------------
        // Cerrar formulario
        //------------------------
        private void PbxCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Función para seleccionar rol
        //-----------------------
        // Seleccionar rol
        //-----------------------
        private void SeleccionarRoles()
        {
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select * from TRoles";
            Rol rol;

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron roles", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            while (mySqlDataReader.Read())
            {
                rol = new Rol(Convert.ToInt32(mySqlDataReader["idRol"].ToString()), mySqlDataReader["Rol"].ToString());
                roles.Add(rol);
            }

            mySqlDataReader.Close();
        }
        #endregion

        #region Función para cargar las categorías
        //-----------------------
        // Cargar categorías
        //-----------------------
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
                MessageBox.Show("No se encontraron categorías", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            while (mySqlDataReader.Read())
            {
                DgvCategorias.Rows.Add(mySqlDataReader["idCategoria"].ToString(), mySqlDataReader["Categoria"].ToString(), false);
                categorias.Add(mySqlDataReader["Categoria"].ToString());
            }

            mySqlDataReader.Close();
        }
        #endregion

        #region Función para cargar los tipos de producto
        //---------------------------
        // Cargar tipos de producto
        //---------------------------
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
                MessageBox.Show("No se encontraron tipos de productos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            while (mySqlDataReader.Read())
            {
                DgvTiposProductos.Rows.Add(mySqlDataReader["idTipoProducto"].ToString(), mySqlDataReader["TipoProducto"].ToString(), categorias[Convert.ToInt32(mySqlDataReader["TCategorias_idCategoria"])-1]);
            }

            mySqlDataReader.Close();
        }
        #endregion

        #region Función para cargar las unidades de medida
        //-----------------------------
        // Cargar unidades de medida
        //-----------------------------
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
                MessageBox.Show("No se encontraron unidades de medida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            while (mySqlDataReader.Read())
            {
                DgvUnidadesDeMedida.Rows.Add(mySqlDataReader["idUnidadMedida"].ToString(), mySqlDataReader["UnidadMedida"].ToString(), false);
            }

            mySqlDataReader.Close();
        }
        #endregion

        #region Botón para agregar categoría
        //-----------------------------
        // Agregar categoría
        //-----------------------------
        private void BtnAgregarCategoria_Click(object sender, EventArgs e)
        {
            AgregarCategoria agregarCategoria = new AgregarCategoria();
            agregarCategoria.ShowDialog();
            ActualizarCategorias();
        }
        #endregion

        #region Botón para editar categoría
        //-----------------------------
        // Editar categoría
        //-----------------------------
        private void BtnEditarCategoria_Click(object sender, EventArgs e)
        {
            MySqlDataReader mySqlDataReader = null;
            Categoria categoria;
            int id;
            int totalSeleccion = DgvCategorias.Rows.Cast<DataGridViewRow>().
                Where(p => Convert.ToBoolean(p.Cells["ColumSeleccionCategorias"].Value)).Count();
            if (totalSeleccion <= 0)
            {
                MessageBox.Show("Seleccione alguna unidad de medida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        #endregion

        #region Función para actualizar categorías
        //-----------------------------
        // Actualizar categorías
        //-----------------------------
        private void ActualizarCategorias()
        {
            DgvCategorias.Rows.Clear();
            CargarCategorias();
        }
        #endregion

        #region Botón para agregar un tipo de producto
        //-----------------------------
        // Agregar tipo de producto
        //-----------------------------
        private void BtnAgregarTipoPorducto_Click(object sender, EventArgs e)
        {
            AgregarTipoProducto agregarTipoProducto = new AgregarTipoProducto();
            agregarTipoProducto.ShowDialog();
            ActualizarTablaTipoProducto();
        }
        #endregion

        #region Botón para editar un tipo de producto
        //-----------------------------
        // Editar tipo de producto
        //-----------------------------
        private void BtnEditarTipoProducto_Click(object sender, EventArgs e)
        {
            MySqlDataReader mySqlDataReader = null;
            TipoProducto tipoProducto;
            int id;
            int totalSeleccion = DgvTiposProductos.Rows.Cast<DataGridViewRow>().
                Where(p => Convert.ToBoolean(p.Cells["ColumSeleccionTiposProductos"].Value)).Count();
            if (totalSeleccion <= 0)
            {
                MessageBox.Show("Seleccione algún tipo de producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        #endregion

        #region Función para actualizar la tabla de tipo de productos
        //-----------------------------------------
        // Actualizar tabla de tipo de productos
        //-----------------------------------------
        private void ActualizarTablaTipoProducto()
        {
            DgvTiposProductos.Rows.Clear();
            CargarTiposProductos();
        }
        #endregion

        #region Botón para agregar unidad de medida
        //-----------------------------
        // Agregar unidad de medida
        //-----------------------------
        private void BtnAgregarUnidadDeMedida_Click(object sender, EventArgs e)
        {
            AgregarUnidadMedida agregarUnidadMedida = new AgregarUnidadMedida();
            agregarUnidadMedida.ShowDialog();
            ActualizarMedidas();
        }
        #endregion

        #region Botón para editar unidad de medida
        //-----------------------------
        // Editar unidad de medida
        //-----------------------------
        private void BtnEditarUnidadDeMedida_Click(object sender, EventArgs e)
        {
            MySqlDataReader mySqlDataReader = null;
            UnidadMedida unidadMedida;
            int id;
            int totalSeleccion = DgvUnidadesDeMedida.Rows.Cast<DataGridViewRow>().
                Where(p => Convert.ToBoolean(p.Cells["ColumSeleccionUnidadesMedidas"].Value)).Count();
            if (totalSeleccion <= 0)
            {
                MessageBox.Show("Seleccione alguna unidad de medida", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        #endregion

        #region Función para actualizar las unidades de medida
        //-----------------------------
        // Actualizar unidades de medida
        //-----------------------------
        private void ActualizarMedidas()
        {
            DgvUnidadesDeMedida.Rows.Clear();
            CargarUnidadesMedidas();
        }
        #endregion
    }
}
