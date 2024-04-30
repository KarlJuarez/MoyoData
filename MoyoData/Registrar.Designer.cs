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
            this.PbxNombreEmpresa = new System.Windows.Forms.PictureBox();
            this.LblRegistrar = new System.Windows.Forms.Label();
            this.PbxCerrarForm = new System.Windows.Forms.PictureBox();
            this.BtnRegistrarUsuario = new System.Windows.Forms.Button();
            this.CbxRegistrarRol = new System.Windows.Forms.ComboBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.LblRol = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.TbxRegistrarNombres = new System.Windows.Forms.TextBox();
            this.TbxRegistrarApellidos = new System.Windows.Forms.TextBox();
            this.TbxRegistrarPassword = new System.Windows.Forms.TextBox();
            this.LblGuionBajoUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxRespuestaRecuperarPassword = new System.Windows.Forms.TextBox();
            this.LblRespuestaRecuperarPassword = new System.Windows.Forms.Label();
            this.LblGuionBajoRespuesta = new System.Windows.Forms.Label();
            this.LblAtencionRecuperarPassword = new System.Windows.Forms.Label();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.Maroon;
            this.PnlTitulo.Controls.Add(this.PbxNombreEmpresa);
            this.PnlTitulo.Controls.Add(this.LblRegistrar);
            this.PnlTitulo.Controls.Add(this.PbxCerrarForm);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(1186, 73);
            this.PnlTitulo.TabIndex = 23;
            this.PnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitulo_MouseDown);
            // 
            // PbxNombreEmpresa
            // 
            this.PbxNombreEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("PbxNombreEmpresa.Image")));
            this.PbxNombreEmpresa.Location = new System.Drawing.Point(808, 23);
            this.PbxNombreEmpresa.Name = "PbxNombreEmpresa";
            this.PbxNombreEmpresa.Size = new System.Drawing.Size(276, 28);
            this.PbxNombreEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxNombreEmpresa.TabIndex = 13;
            this.PbxNombreEmpresa.TabStop = false;
            // 
            // LblRegistrar
            // 
            this.LblRegistrar.AutoSize = true;
            this.LblRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblRegistrar.Font = new System.Drawing.Font("Roboto", 19F, System.Drawing.FontStyle.Bold);
            this.LblRegistrar.ForeColor = System.Drawing.Color.White;
            this.LblRegistrar.Location = new System.Drawing.Point(70, 20);
            this.LblRegistrar.Name = "LblRegistrar";
            this.LblRegistrar.Size = new System.Drawing.Size(331, 38);
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
            this.BtnRegistrarUsuario.Font = new System.Drawing.Font("Rosario", 10F, System.Drawing.FontStyle.Bold);
            this.BtnRegistrarUsuario.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrarUsuario.Location = new System.Drawing.Point(997, 482);
            this.BtnRegistrarUsuario.Name = "BtnRegistrarUsuario";
            this.BtnRegistrarUsuario.Size = new System.Drawing.Size(143, 56);
            this.BtnRegistrarUsuario.TabIndex = 19;
            this.BtnRegistrarUsuario.Text = "Registrar";
            this.BtnRegistrarUsuario.UseVisualStyleBackColor = false;
            this.BtnRegistrarUsuario.Click += new System.EventHandler(this.BtnRegistrarUsuario_Click);
            // 
            // CbxRegistrarRol
            // 
            this.CbxRegistrarRol.BackColor = System.Drawing.Color.White;
            this.CbxRegistrarRol.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CbxRegistrarRol.FormattingEnabled = true;
            this.CbxRegistrarRol.Location = new System.Drawing.Point(230, 353);
            this.CbxRegistrarRol.Name = "CbxRegistrarRol";
            this.CbxRegistrarRol.Size = new System.Drawing.Size(309, 33);
            this.CbxRegistrarRol.TabIndex = 20;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(665, 299);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(136, 36);
            this.LblPassword.TabIndex = 17;
            this.LblPassword.Text = "Contraseña";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidos.Location = new System.Drawing.Point(665, 120);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(129, 36);
            this.LblApellidos.TabIndex = 16;
            this.LblApellidos.Text = "Apellido(s)";
            // 
            // LblRol
            // 
            this.LblRol.AutoSize = true;
            this.LblRol.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRol.Location = new System.Drawing.Point(224, 299);
            this.LblRol.Name = "LblRol";
            this.LblRol.Size = new System.Drawing.Size(49, 36);
            this.LblRol.TabIndex = 15;
            this.LblRol.Text = "Rol";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombres.Location = new System.Drawing.Point(224, 120);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(129, 36);
            this.LblNombres.TabIndex = 14;
            this.LblNombres.Text = "Nombre(s)";
            // 
            // TbxRegistrarNombres
            // 
            this.TbxRegistrarNombres.BackColor = System.Drawing.Color.White;
            this.TbxRegistrarNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxRegistrarNombres.Font = new System.Drawing.Font("Rosario", 10F);
            this.TbxRegistrarNombres.ForeColor = System.Drawing.Color.DimGray;
            this.TbxRegistrarNombres.Location = new System.Drawing.Point(231, 185);
            this.TbxRegistrarNombres.MaxLength = 25;
            this.TbxRegistrarNombres.Name = "TbxRegistrarNombres";
            this.TbxRegistrarNombres.ShortcutsEnabled = false;
            this.TbxRegistrarNombres.Size = new System.Drawing.Size(309, 21);
            this.TbxRegistrarNombres.TabIndex = 24;
            this.TbxRegistrarNombres.Text = "Escribe aquí";
            this.TbxRegistrarNombres.Enter += new System.EventHandler(this.TbxRegistrarNombres_Enter);
            this.TbxRegistrarNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxRegistrarNombres_KeyPress);
            this.TbxRegistrarNombres.Leave += new System.EventHandler(this.TbxRegistrarNombres_Leave);
            // 
            // TbxRegistrarApellidos
            // 
            this.TbxRegistrarApellidos.BackColor = System.Drawing.Color.White;
            this.TbxRegistrarApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxRegistrarApellidos.Font = new System.Drawing.Font("Rosario", 10F);
            this.TbxRegistrarApellidos.ForeColor = System.Drawing.Color.DimGray;
            this.TbxRegistrarApellidos.Location = new System.Drawing.Point(672, 185);
            this.TbxRegistrarApellidos.MaxLength = 25;
            this.TbxRegistrarApellidos.Name = "TbxRegistrarApellidos";
            this.TbxRegistrarApellidos.ShortcutsEnabled = false;
            this.TbxRegistrarApellidos.Size = new System.Drawing.Size(309, 21);
            this.TbxRegistrarApellidos.TabIndex = 25;
            this.TbxRegistrarApellidos.Text = "Escribe aquí";
            this.TbxRegistrarApellidos.Enter += new System.EventHandler(this.TbxRegistrarApellidos_Enter);
            this.TbxRegistrarApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxRegistrarApellidos_KeyPress);
            this.TbxRegistrarApellidos.Leave += new System.EventHandler(this.TbxRegistrarApellidos_Leave);
            // 
            // TbxRegistrarPassword
            // 
            this.TbxRegistrarPassword.BackColor = System.Drawing.Color.White;
            this.TbxRegistrarPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxRegistrarPassword.Font = new System.Drawing.Font("Rosario", 10F);
            this.TbxRegistrarPassword.ForeColor = System.Drawing.Color.DimGray;
            this.TbxRegistrarPassword.Location = new System.Drawing.Point(672, 355);
            this.TbxRegistrarPassword.MaxLength = 50;
            this.TbxRegistrarPassword.Name = "TbxRegistrarPassword";
            this.TbxRegistrarPassword.ShortcutsEnabled = false;
            this.TbxRegistrarPassword.Size = new System.Drawing.Size(309, 21);
            this.TbxRegistrarPassword.TabIndex = 26;
            this.TbxRegistrarPassword.Text = "Escribe aquí";
            this.TbxRegistrarPassword.Enter += new System.EventHandler(this.TbxRegistrarPassword_Enter);
            this.TbxRegistrarPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxRegistrarPassword_KeyPress);
            this.TbxRegistrarPassword.Leave += new System.EventHandler(this.TbxRegistrarPassword_Leave);
            // 
            // LblGuionBajoUsuario
            // 
            this.LblGuionBajoUsuario.AutoSize = true;
            this.LblGuionBajoUsuario.Location = new System.Drawing.Point(226, 190);
            this.LblGuionBajoUsuario.Name = "LblGuionBajoUsuario";
            this.LblGuionBajoUsuario.Size = new System.Drawing.Size(316, 25);
            this.LblGuionBajoUsuario.TabIndex = 37;
            this.LblGuionBajoUsuario.Text = "______________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "______________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "______________________________________";
            // 
            // TbxRespuestaRecuperarPassword
            // 
            this.TbxRespuestaRecuperarPassword.BackColor = System.Drawing.Color.White;
            this.TbxRespuestaRecuperarPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxRespuestaRecuperarPassword.Font = new System.Drawing.Font("Rosario", 10F);
            this.TbxRespuestaRecuperarPassword.ForeColor = System.Drawing.Color.DimGray;
            this.TbxRespuestaRecuperarPassword.Location = new System.Drawing.Point(231, 489);
            this.TbxRespuestaRecuperarPassword.MaxLength = 20;
            this.TbxRespuestaRecuperarPassword.Name = "TbxRespuestaRecuperarPassword";
            this.TbxRespuestaRecuperarPassword.ShortcutsEnabled = false;
            this.TbxRespuestaRecuperarPassword.Size = new System.Drawing.Size(308, 21);
            this.TbxRespuestaRecuperarPassword.TabIndex = 41;
            this.TbxRespuestaRecuperarPassword.Text = "Escribe aquí";
            this.TbxRespuestaRecuperarPassword.Enter += new System.EventHandler(this.TbxRespuestaRecuperarPassword_Enter);
            this.TbxRespuestaRecuperarPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxRespuestaRecuperarPassword_KeyPress);
            this.TbxRespuestaRecuperarPassword.Leave += new System.EventHandler(this.TbxRespuestaRecuperarPassword_Leave);
            // 
            // LblRespuestaRecuperarPassword
            // 
            this.LblRespuestaRecuperarPassword.AutoSize = true;
            this.LblRespuestaRecuperarPassword.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRespuestaRecuperarPassword.Location = new System.Drawing.Point(224, 424);
            this.LblRespuestaRecuperarPassword.Name = "LblRespuestaRecuperarPassword";
            this.LblRespuestaRecuperarPassword.Size = new System.Drawing.Size(285, 36);
            this.LblRespuestaRecuperarPassword.TabIndex = 40;
            this.LblRespuestaRecuperarPassword.Text = "¿Cúal es tu color favorito?";
            // 
            // LblGuionBajoRespuesta
            // 
            this.LblGuionBajoRespuesta.AutoSize = true;
            this.LblGuionBajoRespuesta.Location = new System.Drawing.Point(226, 494);
            this.LblGuionBajoRespuesta.Name = "LblGuionBajoRespuesta";
            this.LblGuionBajoRespuesta.Size = new System.Drawing.Size(316, 25);
            this.LblGuionBajoRespuesta.TabIndex = 42;
            this.LblGuionBajoRespuesta.Text = "______________________________________";
            // 
            // LblAtencionRecuperarPassword
            // 
            this.LblAtencionRecuperarPassword.AutoSize = true;
            this.LblAtencionRecuperarPassword.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAtencionRecuperarPassword.ForeColor = System.Drawing.Color.Black;
            this.LblAtencionRecuperarPassword.Location = new System.Drawing.Point(227, 409);
            this.LblAtencionRecuperarPassword.Name = "LblAtencionRecuperarPassword";
            this.LblAtencionRecuperarPassword.Size = new System.Drawing.Size(240, 15);
            this.LblAtencionRecuperarPassword.TabIndex = 64;
            this.LblAtencionRecuperarPassword.Text = "Pregunta de recuperación de contraseña";
            // 
            // Registrar
            // 
            this.AcceptButton = this.BtnRegistrarUsuario;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 573);
            this.Controls.Add(this.LblAtencionRecuperarPassword);
            this.Controls.Add(this.TbxRespuestaRecuperarPassword);
            this.Controls.Add(this.LblRespuestaRecuperarPassword);
            this.Controls.Add(this.LblGuionBajoRespuesta);
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
            this.Controls.Add(this.LblGuionBajoUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rosario", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar usuario";
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).EndInit();
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
        private System.Windows.Forms.TextBox TbxRegistrarNombres;
        private System.Windows.Forms.TextBox TbxRegistrarApellidos;
        private System.Windows.Forms.TextBox TbxRegistrarPassword;
        private System.Windows.Forms.Label LblGuionBajoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxRespuestaRecuperarPassword;
        private System.Windows.Forms.Label LblRespuestaRecuperarPassword;
        private System.Windows.Forms.Label LblGuionBajoRespuesta;
        private System.Windows.Forms.PictureBox PbxNombreEmpresa;
        private System.Windows.Forms.Label LblAtencionRecuperarPassword;
    }
}