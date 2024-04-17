using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MoyoData
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //--------------------------------
        // Importación para arrastrar
        // ventana Login
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
            Application.Exit();
        }

        //--------------------------------
        // Minimizar ventana
        //--------------------------------
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //--------------------------------
        // Arratrar ventana
        //--------------------------------
        // En formulario
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // En panel
        private void panelIzquierdo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //-----------------------------------------------------
        // Resaltar cuando el puntero entra del
        // Textbox Usuario
        //-----------------------------------------------------
        private void TbxUsuario_Enter(object sender, EventArgs e)
        {
            if(TbxUsuario.Text == "Usuario")
            {
                TbxUsuario.Text = "";
                TbxUsuario.ForeColor = Color.Black;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero sale del
        // Textbox Usuario
        //-----------------------------------------------------
        private void TbxUsuario_Leave(object sender, EventArgs e)
        {
            if (TbxUsuario.Text == "")
            {
                TbxUsuario.Text = "Usuario";
                TbxUsuario.ForeColor= Color.DimGray;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero entra del
        // Textbox Password
        //-----------------------------------------------------
        private void TbxPassword_Enter(object sender, EventArgs e)
        {
            if(TbxPassword.Text == "Contraseña")
            {
                TbxPassword.Text = "";
                TbxPassword.ForeColor = Color.Black;
                TbxPassword.UseSystemPasswordChar = true;
            }
        }

        //-----------------------------------------------------
        // Resaltar cuando el puntero sale del
        // Textbox Password
        //-----------------------------------------------------
        private void TbxPassword_Leave(object sender, EventArgs e)
        {
            if( TbxPassword.Text == "")
            {
                TbxPassword.Text = "Contraseña";
                TbxPassword.ForeColor = Color.DimGray;
                TbxPassword.UseSystemPasswordChar = false;
            }
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Validación
            if(TbxUsuario.Text != "Usuario")
            {
                if (TbxPassword.Text != "Contraseña")
                {

                }
                else
                {
                    MensajeError("Contraseña obligatoria");
                }
            }
            else
            {
                MensajeError("Usuario obligatorio");
            }
        }

        private void MensajeError (string msg)
        {
            LblMensajeError.Text = "    " + msg;
            LblMensajeError.Visible = true;
        }
    }
}
