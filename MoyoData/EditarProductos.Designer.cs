namespace MoyoData
{
    partial class EditarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProductos));
            this.NumUDLimiteEditarProducto = new System.Windows.Forms.NumericUpDown();
            this.LblLimite = new System.Windows.Forms.Label();
            this.CbxTipoProductoEditarProducto = new System.Windows.Forms.ComboBox();
            this.LblTipoProducto = new System.Windows.Forms.Label();
            this.CbxCategoriasEditarProducto = new System.Windows.Forms.ComboBox();
            this.LblCategorias = new System.Windows.Forms.Label();
            this.CbxUnidadesMedidasEditarProducto = new System.Windows.Forms.ComboBox();
            this.LblUnidadesMedida = new System.Windows.Forms.Label();
            this.BtnEditarProducto = new System.Windows.Forms.Button();
            this.NumUDCantidadEditarProducto = new System.Windows.Forms.NumericUpDown();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TbxProductoEditarProducto = new System.Windows.Forms.TextBox();
            this.LblProducto = new System.Windows.Forms.Label();
            this.NumUDStockEditarProducto = new System.Windows.Forms.NumericUpDown();
            this.LblStock = new System.Windows.Forms.Label();
            this.LblGuionBajoUsuario = new System.Windows.Forms.Label();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.LblEditarProducto = new System.Windows.Forms.Label();
            this.PbxCerrarForm = new System.Windows.Forms.PictureBox();
            this.PbxNombreEmpresa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDLimiteEditarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDCantidadEditarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDStockEditarProducto)).BeginInit();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // NumUDLimiteEditarProducto
            // 
            this.NumUDLimiteEditarProducto.BackColor = System.Drawing.Color.White;
            this.NumUDLimiteEditarProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumUDLimiteEditarProducto.Font = new System.Drawing.Font("Roboto", 10F);
            this.NumUDLimiteEditarProducto.Location = new System.Drawing.Point(245, 486);
            this.NumUDLimiteEditarProducto.Name = "NumUDLimiteEditarProducto";
            this.NumUDLimiteEditarProducto.Size = new System.Drawing.Size(270, 28);
            this.NumUDLimiteEditarProducto.TabIndex = 60;
            // 
            // LblLimite
            // 
            this.LblLimite.AutoSize = true;
            this.LblLimite.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLimite.Location = new System.Drawing.Point(236, 434);
            this.LblLimite.Name = "LblLimite";
            this.LblLimite.Size = new System.Drawing.Size(267, 31);
            this.LblLimite.TabIndex = 59;
            this.LblLimite.Text = "Limite al sacar producto";
            // 
            // CbxTipoProductoEditarProducto
            // 
            this.CbxTipoProductoEditarProducto.BackColor = System.Drawing.Color.White;
            this.CbxTipoProductoEditarProducto.FormattingEnabled = true;
            this.CbxTipoProductoEditarProducto.Location = new System.Drawing.Point(699, 485);
            this.CbxTipoProductoEditarProducto.Name = "CbxTipoProductoEditarProducto";
            this.CbxTipoProductoEditarProducto.Size = new System.Drawing.Size(270, 24);
            this.CbxTipoProductoEditarProducto.TabIndex = 58;
            // 
            // LblTipoProducto
            // 
            this.LblTipoProducto.AutoSize = true;
            this.LblTipoProducto.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoProducto.Location = new System.Drawing.Point(690, 431);
            this.LblTipoProducto.Name = "LblTipoProducto";
            this.LblTipoProducto.Size = new System.Drawing.Size(195, 31);
            this.LblTipoProducto.TabIndex = 57;
            this.LblTipoProducto.Text = "Tipo de Producto";
            // 
            // CbxCategoriasEditarProducto
            // 
            this.CbxCategoriasEditarProducto.BackColor = System.Drawing.Color.White;
            this.CbxCategoriasEditarProducto.FormattingEnabled = true;
            this.CbxCategoriasEditarProducto.Location = new System.Drawing.Point(245, 577);
            this.CbxCategoriasEditarProducto.Name = "CbxCategoriasEditarProducto";
            this.CbxCategoriasEditarProducto.Size = new System.Drawing.Size(270, 24);
            this.CbxCategoriasEditarProducto.TabIndex = 56;
            this.CbxCategoriasEditarProducto.SelectedIndexChanged += new System.EventHandler(this.CbxCategoriasEditarProducto_SelectedIndexChanged);
            // 
            // LblCategorias
            // 
            this.LblCategorias.AutoSize = true;
            this.LblCategorias.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategorias.Location = new System.Drawing.Point(238, 523);
            this.LblCategorias.Name = "LblCategorias";
            this.LblCategorias.Size = new System.Drawing.Size(125, 31);
            this.LblCategorias.TabIndex = 55;
            this.LblCategorias.Text = "Categorias";
            // 
            // CbxUnidadesMedidasEditarProducto
            // 
            this.CbxUnidadesMedidasEditarProducto.BackColor = System.Drawing.Color.White;
            this.CbxUnidadesMedidasEditarProducto.FormattingEnabled = true;
            this.CbxUnidadesMedidasEditarProducto.Location = new System.Drawing.Point(699, 392);
            this.CbxUnidadesMedidasEditarProducto.Name = "CbxUnidadesMedidasEditarProducto";
            this.CbxUnidadesMedidasEditarProducto.Size = new System.Drawing.Size(270, 24);
            this.CbxUnidadesMedidasEditarProducto.TabIndex = 54;
            // 
            // LblUnidadesMedida
            // 
            this.LblUnidadesMedida.AutoSize = true;
            this.LblUnidadesMedida.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUnidadesMedida.Location = new System.Drawing.Point(692, 338);
            this.LblUnidadesMedida.Name = "LblUnidadesMedida";
            this.LblUnidadesMedida.Size = new System.Drawing.Size(232, 31);
            this.LblUnidadesMedida.TabIndex = 53;
            this.LblUnidadesMedida.Text = "Unidades de medida";
            // 
            // BtnEditarProducto
            // 
            this.BtnEditarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.BtnEditarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarProducto.Font = new System.Drawing.Font("Rosario", 10F, System.Drawing.FontStyle.Bold);
            this.BtnEditarProducto.Location = new System.Drawing.Point(980, 706);
            this.BtnEditarProducto.Name = "BtnEditarProducto";
            this.BtnEditarProducto.Size = new System.Drawing.Size(167, 56);
            this.BtnEditarProducto.TabIndex = 52;
            this.BtnEditarProducto.Text = "Agregar producto";
            this.BtnEditarProducto.UseVisualStyleBackColor = false;
            this.BtnEditarProducto.Click += new System.EventHandler(this.BtnEditarProducto_Click);
            // 
            // NumUDCantidadEditarProducto
            // 
            this.NumUDCantidadEditarProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumUDCantidadEditarProducto.Font = new System.Drawing.Font("Roboto", 10F);
            this.NumUDCantidadEditarProducto.Location = new System.Drawing.Point(699, 287);
            this.NumUDCantidadEditarProducto.Name = "NumUDCantidadEditarProducto";
            this.NumUDCantidadEditarProducto.Size = new System.Drawing.Size(270, 28);
            this.NumUDCantidadEditarProducto.TabIndex = 51;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(690, 235);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(110, 31);
            this.LblCantidad.TabIndex = 50;
            this.LblCantidad.Text = "Cantidad";
            // 
            // TbxProductoEditarProducto
            // 
            this.TbxProductoEditarProducto.BackColor = System.Drawing.Color.White;
            this.TbxProductoEditarProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxProductoEditarProducto.Font = new System.Drawing.Font("Rosario", 10F);
            this.TbxProductoEditarProducto.ForeColor = System.Drawing.Color.DimGray;
            this.TbxProductoEditarProducto.Location = new System.Drawing.Point(243, 287);
            this.TbxProductoEditarProducto.MaxLength = 100;
            this.TbxProductoEditarProducto.Name = "TbxProductoEditarProducto";
            this.TbxProductoEditarProducto.ShortcutsEnabled = false;
            this.TbxProductoEditarProducto.Size = new System.Drawing.Size(267, 21);
            this.TbxProductoEditarProducto.TabIndex = 49;
            this.TbxProductoEditarProducto.Text = "Escribe aquí";
            this.TbxProductoEditarProducto.Enter += new System.EventHandler(this.TbxProductoEditarProducto_Enter);
            this.TbxProductoEditarProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxProductoEditarProducto_KeyPress);
            this.TbxProductoEditarProducto.Leave += new System.EventHandler(this.TbxProductoEditarProducto_Leave);
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProducto.Location = new System.Drawing.Point(237, 235);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(110, 31);
            this.LblProducto.TabIndex = 48;
            this.LblProducto.Text = "Producto";
            // 
            // NumUDStockEditarProducto
            // 
            this.NumUDStockEditarProducto.BackColor = System.Drawing.Color.White;
            this.NumUDStockEditarProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumUDStockEditarProducto.Font = new System.Drawing.Font("Roboto", 10F);
            this.NumUDStockEditarProducto.Location = new System.Drawing.Point(247, 383);
            this.NumUDStockEditarProducto.Name = "NumUDStockEditarProducto";
            this.NumUDStockEditarProducto.Size = new System.Drawing.Size(270, 28);
            this.NumUDStockEditarProducto.TabIndex = 62;
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStock.Location = new System.Drawing.Point(239, 342);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(71, 31);
            this.LblStock.TabIndex = 61;
            this.LblStock.Text = "Stock";
            // 
            // LblGuionBajoUsuario
            // 
            this.LblGuionBajoUsuario.AutoSize = true;
            this.LblGuionBajoUsuario.Location = new System.Drawing.Point(239, 296);
            this.LblGuionBajoUsuario.Name = "LblGuionBajoUsuario";
            this.LblGuionBajoUsuario.Size = new System.Drawing.Size(273, 16);
            this.LblGuionBajoUsuario.TabIndex = 63;
            this.LblGuionBajoUsuario.Text = "______________________________________";
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.Maroon;
            this.PnlTitulo.Controls.Add(this.LblEditarProducto);
            this.PnlTitulo.Controls.Add(this.PbxCerrarForm);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(1186, 73);
            this.PnlTitulo.TabIndex = 65;
            this.PnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitulo_MouseDown);
            // 
            // LblEditarProducto
            // 
            this.LblEditarProducto.AutoSize = true;
            this.LblEditarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblEditarProducto.Font = new System.Drawing.Font("Roboto", 19F, System.Drawing.FontStyle.Bold);
            this.LblEditarProducto.Location = new System.Drawing.Point(70, 20);
            this.LblEditarProducto.Name = "LblEditarProducto";
            this.LblEditarProducto.Size = new System.Drawing.Size(321, 38);
            this.LblEditarProducto.TabIndex = 1;
            this.LblEditarProducto.Text = "EDITAR PRODUCTOS";
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
            this.PbxNombreEmpresa.BackColor = System.Drawing.Color.Maroon;
            this.PbxNombreEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("PbxNombreEmpresa.Image")));
            this.PbxNombreEmpresa.Location = new System.Drawing.Point(788, 24);
            this.PbxNombreEmpresa.Name = "PbxNombreEmpresa";
            this.PbxNombreEmpresa.Size = new System.Drawing.Size(276, 28);
            this.PbxNombreEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxNombreEmpresa.TabIndex = 66;
            this.PbxNombreEmpresa.TabStop = false;
            // 
            // EditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 796);
            this.Controls.Add(this.PbxNombreEmpresa);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.NumUDStockEditarProducto);
            this.Controls.Add(this.LblStock);
            this.Controls.Add(this.NumUDLimiteEditarProducto);
            this.Controls.Add(this.LblLimite);
            this.Controls.Add(this.CbxTipoProductoEditarProducto);
            this.Controls.Add(this.LblTipoProducto);
            this.Controls.Add(this.CbxCategoriasEditarProducto);
            this.Controls.Add(this.LblCategorias);
            this.Controls.Add(this.CbxUnidadesMedidasEditarProducto);
            this.Controls.Add(this.LblUnidadesMedida);
            this.Controls.Add(this.BtnEditarProducto);
            this.Controls.Add(this.NumUDCantidadEditarProducto);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.TbxProductoEditarProducto);
            this.Controls.Add(this.LblProducto);
            this.Controls.Add(this.LblGuionBajoUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarProductos";
            ((System.ComponentModel.ISupportInitialize)(this.NumUDLimiteEditarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDCantidadEditarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDStockEditarProducto)).EndInit();
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumUDLimiteEditarProducto;
        private System.Windows.Forms.Label LblLimite;
        private System.Windows.Forms.ComboBox CbxTipoProductoEditarProducto;
        private System.Windows.Forms.Label LblTipoProducto;
        private System.Windows.Forms.ComboBox CbxCategoriasEditarProducto;
        private System.Windows.Forms.Label LblCategorias;
        private System.Windows.Forms.ComboBox CbxUnidadesMedidasEditarProducto;
        private System.Windows.Forms.Label LblUnidadesMedida;
        private System.Windows.Forms.Button BtnEditarProducto;
        private System.Windows.Forms.NumericUpDown NumUDCantidadEditarProducto;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TbxProductoEditarProducto;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.NumericUpDown NumUDStockEditarProducto;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.Label LblGuionBajoUsuario;
        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Label LblEditarProducto;
        private System.Windows.Forms.PictureBox PbxCerrarForm;
        private System.Windows.Forms.PictureBox PbxNombreEmpresa;
    }
}