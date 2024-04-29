using MoyoData.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Parameters;
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
    public partial class AgregarSalidaProducto : Form
    {
        //------------------------//
        // ATRIBUTOS
        //------------------------//
        BaseDeDatos conexion = new BaseDeDatos();
        string consulta;
        List<string> categorias = new List<string>();

        //-----------------------
        // Constructor
        //-----------------------
        public AgregarSalidaProducto()
        {
            InitializeComponent();
            ObtenerCategoria();
            SeleccionarProductos();
        }

        //--------------------
        // Cerrar formulario
        //--------------------
        private void PbxCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Obtener categoria
        //----------------------
        // Obtener categoria
        //----------------------
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

        #region Seleccionar producto
        //-----------------------
        // Seleccionar producto
        //-----------------------
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
                DgvProductos.Rows.Add(Convert.ToInt32(mySqlDataReader["idProducto"]), producto.producto, producto.cantidadProducto.ToString(), producto.limteProducto.ToString(), tipoProducto.Item1, tipoProducto.Item2, false);
            }

            mySqlDataReader.Close();
        }
        #endregion

        #region Seleccionar categorias
        //-----------------------------
        // Seleccionar categoria
        //-----------------------------
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
                return Tuple.Create("No se encontró el tipo deproducto", "No se encontró la categoría");
            }

            mySqlDataReader.Read();

            tipoProducto = mySqlDataReader["TipoProducto"].ToString();
            categoria = categorias[Convert.ToInt32(mySqlDataReader["TCategorias_idCategoria"]) - 1];
            mySqlDataReader.Close();
            return Tuple.Create(tipoProducto, categoria);
        }

        #endregion

        #region Agregar producto
        //-----------------------------
        // Agregar producto a la lista
        //-----------------------------
        private void BtnSalidaProductoAgregar_Click(object sender, EventArgs e)
        {
            //Validación
            if (NumUDCantidadSalidaProducto.Value == 0)
            {
                MessageBox.Show("Ingresar una cantidad");
                return;
            }

            int cantidad = Convert.ToInt32(NumUDCantidadSalidaProducto.Value);
            int totalSeleccion = DgvProductos.Rows.Cast<DataGridViewRow>().
                Where(p => Convert.ToBoolean(p.Cells["ColumSeleccion"].Value)).Count();
            int indice;
            int cantidadTotal;
            if (totalSeleccion >= 1)
            {
                foreach (DataGridViewRow row in DgvProductos.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["ColumSeleccion"].Value))
                    {
                        if (Convert.ToInt32(row.Cells["ColumLimite"].Value) < cantidad)
                        {
                            MessageBox.Show("La cantidad del producto " + row.Cells["ColumProducto"].Value + " es menor a la cantidad que se desea sacar.");
                            continue;
                        }

                        if (DgvProductosSeleccionados.Rows.Count != 0)
                        {
                            indice = BuscarEnDgv(DgvProductosSeleccionados, DgvProductosSeleccionados.Columns["ColumProductosSeleccionados"].Index, row.Cells["ColumProducto"].Value.ToString());

                            if (indice == -1)
                            {
                                DgvProductosSeleccionados.Rows.Add(row.Cells["ColumID"].Value, row.Cells["ColumProducto"].Value, cantidad);
                                DgvProductos.Rows[row.Index].Cells["ColumSeleccion"].Value = false;
                                continue;
                            }
                            cantidadTotal = Convert.ToInt32(DgvProductosSeleccionados.Rows[indice].Cells["ColumCantidadSeleccionados"].Value) + cantidad;

                            if (cantidadTotal > Convert.ToInt32(row.Cells["ColumLimite"].Value) || cantidadTotal > Convert.ToInt32(row.Cells["ColumLimite"].Value))
                            {
                                MessageBox.Show("Debe de llevar menor cantidad de este producto");
                                continue;
                            }
                            DgvProductosSeleccionados.Rows[indice].Cells["ColumCantidadSeleccionados"].Value = cantidadTotal;
                            DgvProductos.Rows[row.Index].Cells["ColumSeleccion"].Value = false;
                        }
                        else
                        {
                            DgvProductosSeleccionados.Rows.Add(row.Cells["ColumID"].Value, row.Cells["ColumProducto"].Value, cantidad);
                            DgvProductos.Rows[row.Index].Cells["ColumSeleccion"].Value = false;
                        }
                    }
                }
            }

        }
        #endregion

        #region Buscar en el Dgv
        //-----------------------------
        // Buscar en el DataGridView
        //-----------------------------
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

        #region Realizar salida de productos
        //--------------------------------
        // Realizar salida de productos
        //--------------------------------
        private void BtnSalidaProductoHacerPrestamo_Click(object sender, EventArgs e)
        {
            //Validación.
            if (TbxUsuarioSalidaProducto.Text == "Ingrese al usuario")
            {
                MessageBox.Show("Ingrese al usuario");
                return;
            }

            if (DgvProductosSeleccionados.RowCount == 0)
            {
                MessageBox.Show("Ingrese algún producto.");
                return;
            }
            if (DtpFechaSalidaProducto.Value == null)
            {
                MessageBox.Show("Seleccione una fecha.");
                return;
            }
            //Variables.
            string usuario = TbxUsuarioSalidaProducto.Text;
            DateTime Fecha = DtpFechaSalidaProducto.Value;
            int indiceSalida;
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
                consulta = "Insert Into tsalidaproductos (FechaExpedicion, TUsuarios_idUsuario) " +
                                  "Values ('" + Fecha.ToString("yyyy/MM/dd H:mm:ss") + "', " + idUsuario + ")";

                mySqlDataReader.Close();
                MySqlCommand mySqlCommandInsertar = new MySqlCommand(consulta);
                mySqlCommandInsertar.Connection = conexion.Conectar();
                mySqlCommandInsertar.ExecuteNonQuery();

                buscar = "SELECT * FROM TSalidaProductos ORDER BY idSalidaProducto DESC LIMIT 1";
                mySqlCommandBuscar = new MySqlCommand(buscar);
                mySqlCommandBuscar.Connection = conexion.Conectar();
                mySqlDataReader = mySqlCommandBuscar.ExecuteReader();
                mySqlDataReader.Read();

                indiceSalida = Convert.ToInt32(mySqlDataReader["idSalidaProducto"]);

                mySqlDataReader.Close();
                foreach (DataGridViewRow row in DgvProductosSeleccionados.Rows)
                {
                    indiceProducto = Convert.ToInt32(row.Cells["ColumIDSeleccionados"].Value);
                    cantidadProducto = Convert.ToInt32(row.Cells["ColumCantidadSeleccionados"].Value);
                    int cantidadActualProducto;


                    consulta = "Insert Into TProductos_has_TSalidaProductos (TProductOs_idProducto, TSalidaProductos_idSalidaProducto, CantidadProducto)" +
                               "Values (" + indiceProducto.ToString() + ", " + indiceSalida.ToString() + ", " + cantidadProducto.ToString() + ")";

                    mySqlCommandInsertar = new MySqlCommand(consulta);
                    mySqlCommandInsertar.Connection = conexion.Conectar();
                    mySqlCommandInsertar.ExecuteNonQuery();

                    buscar = "Select cantidadProducto from tProductos where idProducto = " + indiceProducto.ToString();
                    mySqlCommandBuscar = new MySqlCommand(buscar);
                    mySqlCommandBuscar.Connection = conexion.Conectar();
                    mySqlDataReader = mySqlCommandBuscar.ExecuteReader();

                    mySqlDataReader.Read();
                    cantidadActualProducto = Convert.ToInt32(mySqlDataReader["cantidadProducto"]) - cantidadProducto;
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
            this.Close();

        }
        #endregion

        #region Actualizar tabla
        //-----------------------------
        // Actualizar tabla
        //-----------------------------
        private void ActualizarTabla()
        {
            DgvProductos.Rows.Clear();
            SeleccionarProductos();
        }
        #endregion

        #region Validación de campos
        //-----------------------------------------------------
        // Resaltar cuando el puntero entra del
        // Textbox UsuarioSalidaProducto
        //-----------------------------------------------------
        private void TbxUsuarioSalidaProducto_Enter(object sender, EventArgs e)
        {
            if (TbxUsuarioSalidaProducto.Text == "Escribe aquí")
            {
                TbxUsuarioSalidaProducto.Text = "";
                TbxUsuarioSalidaProducto.ForeColor = Color.Black;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero sale del
        // Textbox UsuarioSalidaProducto
        //-----------------------------------------------------
        private void TbxUsuarioSalidaProducto_Leave(object sender, EventArgs e)
        {
            if (TbxUsuarioSalidaProducto.Text == "")
            {
                TbxUsuarioSalidaProducto.Text = "Escribe aquí";
                TbxUsuarioSalidaProducto.ForeColor = Color.DimGray;
            }
        }

        //-----------------------------------------------------
        // Validar que el campo de TbxUsuarioSalidaProducto
        // sólo admita la entrada de letras
        //-----------------------------------------------------
        private void TbxUsuarioSalidaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo puede ingresar letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        #endregion
    }
}
