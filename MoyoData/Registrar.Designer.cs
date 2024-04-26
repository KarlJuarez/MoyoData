namespace MoyoData
{
    partial class Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar));
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.LblRegistrar = new System.Windows.Forms.Label();
            this.PbxCerrarForm = new System.Windows.Forms.PictureBox();
            this.BtnRegistrarUsuario = new System.Windows.Forms.Button();
            this.CbxRegistrarRol = new System.Windows.Forms.ComboBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.LblRol = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.TbxRegistrarNombres = new System.Windows.Forms.TextBox();
            this.TbxRegistrarApellidos = new System.Windows.Forms.TextBox();
            this.TbxRegistrarPassword = new System.Windows.Forms.TextBox();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).BeginInit();
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.Maroon;
            this.PnlTitulo.Controls.Add(this.LblRegistrar);
            this.PnlTitulo.Controls.Add(this.PbxCerrarForm);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 100);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(1186, 73);
            this.PnlTitulo.TabIndex = 23;
            // 
            // LblRegistrar
            // 
            this.LblRegistrar.AutoSize = true;
            this.LblRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblRegistrar.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistrar.Location = new System.Drawing.Point(68, 14);
            this.LblRegistrar.Name = "LblRegistrar";
            this.LblRegistrar.Size = new System.Drawing.Size(353, 45);
            this.LblRegistrar.TabIndex = 1;
            this.LblRegistrar.Text = "REGISTRAR USUARIO";
            // 
            // PbxCerrarForm
            // 
            this.PbxCerrarForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxCerrarForm.Image = ((System.Drawing.Image)(resources.GetObject("PbxCerrarForm.Image")));
            this.PbxCerrarForm.Location = new System.Drawing.Point(1117, 22);
            this.PbxCerrarForm.Name = "PbxCerrarForm";
            this.PbxCerrarForm.Size = new System.Drawing.Size(35, 29);
            this.PbxCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxCerrarForm.TabIndex = 11;
            this.PbxCerrarForm.TabStop = false;
            this.PbxCerrarForm.Click += new System.EventHandler(this.PbxCerrarForm_Click);
            // 
            // BtnRegistrarUsuario
            // 
            this.BtnRegistrarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegistrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.BtnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarUsuario.Location = new System.Drawing.Point(980, 686);
            this.BtnRegistrarUsuario.Name = "BtnRegistrarUsuario";
            this.BtnRegistrarUsuario.Size = new System.Drawing.Size(135, 49);
            this.BtnRegistrarUsuario.TabIndex = 20;
            this.BtnRegistrarUsuario.Text = "Aceptar";
            this.BtnRegistrarUsuario.UseVisualStyleBackColor = false;
            this.BtnRegistrarUsuario.Click += new System.EventHandler(this.BtnRegistrarUsuario_Click);
            // 
            // CbxRegistrarRol
            // 
            this.CbxRegistrarRol.FormattingEnabled = true;
            this.CbxRegistrarRol.Location = new System.Drawing.Point(229, 476);
            this.CbxRegistrarRol.Name = "CbxRegistrarRol";
            this.CbxRegistrarRol.Size = new System.Drawing.Size(200, 24);
            this.CbxRegistrarRol.TabIndex = 19;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(663, 422);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(164, 38);
            this.LblPassword.TabIndex = 17;
            this.LblPassword.Text = "Contraseña";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidos.Location = new System.Drawing.Point(663, 243);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(159, 38);
            this.LblApellidos.TabIndex = 16;
            this.LblApellidos.Text = "Apellido(s)";
            // 
            // LblRol
            // 
            this.LblRol.AutoSize = true;
            this.LblRol.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRol.Location = new System.Drawing.Point(222, 422);
            this.LblRol.Name = "LblRol";
            this.LblRol.Size = new System.Drawing.Size(59, 38);
            this.LblRol.TabIndex = 15;
            this.LblRol.Text = "Rol";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombres.Location = new System.Drawing.Point(222, 243);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(157, 38);
            this.LblNombres.TabIndex = 14;
            this.LblNombres.Text = "Nombre(s)";
            // 
            // PnlLogo
            // 
            this.PnlLogo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.PnlLogo.Controls.Add(this.PbxLogo);
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(1186, 100);
            this.PnlLogo.TabIndex = 13;
            // 
            // PbxLogo
            // 
            this.PbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.PbxLogo.Image = global::MoyoData.Properties.Resources.Group_3;
            this.PbxLogo.Location = new System.Drawing.Point(377, 28);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(415, 44);
            this.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLogo.TabIndex = 1;
            this.PbxLogo.TabStop = false;
            // 
            // TbxRegistrarNombres
            // 
            this.TbxRegistrarNombres.Location = new System.Drawing.Point(229, 308);
            this.TbxRegistrarNombres.Name = "TbxRegistrarNombres";
            this.TbxRegistrarNombres.Size = new System.Drawing.Size(231, 22);
            this.TbxRegistrarNombres.TabIndex = 24;
            // 
            // TbxRegistrarApellidos
            // 
            this.TbxRegistrarApellidos.Location = new System.Drawing.Point(670, 308);
            this.TbxRegistrarApellidos.Name = "TbxRegistrarApellidos";
            this.TbxRegistrarApellidos.Size = new System.Drawing.Size(231, 22);
            this.TbxRegistrarApellidos.TabIndex = 25;
            // 
            // TbxRegistrarPassword
            // 
            this.TbxRegistrarPassword.Location = new System.Drawing.Point(670, 478);
            this.TbxRegistrarPassword.Name = "TbxRegistrarPassword";
            this.TbxRegistrarPassword.Size = new System.Drawing.Size(231, 22);
            this.TbxRegistrarPassword.TabIndex = 26;
            // 
            // Registrar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1186, 796);
            this.Controls.Add(this.TbxRegistrarPassword);
            this.Controls.Add(this.TbxRegistrarApellidos);
            this.Controls.Add(this.TbxRegistrarNombres);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.BtnRegistrarUsuario);
            this.Controls.Add(this.CbxRegistrarRol);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblApellidos);
            this.Controls.Add(this.LblRol);
            this.Controls.Add(this.LblNombres);
            this.Controls.Add(this.PnlLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).EndInit();
            this.PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Label LblRegistrar;
        private System.Windows.Forms.PictureBox PbxCerrarForm;
        private System.Windows.Forms.Button BtnRegistrarUsuario;
        private System.Windows.Forms.ComboBox CbxRegistrarRol;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label LblRol;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.TextBox TbxRegistrarNombres;
        private System.Windows.Forms.TextBox TbxRegistrarApellidos;
        private System.Windows.Forms.TextBox TbxRegistrarPassword;
    }
}