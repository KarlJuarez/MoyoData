﻿namespace MoyoData
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
            this.LblGuionBajoUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.LblRegistrar.Font = new System.Drawing.Font("Roboto", 19F, System.Drawing.FontStyle.Bold);
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
            this.BtnRegistrarUsuario.Location = new System.Drawing.Point(1004, 706);
            this.BtnRegistrarUsuario.Name = "BtnRegistrarUsuario";
            this.BtnRegistrarUsuario.Size = new System.Drawing.Size(143, 56);
            this.BtnRegistrarUsuario.TabIndex = 20;
            this.BtnRegistrarUsuario.Text = "Registrar";
            this.BtnRegistrarUsuario.UseVisualStyleBackColor = false;
            this.BtnRegistrarUsuario.Click += new System.EventHandler(this.BtnRegistrarUsuario_Click);
            // 
            // CbxRegistrarRol
            // 
            this.CbxRegistrarRol.BackColor = System.Drawing.Color.White;
            this.CbxRegistrarRol.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CbxRegistrarRol.FormattingEnabled = true;
            this.CbxRegistrarRol.Location = new System.Drawing.Point(225, 527);
            this.CbxRegistrarRol.Name = "CbxRegistrarRol";
            this.CbxRegistrarRol.Size = new System.Drawing.Size(309, 29);
            this.CbxRegistrarRol.TabIndex = 19;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(660, 473);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(135, 31);
            this.LblPassword.TabIndex = 17;
            this.LblPassword.Text = "Contraseña";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidos.Location = new System.Drawing.Point(660, 294);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(128, 31);
            this.LblApellidos.TabIndex = 16;
            this.LblApellidos.Text = "Apellido(s)";
            // 
            // LblRol
            // 
            this.LblRol.AutoSize = true;
            this.LblRol.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRol.Location = new System.Drawing.Point(219, 473);
            this.LblRol.Name = "LblRol";
            this.LblRol.Size = new System.Drawing.Size(48, 31);
            this.LblRol.TabIndex = 15;
            this.LblRol.Text = "Rol";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombres.Location = new System.Drawing.Point(219, 294);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(128, 31);
            this.LblNombres.TabIndex = 14;
            this.LblNombres.Text = "Nombre(s)";
            // 
            // PnlLogo
            // 
            this.PnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
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
            this.TbxRegistrarNombres.BackColor = System.Drawing.Color.White;
            this.TbxRegistrarNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxRegistrarNombres.Font = new System.Drawing.Font("Rosario", 10F);
            this.TbxRegistrarNombres.ForeColor = System.Drawing.Color.DimGray;
            this.TbxRegistrarNombres.Location = new System.Drawing.Point(226, 359);
            this.TbxRegistrarNombres.Name = "TbxRegistrarNombres";
            this.TbxRegistrarNombres.Size = new System.Drawing.Size(267, 21);
            this.TbxRegistrarNombres.TabIndex = 24;
            this.TbxRegistrarNombres.Text = "Escribe aquí";
            // 
            // TbxRegistrarApellidos
            // 
            this.TbxRegistrarApellidos.BackColor = System.Drawing.Color.White;
            this.TbxRegistrarApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxRegistrarApellidos.Font = new System.Drawing.Font("Rosario", 10F);
            this.TbxRegistrarApellidos.ForeColor = System.Drawing.Color.DimGray;
            this.TbxRegistrarApellidos.Location = new System.Drawing.Point(667, 359);
            this.TbxRegistrarApellidos.Name = "TbxRegistrarApellidos";
            this.TbxRegistrarApellidos.Size = new System.Drawing.Size(267, 21);
            this.TbxRegistrarApellidos.TabIndex = 25;
            this.TbxRegistrarApellidos.Text = "Escribe aquí";
            // 
            // TbxRegistrarPassword
            // 
            this.TbxRegistrarPassword.BackColor = System.Drawing.Color.White;
            this.TbxRegistrarPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxRegistrarPassword.Font = new System.Drawing.Font("Rosario", 10F);
            this.TbxRegistrarPassword.ForeColor = System.Drawing.Color.DimGray;
            this.TbxRegistrarPassword.Location = new System.Drawing.Point(667, 529);
            this.TbxRegistrarPassword.Name = "TbxRegistrarPassword";
            this.TbxRegistrarPassword.Size = new System.Drawing.Size(267, 21);
            this.TbxRegistrarPassword.TabIndex = 26;
            this.TbxRegistrarPassword.Text = "Escribe aquí";
            // 
            // LblGuionBajoUsuario
            // 
            this.LblGuionBajoUsuario.AutoSize = true;
            this.LblGuionBajoUsuario.Location = new System.Drawing.Point(221, 364);
            this.LblGuionBajoUsuario.Name = "LblGuionBajoUsuario";
            this.LblGuionBajoUsuario.Size = new System.Drawing.Size(314, 21);
            this.LblGuionBajoUsuario.TabIndex = 37;
            this.LblGuionBajoUsuario.Text = "______________________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "______________________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "______________________________________";
            // 
            // Registrar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
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
            this.Controls.Add(this.LblGuionBajoUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rosario", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registrar";
            this.Text = "Escribe aquí";
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
        private System.Windows.Forms.Label LblGuionBajoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}