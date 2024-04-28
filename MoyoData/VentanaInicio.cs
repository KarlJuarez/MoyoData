using MoyoData.Models;
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
        Usuario usuario;

        public VentanaInicio(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            LblMenu.Text = usuario.usuario;
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
            AbrirFormularioHijo(new Inventario());
        }

        //-------------------------------------------
        // Abrir formulario AgregarEntradaProducto
        //-------------------------------------------
        private void BtnEntradaProducto_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new EntradaProductos());
        }

        //------------------------------------------
        // Abrir formulario AgregarSalidaProducto
        //------------------------------------------
        private void BtnSalidaProducto_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new SalidaProductos());
        }

        //-------------------------------------
        // Abrir formulario Aspectos
        //-------------------------------------
        private void BtnAspectos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Aspectos());
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
