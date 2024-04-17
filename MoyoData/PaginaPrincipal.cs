using MoyoData.Models;
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
    public partial class PaginaPrincipal : System.Windows.Forms.Form
    {
        Usuario usuario;
        public PaginaPrincipal(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            MessageBox.Show(usuario.usuario);
        }


    }
}
