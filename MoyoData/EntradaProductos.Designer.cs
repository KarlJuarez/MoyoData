namespace MoyoData
{
    partial class EntradaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaProductos));
            this.DgvEntradaProductos = new System.Windows.Forms.DataGridView();
            this.ColumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumSeleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.LblEntradaProducto = new System.Windows.Forms.Label();
            this.PbxCerrarForm = new System.Windows.Forms.PictureBox();
            this.LblEntradaProductos = new System.Windows.Forms.Label();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.BtnEntradaProductoEliminar = new System.Windows.Forms.Button();
            this.PnlAgregarProdcuto = new System.Windows.Forms.Panel();
            this.BtnEntradaProductoAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEntradaProductos)).BeginInit();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).BeginInit();
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            this.PnlAgregarProdcuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvEntradaProductos
            // 
            this.DgvEntradaProductos.AllowUserToAddRows = false;
            this.DgvEntradaProductos.AllowUserToDeleteRows = false;
            this.DgvEntradaProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgvEntradaProductos.BackgroundColor = System.Drawing.Color.White;
            this.DgvEntradaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEntradaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumID,
            this.ColumFecha,
            this.ColumUsuario,
            this.ColumProducto,
            this.ColumCantidad,
            this.ColumSeleccion});
            this.DgvEntradaProductos.Location = new System.Drawing.Point(54, 287);
            this.DgvEntradaProductos.Name = "DgvEntradaProductos";
            this.DgvEntradaProductos.RowHeadersWidth = 51;
            this.DgvEntradaProductos.RowTemplate.Height = 24;
            this.DgvEntradaProductos.Size = new System.Drawing.Size(1080, 440);
            this.DgvEntradaProductos.TabIndex = 29;
            // 
            // ColumID
            // 
            this.ColumID.HeaderText = "ID";
            this.ColumID.MinimumWidth = 6;
            this.ColumID.Name = "ColumID";
            this.ColumID.Width = 125;
            // 
            // ColumFecha
            // 
            this.ColumFecha.HeaderText = "Fecha";
            this.ColumFecha.MinimumWidth = 6;
            this.ColumFecha.Name = "ColumFecha";
            this.ColumFecha.Width = 125;
            // 
            // ColumUsuario
            // 
            this.ColumUsuario.HeaderText = "Usuario";
            this.ColumUsuario.MinimumWidth = 6;
            this.ColumUsuario.Name = "ColumUsuario";
            this.ColumUsuario.Width = 125;
            // 
            // ColumProducto
            // 
            this.ColumProducto.HeaderText = "Producto";
            this.ColumProducto.MinimumWidth = 6;
            this.ColumProducto.Name = "ColumProducto";
            this.ColumProducto.Width = 125;
            // 
            // ColumCantidad
            // 
            this.ColumCantidad.HeaderText = "Cantidad";
            this.ColumCantidad.MinimumWidth = 6;
            this.ColumCantidad.Name = "ColumCantidad";
            this.ColumCantidad.Width = 125;
            // 
            // ColumSeleccion
            // 
            this.ColumSeleccion.HeaderText = "Selección";
            this.ColumSeleccion.MinimumWidth = 6;
            this.ColumSeleccion.Name = "ColumSeleccion";
            this.ColumSeleccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumSeleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumSeleccion.Width = 125;
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.Maroon;
            this.PnlTitulo.Controls.Add(this.LblEntradaProducto);
            this.PnlTitulo.Controls.Add(this.PbxCerrarForm);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 100);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(1168, 73);
            this.PnlTitulo.TabIndex = 27;
            // 
            // LblEntradaProducto
            // 
            this.LblEntradaProducto.AutoSize = true;
            this.LblEntradaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblEntradaProducto.Font = new System.Drawing.Font("Roboto", 19F, System.Drawing.FontStyle.Bold);
            this.LblEntradaProducto.ForeColor = System.Drawing.Color.White;
            this.LblEntradaProducto.Location = new System.Drawing.Point(70, 20);
            this.LblEntradaProducto.Name = "LblEntradaProducto";
            this.LblEntradaProducto.Size = new System.Drawing.Size(386, 38);
            this.LblEntradaProducto.TabIndex = 1;
            this.LblEntradaProducto.Text = "ENTRADA DE PRODUCTO";
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
            // LblEntradaProductos
            // 
            this.LblEntradaProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblEntradaProductos.AutoSize = true;
            this.LblEntradaProductos.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold);
            this.LblEntradaProductos.Location = new System.Drawing.Point(48, 234);
            this.LblEntradaProductos.Name = "LblEntradaProductos";
            this.LblEntradaProductos.Size = new System.Drawing.Size(364, 31);
            this.LblEntradaProductos.TabIndex = 34;
            this.LblEntradaProductos.Text = "Registro de entrada de productos";
            // 
            // PnlLogo
            // 
            this.PnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.PnlLogo.Controls.Add(this.PbxLogo);
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(1168, 100);
            this.PnlLogo.TabIndex = 21;
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
            // BtnEntradaProductoEliminar
            // 
            this.BtnEntradaProductoEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEntradaProductoEliminar.AutoSize = true;
            this.BtnEntradaProductoEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEntradaProductoEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEntradaProductoEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEntradaProductoEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntradaProductoEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntradaProductoEliminar.Image = global::MoyoData.Properties.Resources._2_icon__trash_;
            this.BtnEntradaProductoEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEntradaProductoEliminar.Location = new System.Drawing.Point(889, 215);
            this.BtnEntradaProductoEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEntradaProductoEliminar.Name = "BtnEntradaProductoEliminar";
            this.BtnEntradaProductoEliminar.Size = new System.Drawing.Size(245, 50);
            this.BtnEntradaProductoEliminar.TabIndex = 38;
            this.BtnEntradaProductoEliminar.Text = "     Eliminar producto";
            this.BtnEntradaProductoEliminar.UseVisualStyleBackColor = false;
            this.BtnEntradaProductoEliminar.Click += new System.EventHandler(this.BtnEntradaProductoEliminar_Click);
            // 
            // PnlAgregarProdcuto
            // 
            this.PnlAgregarProdcuto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PnlAgregarProdcuto.Controls.Add(this.BtnEntradaProductoAgregar);
            this.PnlAgregarProdcuto.Location = new System.Drawing.Point(663, 215);
            this.PnlAgregarProdcuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlAgregarProdcuto.Name = "PnlAgregarProdcuto";
            this.PnlAgregarProdcuto.Size = new System.Drawing.Size(221, 50);
            this.PnlAgregarProdcuto.TabIndex = 37;
            // 
            // BtnEntradaProductoAgregar
            // 
            this.BtnEntradaProductoAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEntradaProductoAgregar.AutoSize = true;
            this.BtnEntradaProductoAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEntradaProductoAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEntradaProductoAgregar.FlatAppearance.BorderSize = 0;
            this.BtnEntradaProductoAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntradaProductoAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntradaProductoAgregar.Image = global::MoyoData.Properties.Resources._5_icon__plus_;
            this.BtnEntradaProductoAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEntradaProductoAgregar.Location = new System.Drawing.Point(0, 0);
            this.BtnEntradaProductoAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEntradaProductoAgregar.Name = "BtnEntradaProductoAgregar";
            this.BtnEntradaProductoAgregar.Size = new System.Drawing.Size(221, 50);
            this.BtnEntradaProductoAgregar.TabIndex = 3;
            this.BtnEntradaProductoAgregar.Text = "     Agregar producto";
            this.BtnEntradaProductoAgregar.UseVisualStyleBackColor = false;
            this.BtnEntradaProductoAgregar.Click += new System.EventHandler(this.BtnEntradaProductoAgregar_Click);
            // 
            // EntradaProductos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1168, 749);
            this.Controls.Add(this.BtnEntradaProductoEliminar);
            this.Controls.Add(this.PnlAgregarProdcuto);
            this.Controls.Add(this.DgvEntradaProductos);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.LblEntradaProductos);
            this.Controls.Add(this.PnlLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntradaProductos";
            this.Text = "Entrada de productos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvEntradaProductos)).EndInit();
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).EndInit();
            this.PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            this.PnlAgregarProdcuto.ResumeLayout(false);
            this.PnlAgregarProdcuto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEntradaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCantidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumSeleccion;
        private System.Windows.Forms.PictureBox PbxCerrarForm;
        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Label LblEntradaProducto;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.Label LblEntradaProductos;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.Button BtnEntradaProductoEliminar;
        private System.Windows.Forms.Panel PnlAgregarProdcuto;
        private System.Windows.Forms.Button BtnEntradaProductoAgregar;
    }
}