namespace MoyoData
{
    partial class SalidaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalidaProducto));
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.LblSalidaProducto = new System.Windows.Forms.Label();
            this.PbxCerrarForm = new System.Windows.Forms.PictureBox();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.DgvProductosSeleccionados = new System.Windows.Forms.DataGridView();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.ColumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumSeleccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSalidaProductoHacerPrestamo = new System.Windows.Forms.Button();
            this.BtnSalidaProductoAgregar = new System.Windows.Forms.Button();
            this.DtpFechaSalidaProducto = new System.Windows.Forms.DateTimePicker();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.TbxUsuarioSalidaProducto = new System.Windows.Forms.TextBox();
            this.NumUDCantidadSalidaProducto = new System.Windows.Forms.NumericUpDown();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).BeginInit();
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDCantidadSalidaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.Maroon;
            this.PnlTitulo.Controls.Add(this.LblSalidaProducto);
            this.PnlTitulo.Controls.Add(this.PbxCerrarForm);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 100);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(1186, 73);
            this.PnlTitulo.TabIndex = 23;
            // 
            // LblSalidaProducto
            // 
            this.LblSalidaProducto.AutoSize = true;
            this.LblSalidaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblSalidaProducto.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalidaProducto.Location = new System.Drawing.Point(68, 14);
            this.LblSalidaProducto.Name = "LblSalidaProducto";
            this.LblSalidaProducto.Size = new System.Drawing.Size(375, 45);
            this.LblSalidaProducto.TabIndex = 1;
            this.LblSalidaProducto.Text = "SALIDA DE PRODUCTO";
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
            // DgvProductosSeleccionados
            // 
            this.DgvProductosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductosSeleccionados.Location = new System.Drawing.Point(701, 201);
            this.DgvProductosSeleccionados.Name = "DgvProductosSeleccionados";
            this.DgvProductosSeleccionados.RowHeadersWidth = 51;
            this.DgvProductosSeleccionados.RowTemplate.Height = 24;
            this.DgvProductosSeleccionados.Size = new System.Drawing.Size(436, 264);
            this.DgvProductosSeleccionados.TabIndex = 33;
            // 
            // DgvProductos
            // 
            this.DgvProductos.AllowUserToAddRows = false;
            this.DgvProductos.AllowUserToDeleteRows = false;
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumID,
            this.ColumProducto,
            this.ColumStock,
            this.ColumCantidad,
            this.ColumTipo,
            this.ColumCategoria,
            this.ColumSeleccion});
            this.DgvProductos.Location = new System.Drawing.Point(61, 497);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.RowHeadersWidth = 51;
            this.DgvProductos.RowTemplate.Height = 24;
            this.DgvProductos.Size = new System.Drawing.Size(925, 257);
            this.DgvProductos.TabIndex = 32;
            // 
            // ColumID
            // 
            this.ColumID.HeaderText = "ID";
            this.ColumID.MinimumWidth = 6;
            this.ColumID.Name = "ColumID";
            this.ColumID.Width = 125;
            // 
            // ColumProducto
            // 
            this.ColumProducto.HeaderText = "Producto";
            this.ColumProducto.MinimumWidth = 6;
            this.ColumProducto.Name = "ColumProducto";
            this.ColumProducto.Width = 125;
            // 
            // ColumStock
            // 
            this.ColumStock.HeaderText = "Stock";
            this.ColumStock.MinimumWidth = 6;
            this.ColumStock.Name = "ColumStock";
            this.ColumStock.Width = 125;
            // 
            // ColumCantidad
            // 
            this.ColumCantidad.HeaderText = "Cantidad";
            this.ColumCantidad.MinimumWidth = 6;
            this.ColumCantidad.Name = "ColumCantidad";
            this.ColumCantidad.Width = 125;
            // 
            // ColumTipo
            // 
            this.ColumTipo.HeaderText = "Tipo";
            this.ColumTipo.MinimumWidth = 6;
            this.ColumTipo.Name = "ColumTipo";
            this.ColumTipo.Width = 125;
            // 
            // ColumCategoria
            // 
            this.ColumCategoria.HeaderText = "Categoría";
            this.ColumCategoria.MinimumWidth = 6;
            this.ColumCategoria.Name = "ColumCategoria";
            this.ColumCategoria.Width = 125;
            // 
            // ColumSeleccion
            // 
            this.ColumSeleccion.HeaderText = "Selección";
            this.ColumSeleccion.MinimumWidth = 6;
            this.ColumSeleccion.Name = "ColumSeleccion";
            this.ColumSeleccion.Width = 125;
            // 
            // BtnSalidaProductoHacerPrestamo
            // 
            this.BtnSalidaProductoHacerPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalidaProductoHacerPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.BtnSalidaProductoHacerPrestamo.FlatAppearance.BorderSize = 0;
            this.BtnSalidaProductoHacerPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalidaProductoHacerPrestamo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalidaProductoHacerPrestamo.Location = new System.Drawing.Point(291, 415);
            this.BtnSalidaProductoHacerPrestamo.Name = "BtnSalidaProductoHacerPrestamo";
            this.BtnSalidaProductoHacerPrestamo.Size = new System.Drawing.Size(143, 56);
            this.BtnSalidaProductoHacerPrestamo.TabIndex = 31;
            this.BtnSalidaProductoHacerPrestamo.Text = "Hacer préstamo";
            this.BtnSalidaProductoHacerPrestamo.UseVisualStyleBackColor = false;
            this.BtnSalidaProductoHacerPrestamo.Click += new System.EventHandler(this.BtnSalidaProductoHacerPrestamo_Click);
            // 
            // BtnSalidaProductoAgregar
            // 
            this.BtnSalidaProductoAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalidaProductoAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.BtnSalidaProductoAgregar.FlatAppearance.BorderSize = 0;
            this.BtnSalidaProductoAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalidaProductoAgregar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalidaProductoAgregar.Location = new System.Drawing.Point(103, 415);
            this.BtnSalidaProductoAgregar.Name = "BtnSalidaProductoAgregar";
            this.BtnSalidaProductoAgregar.Size = new System.Drawing.Size(143, 56);
            this.BtnSalidaProductoAgregar.TabIndex = 29;
            this.BtnSalidaProductoAgregar.Text = "Agregar producto";
            this.BtnSalidaProductoAgregar.UseVisualStyleBackColor = false;
            this.BtnSalidaProductoAgregar.Click += new System.EventHandler(this.BtnSalidaProductoAgregar_Click);
            // 
            // DtpFechaSalidaProducto
            // 
            this.DtpFechaSalidaProducto.Location = new System.Drawing.Point(74, 264);
            this.DtpFechaSalidaProducto.Name = "DtpFechaSalidaProducto";
            this.DtpFechaSalidaProducto.Size = new System.Drawing.Size(200, 22);
            this.DtpFechaSalidaProducto.TabIndex = 27;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(407, 201);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(117, 38);
            this.LblUsuario.TabIndex = 26;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(67, 316);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(134, 38);
            this.LblCantidad.TabIndex = 25;
            this.LblCantidad.Text = "Cantidad";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(67, 201);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(282, 38);
            this.LblFecha.TabIndex = 24;
            this.LblFecha.Text = "Fecha de expedición";
            // 
            // TbxUsuarioSalidaProducto
            // 
            this.TbxUsuarioSalidaProducto.Location = new System.Drawing.Point(414, 264);
            this.TbxUsuarioSalidaProducto.Name = "TbxUsuarioSalidaProducto";
            this.TbxUsuarioSalidaProducto.Size = new System.Drawing.Size(178, 22);
            this.TbxUsuarioSalidaProducto.TabIndex = 34;
            // 
            // NumUDCantidadSalidaProducto
            // 
            this.NumUDCantidadSalidaProducto.Location = new System.Drawing.Point(76, 368);
            this.NumUDCantidadSalidaProducto.Name = "NumUDCantidadSalidaProducto";
            this.NumUDCantidadSalidaProducto.Size = new System.Drawing.Size(198, 22);
            this.NumUDCantidadSalidaProducto.TabIndex = 35;
            // 
            // SalidaProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1186, 796);
            this.Controls.Add(this.NumUDCantidadSalidaProducto);
            this.Controls.Add(this.TbxUsuarioSalidaProducto);
            this.Controls.Add(this.DgvProductosSeleccionados);
            this.Controls.Add(this.DgvProductos);
            this.Controls.Add(this.BtnSalidaProductoHacerPrestamo);
            this.Controls.Add(this.BtnSalidaProductoAgregar);
            this.Controls.Add(this.DtpFechaSalidaProducto);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.PnlLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalidaProducto";
            this.Text = "SalidaProducto";
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).EndInit();
            this.PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDCantidadSalidaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Label LblSalidaProducto;
        private System.Windows.Forms.PictureBox PbxCerrarForm;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.DataGridView DgvProductosSeleccionados;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumSeleccion;
        private System.Windows.Forms.Button BtnSalidaProductoHacerPrestamo;
        private System.Windows.Forms.Button BtnSalidaProductoAgregar;
        private System.Windows.Forms.DateTimePicker DtpFechaSalidaProducto;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.TextBox TbxUsuarioSalidaProducto;
        private System.Windows.Forms.NumericUpDown NumUDCantidadSalidaProducto;
    }
}