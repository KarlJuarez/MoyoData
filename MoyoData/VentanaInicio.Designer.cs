namespace MoyoData
{
    partial class VentanaInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaInicio));
            this.SidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.PnlDesplegarMenu = new System.Windows.Forms.Panel();
            this.LblMenu = new System.Windows.Forms.Label();
            this.PbxBotonMenu = new System.Windows.Forms.PictureBox();
            this.PnlFormHijo = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.Sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnRegistrarUsuario = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnEntradaProducto = new System.Windows.Forms.Button();
            this.BtnSalidaProducto = new System.Windows.Forms.Button();
            this.PnlSidebarRelleno = new System.Windows.Forms.Panel();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.PnlDesplegarMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBotonMenu)).BeginInit();
            this.PnlFormHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.Sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidebarTimer
            // 
            this.SidebarTimer.Interval = 10;
            this.SidebarTimer.Tick += new System.EventHandler(this.SidebarTimer_Tick);
            // 
            // PnlDesplegarMenu
            // 
            this.PnlDesplegarMenu.BackColor = System.Drawing.Color.Maroon;
            this.PnlDesplegarMenu.Controls.Add(this.LblMenu);
            this.PnlDesplegarMenu.Controls.Add(this.PbxBotonMenu);
            this.PnlDesplegarMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlDesplegarMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlDesplegarMenu.Margin = new System.Windows.Forms.Padding(0);
            this.PnlDesplegarMenu.Name = "PnlDesplegarMenu";
            this.PnlDesplegarMenu.Size = new System.Drawing.Size(275, 102);
            this.PnlDesplegarMenu.TabIndex = 0;
            this.PnlDesplegarMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlDesplegarMenu_MouseDown);
            // 
            // LblMenu
            // 
            this.LblMenu.AutoSize = true;
            this.LblMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenu.Location = new System.Drawing.Point(94, 40);
            this.LblMenu.Name = "LblMenu";
            this.LblMenu.Size = new System.Drawing.Size(66, 28);
            this.LblMenu.TabIndex = 1;
            this.LblMenu.Text = "Menú";
            // 
            // PbxBotonMenu
            // 
            this.PbxBotonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbxBotonMenu.Image = ((System.Drawing.Image)(resources.GetObject("PbxBotonMenu.Image")));
            this.PbxBotonMenu.Location = new System.Drawing.Point(22, 32);
            this.PbxBotonMenu.Name = "PbxBotonMenu";
            this.PbxBotonMenu.Size = new System.Drawing.Size(42, 37);
            this.PbxBotonMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxBotonMenu.TabIndex = 0;
            this.PbxBotonMenu.TabStop = false;
            this.PbxBotonMenu.Click += new System.EventHandler(this.PbxBotonMenu_Click);
            // 
            // PnlFormHijo
            // 
            this.PnlFormHijo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.PnlFormHijo.Controls.Add(this.BtnMinimizar);
            this.PnlFormHijo.Controls.Add(this.PbxLogo);
            this.PnlFormHijo.Controls.Add(this.BtnCerrar);
            this.PnlFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFormHijo.Location = new System.Drawing.Point(220, 0);
            this.PnlFormHijo.Name = "PnlFormHijo";
            this.PnlFormHijo.Size = new System.Drawing.Size(1198, 796);
            this.PnlFormHijo.TabIndex = 2;
            this.PnlFormHijo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlFormHijo_MouseDown);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(1129, 12);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 5;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // PbxLogo
            // 
            this.PbxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbxLogo.Image")));
            this.PbxLogo.Location = new System.Drawing.Point(331, 175);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(575, 445);
            this.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLogo.TabIndex = 2;
            this.PbxLogo.TabStop = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(1166, 12);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(20, 20);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.Sidebar.Controls.Add(this.PnlDesplegarMenu);
            this.Sidebar.Controls.Add(this.BtnRegistrarUsuario);
            this.Sidebar.Controls.Add(this.BtnInventario);
            this.Sidebar.Controls.Add(this.BtnEntradaProducto);
            this.Sidebar.Controls.Add(this.BtnSalidaProducto);
            this.Sidebar.Controls.Add(this.PnlSidebarRelleno);
            this.Sidebar.Controls.Add(this.BtnCerrarSesion);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.MaximumSize = new System.Drawing.Size(220, 800);
            this.Sidebar.MinimumSize = new System.Drawing.Size(83, 665);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(220, 796);
            this.Sidebar.TabIndex = 0;
            // 
            // BtnRegistrarUsuario
            // 
            this.BtnRegistrarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarUsuario.ForeColor = System.Drawing.Color.Black;
            this.BtnRegistrarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarUsuario.Image")));
            this.BtnRegistrarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrarUsuario.Location = new System.Drawing.Point(0, 102);
            this.BtnRegistrarUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRegistrarUsuario.Name = "BtnRegistrarUsuario";
            this.BtnRegistrarUsuario.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnRegistrarUsuario.Size = new System.Drawing.Size(275, 61);
            this.BtnRegistrarUsuario.TabIndex = 1;
            this.BtnRegistrarUsuario.Text = "           Registrar";
            this.BtnRegistrarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrarUsuario.UseVisualStyleBackColor = true;
            this.BtnRegistrarUsuario.Click += new System.EventHandler(this.BtnRegistrarUsuario_Click);
            // 
            // BtnInventario
            // 
            this.BtnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInventario.FlatAppearance.BorderSize = 0;
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.ForeColor = System.Drawing.Color.Black;
            this.BtnInventario.Image = ((System.Drawing.Image)(resources.GetObject("BtnInventario.Image")));
            this.BtnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventario.Location = new System.Drawing.Point(0, 163);
            this.BtnInventario.Margin = new System.Windows.Forms.Padding(0);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnInventario.Size = new System.Drawing.Size(275, 61);
            this.BtnInventario.TabIndex = 2;
            this.BtnInventario.Text = "           Inventario";
            this.BtnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventario.UseVisualStyleBackColor = true;
            this.BtnInventario.Click += new System.EventHandler(this.BtnInventario_Click);
            // 
            // BtnEntradaProducto
            // 
            this.BtnEntradaProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEntradaProducto.FlatAppearance.BorderSize = 0;
            this.BtnEntradaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntradaProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntradaProducto.ForeColor = System.Drawing.Color.Black;
            this.BtnEntradaProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnEntradaProducto.Image")));
            this.BtnEntradaProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEntradaProducto.Location = new System.Drawing.Point(0, 224);
            this.BtnEntradaProducto.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEntradaProducto.Name = "BtnEntradaProducto";
            this.BtnEntradaProducto.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnEntradaProducto.Size = new System.Drawing.Size(275, 61);
            this.BtnEntradaProducto.TabIndex = 3;
            this.BtnEntradaProducto.Text = "           Entrada";
            this.BtnEntradaProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEntradaProducto.UseVisualStyleBackColor = true;
            this.BtnEntradaProducto.Click += new System.EventHandler(this.BtnEntradaProducto_Click);
            // 
            // BtnSalidaProducto
            // 
            this.BtnSalidaProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSalidaProducto.FlatAppearance.BorderSize = 0;
            this.BtnSalidaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalidaProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalidaProducto.ForeColor = System.Drawing.Color.Black;
            this.BtnSalidaProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalidaProducto.Image")));
            this.BtnSalidaProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalidaProducto.Location = new System.Drawing.Point(0, 285);
            this.BtnSalidaProducto.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSalidaProducto.Name = "BtnSalidaProducto";
            this.BtnSalidaProducto.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnSalidaProducto.Size = new System.Drawing.Size(275, 61);
            this.BtnSalidaProducto.TabIndex = 4;
            this.BtnSalidaProducto.Text = "           Salida";
            this.BtnSalidaProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalidaProducto.UseVisualStyleBackColor = true;
            this.BtnSalidaProducto.Click += new System.EventHandler(this.BtnSalidaProducto_Click);
            // 
            // PnlSidebarRelleno
            // 
            this.PnlSidebarRelleno.Location = new System.Drawing.Point(3, 349);
            this.PnlSidebarRelleno.Name = "PnlSidebarRelleno";
            this.PnlSidebarRelleno.Size = new System.Drawing.Size(229, 241);
            this.PnlSidebarRelleno.TabIndex = 5;
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.BtnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrarSesion.Image")));
            this.BtnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(0, 593);
            this.BtnCerrarSesion.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnCerrarSesion.Size = new System.Drawing.Size(275, 61);
            this.BtnCerrarSesion.TabIndex = 5;
            this.BtnCerrarSesion.Text = "           Cerrar Sesión";
            this.BtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // VentanaInicio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1418, 796);
            this.Controls.Add(this.PnlFormHijo);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1418, 796);
            this.MinimumSize = new System.Drawing.Size(1418, 796);
            this.Name = "VentanaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.PnlDesplegarMenu.ResumeLayout(false);
            this.PnlDesplegarMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxBotonMenu)).EndInit();
            this.PnlFormHijo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.Sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer SidebarTimer;
        private System.Windows.Forms.Button BtnSalidaProducto;
        private System.Windows.Forms.Button BtnEntradaProducto;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Button BtnRegistrarUsuario;
        private System.Windows.Forms.Panel PnlDesplegarMenu;
        private System.Windows.Forms.Label LblMenu;
        private System.Windows.Forms.PictureBox PbxBotonMenu;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.Panel PnlFormHijo;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.FlowLayoutPanel Sidebar;
        private System.Windows.Forms.Panel PnlSidebarRelleno;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
    }
}