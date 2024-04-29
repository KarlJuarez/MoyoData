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
    public partial class EntradaProductos : Form
    {
        //-----------------------------------//
        // ATRIBUTOS
        //-----------------------------------//
        BaseDeDatos conexion = new BaseDeDatos();
        List<Producto> productos = new List<Producto>();
        List<Usuario> usuarios = new List<Usuario>();
        List<Rol> roles = new List<Rol>();
        Usuario usuario;
        string idRol;
        string consulta;

        //-----------------------
        // Constructor
        //-----------------------
        public EntradaProductos(Usuario usuario)
        {
            InitializeComponent();
            SeleccionarProductos();
            SeleccionarUsuarios();
            SeleccionarRoles();
            CargarDatos();
            this.usuario = usuario;
            idRol = roles.Find(p => p.rol == "Administrador").id.ToString();

            if (this.usuario.rol != idRol)
            {
               BtnEntradaProductoEliminar.Dispose();
            }
        }

        //-----------------------------
        // Cerrar formulario
        //-----------------------------
        private void PbxCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Función para seleccionar roles
        //-----------------------
        // Seleccionar roles
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
        #endregion

        #region Función para seleccionar productos
        //-------------------------
        // Seleccionar productos
        //-------------------------
        private void SeleccionarProductos()
        {
            MySqlDataReader mySqlDataReader = null;
            Producto producto;
            consulta = "Select * from TProductos";

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron productos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            while (mySqlDataReader.Read())
            {
                producto = new Producto(Convert.ToInt32(mySqlDataReader["idProducto"]), mySqlDataReader["NombreProducto"].ToString());
                productos.Add(producto);
            }
            mySqlDataReader.Close();
        }
        #endregion

        #region Función para seleccionar usuarios
        //-----------------------------
        // Seleccionar usuarios
        //-----------------------------
        private void SeleccionarUsuarios()
        {
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select * from TUsuarios";
            Usuario usuario;

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron usuarios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            while (mySqlDataReader.Read())
            {
                usuario = new Usuario(Convert.ToInt32(mySqlDataReader["idUsuario"].ToString()), mySqlDataReader["usuario"].ToString());
                usuarios.Add(usuario);
            }
            mySqlDataReader.Close();
        }
        #endregion

        #region Función para cargar datos en DgvEntradaProductos
        //----------------------------------------
        // Cargar datos en DgvEntradaProductos
        //----------------------------------------
        private void CargarDatos() 
        {
            DgvEntradaProductos.Rows.Clear();
            MySqlDataReader mySqlDataReader = null;
            consulta = "Select * from TEntradaProductos_has_TProductos";
            int id;
            Producto producto;
            string fecha;
            Usuario usuario;

            MySqlCommand mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            if (!mySqlDataReader.HasRows)
            {
                mySqlDataReader.Close();
                MessageBox.Show("No se encontraron entrada de productos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            while (mySqlDataReader.Read())
            {
                id = Convert.ToInt32(mySqlDataReader["TEntradaProductos_idEntradaProducto"]);
                producto = productos.Find(p => p.Id == Convert.ToInt32(mySqlDataReader["TProductos_idProducto"]));
                DgvEntradaProductos.Rows.Add(id, "", "", producto.producto,
                                            mySqlDataReader["CantidadProducto"], false);
            }

            mySqlDataReader.Close();

            consulta = "Select * from TEntradaProductos";

            mySqlCommand = new MySqlCommand(consulta);
            mySqlCommand.Connection = conexion.Conectar();
            mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                id = Convert.ToInt32(mySqlDataReader["idEntradaProducto"]);
                fecha = mySqlDataReader["FechaIngreso"].ToString();
                usuario = usuarios.Find(p => p.id == Convert.ToInt32(mySqlDataReader["TUsuarios_idUsuario"]));
                foreach (DataGridViewRow row in DgvEntradaProductos.Rows)
                {
                    if (id == Convert.ToInt32(DgvEntradaProductos.Rows[row.Index].Cells["ColumID"].Value))
                    {
                        DgvEntradaProductos.Rows[row.Index].Cells["ColumFecha"].Value = fecha;
                        DgvEntradaProductos.Rows[row.Index].Cells["ColumUsuario"].Value = usuario.usuario;
                    }
                }
            }
            mySqlDataReader.Close();
        }
        #endregion

        #region Botón para agregar entrada de producto
        //-----------------------------
        // Agregar entrada de producto
        //-----------------------------
        private void BtnEntradaProductoAgregar_Click(object sender, EventArgs e)
        {
            AgregarEntradaProducto agregarEntradaProducto = new AgregarEntradaProducto();
            agregarEntradaProducto.ShowDialog();
            CargarDatos();
        }
        #endregion

        #region Botón para eliminar entrada de producto
        //-------------------------------
        // Eliminar entrada de producto
        //-------------------------------
        private void BtnEntradaProductoEliminar_Click(object sender, EventArgs e)
        {
            int id;
            int totalSeleccion = DgvEntradaProductos.Rows.Cast<DataGridViewRow>().
                Where(p => Convert.ToBoolean(p.Cells["ColumSeleccion"].Value)).Count();
            if (totalSeleccion <= 0)
            {
                MessageBox.Show("Seleccione alguna salida de producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("¿Quiéres borrar las entradas del producto?"
                , "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            foreach (DataGridViewRow row in DgvEntradaProductos.Rows)
            {
                if (Convert.ToBoolean(row.Cells["ColumSeleccion"].Value))
                {
                    id = Convert.ToInt32(row.Cells["ColumID"].Value);

                    consulta = "Delete from TEntradaProductos_has_TProductos where TEntradaProductos_idEntradaProducto = " + id.ToString();
                    MySqlCommand mySqlCommandBorrarSalidaProductos = new MySqlCommand(consulta);
                    mySqlCommandBorrarSalidaProductos.Connection = conexion.Conectar();
                    mySqlCommandBorrarSalidaProductos.ExecuteNonQuery();

                    consulta = "Delete from TEntradaProductos where idEntradaProducto = " + id.ToString();
                    MySqlCommand mySqlCommandBorrar = new MySqlCommand(consulta);
                    mySqlCommandBorrar.Connection = conexion.Conectar();
                    mySqlCommandBorrar.ExecuteNonQuery();

                }
            }
            CargarDatos();
            MessageBox.Show("Se ha borrado las salidas de productos", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
