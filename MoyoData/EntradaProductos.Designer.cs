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
            this.BtnEntradaProductoEliminar = new System.Windows.Forms.Button();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.LblEntradaProducto = new System.Windows.Forms.Label();
            this.BtnEntradaProductoAgregar = new System.Windows.Forms.Button();
            this.LblEntradaProductos = new System.Windows.Forms.Label();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.PbxCerrarForm = new System.Windows.Forms.PictureBox();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEntradaProductos)).BeginInit();
            this.PnlTitulo.SuspendLayout();
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvEntradaProductos
            // 
            this.DgvEntradaProductos.AllowUserToAddRows = false;
            this.DgvEntradaProductos.AllowUserToDeleteRows = false;
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
            // BtnEntradaProductoEliminar
            // 
            this.BtnEntradaProductoEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEntradaProductoEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.BtnEntradaProductoEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntradaProductoEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnEntradaProductoEliminar.Location = new System.Drawing.Point(1013, 208);
            this.BtnEntradaProductoEliminar.Name = "BtnEntradaProductoEliminar";
            this.BtnEntradaProductoEliminar.Size = new System.Drawing.Size(143, 56);
            this.BtnEntradaProductoEliminar.TabIndex = 28;
            this.BtnEntradaProductoEliminar.Text = "Eliminar";
            this.BtnEntradaProductoEliminar.UseVisualStyleBackColor = false;
            this.BtnEntradaProductoEliminar.Click += new System.EventHandler(this.BtnEntradaProductoEliminar_Click);
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
            this.LblEntradaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.LblEntradaProducto.Location = new System.Drawing.Point(70, 20);
            this.LblEntradaProducto.Name = "LblEntradaProducto";
            this.LblEntradaProducto.Size = new System.Drawing.Size(434, 37);
            this.LblEntradaProducto.TabIndex = 1;
            this.LblEntradaProducto.Text = "ENTRADA DE PRODUCTO";
            // 
            // BtnEntradaProductoAgregar
            // 
            this.BtnEntradaProductoAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEntradaProductoAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.BtnEntradaProductoAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntradaProductoAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnEntradaProductoAgregar.Location = new System.Drawing.Point(855, 207);
            this.BtnEntradaProductoAgregar.Name = "BtnEntradaProductoAgregar";
            this.BtnEntradaProductoAgregar.Size = new System.Drawing.Size(143, 56);
            this.BtnEntradaProductoAgregar.TabIndex = 26;
            this.BtnEntradaProductoAgregar.Text = "Agregar producto";
            this.BtnEntradaProductoAgregar.UseVisualStyleBackColor = false;
            this.BtnEntradaProductoAgregar.Click += new System.EventHandler(this.BtnEntradaProductoAgregar_Click);
            // 
            // LblEntradaProductos
            // 
            this.LblEntradaProductos.AutoSize = true;
            this.LblEntradaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEntradaProductos.Location = new System.Drawing.Point(63, 218);
            this.LblEntradaProductos.Name = "LblEntradaProductos";
            this.LblEntradaProductos.Size = new System.Drawing.Size(419, 29);
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
            // EntradaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 749);
            this.Controls.Add(this.DgvEntradaProductos);
            this.Controls.Add(this.BtnEntradaProductoEliminar);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.BtnEntradaProductoAgregar);
            this.Controls.Add(this.LblEntradaProductos);
            this.Controls.Add(this.PnlLogo);
            this.Name = "EntradaProductos";
            this.Text = "EntradaProductos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvEntradaProductos)).EndInit();
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            this.PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
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
        private System.Windows.Forms.Button BtnEntradaProductoEliminar;
        private System.Windows.Forms.PictureBox PbxCerrarForm;
        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Label LblEntradaProducto;
        private System.Windows.Forms.Button BtnEntradaProductoAgregar;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.Label LblEntradaProductos;
        private System.Windows.Forms.Panel PnlLogo;
    }
}