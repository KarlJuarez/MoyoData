namespace MoyoData
{
    partial class AgregarSalidaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarSalidaProducto));
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.LblSalidaProducto = new System.Windows.Forms.Label();
            this.PbxCerrarForm = new System.Windows.Forms.PictureBox();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.DgvProductosSeleccionados = new System.Windows.Forms.DataGridView();
            this.ColumIDSeleccionados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumProductosSeleccionados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCantidadSeleccionados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.ColumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumSeleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnSalidaProductoHacerPrestamo = new System.Windows.Forms.Button();
            this.BtnSalidaProductoAgregar = new System.Windows.Forms.Button();
            this.DtpFechaSalidaProducto = new System.Windows.Forms.DateTimePicker();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.TbxUsuarioSalidaProducto = new System.Windows.Forms.TextBox();
            this.NumUDCantidadSalidaProducto = new System.Windows.Forms.NumericUpDown();
            this.LblGuionBajoUsuario = new System.Windows.Forms.Label();
            this.LblProductosSeleccionados = new System.Windows.Forms.Label();
            this.LblProductos = new System.Windows.Forms.Label();
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
            this.LblSalidaProducto.Font = new System.Drawing.Font("Roboto", 19F, System.Drawing.FontStyle.Bold);
            this.LblSalidaProducto.Location = new System.Drawing.Point(70, 20);
            this.LblSalidaProducto.Name = "LblSalidaProducto";
            this.LblSalidaProducto.Size = new System.Drawing.Size(351, 38);
            this.LblSalidaProducto.TabIndex = 100;
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
            // DgvProductosSeleccionados
            // 
            this.DgvProductosSeleccionados.AllowUserToAddRows = false;
            this.DgvProductosSeleccionados.AllowUserToDeleteRows = false;
            this.DgvProductosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductosSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumIDSeleccionados,
            this.ColumProductosSeleccionados,
            this.ColumCantidadSeleccionados});
            this.DgvProductosSeleccionados.Location = new System.Drawing.Point(77, 525);
            this.DgvProductosSeleccionados.Name = "DgvProductosSeleccionados";
            this.DgvProductosSeleccionados.RowHeadersWidth = 51;
            this.DgvProductosSeleccionados.RowTemplate.Height = 24;
            this.DgvProductosSeleccionados.Size = new System.Drawing.Size(426, 249);
            this.DgvProductosSeleccionados.TabIndex = 33;
            // 
            // ColumIDSeleccionados
            // 
            this.ColumIDSeleccionados.HeaderText = "ID";
            this.ColumIDSeleccionados.MinimumWidth = 6;
            this.ColumIDSeleccionados.Name = "ColumIDSeleccionados";
            this.ColumIDSeleccionados.Width = 125;
            // 
            // ColumProductosSeleccionados
            // 
            this.ColumProductosSeleccionados.HeaderText = "Producto";
            this.ColumProductosSeleccionados.MinimumWidth = 6;
            this.ColumProductosSeleccionados.Name = "ColumProductosSeleccionados";
            this.ColumProductosSeleccionados.Width = 125;
            // 
            // ColumCantidadSeleccionados
            // 
            this.ColumCantidadSeleccionados.HeaderText = "Cantidad";
            this.ColumCantidadSeleccionados.MinimumWidth = 6;
            this.ColumCantidadSeleccionados.Name = "ColumCantidadSeleccionados";
            this.ColumCantidadSeleccionados.Width = 125;
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
            this.ColumLimite,
            this.ColumTipo,
            this.ColumCategoria,
            this.ColumSeleccion});
            this.DgvProductos.Location = new System.Drawing.Point(534, 229);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.RowHeadersWidth = 51;
            this.DgvProductos.RowTemplate.Height = 24;
            this.DgvProductos.Size = new System.Drawing.Size(613, 440);
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
            // ColumLimite
            // 
            this.ColumLimite.HeaderText = "Limite";
            this.ColumLimite.MinimumWidth = 6;
            this.ColumLimite.Name = "ColumLimite";
            this.ColumLimite.Width = 125;
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
            // BtnSalidaProductoHacerPrestamo
            // 
            this.BtnSalidaProductoHacerPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalidaProductoHacerPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.BtnSalidaProductoHacerPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalidaProductoHacerPrestamo.Font = new System.Drawing.Font("Rosario", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSalidaProductoHacerPrestamo.Location = new System.Drawing.Point(1004, 706);
            this.BtnSalidaProductoHacerPrestamo.Name = "BtnSalidaProductoHacerPrestamo";
            this.BtnSalidaProductoHacerPrestamo.Size = new System.Drawing.Size(143, 56);
            this.BtnSalidaProductoHacerPrestamo.TabIndex = 27;
            this.BtnSalidaProductoHacerPrestamo.Text = "Hacer préstamo";
            this.BtnSalidaProductoHacerPrestamo.UseVisualStyleBackColor = false;
            this.BtnSalidaProductoHacerPrestamo.Click += new System.EventHandler(this.BtnSalidaProductoHacerPrestamo_Click);
            // 
            // BtnSalidaProductoAgregar
            // 
            this.BtnSalidaProductoAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalidaProductoAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.BtnSalidaProductoAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalidaProductoAgregar.Font = new System.Drawing.Font("Rosario", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSalidaProductoAgregar.Location = new System.Drawing.Point(836, 706);
            this.BtnSalidaProductoAgregar.Name = "BtnSalidaProductoAgregar";
            this.BtnSalidaProductoAgregar.Size = new System.Drawing.Size(143, 56);
            this.BtnSalidaProductoAgregar.TabIndex = 29;
            this.BtnSalidaProductoAgregar.Text = "Agregar producto";
            this.BtnSalidaProductoAgregar.UseVisualStyleBackColor = false;
            this.BtnSalidaProductoAgregar.Click += new System.EventHandler(this.BtnSalidaProductoAgregar_Click);
            // 
            // DtpFechaSalidaProducto
            // 
            this.DtpFechaSalidaProducto.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaSalidaProducto.Location = new System.Drawing.Point(77, 430);
            this.DtpFechaSalidaProducto.Name = "DtpFechaSalidaProducto";
            this.DtpFechaSalidaProducto.Size = new System.Drawing.Size(270, 23);
            this.DtpFechaSalidaProducto.TabIndex = 34;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(71, 195);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(97, 31);
            this.LblUsuario.TabIndex = 26;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(71, 293);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(110, 31);
            this.LblCantidad.TabIndex = 25;
            this.LblCantidad.Text = "Cantidad";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(71, 383);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(227, 31);
            this.LblFecha.TabIndex = 24;
            this.LblFecha.Text = "Fecha de expedición";
            // 
            // TbxUsuarioSalidaProducto
            // 
            this.TbxUsuarioSalidaProducto.BackColor = System.Drawing.Color.White;
            this.TbxUsuarioSalidaProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxUsuarioSalidaProducto.Font = new System.Drawing.Font("Rosario", 10F);
            this.TbxUsuarioSalidaProducto.ForeColor = System.Drawing.Color.DimGray;
            this.TbxUsuarioSalidaProducto.Location = new System.Drawing.Point(77, 238);
            this.TbxUsuarioSalidaProducto.MaxLength = 25;
            this.TbxUsuarioSalidaProducto.Name = "TbxUsuarioSalidaProducto";
            this.TbxUsuarioSalidaProducto.ShortcutsEnabled = false;
            this.TbxUsuarioSalidaProducto.Size = new System.Drawing.Size(267, 21);
            this.TbxUsuarioSalidaProducto.TabIndex = 31;
            this.TbxUsuarioSalidaProducto.Text = "Escribe aquí";
            this.TbxUsuarioSalidaProducto.Enter += new System.EventHandler(this.TbxUsuarioSalidaProducto_Enter);
            this.TbxUsuarioSalidaProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxUsuarioSalidaProducto_KeyPress);
            this.TbxUsuarioSalidaProducto.Leave += new System.EventHandler(this.TbxUsuarioSalidaProducto_Leave);
            // 
            // NumUDCantidadSalidaProducto
            // 
            this.NumUDCantidadSalidaProducto.BackColor = System.Drawing.Color.White;
            this.NumUDCantidadSalidaProducto.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumUDCantidadSalidaProducto.Location = new System.Drawing.Point(77, 336);
            this.NumUDCantidadSalidaProducto.Name = "NumUDCantidadSalidaProducto";
            this.NumUDCantidadSalidaProducto.Size = new System.Drawing.Size(270, 28);
            this.NumUDCantidadSalidaProducto.TabIndex = 35;
            // 
            // LblGuionBajoUsuario
            // 
            this.LblGuionBajoUsuario.AutoSize = true;
            this.LblGuionBajoUsuario.Location = new System.Drawing.Point(74, 249);
            this.LblGuionBajoUsuario.Name = "LblGuionBajoUsuario";
            this.LblGuionBajoUsuario.Size = new System.Drawing.Size(273, 16);
            this.LblGuionBajoUsuario.TabIndex = 36;
            this.LblGuionBajoUsuario.Text = "______________________________________";
            // 
            // LblProductosSeleccionados
            // 
            this.LblProductosSeleccionados.AutoSize = true;
            this.LblProductosSeleccionados.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductosSeleccionados.Location = new System.Drawing.Point(71, 480);
            this.LblProductosSeleccionados.Name = "LblProductosSeleccionados";
            this.LblProductosSeleccionados.Size = new System.Drawing.Size(273, 31);
            this.LblProductosSeleccionados.TabIndex = 38;
            this.LblProductosSeleccionados.Text = "Productos seleccionados";
            // 
            // LblProductos
            // 
            this.LblProductos.AutoSize = true;
            this.LblProductos.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductos.Location = new System.Drawing.Point(528, 195);
            this.LblProductos.Name = "LblProductos";
            this.LblProductos.Size = new System.Drawing.Size(288, 31);
            this.LblProductos.TabIndex = 37;
            this.LblProductos.Text = "Productos en el inventario";
            // 
            // AgregarSalidaProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 796);
            this.Controls.Add(this.LblProductosSeleccionados);
            this.Controls.Add(this.LblProductos);
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
            this.Controls.Add(this.LblGuionBajoUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarSalidaProducto";
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
        private System.Windows.Forms.Button BtnSalidaProductoHacerPrestamo;
        private System.Windows.Forms.Button BtnSalidaProductoAgregar;
        private System.Windows.Forms.DateTimePicker DtpFechaSalidaProducto;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.TextBox TbxUsuarioSalidaProducto;
        private System.Windows.Forms.NumericUpDown NumUDCantidadSalidaProducto;
        private System.Windows.Forms.Label LblGuionBajoUsuario;
        private System.Windows.Forms.Label LblProductosSeleccionados;
        private System.Windows.Forms.Label LblProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCategoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumIDSeleccionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumProductosSeleccionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCantidadSeleccionados;
    }
}