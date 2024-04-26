namespace MoyoData
{
    partial class EntradaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaProducto));
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.LblEntradaProducto = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.DtpFechaEntradaProducto = new System.Windows.Forms.DateTimePicker();
            this.BtnEntradaProductoAgregar = new System.Windows.Forms.Button();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.PbxCerrarForm = new System.Windows.Forms.PictureBox();
            this.BtnEntradaProductoIngresar = new System.Windows.Forms.Button();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.DgvProductosSeleccionados = new System.Windows.Forms.DataGridView();
            this.ColumIDSeleccionados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumProductoSeleccionados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCantidadSeleccionados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TbxUsuarioEntradaProducto = new System.Windows.Forms.TextBox();
            this.NumUDCantidadEntradaProducto = new System.Windows.Forms.NumericUpDown();
            this.ColumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumSeleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDCantidadEntradaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlLogo
            // 
            this.PnlLogo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.PnlLogo.Controls.Add(this.PbxLogo);
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(1186, 100);
            this.PnlLogo.TabIndex = 0;
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
            // LblEntradaProducto
            // 
            this.LblEntradaProducto.AutoSize = true;
            this.LblEntradaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblEntradaProducto.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEntradaProducto.Location = new System.Drawing.Point(68, 14);
            this.LblEntradaProducto.Name = "LblEntradaProducto";
            this.LblEntradaProducto.Size = new System.Drawing.Size(414, 45);
            this.LblEntradaProducto.TabIndex = 1;
            this.LblEntradaProducto.Text = "ENTRADA DE PRODUCTO";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(82, 200);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(92, 38);
            this.LblFecha.TabIndex = 2;
            this.LblFecha.Text = "Fecha";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(82, 315);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(134, 38);
            this.LblCantidad.TabIndex = 3;
            this.LblCantidad.Text = "Cantidad";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(386, 200);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(117, 38);
            this.LblUsuario.TabIndex = 4;
            this.LblUsuario.Text = "Usuario";
            // 
            // DtpFechaEntradaProducto
            // 
            this.DtpFechaEntradaProducto.Location = new System.Drawing.Point(89, 263);
            this.DtpFechaEntradaProducto.Name = "DtpFechaEntradaProducto";
            this.DtpFechaEntradaProducto.Size = new System.Drawing.Size(200, 22);
            this.DtpFechaEntradaProducto.TabIndex = 6;
            // 
            // BtnEntradaProductoAgregar
            // 
            this.BtnEntradaProductoAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.BtnEntradaProductoAgregar.FlatAppearance.BorderSize = 0;
            this.BtnEntradaProductoAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntradaProductoAgregar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntradaProductoAgregar.Location = new System.Drawing.Point(118, 414);
            this.BtnEntradaProductoAgregar.Name = "BtnEntradaProductoAgregar";
            this.BtnEntradaProductoAgregar.Size = new System.Drawing.Size(143, 56);
            this.BtnEntradaProductoAgregar.TabIndex = 8;
            this.BtnEntradaProductoAgregar.Text = "Agregar producto";
            this.BtnEntradaProductoAgregar.UseVisualStyleBackColor = false;
            this.BtnEntradaProductoAgregar.Click += new System.EventHandler(this.BtnEntradaProductoAgregar_Click);
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.Maroon;
            this.PnlTitulo.Controls.Add(this.LblEntradaProducto);
            this.PnlTitulo.Controls.Add(this.PbxCerrarForm);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 100);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(1186, 73);
            this.PnlTitulo.TabIndex = 12;
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
            // BtnEntradaProductoIngresar
            // 
            this.BtnEntradaProductoIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.BtnEntradaProductoIngresar.FlatAppearance.BorderSize = 0;
            this.BtnEntradaProductoIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntradaProductoIngresar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntradaProductoIngresar.Location = new System.Drawing.Point(306, 414);
            this.BtnEntradaProductoIngresar.Name = "BtnEntradaProductoIngresar";
            this.BtnEntradaProductoIngresar.Size = new System.Drawing.Size(143, 56);
            this.BtnEntradaProductoIngresar.TabIndex = 13;
            this.BtnEntradaProductoIngresar.Text = "Ingresar";
            this.BtnEntradaProductoIngresar.UseVisualStyleBackColor = false;
            this.BtnEntradaProductoIngresar.Click += new System.EventHandler(this.BtnEntradaProductoIngresar_Click);
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
            this.DgvProductos.Location = new System.Drawing.Point(76, 496);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.RowHeadersWidth = 51;
            this.DgvProductos.RowTemplate.Height = 24;
            this.DgvProductos.Size = new System.Drawing.Size(925, 257);
            this.DgvProductos.TabIndex = 14;
            // 
            // DgvProductosSeleccionados
            // 
            this.DgvProductosSeleccionados.AllowUserToAddRows = false;
            this.DgvProductosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductosSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumIDSeleccionados,
            this.ColumProductoSeleccionados,
            this.ColumCantidadSeleccionados});
            this.DgvProductosSeleccionados.Location = new System.Drawing.Point(716, 200);
            this.DgvProductosSeleccionados.Name = "DgvProductosSeleccionados";
            this.DgvProductosSeleccionados.RowHeadersWidth = 51;
            this.DgvProductosSeleccionados.RowTemplate.Height = 24;
            this.DgvProductosSeleccionados.Size = new System.Drawing.Size(424, 264);
            this.DgvProductosSeleccionados.TabIndex = 15;
            // 
            // ColumIDSeleccionados
            // 
            this.ColumIDSeleccionados.HeaderText = "ID";
            this.ColumIDSeleccionados.MinimumWidth = 6;
            this.ColumIDSeleccionados.Name = "ColumIDSeleccionados";
            this.ColumIDSeleccionados.Width = 125;
            // 
            // ColumProductoSeleccionados
            // 
            this.ColumProductoSeleccionados.HeaderText = "Producto";
            this.ColumProductoSeleccionados.MinimumWidth = 6;
            this.ColumProductoSeleccionados.Name = "ColumProductoSeleccionados";
            this.ColumProductoSeleccionados.Width = 125;
            // 
            // ColumCantidadSeleccionados
            // 
            this.ColumCantidadSeleccionados.HeaderText = "Cantidad";
            this.ColumCantidadSeleccionados.MinimumWidth = 6;
            this.ColumCantidadSeleccionados.Name = "ColumCantidadSeleccionados";
            this.ColumCantidadSeleccionados.Width = 125;
            // 
            // TbxUsuarioEntradaProducto
            // 
            this.TbxUsuarioEntradaProducto.Location = new System.Drawing.Point(393, 263);
            this.TbxUsuarioEntradaProducto.Name = "TbxUsuarioEntradaProducto";
            this.TbxUsuarioEntradaProducto.Size = new System.Drawing.Size(186, 22);
            this.TbxUsuarioEntradaProducto.TabIndex = 16;
            // 
            // NumUDCantidadEntradaProducto
            // 
            this.NumUDCantidadEntradaProducto.Location = new System.Drawing.Point(89, 369);
            this.NumUDCantidadEntradaProducto.Name = "NumUDCantidadEntradaProducto";
            this.NumUDCantidadEntradaProducto.Size = new System.Drawing.Size(200, 22);
            this.NumUDCantidadEntradaProducto.TabIndex = 17;
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
            this.ColumSeleccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumSeleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumSeleccion.Width = 125;
            // 
            // EntradaProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1186, 796);
            this.Controls.Add(this.NumUDCantidadEntradaProducto);
            this.Controls.Add(this.TbxUsuarioEntradaProducto);
            this.Controls.Add(this.DgvProductosSeleccionados);
            this.Controls.Add(this.DgvProductos);
            this.Controls.Add(this.BtnEntradaProductoIngresar);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.BtnEntradaProductoAgregar);
            this.Controls.Add(this.DtpFechaEntradaProducto);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.PnlLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntradaProducto";
            this.Text = "EntradaProducto";
            this.PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDCantidadEntradaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.Label LblEntradaProducto;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.DateTimePicker DtpFechaEntradaProducto;
        private System.Windows.Forms.Button BtnEntradaProductoAgregar;
        private System.Windows.Forms.PictureBox PbxCerrarForm;
        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Button BtnEntradaProductoIngresar;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.DataGridView DgvProductosSeleccionados;
        private System.Windows.Forms.TextBox TbxUsuarioEntradaProducto;
        private System.Windows.Forms.NumericUpDown NumUDCantidadEntradaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumIDSeleccionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumProductoSeleccionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCantidadSeleccionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCategoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumSeleccion;
    }
}