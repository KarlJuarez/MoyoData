namespace MoyoData
{
    partial class EditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarUsuario));
            this.TbxEditarPassword = new System.Windows.Forms.TextBox();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.PbxNombreEmpresa = new System.Windows.Forms.PictureBox();
            this.LblEditarUsuario = new System.Windows.Forms.Label();
            this.PbxCerrarForm = new System.Windows.Forms.PictureBox();
            this.BtnRegistrarUsuario = new System.Windows.Forms.Button();
            this.CbxEditarRol = new System.Windows.Forms.ComboBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblRol = new System.Windows.Forms.Label();
            this.LblNombreCompleto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxPasswordNueva = new System.Windows.Forms.TextBox();
            this.LblPasswordNueva = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxRespuestaRecuperarPassword = new System.Windows.Forms.TextBox();
            this.LblRespuestaRecuperarPassword = new System.Windows.Forms.Label();
            this.LblGuionBajoRespuesta = new System.Windows.Forms.Label();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.TbxEditarNombres = new System.Windows.Forms.TextBox();
            this.LblGuionBajo = new System.Windows.Forms.Label();
            this.LblAtencionRecuperarPassword = new System.Windows.Forms.Label();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).BeginInit();
            this.SuspendLayout();
            // 
            // TbxEditarPassword
            // 
            this.TbxEditarPassword.BackColor = System.Drawing.Color.White;
            this.TbxEditarPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxEditarPassword.Font = new System.Drawing.Font("Rosario", 10F);
            this.TbxEditarPassword.ForeColor = System.Drawing.Color.DimGray;
            this.TbxEditarPassword.Location = new System.Drawing.Point(459, 174);
            this.TbxEditarPassword.MaxLength = 25;
            this.TbxEditarPassword.Name = "TbxEditarPassword";
            this.TbxEditarPassword.ShortcutsEnabled = false;
            this.TbxEditarPassword.Size = new System.Drawing.Size(267, 21);
            this.TbxEditarPassword.TabIndex = 50;
            this.TbxEditarPassword.Text = "Escribe aquí";
            this.TbxEditarPassword.Enter += new System.EventHandler(this.TbxEditarPassword_Enter);
            this.TbxEditarPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxEditarPassword_KeyPress);
            this.TbxEditarPassword.Leave += new System.EventHandler(this.TbxEditarPassword_Leave);
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.Maroon;
            this.PnlTitulo.Controls.Add(this.PbxNombreEmpresa);
            this.PnlTitulo.Controls.Add(this.LblEditarUsuario);
            this.PnlTitulo.Controls.Add(this.PbxCerrarForm);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(1168, 73);
            this.PnlTitulo.TabIndex = 47;
            this.PnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitulo_MouseDown);
            // 
            // PbxNombreEmpresa
            // 
            this.PbxNombreEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("PbxNombreEmpresa.Image")));
            this.PbxNombreEmpresa.Location = new System.Drawing.Point(794, 24);
            this.PbxNombreEmpresa.Name = "PbxNombreEmpresa";
            this.PbxNombreEmpresa.Size = new System.Drawing.Size(276, 28);
            this.PbxNombreEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxNombreEmpresa.TabIndex = 13;
            this.PbxNombreEmpresa.TabStop = false;
            // 
            // LblEditarUsuario
            // 
            this.LblEditarUsuario.AutoSize = true;
            this.LblEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblEditarUsuario.Font = new System.Drawing.Font("Roboto", 19F, System.Drawing.FontStyle.Bold);
            this.LblEditarUsuario.ForeColor = System.Drawing.Color.White;
            this.LblEditarUsuario.Location = new System.Drawing.Point(70, 20);
            this.LblEditarUsuario.Name = "LblEditarUsuario";
            this.LblEditarUsuario.Size = new System.Drawing.Size(268, 38);
            this.LblEditarUsuario.TabIndex = 1;
            this.LblEditarUsuario.Text = "EDITAR USUARIO";
            // 
            // PbxCerrarForm
            // 
            this.PbxCerrarForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxCerrarForm.Image = ((System.Drawing.Image)(resources.GetObject("PbxCerrarForm.Image")));
            this.PbxCerrarForm.Location = new System.Drawing.Point(1099, 22);
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
            this.BtnRegistrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnRegistrarUsuario.Location = new System.Drawing.Point(1199, 589);
            this.BtnRegistrarUsuario.Name = "BtnRegistrarUsuario";
            this.BtnRegistrarUsuario.Size = new System.Drawing.Size(143, 56);
            this.BtnRegistrarUsuario.TabIndex = 46;
            this.BtnRegistrarUsuario.Text = "Registrar";
            this.BtnRegistrarUsuario.UseVisualStyleBackColor = false;
            // 
            // CbxEditarRol
            // 
            this.CbxEditarRol.BackColor = System.Drawing.Color.White;
            this.CbxEditarRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxEditarRol.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CbxEditarRol.FormattingEnabled = true;
            this.CbxEditarRol.Location = new System.Drawing.Point(802, 179);
            this.CbxEditarRol.Name = "CbxEditarRol";
            this.CbxEditarRol.Size = new System.Drawing.Size(268, 24);
            this.CbxEditarRol.TabIndex = 45;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold);
            this.LblPassword.Location = new System.Drawing.Point(453, 123);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(135, 31);
            this.LblPassword.TabIndex = 44;
            this.LblPassword.Text = "Contraseña";
            // 
            // LblRol
            // 
            this.LblRol.AutoSize = true;
            this.LblRol.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold);
            this.LblRol.Location = new System.Drawing.Point(796, 123);
            this.LblRol.Name = "LblRol";
            this.LblRol.Size = new System.Drawing.Size(48, 31);
            this.LblRol.TabIndex = 42;
            this.LblRol.Text = "Rol";
            // 
            // LblNombreCompleto
            // 
            this.LblNombreCompleto.AutoSize = true;
            this.LblNombreCompleto.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold);
            this.LblNombreCompleto.Location = new System.Drawing.Point(39, 123);
            this.LblNombreCompleto.Name = "LblNombreCompleto";
            this.LblNombreCompleto.Size = new System.Drawing.Size(211, 31);
            this.LblNombreCompleto.TabIndex = 41;
            this.LblNombreCompleto.Text = "Nombre y Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "______________________________________";
            // 
            // TbxPasswordNueva
            // 
            this.TbxPasswordNueva.BackColor = System.Drawing.Color.White;
            this.TbxPasswordNueva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxPasswordNueva.Font = new System.Drawing.Font("Rosario", 10F);
            this.TbxPasswordNueva.ForeColor = System.Drawing.Color.DimGray;
            this.TbxPasswordNueva.Location = new System.Drawing.Point(221, 386);
            this.TbxPasswordNueva.MaxLength = 25;
            this.TbxPasswordNueva.Name = "TbxPasswordNueva";
            this.TbxPasswordNueva.ShortcutsEnabled = false;
            this.TbxPasswordNueva.Size = new System.Drawing.Size(267, 21);
            this.TbxPasswordNueva.TabIndex = 55;
            this.TbxPasswordNueva.Text = "Escribe aquí";
            this.TbxPasswordNueva.Enter += new System.EventHandler(this.TbxPasswordNueva_Enter);
            this.TbxPasswordNueva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxPasswordNueva_KeyPress);
            this.TbxPasswordNueva.Leave += new System.EventHandler(this.TbxPasswordNueva_Leave);
            // 
            // LblPasswordNueva
            // 
            this.LblPasswordNueva.AutoSize = true;
            this.LblPasswordNueva.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold);
            this.LblPasswordNueva.Location = new System.Drawing.Point(215, 330);
            this.LblPasswordNueva.Name = "LblPasswordNueva";
            this.LblPasswordNueva.Size = new System.Drawing.Size(203, 31);
            this.LblPasswordNueva.TabIndex = 54;
            this.LblPasswordNueva.Text = "Nueva contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "______________________________________";
            // 
            // TbxRespuestaRecuperarPassword
            // 
            this.TbxRespuestaRecuperarPassword.BackColor = System.Drawing.Color.White;
            this.TbxRespuestaRecuperarPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxRespuestaRecuperarPassword.Font = new System.Drawing.Font("Rosario", 10F);
            this.TbxRespuestaRecuperarPassword.ForeColor = System.Drawing.Color.DimGray;
            this.TbxRespuestaRecuperarPassword.Location = new System.Drawing.Point(646, 386);
            this.TbxRespuestaRecuperarPassword.MaxLength = 25;
            this.TbxRespuestaRecuperarPassword.Name = "TbxRespuestaRecuperarPassword";
            this.TbxRespuestaRecuperarPassword.ShortcutsEnabled = false;
            this.TbxRespuestaRecuperarPassword.Size = new System.Drawing.Size(308, 21);
            this.TbxRespuestaRecuperarPassword.TabIndex = 58;
            this.TbxRespuestaRecuperarPassword.Text = "Escribe aquí";
            this.TbxRespuestaRecuperarPassword.Enter += new System.EventHandler(this.TbxRespuestaRecuperarPassword_Enter);
            this.TbxRespuestaRecuperarPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxRespuestaRecuperarPassword_KeyPress);
            this.TbxRespuestaRecuperarPassword.Leave += new System.EventHandler(this.TbxRespuestaRecuperarPassword_Leave);
            // 
            // LblRespuestaRecuperarPassword
            // 
            this.LblRespuestaRecuperarPassword.AutoSize = true;
            this.LblRespuestaRecuperarPassword.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold);
            this.LblRespuestaRecuperarPassword.Location = new System.Drawing.Point(640, 330);
            this.LblRespuestaRecuperarPassword.Name = "LblRespuestaRecuperarPassword";
            this.LblRespuestaRecuperarPassword.Size = new System.Drawing.Size(308, 31);
            this.LblRespuestaRecuperarPassword.TabIndex = 57;
            this.LblRespuestaRecuperarPassword.Text = "¿Cuál es tu comida favorita?";
            // 
            // LblGuionBajoRespuesta
            // 
            this.LblGuionBajoRespuesta.AutoSize = true;
            this.LblGuionBajoRespuesta.Location = new System.Drawing.Point(641, 395);
            this.LblGuionBajoRespuesta.Name = "LblGuionBajoRespuesta";
            this.LblGuionBajoRespuesta.Size = new System.Drawing.Size(273, 16);
            this.LblGuionBajoRespuesta.TabIndex = 59;
            this.LblGuionBajoRespuesta.Text = "______________________________________";
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Rosario", 10F, System.Drawing.FontStyle.Bold);
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(991, 408);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(143, 56);
            this.BtnEditar.TabIndex = 60;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // TbxEditarNombres
            // 
            this.TbxEditarNombres.BackColor = System.Drawing.Color.White;
            this.TbxEditarNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxEditarNombres.Font = new System.Drawing.Font("Rosario", 10F);
            this.TbxEditarNombres.ForeColor = System.Drawing.Color.DimGray;
            this.TbxEditarNombres.Location = new System.Drawing.Point(45, 174);
            this.TbxEditarNombres.MaxLength = 40;
            this.TbxEditarNombres.Name = "TbxEditarNombres";
            this.TbxEditarNombres.ShortcutsEnabled = false;
            this.TbxEditarNombres.Size = new System.Drawing.Size(256, 21);
            this.TbxEditarNombres.TabIndex = 61;
            this.TbxEditarNombres.Text = "Escribe aquí";
            this.TbxEditarNombres.Enter += new System.EventHandler(this.TbxEditarNombres_Enter);
            this.TbxEditarNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxEditarNombres_KeyPress);
            this.TbxEditarNombres.Leave += new System.EventHandler(this.TbxEditarNombres_Leave);
            // 
            // LblGuionBajo
            // 
            this.LblGuionBajo.AutoSize = true;
            this.LblGuionBajo.Location = new System.Drawing.Point(42, 183);
            this.LblGuionBajo.Name = "LblGuionBajo";
            this.LblGuionBajo.Size = new System.Drawing.Size(273, 16);
            this.LblGuionBajo.TabIndex = 62;
            this.LblGuionBajo.Text = "______________________________________";
            // 
            // LblAtencionRecuperarPassword
            // 
            this.LblAtencionRecuperarPassword.AutoSize = true;
            this.LblAtencionRecuperarPassword.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAtencionRecuperarPassword.ForeColor = System.Drawing.Color.Black;
            this.LblAtencionRecuperarPassword.Location = new System.Drawing.Point(653, 300);
            this.LblAtencionRecuperarPassword.Name = "LblAtencionRecuperarPassword";
            this.LblAtencionRecuperarPassword.Size = new System.Drawing.Size(240, 15);
            this.LblAtencionRecuperarPassword.TabIndex = 63;
            this.LblAtencionRecuperarPassword.Text = "Pregunta de recuperación de contraseña";
            // 
            // EditarUsuario
            // 
            this.AcceptButton = this.BtnEditar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1168, 489);
            this.Controls.Add(this.LblAtencionRecuperarPassword);
            this.Controls.Add(this.TbxEditarNombres);
            this.Controls.Add(this.LblGuionBajo);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.TbxRespuestaRecuperarPassword);
            this.Controls.Add(this.LblRespuestaRecuperarPassword);
            this.Controls.Add(this.TbxPasswordNueva);
            this.Controls.Add(this.LblPasswordNueva);
            this.Controls.Add(this.TbxEditarPassword);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.BtnRegistrarUsuario);
            this.Controls.Add(this.CbxEditarRol);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblRol);
            this.Controls.Add(this.LblNombreCompleto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblGuionBajoRespuesta);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar usuario";
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxEditarPassword;
        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Label LblEditarUsuario;
        private System.Windows.Forms.PictureBox PbxCerrarForm;
        private System.Windows.Forms.Button BtnRegistrarUsuario;
        private System.Windows.Forms.ComboBox CbxEditarRol;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblRol;
        private System.Windows.Forms.Label LblNombreCompleto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxPasswordNueva;
        private System.Windows.Forms.Label LblPasswordNueva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbxRespuestaRecuperarPassword;
        private System.Windows.Forms.Label LblRespuestaRecuperarPassword;
        private System.Windows.Forms.Label LblGuionBajoRespuesta;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.TextBox TbxEditarNombres;
        private System.Windows.Forms.Label LblGuionBajo;
        private System.Windows.Forms.Label LblAtencionRecuperarPassword;
        private System.Windows.Forms.PictureBox PbxNombreEmpresa;
    }
}