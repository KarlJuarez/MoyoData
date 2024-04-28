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
    public partial class VentanaInicio : Form
    {
        //-------------------------------------//
        // ATRIBUTOS
        //-------------------------------------//
        bool SidebarExpand = true;
        BaseDeDatos conexion = new BaseDeDatos();
        Usuario usuario;
        List<Rol> roles = new List<Rol>();
        string consulta;
        string idRol;

        public VentanaInicio(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            LblMenu.Text = usuario.usuario;
            SeleccionarRoles();
            idRol = roles.Find(p=> p.rol == "Administrador").id.ToString();

            if (this.usuario.rol != idRol)
            {
                BtnUsuarios.Dispose();
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

        #region Movimiento de la ventana
        //--------------------------------
        // Importación para arrastrar
        // ventanas
        //--------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
            int wparam, int lparam);

        //--------------------------------
        // Cerrar ventana
        //--------------------------------
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        //--------------------------------
        // Minimizar ventana
        //--------------------------------
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        //--------------------------------
        // Arratrar ventana (Panel de
        // Inicio)
        //--------------------------------
        private void PnlFormHijo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //--------------------------------
        // Arratrar ventana (Panel de
        // despliegue de menú)
        //--------------------------------
        private void PnlDesplegarMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Barra de menu retractil
        //-----------------------------
        // Simular barra de menú
        // retráctil
        //-----------------------------
        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            // Establecer el mínimo y máximo tamaño del panel sidebar

            if (SidebarExpand)
            {
                Sidebar.Width -= 10; // Si el sidebar está expandido, minimizarlo

                if (Sidebar.Width <= Sidebar.MinimumSize.Width)
                {
                    SidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                Sidebar.Width += 10;

                if (Sidebar.Width >= Sidebar.MaximumSize.Width)
                {
                    SidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }

        //-----------------------------
        // Desplegar barra de menú
        //-----------------------------
        private void PbxBotonMenu_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }
        #endregion

        #region Cambiar formulario en VentanaInicio
        //--------------------------------
        // Cambiar entre formularios
        //--------------------------------
        private Form FormActivo = null;
        private void AbrirFormularioHijo(Form FormHijo)
        {
            if (FormActivo != null)

                FormActivo.Close();
                FormActivo = FormHijo;
                FormHijo.TopLevel = false;
                FormHijo.FormBorderStyle = FormBorderStyle.None;
                FormHijo.Dock = DockStyle.Fill;
                PnlFormHijo.Controls.Add(FormHijo);
                PnlFormHijo.Tag = FormHijo;
                FormHijo.BringToFront();
                FormHijo.Show();
        }
        #endregion

        #region Abrir formularios hijo
        //-------------------------------------
        // Abrir formulario MostrarUsuarios
        //-------------------------------------
        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new MostrarUsuarios());
        }

        //-------------------------------------
        // Abrir formulario Inventario
        //-------------------------------------
        private void BtnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Inventario(usuario));
        }

        //-------------------------------------------
        // Abrir formulario AgregarEntradaProducto
        //-------------------------------------------
        private void BtnEntradaProducto_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new EntradaProductos(usuario));
        }

        //------------------------------------------
        // Abrir formulario AgregarSalidaProducto
        //------------------------------------------
        private void BtnSalidaProducto_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new SalidaProductos(usuario));
        }

        //-------------------------------------
        // Abrir formulario Aspectos
        //-------------------------------------
        private void BtnAspectos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Aspectos(usuario));
        }
        #endregion

        //-------------------------------------
        // Cerrar sesión del usuario
        //-------------------------------------
        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            usuario = null;
            Login login = new Login();
            login.Show();
            this.Close();
        }

    }
}
