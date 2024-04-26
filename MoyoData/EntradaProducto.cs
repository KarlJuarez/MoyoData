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
    public partial class EntradaProducto : Form
    {
        //---------------------------//
        // ATRIBUTOS
        //---------------------------//
        BaseDeDatos conexion = new BaseDeDatos();
        string consulta;
        List<string> categorias = new List<string>();

        public EntradaProducto()
        {
            InitializeComponent();
            ObtenerCategoria();
            SeleccionarProductos();
        }

        //-----------------------
        // Cerrar formulario
        //-----------------------
        private void PbxCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Obtener categorias
        //-----------------------------------------
        // Obtener categorías para
        // ingresarlo en la lista "categorias"
        //-----------------------------------------
        private void ObtenerCategoria()
        {
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select categoria from TCategorias";

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
                categorias.Add(mySqlDataReader["categoria"].ToString());
            }

            mySqlDataReader.Close();
        }
        #endregion

        #region Seleccionar productos
        //-----------------------------------
        // Seleccionar los productos
        // para agregarlos al DataGridView
        //-----------------------------------
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
        //----------------------------------
        // Seleccionar el tipo de categoría
        // y lo agrega a una tupla
        //----------------------------------
        private Tuple<string, string> SeleccionarTipoCategoria(string id)
        {
            BaseDeDatos conexion2 = new BaseDeDatos();
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select * from TTiposProductos Where idTipoProducto = " + id;
            string tipoProducto;
            string categoria;

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
            categoria = categorias[Convert.ToInt32(mySqlDataReader["TCategorias_idCategoria"]) - 1];
            mySqlDataReader.Close();
            return Tuple.Create(tipoProducto, categoria);
        }

        #endregion

        #region Agregar producto a Dgv
        //------------------------------------
        // Agregar producto en el DataGridView
        //------------------------------------
        private void BtnEntradaProductoAgregar_Click(object sender, EventArgs e)
        {
            //Validación
            if (NumUDCantidadEntradaProducto.Value == 0)
            {
                MessageBox.Show("Ingresar una cantidad");
                return;
            }

            // Variables
            int cantidad = Convert.ToInt32(NumUDCantidadEntradaProducto.Value);
            int totalSeleccion = DgvProductos.Rows.Cast<DataGridViewRow>().
                Where(p => Convert.ToBoolean(p.Cells["Seleccion"].Value)).Count();
            int indice;
            int cantidadTotal;

            if (totalSeleccion >= 1)
            {
                foreach (DataGridViewRow row in DgvProductos.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Seleccion"].Value))
                    {
                        if (Convert.ToInt32(row.Cells["Stock"].Value) < (cantidad + Convert.ToInt32(row.Cells["Cantidad"].Value)))
                        {
                            MessageBox.Show("La cantidad del producto " + row.Cells["Producto"].Value + " es mayor al permitido en el almacén.");
                            continue;
                        }

                        if (DgvProductosSeleccionados.Rows.Count != 0)
                        {
                            indice = BuscarEnDgv(DgvProductosSeleccionados, DgvProductosSeleccionados.Rows[row.Index].Cells["ProductoSeleccionado"].ColumnIndex, row.Cells["Producto"].Value.ToString());
                            cantidadTotal = Convert.ToInt32(DgvProductosSeleccionados.Rows[indice].Cells["CantidadSeleccionado"].Value) + cantidad + Convert.ToInt32(row.Cells["Cantidad"].Value);

                            if (cantidadTotal > Convert.ToInt32(row.Cells["Stock"].Value))
                            {
                                MessageBox.Show("La cantidad del producto" + row.Cells["Producto"].Value + " es mayor al permitido en el almacén.");
                                continue;
                            }

                            DgvProductosSeleccionados.Rows[indice].Cells["CantidadSeleccionado"].Value = cantidadTotal;
                        }
                        else
                        {
                            DgvProductosSeleccionados.Rows.Add(row.Cells["id"].Value, row.Cells["Producto"].Value, cantidad);
                        }
                        DgvProductos.Rows[row.Index].Cells["Seleccion"].Value = false;
                    }
                }
            }

        }
        #endregion

        #region Buscar productos en el Dgv
        //----------------------------
        // Buscar en el DataGridView
        //----------------------------
        private int BuscarEnDgv(DataGridView d, int col, string producto)
        {
            for (int i = 0; i < d.Rows.Count; i++)
            {
                string dato = d.Rows[i].Cells[col].Value.ToString();
                if (producto == dato)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion

        #region Ingresar producto
        //-----------------------
        // Ingresar producto
        //-----------------------
        private void BtnEntradaProductoIngresar_Click(object sender, EventArgs e)
        {
            //Validación.
            if (TbxUsuarioEntradaProducto.Text == "Ingrese al usuario")
            {
                MessageBox.Show("Ingrese al usuario");
                return;
            }

            if (DgvProductosSeleccionados.RowCount == 0)
            {
                MessageBox.Show("Ingrese algún producto.");
                return;
            }
            if (DtpFechaEntradaProducto.Value == null)
            {
                MessageBox.Show("Seleccione una fecha.");
                return;
            }

            //Variables.
            string usuario = TbxUsuarioEntradaProducto.Text;
            DateTime Fecha = DtpFechaEntradaProducto.Value;
            int indiceEntrada;
            int indiceProducto;
            int idUsuario;
            int cantidadProducto;

            MySqlDataReader mySqlDataReader = null;
            string buscar = "Select * from tusuarios where Usuario = '" + usuario + "'";
            MySqlCommand mySqlCommandBuscar = new MySqlCommand(buscar);
            mySqlCommandBuscar.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommandBuscar.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                MessageBox.Show("Registro fallido. Usuario inexistente.");
                mySqlDataReader.Close();
                return;
            }
            else
            {
                mySqlDataReader.Read();
                idUsuario = Convert.ToInt32(mySqlDataReader["idUsuario"]);
                //Variables para la base de datos.
                consulta = "Insert Into tEntradaproductos (FechaIngreso, TUsuarios_idUsuario) " +
                                  "Values ('" + Fecha.ToString("yyyy/MM/dd H:mm:ss") + "', " + idUsuario + ")";

                mySqlDataReader.Close();
                MySqlCommand mySqlCommandInsertar = new MySqlCommand(consulta);
                mySqlCommandInsertar.Connection = conexion.Conectar();
                mySqlCommandInsertar.ExecuteNonQuery();

                buscar = "Select COUNT(*) from tEntradaProductos";
                mySqlCommandBuscar = new MySqlCommand(buscar);
                mySqlCommandBuscar.Connection = conexion.Conectar();
                mySqlDataReader = mySqlCommandBuscar.ExecuteReader();

                indiceEntrada = Convert.ToInt32(mySqlDataReader.Read());

                mySqlDataReader.Close();
                foreach (DataGridViewRow row in DgvProductosSeleccionados.Rows)
                {
                    indiceProducto = Convert.ToInt32(row.Cells["idSeleccion"].Value);
                    cantidadProducto = Convert.ToInt32(row.Cells["CantidadSeleccionado"].Value);
                    int cantidadActualProducto;

                    consulta = "Insert Into TEntradaProductos_has_TProductos (TEntradaProductos_idEntradaProducto, TProductos_idProducto, CantidadProducto)" +
                               "Values (" + indiceProducto.ToString() + ", " + indiceEntrada.ToString() + ", " + cantidadProducto.ToString() + ")";

                    mySqlCommandInsertar = new MySqlCommand(consulta);
                    mySqlCommandInsertar.Connection = conexion.Conectar();
                    mySqlCommandInsertar.ExecuteNonQuery();

                    buscar = "Select cantidadProducto from tProductos where idProducto = " + indiceProducto.ToString();
                    mySqlCommandBuscar = new MySqlCommand(buscar);
                    mySqlCommandBuscar.Connection = conexion.Conectar();
                    mySqlDataReader = mySqlCommandBuscar.ExecuteReader();

                    mySqlDataReader.Read();
                    cantidadActualProducto = Convert.ToInt32(mySqlDataReader["cantidadProducto"]) + cantidadProducto;
                    mySqlDataReader.Close();

                    consulta = "Update TProductos Set cantidadProducto = " + cantidadActualProducto.ToString() + "  Where idProducto = " + indiceProducto.ToString();

                    MySqlCommand mySqlCommandActualizar = new MySqlCommand(consulta);
                    mySqlCommandActualizar.Connection = conexion.Conectar();
                    mySqlCommandActualizar.ExecuteNonQuery();
                }

                ActualizarTabla();
                DgvProductosSeleccionados.Rows.Clear();

                MessageBox.Show("Se ha registrado el producto");
            }
        }
        #endregion

        #region Actualizar tabla
        //-----------------------
        // Actualizar tabla
        //-----------------------
        private void ActualizarTabla()
        {
            DgvProductos.Rows.Clear();
            SeleccionarProductos();
        }
        #endregion
    }
}
