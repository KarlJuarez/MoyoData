namespace MoyoData
{
    partial class RecuperarPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarPassword));
            this.TbxRecuperarNombres = new System.Windows.Forms.TextBox();
            this.LblNombres = new System.Windows.Forms.Label();
            this.LblGuionBajoUsuario = new System.Windows.Forms.Label();
            this.TbxRespuestaRecuperarPassword = new System.Windows.Forms.TextBox();
            this.LblRespuestaRecuperarPassword = new System.Windows.Forms.Label();
            this.LblGuionBajoRespuesta = new System.Windows.Forms.Label();
            this.BtnRecuperarPassword = new System.Windows.Forms.Button();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.PbxNombreEmpresa = new System.Windows.Forms.PictureBox();
            this.LblRecuperarPassword = new System.Windows.Forms.Label();
            this.PbxCerrarForm = new System.Windows.Forms.PictureBox();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).BeginInit();
            this.SuspendLayout();
            // 
            // TbxRecuperarNombres
            // 
            this.TbxRecuperarNombres.BackColor = System.Drawing.Color.White;
            this.TbxRecuperarNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxRecuperarNombres.Font = new System.Drawing.Font("Rosario", 10F);
            this.TbxRecuperarNombres.ForeColor = System.Drawing.Color.DimGray;
            this.TbxRecuperarNombres.Location = new System.Drawing.Point(96, 246);
            this.TbxRecuperarNombres.MaxLength = 40;
            this.TbxRecuperarNombres.Name = "TbxRecuperarNombres";
            this.TbxRecuperarNombres.Size = new System.Drawing.Size(253, 21);
            this.TbxRecuperarNombres.TabIndex = 63;
            this.TbxRecuperarNombres.Text = "Escribe aquí";
            this.TbxRecuperarNombres.Enter += new System.EventHandler(this.TbxRecuperarNombres_Enter);
            this.TbxRecuperarNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxRecuperarNombres_KeyPress);
            this.TbxRecuperarNombres.Leave += new System.EventHandler(this.TbxRecuperarNombres_Leave);
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold);
            this.LblNombres.Location = new System.Drawing.Point(90, 193);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(266, 36);
            this.LblNombres.TabIndex = 52;
            this.LblNombres.Text = "Nombre(s) y Apellido(s)";
            // 
            // LblGuionBajoUsuario
            // 
            this.LblGuionBajoUsuario.AutoSize = true;
            this.LblGuionBajoUsuario.Location = new System.Drawing.Point(91, 256);
            this.LblGuionBajoUsuario.Name = "LblGuionBajoUsuario";
            this.LblGuionBajoUsuario.Size = new System.Drawing.Size(273, 16);
            this.LblGuionBajoUsuario.TabIndex = 54;
            this.LblGuionBajoUsuario.Text = "______________________________________";
            // 
            // TbxRespuestaRecuperarPassword
            // 
            this.TbxRespuestaRecuperarPassword.BackColor = System.Drawing.Color.White;
            this.TbxRespuestaRecuperarPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxRespuestaRecuperarPassword.Font = new System.Drawing.Font("Rosario", 10F);
            this.TbxRespuestaRecuperarPassword.ForeColor = System.Drawing.Color.DimGray;
            this.TbxRespuestaRecuperarPassword.Location = new System.Drawing.Point(443, 246);
            this.TbxRespuestaRecuperarPassword.MaxLength = 25;
            this.TbxRespuestaRecuperarPassword.Name = "TbxRespuestaRecuperarPassword";
            this.TbxRespuestaRecuperarPassword.ShortcutsEnabled = false;
            this.TbxRespuestaRecuperarPassword.Size = new System.Drawing.Size(258, 21);
            this.TbxRespuestaRecuperarPassword.TabIndex = 61;
            this.TbxRespuestaRecuperarPassword.Text = "Escribe aquí";
            this.TbxRespuestaRecuperarPassword.Enter += new System.EventHandler(this.TbxRespuestaRecuperarPassword_Enter);
            this.TbxRespuestaRecuperarPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxRespuestaRecuperarPassword_KeyPress);
            this.TbxRespuestaRecuperarPassword.Leave += new System.EventHandler(this.TbxRespuestaRecuperarPassword_Leave);
            // 
            // LblRespuestaRecuperarPassword
            // 
            this.LblRespuestaRecuperarPassword.AutoSize = true;
            this.LblRespuestaRecuperarPassword.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold);
            this.LblRespuestaRecuperarPassword.Location = new System.Drawing.Point(437, 193);
            this.LblRespuestaRecuperarPassword.Name = "LblRespuestaRecuperarPassword";
            this.LblRespuestaRecuperarPassword.Size = new System.Drawing.Size(309, 36);
            this.LblRespuestaRecuperarPassword.TabIndex = 60;
            this.LblRespuestaRecuperarPassword.Text = "¿Cuál es tu comida favorita?";
            // 
            // LblGuionBajoRespuesta
            // 
            this.LblGuionBajoRespuesta.AutoSize = true;
            this.LblGuionBajoRespuesta.Location = new System.Drawing.Point(439, 254);
            this.LblGuionBajoRespuesta.Name = "LblGuionBajoRespuesta";
            this.LblGuionBajoRespuesta.Size = new System.Drawing.Size(273, 16);
            this.LblGuionBajoRespuesta.TabIndex = 62;
            this.LblGuionBajoRespuesta.Text = "______________________________________";
            // 
            // BtnRecuperarPassword
            // 
            this.BtnRecuperarPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRecuperarPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.BtnRecuperarPassword.FlatAppearance.BorderSize = 0;
            this.BtnRecuperarPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecuperarPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnRecuperarPassword.ForeColor = System.Drawing.Color.White;
            this.BtnRecuperarPassword.Location = new System.Drawing.Point(334, 330);
            this.BtnRecuperarPassword.Name = "BtnRecuperarPassword";
            this.BtnRecuperarPassword.Size = new System.Drawing.Size(143, 56);
            this.BtnRecuperarPassword.TabIndex = 53;
            this.BtnRecuperarPassword.Text = "Aceptar";
            this.BtnRecuperarPassword.UseVisualStyleBackColor = false;
            this.BtnRecuperarPassword.Click += new System.EventHandler(this.BtnRecuperarPassword_Click);
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.Maroon;
            this.PnlTitulo.Controls.Add(this.PbxNombreEmpresa);
            this.PnlTitulo.Controls.Add(this.LblRecuperarPassword);
            this.PnlTitulo.Controls.Add(this.PbxCerrarForm);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(800, 73);
            this.PnlTitulo.TabIndex = 64;
            this.PnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitulo_MouseDown);
            // 
            // PbxNombreEmpresa
            // 
            this.PbxNombreEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("PbxNombreEmpresa.Image")));
            this.PbxNombreEmpresa.Location = new System.Drawing.Point(425, 23);
            this.PbxNombreEmpresa.Name = "PbxNombreEmpresa";
            this.PbxNombreEmpresa.Size = new System.Drawing.Size(276, 28);
            this.PbxNombreEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxNombreEmpresa.TabIndex = 12;
            this.PbxNombreEmpresa.TabStop = false;
            // 
            // LblRecuperarPassword
            // 
            this.LblRecuperarPassword.AutoSize = true;
            this.LblRecuperarPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblRecuperarPassword.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecuperarPassword.ForeColor = System.Drawing.Color.White;
            this.LblRecuperarPassword.Location = new System.Drawing.Point(20, 23);
            this.LblRecuperarPassword.Name = "LblRecuperarPassword";
            this.LblRecuperarPassword.Size = new System.Drawing.Size(364, 34);
            this.LblRecuperarPassword.TabIndex = 1;
            this.LblRecuperarPassword.Text = "RECUPERAR CONTRASEÑA";
            // 
            // PbxCerrarForm
            // 
            this.PbxCerrarForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxCerrarForm.Image = ((System.Drawing.Image)(resources.GetObject("PbxCerrarForm.Image")));
            this.PbxCerrarForm.Location = new System.Drawing.Point(731, 22);
            this.PbxCerrarForm.Name = "PbxCerrarForm";
            this.PbxCerrarForm.Size = new System.Drawing.Size(35, 29);
            this.PbxCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxCerrarForm.TabIndex = 11;
            this.PbxCerrarForm.TabStop = false;
            this.PbxCerrarForm.Click += new System.EventHandler(this.PbxCerrarForm_Click);
            // 
            // RecuperarPassword
            // 
            this.AcceptButton = this.BtnRecuperarPassword;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.BtnRecuperarPassword);
            this.Controls.Add(this.TbxRespuestaRecuperarPassword);
            this.Controls.Add(this.LblRespuestaRecuperarPassword);
            this.Controls.Add(this.LblGuionBajoRespuesta);
            this.Controls.Add(this.TbxRecuperarNombres);
            this.Controls.Add(this.LblNombres);
            this.Controls.Add(this.LblGuionBajoUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecuperarPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperación de contraseña";
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxRecuperarNombres;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Label LblGuionBajoUsuario;
        private System.Windows.Forms.TextBox TbxRespuestaRecuperarPassword;
        private System.Windows.Forms.Label LblRespuestaRecuperarPassword;
        private System.Windows.Forms.Label LblGuionBajoRespuesta;
        private System.Windows.Forms.Button BtnRecuperarPassword;
        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.PictureBox PbxNombreEmpresa;
        private System.Windows.Forms.Label LblRecuperarPassword;
        private System.Windows.Forms.PictureBox PbxCerrarForm;
    }
}