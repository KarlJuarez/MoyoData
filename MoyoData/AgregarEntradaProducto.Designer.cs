namespace MoyoData
{
    partial class AgregarEntradaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEntradaProducto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblEntradaProducto = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.DtpFechaEntradaProducto = new System.Windows.Forms.DateTimePicker();
            this.BtnEntradaProductoAgregar = new System.Windows.Forms.Button();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.PbxNombreEmpresa = new System.Windows.Forms.PictureBox();
            this.PbxCerrarForm = new System.Windows.Forms.PictureBox();
            this.BtnEntradaProductoIngresar = new System.Windows.Forms.Button();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.DgvProductosSeleccionados = new System.Windows.Forms.DataGridView();
            this.ColumIDSeleccionados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumProductoSeleccionados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCantidadSeleccionados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TbxUsuarioEntradaProducto = new System.Windows.Forms.TextBox();
            this.NumUDCantidadEntradaProducto = new System.Windows.Forms.NumericUpDown();
            this.LblGuionBajoUsuario = new System.Windows.Forms.Label();
            this.LblProductos = new System.Windows.Forms.Label();
            this.LblProductosSeleccionados = new System.Windows.Forms.Label();
            this.ColumSeleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDCantidadEntradaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // LblEntradaProducto
            // 
            this.LblEntradaProducto.AutoSize = true;
            this.LblEntradaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblEntradaProducto.Font = new System.Drawing.Font("Roboto", 19F, System.Drawing.FontStyle.Bold);
            this.LblEntradaProducto.ForeColor = System.Drawing.Color.White;
            this.LblEntradaProducto.Location = new System.Drawing.Point(70, 20);
            this.LblEntradaProducto.Name = "LblEntradaProducto";
            this.LblEntradaProducto.Size = new System.Drawing.Size(540, 38);
            this.LblEntradaProducto.TabIndex = 1;
            this.LblEntradaProducto.Text = "AGREGAR ENTRADA DE PRODUCTO";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(60, 295);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(193, 36);
            this.LblFecha.TabIndex = 2;
            this.LblFecha.Text = "Fecha de entrega";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(60, 205);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(111, 36);
            this.LblCantidad.TabIndex = 3;
            this.LblCantidad.Text = "Cantidad";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(60, 107);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(98, 36);
            this.LblUsuario.TabIndex = 4;
            this.LblUsuario.Text = "Usuario";
            // 
            // DtpFechaEntradaProducto
            // 
            this.DtpFechaEntradaProducto.Checked = false;
            this.DtpFechaEntradaProducto.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaEntradaProducto.Location = new System.Drawing.Point(66, 342);
            this.DtpFechaEntradaProducto.MaxDate = new System.DateTime(2300, 1, 1, 0, 0, 0, 0);
            this.DtpFechaEntradaProducto.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DtpFechaEntradaProducto.Name = "DtpFechaEntradaProducto";
            this.DtpFechaEntradaProducto.Size = new System.Drawing.Size(270, 23);
            this.DtpFechaEntradaProducto.TabIndex = 6;
            this.DtpFechaEntradaProducto.Value = new System.DateTime(2024, 5, 3, 0, 0, 0, 0);
            // 
            // BtnEntradaProductoAgregar
            // 
            this.BtnEntradaProductoAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEntradaProductoAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.BtnEntradaProductoAgregar.FlatAppearance.BorderSize = 0;
            this.BtnEntradaProductoAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntradaProductoAgregar.Font = new System.Drawing.Font("Rosario", 10F, System.Drawing.FontStyle.Bold);
            this.BtnEntradaProductoAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnEntradaProductoAgregar.Location = new System.Drawing.Point(825, 618);
            this.BtnEntradaProductoAgregar.Name = "BtnEntradaProductoAgregar";
            this.BtnEntradaProductoAgregar.Size = new System.Drawing.Size(143, 56);
            this.BtnEntradaProductoAgregar.TabIndex = 8;
            this.BtnEntradaProductoAgregar.Text = "Agregar";
            this.BtnEntradaProductoAgregar.UseVisualStyleBackColor = false;
            this.BtnEntradaProductoAgregar.Click += new System.EventHandler(this.BtnEntradaProductoAgregar_Click);
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.Maroon;
            this.PnlTitulo.Controls.Add(this.PbxNombreEmpresa);
            this.PnlTitulo.Controls.Add(this.LblEntradaProducto);
            this.PnlTitulo.Controls.Add(this.PbxCerrarForm);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(1186, 73);
            this.PnlTitulo.TabIndex = 12;
            this.PnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitulo_MouseDown);
            // 
            // PbxNombreEmpresa
            // 
            this.PbxNombreEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("PbxNombreEmpresa.Image")));
            this.PbxNombreEmpresa.Location = new System.Drawing.Point(812, 23);
            this.PbxNombreEmpresa.Name = "PbxNombreEmpresa";
            this.PbxNombreEmpresa.Size = new System.Drawing.Size(276, 28);
            this.PbxNombreEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxNombreEmpresa.TabIndex = 13;
            this.PbxNombreEmpresa.TabStop = false;
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
            this.BtnEntradaProductoIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEntradaProductoIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.BtnEntradaProductoIngresar.FlatAppearance.BorderSize = 0;
            this.BtnEntradaProductoIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntradaProductoIngresar.Font = new System.Drawing.Font("Rosario", 10F, System.Drawing.FontStyle.Bold);
            this.BtnEntradaProductoIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnEntradaProductoIngresar.Location = new System.Drawing.Point(993, 618);
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
            this.DgvProductos.AllowUserToResizeColumns = false;
            this.DgvProductos.AllowUserToResizeRows = false;
            this.DgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvProductos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumSeleccion,
            this.ColumID,
            this.ColumProducto,
            this.ColumStock,
            this.ColumCantidad,
            this.ColumTipo,
            this.ColumCategoria});
            this.DgvProductos.Location = new System.Drawing.Point(523, 141);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvProductos.RowTemplate.Height = 24;
            this.DgvProductos.Size = new System.Drawing.Size(613, 440);
            this.DgvProductos.TabIndex = 14;
            // 
            // DgvProductosSeleccionados
            // 
            this.DgvProductosSeleccionados.AllowUserToAddRows = false;
            this.DgvProductosSeleccionados.AllowUserToDeleteRows = false;
            this.DgvProductosSeleccionados.AllowUserToResizeColumns = false;
            this.DgvProductosSeleccionados.AllowUserToResizeRows = false;
            this.DgvProductosSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProductosSeleccionados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvProductosSeleccionados.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProductosSeleccionados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvProductosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductosSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumIDSeleccionados,
            this.ColumProductoSeleccionados,
            this.ColumCantidadSeleccionados});
            this.DgvProductosSeleccionados.Location = new System.Drawing.Point(66, 437);
            this.DgvProductosSeleccionados.Name = "DgvProductosSeleccionados";
            this.DgvProductosSeleccionados.ReadOnly = true;
            this.DgvProductosSeleccionados.RowHeadersWidth = 51;
            this.DgvProductosSeleccionados.RowTemplate.Height = 24;
            this.DgvProductosSeleccionados.Size = new System.Drawing.Size(426, 249);
            this.DgvProductosSeleccionados.TabIndex = 15;
            // 
            // ColumIDSeleccionados
            // 
            this.ColumIDSeleccionados.HeaderText = "ID";
            this.ColumIDSeleccionados.MinimumWidth = 6;
            this.ColumIDSeleccionados.Name = "ColumIDSeleccionados";
            this.ColumIDSeleccionados.ReadOnly = true;
            // 
            // ColumProductoSeleccionados
            // 
            this.ColumProductoSeleccionados.HeaderText = "Producto";
            this.ColumProductoSeleccionados.MinimumWidth = 6;
            this.ColumProductoSeleccionados.Name = "ColumProductoSeleccionados";
            this.ColumProductoSeleccionados.ReadOnly = true;
            // 
            // ColumCantidadSeleccionados
            // 
            this.ColumCantidadSeleccionados.HeaderText = "Cantidad";
            this.ColumCantidadSeleccionados.MinimumWidth = 6;
            this.ColumCantidadSeleccionados.Name = "ColumCantidadSeleccionados";
            this.ColumCantidadSeleccionados.ReadOnly = true;
            // 
            // TbxUsuarioEntradaProducto
            // 
            this.TbxUsuarioEntradaProducto.BackColor = System.Drawing.Color.White;
            this.TbxUsuarioEntradaProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxUsuarioEntradaProducto.Font = new System.Drawing.Font("Rosario", 10F);
            this.TbxUsuarioEntradaProducto.ForeColor = System.Drawing.Color.DimGray;
            this.TbxUsuarioEntradaProducto.Location = new System.Drawing.Point(66, 150);
            this.TbxUsuarioEntradaProducto.MaxLength = 25;
            this.TbxUsuarioEntradaProducto.Name = "TbxUsuarioEntradaProducto";
            this.TbxUsuarioEntradaProducto.ShortcutsEnabled = false;
            this.TbxUsuarioEntradaProducto.Size = new System.Drawing.Size(252, 21);
            this.TbxUsuarioEntradaProducto.TabIndex = 16;
            this.TbxUsuarioEntradaProducto.Text = "Escribe aquí";
            this.TbxUsuarioEntradaProducto.Enter += new System.EventHandler(this.TbxUsuarioEntradaProducto_Enter);
            this.TbxUsuarioEntradaProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxUsuarioEntradaProducto_KeyPress);
            this.TbxUsuarioEntradaProducto.Leave += new System.EventHandler(this.TbxUsuarioEntradaProducto_Leave);
            // 
            // NumUDCantidadEntradaProducto
            // 
            this.NumUDCantidadEntradaProducto.BackColor = System.Drawing.Color.White;
            this.NumUDCantidadEntradaProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumUDCantidadEntradaProducto.Font = new System.Drawing.Font("Roboto", 10F);
            this.NumUDCantidadEntradaProducto.Location = new System.Drawing.Point(66, 248);
            this.NumUDCantidadEntradaProducto.Name = "NumUDCantidadEntradaProducto";
            this.NumUDCantidadEntradaProducto.Size = new System.Drawing.Size(270, 28);
            this.NumUDCantidadEntradaProducto.TabIndex = 17;
            this.NumUDCantidadEntradaProducto.ThousandsSeparator = true;
            this.NumUDCantidadEntradaProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumUDCantidadEntradaProducto_KeyPress);
            // 
            // LblGuionBajoUsuario
            // 
            this.LblGuionBajoUsuario.AutoSize = true;
            this.LblGuionBajoUsuario.Location = new System.Drawing.Point(63, 161);
            this.LblGuionBajoUsuario.Name = "LblGuionBajoUsuario";
            this.LblGuionBajoUsuario.Size = new System.Drawing.Size(308, 16);
            this.LblGuionBajoUsuario.TabIndex = 18;
            this.LblGuionBajoUsuario.Text = "___________________________________________";
            // 
            // LblProductos
            // 
            this.LblProductos.AutoSize = true;
            this.LblProductos.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductos.Location = new System.Drawing.Point(517, 107);
            this.LblProductos.Name = "LblProductos";
            this.LblProductos.Size = new System.Drawing.Size(289, 36);
            this.LblProductos.TabIndex = 19;
            this.LblProductos.Text = "Productos en el inventario";
            // 
            // LblProductosSeleccionados
            // 
            this.LblProductosSeleccionados.AutoSize = true;
            this.LblProductosSeleccionados.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductosSeleccionados.Location = new System.Drawing.Point(60, 392);
            this.LblProductosSeleccionados.Name = "LblProductosSeleccionados";
            this.LblProductosSeleccionados.Size = new System.Drawing.Size(275, 36);
            this.LblProductosSeleccionados.TabIndex = 20;
            this.LblProductosSeleccionados.Text = "Productos seleccionados";
            // 
            // ColumSeleccion
            // 
            this.ColumSeleccion.HeaderText = "Selección";
            this.ColumSeleccion.MinimumWidth = 6;
            this.ColumSeleccion.Name = "ColumSeleccion";
            this.ColumSeleccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumSeleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumID
            // 
            this.ColumID.HeaderText = "ID";
            this.ColumID.MinimumWidth = 6;
            this.ColumID.Name = "ColumID";
            // 
            // ColumProducto
            // 
            this.ColumProducto.HeaderText = "Producto";
            this.ColumProducto.MinimumWidth = 6;
            this.ColumProducto.Name = "ColumProducto";
            // 
            // ColumStock
            // 
            this.ColumStock.HeaderText = "Stock";
            this.ColumStock.MinimumWidth = 6;
            this.ColumStock.Name = "ColumStock";
            // 
            // ColumCantidad
            // 
            this.ColumCantidad.HeaderText = "Cantidad";
            this.ColumCantidad.MinimumWidth = 6;
            this.ColumCantidad.Name = "ColumCantidad";
            // 
            // ColumTipo
            // 
            this.ColumTipo.HeaderText = "Tipo";
            this.ColumTipo.MinimumWidth = 6;
            this.ColumTipo.Name = "ColumTipo";
            // 
            // ColumCategoria
            // 
            this.ColumCategoria.HeaderText = "Categoría";
            this.ColumCategoria.MinimumWidth = 6;
            this.ColumCategoria.Name = "ColumCategoria";
            // 
            // AgregarEntradaProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 708);
            this.Controls.Add(this.LblProductosSeleccionados);
            this.Controls.Add(this.LblProductos);
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
            this.Controls.Add(this.LblGuionBajoUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarEntradaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar entrada de producto";
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductosSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDCantidadEntradaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label LblGuionBajoUsuario;
        private System.Windows.Forms.Label LblProductos;
        private System.Windows.Forms.Label LblProductosSeleccionados;
        private System.Windows.Forms.PictureBox PbxNombreEmpresa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCategoria;
    }
}