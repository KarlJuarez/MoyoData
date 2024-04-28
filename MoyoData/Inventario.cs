using MoyoData.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoyoData
{
    public partial class Inventario : Form
    {
        //---------------------//
        // ATRIBUTOS
        //---------------------//
        BaseDeDatos conexion = new BaseDeDatos();
        string consulta;
        List<Categoria> categorias = new List<Categoria>();
        Usuario usuario;
        List<Rol> roles = new List<Rol>();
        string idRol;
        public Inventario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            SeleccionarCategorias();
            SeleccionarProductos();
            SeleccionarRoles();
            idRol = roles.Find(p => p.rol == "Administrador").id.ToString();

            if (this.usuario.rol != idRol)
            {
                BtnEditarProducto.Dispose();
                BtnEliminarProductoInventario.Dispose();
            }
        }

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
                MessageBox.Show("No se encontraron roles", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            while (mySqlDataReader.Read())
            {
                rol = new Rol(Convert.ToInt32(mySqlDataReader["idRol"].ToString()), mySqlDataReader["Rol"].ToString());
                roles.Add(rol);
            }

            mySqlDataReader.Close();
        }
        //--------------------------
        // Cerrar formulario
        //--------------------------
        private void PbxCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Obtener categoria
        //-----------------------------
        // Obtener categoria
        //-----------------------------
        private void SeleccionarCategorias()
        {
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select * from TCategorias";
            Categoria categoria;

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
                categoria = new Categoria(Convert.ToInt32(mySqlDataReader["idCategoria"].ToString()), mySqlDataReader["Categoria"].ToString());
                categorias.Add(categoria);
            }

            mySqlDataReader.Close();
        }
        #endregion

        #region Seleccionar producto
        //-----------------------------
        // Seleccionar producto
        //-----------------------------
        private void SeleccionarProductos()
        {
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select * from TProductos";
            Producto producto;
            Tuple<string, string> tipoProducto;

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron productos");
                return;
            }

            while (mySqlDataReader.Read())
            {
                producto = new Producto(mySqlDataReader["NombreProducto"].ToString(),
                                        Convert.ToInt32(mySqlDataReader["Stock"]),
                                        Convert.ToInt32(mySqlDataReader["CantidadProducto"]),
                                        Convert.ToInt32(mySqlDataReader["LimiteSacarProducto"]),
                                        Convert.ToInt32(mySqlDataReader["TUnidadesMedidas_idUnidadMedida"]),
                                        Convert.ToInt32(mySqlDataReader["TTiposProductos_idTipoProducto"]));
                tipoProducto = SeleccionarTipoCategoria(mySqlDataReader["TTiposProductos_idTipoProducto"].ToString());
                DgvProductos.Rows.Add(Convert.ToInt32(mySqlDataReader["idProducto"]), producto.producto, producto.stock.ToString(), producto.cantidadProducto.ToString(), tipoProducto.Item1, tipoProducto.Item2, false);
            }

            mySqlDataReader.Close();
        }
        #endregion

        #region Seleccionar tipo de categoria
        //---------------------------------
        // Seleccionar tipo de categoria
        //---------------------------------
        private Tuple<string, string> SeleccionarTipoCategoria(string id)
        {
            BaseDeDatos conexion2 = new BaseDeDatos();
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select * from TTiposProductos Where idTipoProducto = " + id;
            string tipoProducto;
            Categoria categoria;

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion2.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron productos");
                return Tuple.Create("No se encontró el tipo de producto", "No se encontró la categoría");
            }

            mySqlDataReader.Read();

            tipoProducto = mySqlDataReader["TipoProducto"].ToString();
            categoria = categorias.Find(p=>p.id == Convert.ToInt32(mySqlDataReader["TCategorias_idCategoria"]));
            mySqlDataReader.Close();
            return Tuple.Create(tipoProducto, categoria.categoria);
        }

        #endregion

        #region Editar producto del inventario
        //---------------------------------
        // Editar producto del inventario
        //---------------------------------
        private void BtnEditarProducto_Click(object sender, EventArgs e)
        {
            MySqlDataReader mySqlDataReader = null;
            Producto producto;
            int id;
            int totalSeleccion = DgvProductos.Rows.Cast<DataGridViewRow>().
                Where(p => Convert.ToBoolean(p.Cells["ColumSeleccionInventario"].Value)).Count();
            if (totalSeleccion <= 0)
            {
                MessageBox.Show("Seleccione algún producto.");
                return;
            }

            foreach (DataGridViewRow row in DgvProductos.Rows)
            {
                if (Convert.ToBoolean(row.Cells["ColumSeleccionInventario"].Value))
                {
                    id = Convert.ToInt32(row.Cells["ColumIDInventario"].Value);
                    consulta = "Select * from TProductos where idProducto = " + id.ToString();
                    MySqlCommand mySqlCommand = new MySqlCommand(consulta);
                    mySqlCommand.Connection = conexion.Conectar();
                    mySqlDataReader = mySqlCommand.ExecuteReader();
                    mySqlDataReader.Read();

                    producto = new Producto(mySqlDataReader["NombreProducto"].ToString(),
                                            Convert.ToInt32(mySqlDataReader["Stock"]),
                                            Convert.ToInt32(mySqlDataReader["CantidadProducto"]),
                                            Convert.ToInt32(mySqlDataReader["LimiteSacarProducto"]),
                                            Convert.ToInt32(mySqlDataReader["TUnidadesMedidas_idUnidadMedida"]),
                                            Convert.ToInt32(mySqlDataReader["TTiposProductos_idTipoProducto"]));
                    mySqlDataReader.Close();
                    EditarProductos editarProductos = new EditarProductos(producto);
                    editarProductos.ShowDialog();
                }
            }

            ActualizarTabla();
        }
        #endregion

        //-----------------------------
        // Actualizar tabla
        //-----------------------------
        private void ActualizarTabla()
        {
            DgvProductos.Rows.Clear();
            SeleccionarProductos();
        }

        #region Agregar y eliminar producto del inventario
        //----------------------------------
        // Agregar producto al inventario
        //----------------------------------
        private void BtnAgregarProductoInventario_Click(object sender, EventArgs e)
        {
            AgregarProducto agregarProducto = new AgregarProducto();
            agregarProducto.ShowDialog();
            ActualizarTabla();
        }

        //------------------------------------
        // Eliminar producto del inventario
        //------------------------------------
        private void BtnEliminarProductoInventario_Click(object sender, EventArgs e)
        {
            int id;
            int totalSeleccion = DgvProductos.Rows.Cast<DataGridViewRow>().
                Where(p => Convert.ToBoolean(p.Cells["ColumSeleccionInventario"].Value)).Count();
            if (totalSeleccion <= 0)
            {
                MessageBox.Show("Seleccione algún producto.");
                return;
            }

            DialogResult result = MessageBox.Show("¿Quiéres borrar los productos? Se borrarán las entradas y salidas de productos"
                , "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            foreach (DataGridViewRow row in DgvProductos.Rows)
            {
                if (Convert.ToBoolean(row.Cells["ColumSeleccionInventario"].Value))
                {
                    id = Convert.ToInt32(row.Cells["ColumIDInventario"].Value);

                    consulta = "Delete from TEntradaProductos_has_TProductos where TProductos_idProducto = " + id.ToString();
                    MySqlCommand mySqlCommandBorrarEntradaProductos = new MySqlCommand(consulta);
                    mySqlCommandBorrarEntradaProductos.Connection = conexion.Conectar();
                    mySqlCommandBorrarEntradaProductos.ExecuteNonQuery();

                    consulta = "Delete from TProductos_has_TSalidaProductos where TProductos_idProducto = " + id.ToString();
                    MySqlCommand mySqlCommandBorrarSalidaProductos = new MySqlCommand(consulta);
                    mySqlCommandBorrarSalidaProductos.Connection = conexion.Conectar();
                    mySqlCommandBorrarSalidaProductos.ExecuteNonQuery();

                    consulta = "Delete from TProductos where idProducto = " + id.ToString();
                    MySqlCommand mySqlCommandBorrar = new MySqlCommand(consulta);
                    mySqlCommandBorrar.Connection = conexion.Conectar();
                    mySqlCommandBorrar.ExecuteNonQuery();
                    
                }
            }
            ActualizarTabla();
            MessageBox.Show("Se ha borrado los producto");
        }

        #endregion
    }
}
