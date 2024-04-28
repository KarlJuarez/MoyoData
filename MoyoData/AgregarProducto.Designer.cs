﻿namespace MoyoData
{
    partial class AgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            this.TbxProductoAgregarProducto = new System.Windows.Forms.TextBox();
            this.LblProducto = new System.Windows.Forms.Label();
            this.NumUDCantidadAgregarProducto = new System.Windows.Forms.NumericUpDown();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.CbxUnidadesMedidasAgregarProducto = new System.Windows.Forms.ComboBox();
            this.LblUnidadesMedida = new System.Windows.Forms.Label();
            this.CbxCategoriasAgregarProducto = new System.Windows.Forms.ComboBox();
            this.LblCategorias = new System.Windows.Forms.Label();
            this.CbxTipoProductoAgregarProducto = new System.Windows.Forms.ComboBox();
            this.LblTipoProducto = new System.Windows.Forms.Label();
            this.NumUDLimiteAgregarProducto = new System.Windows.Forms.NumericUpDown();
            this.LblLimite = new System.Windows.Forms.Label();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.LblAspectos = new System.Windows.Forms.Label();
            this.LblGuionBajoProducto = new System.Windows.Forms.Label();
            this.PbxCerrarForm = new System.Windows.Forms.PictureBox();
            this.PbxNombreEmpresa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDCantidadAgregarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDLimiteAgregarProducto)).BeginInit();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // TbxProductoAgregarProducto
            // 
            this.TbxProductoAgregarProducto.BackColor = System.Drawing.Color.White;
            this.TbxProductoAgregarProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxProductoAgregarProducto.Font = new System.Drawing.Font("Rosario", 10F);
            this.TbxProductoAgregarProducto.ForeColor = System.Drawing.Color.DimGray;
            this.TbxProductoAgregarProducto.Location = new System.Drawing.Point(213, 296);
            this.TbxProductoAgregarProducto.MaxLength = 100;
            this.TbxProductoAgregarProducto.Name = "TbxProductoAgregarProducto";
            this.TbxProductoAgregarProducto.ShortcutsEnabled = false;
            this.TbxProductoAgregarProducto.Size = new System.Drawing.Size(267, 21);
            this.TbxProductoAgregarProducto.TabIndex = 39;
            this.TbxProductoAgregarProducto.Text = "Escribe aquí";
            this.TbxProductoAgregarProducto.Enter += new System.EventHandler(this.TbxProductoAgregarProducto_Enter);
            this.TbxProductoAgregarProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxProductoAgregarProducto_KeyPress);
            this.TbxProductoAgregarProducto.Leave += new System.EventHandler(this.TbxProductoAgregarProducto_Leave);
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(206, 247);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(110, 31);
            this.LblProducto.TabIndex = 35;
            this.LblProducto.Text = "Producto";
            // 
            // NumUDCantidadAgregarProducto
            // 
            this.NumUDCantidadAgregarProducto.BackColor = System.Drawing.Color.White;
            this.NumUDCantidadAgregarProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumUDCantidadAgregarProducto.Font = new System.Drawing.Font("Roboto", 10F);
            this.NumUDCantidadAgregarProducto.Location = new System.Drawing.Point(665, 300);
            this.NumUDCantidadAgregarProducto.Name = "NumUDCantidadAgregarProducto";
            this.NumUDCantidadAgregarProducto.Size = new System.Drawing.Size(309, 28);
            this.NumUDCantidadAgregarProducto.TabIndex = 38;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(659, 247);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(110, 31);
            this.LblCantidad.TabIndex = 37;
            this.LblCantidad.Text = "Cantidad";
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.BtnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarProducto.Font = new System.Drawing.Font("Rosario", 10F, System.Drawing.FontStyle.Bold);
            this.BtnAgregarProducto.Location = new System.Drawing.Point(1004, 706);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(143, 56);
            this.BtnAgregarProducto.TabIndex = 36;
            this.BtnAgregarProducto.Text = "Agregar producto";
            this.BtnAgregarProducto.UseVisualStyleBackColor = false;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // CbxUnidadesMedidasAgregarProducto
            // 
            this.CbxUnidadesMedidasAgregarProducto.BackColor = System.Drawing.Color.White;
            this.CbxUnidadesMedidasAgregarProducto.FormattingEnabled = true;
            this.CbxUnidadesMedidasAgregarProducto.Location = new System.Drawing.Point(665, 404);
            this.CbxUnidadesMedidasAgregarProducto.Name = "CbxUnidadesMedidasAgregarProducto";
            this.CbxUnidadesMedidasAgregarProducto.Size = new System.Drawing.Size(309, 24);
            this.CbxUnidadesMedidasAgregarProducto.TabIndex = 41;
            // 
            // LblUnidadesMedida
            // 
            this.LblUnidadesMedida.AutoSize = true;
            this.LblUnidadesMedida.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUnidadesMedida.Location = new System.Drawing.Point(659, 350);
            this.LblUnidadesMedida.Name = "LblUnidadesMedida";
            this.LblUnidadesMedida.Size = new System.Drawing.Size(232, 31);
            this.LblUnidadesMedida.TabIndex = 40;
            this.LblUnidadesMedida.Text = "Unidades de medida";
            // 
            // CbxCategoriasAgregarProducto
            // 
            this.CbxCategoriasAgregarProducto.BackColor = System.Drawing.Color.White;
            this.CbxCategoriasAgregarProducto.FormattingEnabled = true;
            this.CbxCategoriasAgregarProducto.Location = new System.Drawing.Point(212, 488);
            this.CbxCategoriasAgregarProducto.Name = "CbxCategoriasAgregarProducto";
            this.CbxCategoriasAgregarProducto.Size = new System.Drawing.Size(309, 24);
            this.CbxCategoriasAgregarProducto.TabIndex = 43;
            this.CbxCategoriasAgregarProducto.SelectedIndexChanged += new System.EventHandler(this.CbxCategoriasAgregarProducto_SelectedIndexChanged);
            // 
            // LblCategorias
            // 
            this.LblCategorias.AutoSize = true;
            this.LblCategorias.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategorias.Location = new System.Drawing.Point(206, 443);
            this.LblCategorias.Name = "LblCategorias";
            this.LblCategorias.Size = new System.Drawing.Size(125, 31);
            this.LblCategorias.TabIndex = 42;
            this.LblCategorias.Text = "Categorias";
            // 
            // CbxTipoProductoAgregarProducto
            // 
            this.CbxTipoProductoAgregarProducto.BackColor = System.Drawing.Color.White;
            this.CbxTipoProductoAgregarProducto.FormattingEnabled = true;
            this.CbxTipoProductoAgregarProducto.Location = new System.Drawing.Point(665, 488);
            this.CbxTipoProductoAgregarProducto.Name = "CbxTipoProductoAgregarProducto";
            this.CbxTipoProductoAgregarProducto.Size = new System.Drawing.Size(309, 24);
            this.CbxTipoProductoAgregarProducto.TabIndex = 45;
            // 
            // LblTipoProducto
            // 
            this.LblTipoProducto.AutoSize = true;
            this.LblTipoProducto.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoProducto.Location = new System.Drawing.Point(659, 443);
            this.LblTipoProducto.Name = "LblTipoProducto";
            this.LblTipoProducto.Size = new System.Drawing.Size(195, 31);
            this.LblTipoProducto.TabIndex = 44;
            this.LblTipoProducto.Text = "Tipo de Producto";
            // 
            // NumUDLimiteAgregarProducto
            // 
            this.NumUDLimiteAgregarProducto.BackColor = System.Drawing.Color.White;
            this.NumUDLimiteAgregarProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumUDLimiteAgregarProducto.Font = new System.Drawing.Font("Roboto", 10F);
            this.NumUDLimiteAgregarProducto.Location = new System.Drawing.Point(212, 400);
            this.NumUDLimiteAgregarProducto.Name = "NumUDLimiteAgregarProducto";
            this.NumUDLimiteAgregarProducto.Size = new System.Drawing.Size(309, 28);
            this.NumUDLimiteAgregarProducto.TabIndex = 47;
            // 
            // LblLimite
            // 
            this.LblLimite.AutoSize = true;
            this.LblLimite.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLimite.Location = new System.Drawing.Point(206, 350);
            this.LblLimite.Name = "LblLimite";
            this.LblLimite.Size = new System.Drawing.Size(267, 31);
            this.LblLimite.TabIndex = 46;
            this.LblLimite.Text = "Limite al sacar producto";
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.Maroon;
            this.PnlTitulo.Controls.Add(this.PbxNombreEmpresa);
            this.PnlTitulo.Controls.Add(this.LblAspectos);
            this.PnlTitulo.Controls.Add(this.PbxCerrarForm);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(1186, 73);
            this.PnlTitulo.TabIndex = 49;
            this.PnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitulo_MouseDown);
            // 
            // LblAspectos
            // 
            this.LblAspectos.AutoSize = true;
            this.LblAspectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblAspectos.Font = new System.Drawing.Font("Roboto", 19F, System.Drawing.FontStyle.Bold);
            this.LblAspectos.Location = new System.Drawing.Point(70, 20);
            this.LblAspectos.Name = "LblAspectos";
            this.LblAspectos.Size = new System.Drawing.Size(339, 38);
            this.LblAspectos.TabIndex = 1;
            this.LblAspectos.Text = "AGREGAR PRODUCTO";
            // 
            // LblGuionBajoProducto
            // 
            this.LblGuionBajoProducto.AutoSize = true;
            this.LblGuionBajoProducto.Location = new System.Drawing.Point(207, 305);
            this.LblGuionBajoProducto.Name = "LblGuionBajoProducto";
            this.LblGuionBajoProducto.Size = new System.Drawing.Size(273, 16);
            this.LblGuionBajoProducto.TabIndex = 50;
            this.LblGuionBajoProducto.Text = "______________________________________";
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
            // PbxNombreEmpresa
            // 
            this.PbxNombreEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("PbxNombreEmpresa.Image")));
            this.PbxNombreEmpresa.Location = new System.Drawing.Point(788, 24);
            this.PbxNombreEmpresa.Name = "PbxNombreEmpresa";
            this.PbxNombreEmpresa.Size = new System.Drawing.Size(276, 28);
            this.PbxNombreEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxNombreEmpresa.TabIndex = 12;
            this.PbxNombreEmpresa.TabStop = false;
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1168, 749);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.NumUDLimiteAgregarProducto);
            this.Controls.Add(this.LblLimite);
            this.Controls.Add(this.CbxTipoProductoAgregarProducto);
            this.Controls.Add(this.LblTipoProducto);
            this.Controls.Add(this.CbxCategoriasAgregarProducto);
            this.Controls.Add(this.LblCategorias);
            this.Controls.Add(this.CbxUnidadesMedidasAgregarProducto);
            this.Controls.Add(this.LblUnidadesMedida);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.NumUDCantidadAgregarProducto);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.TbxProductoAgregarProducto);
            this.Controls.Add(this.LblProducto);
            this.Controls.Add(this.LblGuionBajoProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1186, 796);
            this.MinimumSize = new System.Drawing.Size(1186, 796);
            this.Name = "AgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar producto";
            ((System.ComponentModel.ISupportInitialize)(this.NumUDCantidadAgregarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDLimiteAgregarProducto)).EndInit();
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxProductoAgregarProducto;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.NumericUpDown NumUDCantidadAgregarProducto;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.ComboBox CbxUnidadesMedidasAgregarProducto;
        private System.Windows.Forms.Label LblUnidadesMedida;
        private System.Windows.Forms.ComboBox CbxCategoriasAgregarProducto;
        private System.Windows.Forms.Label LblCategorias;
        private System.Windows.Forms.ComboBox CbxTipoProductoAgregarProducto;
        private System.Windows.Forms.Label LblTipoProducto;
        private System.Windows.Forms.NumericUpDown NumUDLimiteAgregarProducto;
        private System.Windows.Forms.Label LblLimite;
        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Label LblAspectos;
        private System.Windows.Forms.Label LblGuionBajoProducto;
        private System.Windows.Forms.PictureBox PbxCerrarForm;
        private System.Windows.Forms.PictureBox PbxNombreEmpresa;
    }
}