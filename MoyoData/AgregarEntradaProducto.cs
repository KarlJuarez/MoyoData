using MoyoData.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoyoData
{
    public partial class AgregarEntradaProducto : Form
    {
        //---------------------------//
        // ATRIBUTOS
        //---------------------------//
        BaseDeDatos conexion = new BaseDeDatos();
        string consulta;
        List<Categoria> categorias = new List<Categoria>();

        //-----------------------
        // Constructor
        //-----------------------
        public AgregarEntradaProducto()
        {
            InitializeComponent();
            ObtenerCategoria();
            SeleccionarProductos();
        }

        //--------------------------------
        // Importación para arrastrar
        // ventana
        //--------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
            int wparam, int lparam);

        //-----------------------
        // Cerrar formulario
        //-----------------------
        private void PbxCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //--------------------
        // Arrastrar ventana
        //--------------------
        private void PnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region Obtener categorias
        //-----------------------------------------
        // Obtener categorías para
        // ingresarlo en la lista "categorias"
        //-----------------------------------------
        private void ObtenerCategoria()
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
                categoria = new Categoria(Convert.ToInt32(mySqlDataReader["idcategoria"]), mySqlDataReader["categoria"].ToString());
                categorias.Add(categoria);
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
            Categoria categoria;
            string tipoProducto;

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
            categoria = categorias.Find(p => p.id == Convert.ToInt32(mySqlDataReader["TCategorias_IdCategoria"]));
            mySqlDataReader.Close();
            return Tuple.Create(tipoProducto, categoria.categoria);
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
                Where(p => Convert.ToBoolean(p.Cells["ColumSeleccion"].Value)).Count();
            int indice;
            int cantidadTotal;

            if (totalSeleccion >= 1)
            {
                foreach (DataGridViewRow row in DgvProductos.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["ColumSeleccion"].Value))
                    {
                        if (Convert.ToInt32(row.Cells["ColumStock"].Value) < (cantidad + Convert.ToInt32(row.Cells["ColumCantidad"].Value)))
                        {
                            MessageBox.Show("La cantidad del producto " + row.Cells["ColumProducto"].Value + " es mayor al permitido en el almacén.");
                            continue;
                        }

                        if (DgvProductosSeleccionados.Rows.Count != 0)
                        {
                            indice = BuscarEnDgv(DgvProductosSeleccionados, DgvProductosSeleccionados.Columns["ColumProductoSeleccionados"].Index, row.Cells["ColumProducto"].Value.ToString());

                            if (indice == -1)
                            {
                                DgvProductosSeleccionados.Rows.Add(row.Cells["ColumID"].Value, row.Cells["ColumProducto"].Value, cantidad);
                                DgvProductos.Rows[row.Index].Cells["ColumSeleccion"].Value = false;
                                continue;
                            }

                            cantidadTotal = Convert.ToInt32(DgvProductosSeleccionados.Rows[indice].Cells["ColumCantidadSeleccionados"].Value) + cantidad + Convert.ToInt32(row.Cells["ColumCantidad"].Value);

                            if (cantidadTotal > Convert.ToInt32(row.Cells["ColumStock"].Value))
                            {
                                MessageBox.Show("La cantidad del producto" + row.Cells["ColumProducto"].Value + " es mayor al permitido en el almacén.");
                                continue;
                            }

                            DgvProductosSeleccionados.Rows[indice].Cells["ColumCantidadSeleccionados"].Value = cantidadTotal;
                        }
                        else
                        {
                            DgvProductosSeleccionados.Rows.Add(row.Cells["ColumID"].Value, row.Cells["ColumProducto"].Value, cantidad);
                        }
                        DgvProductos.Rows[row.Index].Cells["ColumSeleccion"].Value = false;
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
            //Validación
            if (TbxUsuarioEntradaProducto.Text == "Ingrese al usuario")
            {
                MessageBox.Show("Ingrese al usuario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (DgvProductosSeleccionados.RowCount == 0)
            {
                MessageBox.Show("Ingrese algún producto.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (DtpFechaEntradaProducto.Value == null)
            {
                MessageBox.Show("Seleccione una fecha.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            mySqlDataReader.Read();
            idUsuario = Convert.ToInt32(mySqlDataReader["idUsuario"]);
            //Variables para la base de datos.
            consulta = "Insert Into tEntradaproductos (FechaIngreso, TUsuarios_idUsuario) " +
                              "Values ('" + Fecha.ToString("yyyy/MM/dd H:mm:ss") + "', " + idUsuario + ")";

            mySqlDataReader.Close();
            MySqlCommand mySqlCommandInsertar = new MySqlCommand(consulta);
            mySqlCommandInsertar.Connection = conexion.Conectar();
            mySqlCommandInsertar.ExecuteNonQuery();

            buscar = "SELECT * FROM TEntradaProductos ORDER BY idEntradaProducto DESC LIMIT 1";
            mySqlCommandBuscar = new MySqlCommand(buscar);
            mySqlCommandBuscar.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommandBuscar.ExecuteReader();
            mySqlDataReader.Read();

            indiceEntrada = Convert.ToInt32(mySqlDataReader["idEntradaProducto"]);

            mySqlDataReader.Close();
            foreach (DataGridViewRow row in DgvProductosSeleccionados.Rows)
            {
                indiceProducto = Convert.ToInt32(row.Cells["ColumIDSeleccionados"].Value);
                cantidadProducto = Convert.ToInt32(row.Cells["ColumCantidadSeleccionados"].Value);
                int cantidadActualProducto;

                consulta = "Insert Into TEntradaProductos_has_TProductos (TEntradaProductos_idEntradaProducto, TProductos_idProducto, CantidadProducto)" +
                           "Values (" + indiceEntrada.ToString() + ", " + indiceProducto.ToString() + ", " + cantidadProducto.ToString() + ")";

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
            this.Close();
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

        #region Validación de campos
        //-----------------------------------------------------
        // Resaltar cuando el puntero entra del
        // Textbox EntradaProducto
        //-----------------------------------------------------
        private void TbxUsuarioEntradaProducto_Enter(object sender, EventArgs e)
        {
            if (TbxUsuarioEntradaProducto.Text == "Escribe aquí")
            {
                TbxUsuarioEntradaProducto.Text = "";
                TbxUsuarioEntradaProducto.ForeColor = Color.Black;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero sale del
        // Textbox EntradaProducto
        //-----------------------------------------------------
        private void TbxUsuarioEntradaProducto_Leave(object sender, EventArgs e)
        {
            if (TbxUsuarioEntradaProducto.Text == "")
            {
                TbxUsuarioEntradaProducto.Text = "Escribe aquí";
                TbxUsuarioEntradaProducto.ForeColor = Color.DimGray;
            }
        }

        //-----------------------------------------------------
        // Validar que el campo de TbxUsuarioEntradaProducto
        // sólo admita la entrada de letras
        //-----------------------------------------------------
        private void TbxUsuarioEntradaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo puede ingresar letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //--------------------------------------------------------
        // Validar que el campo de NumUDCantidadEntradaProducto
        // sólo admita la entrada de números
        //--------------------------------------------------------
        private void NumUDCantidadEntradaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Sólo puede ingresar números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        #endregion
    }
}
