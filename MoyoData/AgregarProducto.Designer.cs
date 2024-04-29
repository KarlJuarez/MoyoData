namespace MoyoData
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
            this.LblCategoria = new System.Windows.Forms.Label();
            this.CbxTipoProductoAgregarProducto = new System.Windows.Forms.ComboBox();
            this.LblTipoProducto = new System.Windows.Forms.Label();
            this.NumUDLimiteAgregarProducto = new System.Windows.Forms.NumericUpDown();
            this.LblLimite = new System.Windows.Forms.Label();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.PbxNombreEmpresa = new System.Windows.Forms.PictureBox();
            this.LblAgregarProducto = new System.Windows.Forms.Label();
            this.PbxCerrarForm = new System.Windows.Forms.PictureBox();
            this.LblGuionBajo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDCantidadAgregarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDLimiteAgregarProducto)).BeginInit();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).BeginInit();
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
            this.TbxProductoAgregarProducto.Size = new System.Drawing.Size(260, 21);
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
            this.NumUDCantidadAgregarProducto.ThousandsSeparator = true;
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
            this.BtnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.BtnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarProducto.Font = new System.Drawing.Font("Rosario", 10F, System.Drawing.FontStyle.Bold);
            this.BtnAgregarProducto.Location = new System.Drawing.Point(1004, 706);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(143, 56);
            this.BtnAgregarProducto.TabIndex = 36;
            this.BtnAgregarProducto.Text = "Aceptar";
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
            this.LblUnidadesMedida.Size = new System.Drawing.Size(209, 31);
            this.LblUnidadesMedida.TabIndex = 40;
            this.LblUnidadesMedida.Text = "Unidad de medida";
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
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.Location = new System.Drawing.Point(206, 443);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(114, 31);
            this.LblCategoria.TabIndex = 42;
            this.LblCategoria.Text = "Categoría";
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
            this.LblTipoProducto.Text = "Tipo de producto";
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
            this.NumUDLimiteAgregarProducto.ThousandsSeparator = true;
            // 
            // LblLimite
            // 
            this.LblLimite.AutoSize = true;
            this.LblLimite.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLimite.Location = new System.Drawing.Point(206, 350);
            this.LblLimite.Name = "LblLimite";
            this.LblLimite.Size = new System.Drawing.Size(267, 31);
            this.LblLimite.TabIndex = 46;
            this.LblLimite.Text = "Límite al sacar producto";
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.Maroon;
            this.PnlTitulo.Controls.Add(this.PbxNombreEmpresa);
            this.PnlTitulo.Controls.Add(this.LblAgregarProducto);
            this.PnlTitulo.Controls.Add(this.PbxCerrarForm);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(1186, 73);
            this.PnlTitulo.TabIndex = 49;
            this.PnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitulo_MouseDown);
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
            // LblAgregarProducto
            // 
            this.LblAgregarProducto.AutoSize = true;
            this.LblAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblAgregarProducto.Font = new System.Drawing.Font("Roboto", 19F, System.Drawing.FontStyle.Bold);
            this.LblAgregarProducto.Location = new System.Drawing.Point(70, 20);
            this.LblAgregarProducto.Name = "LblAgregarProducto";
            this.LblAgregarProducto.Size = new System.Drawing.Size(339, 38);
            this.LblAgregarProducto.TabIndex = 1;
            this.LblAgregarProducto.Text = "AGREGAR PRODUCTO";
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
            // LblGuionBajo
            // 
            this.LblGuionBajo.AutoSize = true;
            this.LblGuionBajo.Location = new System.Drawing.Point(207, 305);
            this.LblGuionBajo.Name = "LblGuionBajo";
            this.LblGuionBajo.Size = new System.Drawing.Size(273, 16);
            this.LblGuionBajo.TabIndex = 50;
            this.LblGuionBajo.Text = "______________________________________";
            // 
            // AgregarProducto
            // 
            this.AcceptButton = this.BtnAgregarProducto;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 796);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.NumUDLimiteAgregarProducto);
            this.Controls.Add(this.LblLimite);
            this.Controls.Add(this.CbxTipoProductoAgregarProducto);
            this.Controls.Add(this.LblTipoProducto);
            this.Controls.Add(this.CbxCategoriasAgregarProducto);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.CbxUnidadesMedidasAgregarProducto);
            this.Controls.Add(this.LblUnidadesMedida);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.NumUDCantidadAgregarProducto);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.TbxProductoAgregarProducto);
            this.Controls.Add(this.LblProducto);
            this.Controls.Add(this.LblGuionBajo);
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
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).EndInit();
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
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.ComboBox CbxTipoProductoAgregarProducto;
        private System.Windows.Forms.Label LblTipoProducto;
        private System.Windows.Forms.NumericUpDown NumUDLimiteAgregarProducto;
        private System.Windows.Forms.Label LblLimite;
        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Label LblAgregarProducto;
        private System.Windows.Forms.Label LblGuionBajo;
        private System.Windows.Forms.PictureBox PbxCerrarForm;
        private System.Windows.Forms.PictureBox PbxNombreEmpresa;
    }
}