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
        bool sidebarExpand = false;
        public EntradaProducto()
        {
            InitializeComponent();
            sidebar.Width = sidebar.MinimumSize.Width;
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
            var coords = new Point(PnlFondo.Location.X, PnlFondo.Location.Y);
            coords.X = sidebar.Location.X + sidebar.Width + 12;
            PnlFondo.Location = coords;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
    }
}
