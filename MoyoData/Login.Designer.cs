namespace MoyoData
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.PnlIzquierdo = new System.Windows.Forms.Panel();
            this.LinkLblRecuperarPassword = new System.Windows.Forms.LinkLabel();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.TbxUsuario = new System.Windows.Forms.TextBox();
            this.PbxNombreEmpresa = new System.Windows.Forms.PictureBox();
            this.LblGuionBajoUsuario = new System.Windows.Forms.Label();
            this.LblGuionBajoPassword = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.PbxHormiga = new System.Windows.Forms.PictureBox();
            this.PnlIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxHormiga)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlIzquierdo
            // 
            this.PnlIzquierdo.BackColor = System.Drawing.Color.White;
            this.PnlIzquierdo.Controls.Add(this.LinkLblRecuperarPassword);
            this.PnlIzquierdo.Controls.Add(this.BtnIniciarSesion);
            this.PnlIzquierdo.Controls.Add(this.TbxPassword);
            this.PnlIzquierdo.Controls.Add(this.TbxUsuario);
            this.PnlIzquierdo.Controls.Add(this.PbxNombreEmpresa);
            this.PnlIzquierdo.Controls.Add(this.LblGuionBajoUsuario);
            this.PnlIzquierdo.Controls.Add(this.LblGuionBajoPassword);
            this.PnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.PnlIzquierdo.Name = "PnlIzquierdo";
            this.PnlIzquierdo.Size = new System.Drawing.Size(395, 330);
            this.PnlIzquierdo.TabIndex = 1;
            this.PnlIzquierdo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelIzquierdo_MouseDown);
            // 
            // LinkLblRecuperarPassword
            // 
            this.LinkLblRecuperarPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LinkLblRecuperarPassword.AutoSize = true;
            this.LinkLblRecuperarPassword.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLblRecuperarPassword.LinkColor = System.Drawing.Color.DimGray;
            this.LinkLblRecuperarPassword.Location = new System.Drawing.Point(92, 306);
            this.LinkLblRecuperarPassword.Name = "LinkLblRecuperarPassword";
            this.LinkLblRecuperarPassword.Size = new System.Drawing.Size(182, 15);
            this.LinkLblRecuperarPassword.TabIndex = 0;
            this.LinkLblRecuperarPassword.TabStop = true;
            this.LinkLblRecuperarPassword.Text = "¿Olvidaste tu contraseña?";
            this.LinkLblRecuperarPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblRecuperarPassword_LinkClicked);
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.BtnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.BtnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.BtnIniciarSesion.Location = new System.Drawing.Point(85, 242);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(223, 40);
            this.BtnIniciarSesion.TabIndex = 3;
            this.BtnIniciarSesion.Text = "Iniciar sesión";
            this.BtnIniciarSesion.UseVisualStyleBackColor = false;
            this.BtnIniciarSesion.Click += new System.EventHandler(this.BtnIniciarSesion_Click);
            // 
            // TbxPassword
            // 
            this.TbxPassword.BackColor = System.Drawing.Color.White;
            this.TbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.TbxPassword.Location = new System.Drawing.Point(54, 161);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(289, 19);
            this.TbxPassword.TabIndex = 2;
            this.TbxPassword.Text = "Contraseña";
            this.TbxPassword.Enter += new System.EventHandler(this.TbxPassword_Enter);
            this.TbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxPassword_KeyPress);
            this.TbxPassword.Leave += new System.EventHandler(this.TbxPassword_Leave);
            // 
            // TbxUsuario
            // 
            this.TbxUsuario.BackColor = System.Drawing.Color.White;
            this.TbxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TbxUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.TbxUsuario.Location = new System.Drawing.Point(54, 104);
            this.TbxUsuario.Name = "TbxUsuario";
            this.TbxUsuario.ShortcutsEnabled = false;
            this.TbxUsuario.Size = new System.Drawing.Size(289, 19);
            this.TbxUsuario.TabIndex = 1;
            this.TbxUsuario.Text = "Usuario";
            this.TbxUsuario.Enter += new System.EventHandler(this.TbxUsuario_Enter);
            this.TbxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxUsuario_KeyPress);
            this.TbxUsuario.Leave += new System.EventHandler(this.TbxUsuario_Leave);
            // 
            // PbxNombreEmpresa
            // 
            this.PbxNombreEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("PbxNombreEmpresa.Image")));
            this.PbxNombreEmpresa.Location = new System.Drawing.Point(54, 39);
            this.PbxNombreEmpresa.Name = "PbxNombreEmpresa";
            this.PbxNombreEmpresa.Size = new System.Drawing.Size(276, 28);
            this.PbxNombreEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxNombreEmpresa.TabIndex = 0;
            this.PbxNombreEmpresa.TabStop = false;
            // 
            // LblGuionBajoUsuario
            // 
            this.LblGuionBajoUsuario.AutoSize = true;
            this.LblGuionBajoUsuario.Location = new System.Drawing.Point(51, 116);
            this.LblGuionBajoUsuario.Name = "LblGuionBajoUsuario";
            this.LblGuionBajoUsuario.Size = new System.Drawing.Size(287, 16);
            this.LblGuionBajoUsuario.TabIndex = 5;
            this.LblGuionBajoUsuario.Text = "________________________________________";
            // 
            // LblGuionBajoPassword
            // 
            this.LblGuionBajoPassword.AutoSize = true;
            this.LblGuionBajoPassword.Location = new System.Drawing.Point(51, 172);
            this.LblGuionBajoPassword.Name = "LblGuionBajoPassword";
            this.LblGuionBajoPassword.Size = new System.Drawing.Size(287, 16);
            this.LblGuionBajoPassword.TabIndex = 6;
            this.LblGuionBajoPassword.Text = "________________________________________";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(748, 12);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(20, 20);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(712, 12);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 3;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // PbxHormiga
            // 
            this.PbxHormiga.Image = ((System.Drawing.Image)(resources.GetObject("PbxHormiga.Image")));
            this.PbxHormiga.Location = new System.Drawing.Point(488, 73);
            this.PbxHormiga.Name = "PbxHormiga";
            this.PbxHormiga.Size = new System.Drawing.Size(217, 181);
            this.PbxHormiga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxHormiga.TabIndex = 4;
            this.PbxHormiga.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.BtnIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.PbxHormiga);
            this.Controls.Add(this.BtnMinimizar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.PnlIzquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.PnlIzquierdo.ResumeLayout(false);
            this.PnlIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxHormiga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlIzquierdo;
        private System.Windows.Forms.PictureBox PbxNombreEmpresa;
        private System.Windows.Forms.TextBox TbxUsuario;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.Label LblGuionBajoPassword;
        private System.Windows.Forms.Label LblGuionBajoUsuario;
        private System.Windows.Forms.PictureBox PbxHormiga;
        private System.Windows.Forms.LinkLabel LinkLblRecuperarPassword;
    }
}