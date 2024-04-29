namespace MoyoData
{
    partial class SalidaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalidaProductos));
            this.DgvSalidaProductos = new System.Windows.Forms.DataGridView();
            this.ColumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumSeleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PbxCerrarForm = new System.Windows.Forms.PictureBox();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.LblSalida = new System.Windows.Forms.Label();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.LblSalidaProductos = new System.Windows.Forms.Label();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.BtnSalidaProductoEliminar = new System.Windows.Forms.Button();
            this.PnlAgregarProdcuto = new System.Windows.Forms.Panel();
            this.BtnSalidaProductoAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSalidaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).BeginInit();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            this.PnlLogo.SuspendLayout();
            this.PnlAgregarProdcuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvSalidaProductos
            // 
            this.DgvSalidaProductos.AllowUserToAddRows = false;
            this.DgvSalidaProductos.AllowUserToDeleteRows = false;
            this.DgvSalidaProductos.BackgroundColor = System.Drawing.Color.White;
            this.DgvSalidaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSalidaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumID,
            this.ColumFecha,
            this.ColumUsuario,
            this.ColumProducto,
            this.ColumCantidad,
            this.ColumSeleccion});
            this.DgvSalidaProductos.Location = new System.Drawing.Point(54, 287);
            this.DgvSalidaProductos.Name = "DgvSalidaProductos";
            this.DgvSalidaProductos.RowHeadersWidth = 51;
            this.DgvSalidaProductos.RowTemplate.Height = 24;
            this.DgvSalidaProductos.Size = new System.Drawing.Size(1080, 440);
            this.DgvSalidaProductos.TabIndex = 39;
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
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.Maroon;
            this.PnlTitulo.Controls.Add(this.LblSalida);
            this.PnlTitulo.Controls.Add(this.PbxCerrarForm);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 100);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(1168, 73);
            this.PnlTitulo.TabIndex = 37;
            // 
            // LblSalida
            // 
            this.LblSalida.AutoSize = true;
            this.LblSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold);
            this.LblSalida.Location = new System.Drawing.Point(70, 20);
            this.LblSalida.Name = "LblSalida";
            this.LblSalida.Size = new System.Drawing.Size(393, 37);
            this.LblSalida.TabIndex = 1;
            this.LblSalida.Text = "SALIDA DE PRODUCTO";
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
            // LblSalidaProductos
            // 
            this.LblSalidaProductos.AutoSize = true;
            this.LblSalidaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.LblSalidaProductos.Location = new System.Drawing.Point(48, 234);
            this.LblSalidaProductos.Name = "LblSalidaProductos";
            this.LblSalidaProductos.Size = new System.Drawing.Size(419, 29);
            this.LblSalidaProductos.TabIndex = 40;
            this.LblSalidaProductos.Text = "Registro de entrada de productos";
            // 
            // PnlLogo
            // 
            this.PnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.PnlLogo.Controls.Add(this.PbxLogo);
            this.PnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLogo.Location = new System.Drawing.Point(0, 0);
            this.PnlLogo.Name = "PnlLogo";
            this.PnlLogo.Size = new System.Drawing.Size(1168, 100);
            this.PnlLogo.TabIndex = 35;
            // 
            // BtnSalidaProductoEliminar
            // 
            this.BtnSalidaProductoEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalidaProductoEliminar.AutoSize = true;
            this.BtnSalidaProductoEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalidaProductoEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalidaProductoEliminar.FlatAppearance.BorderSize = 0;
            this.BtnSalidaProductoEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalidaProductoEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalidaProductoEliminar.Image = global::MoyoData.Properties.Resources._2_icon__trash_;
            this.BtnSalidaProductoEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalidaProductoEliminar.Location = new System.Drawing.Point(816, 215);
            this.BtnSalidaProductoEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSalidaProductoEliminar.Name = "BtnSalidaProductoEliminar";
            this.BtnSalidaProductoEliminar.Size = new System.Drawing.Size(245, 50);
            this.BtnSalidaProductoEliminar.TabIndex = 40;
            this.BtnSalidaProductoEliminar.Text = "     Eliminar producto";
            this.BtnSalidaProductoEliminar.UseVisualStyleBackColor = false;
            this.BtnSalidaProductoEliminar.Click += new System.EventHandler(this.BtnSalidaProductoEliminar_Click);
            // 
            // PnlAgregarProdcuto
            // 
            this.PnlAgregarProdcuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlAgregarProdcuto.Controls.Add(this.BtnSalidaProductoAgregar);
            this.PnlAgregarProdcuto.Location = new System.Drawing.Point(587, 215);
            this.PnlAgregarProdcuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlAgregarProdcuto.Name = "PnlAgregarProdcuto";
            this.PnlAgregarProdcuto.Size = new System.Drawing.Size(221, 50);
            this.PnlAgregarProdcuto.TabIndex = 39;
            // 
            // BtnSalidaProductoAgregar
            // 
            this.BtnSalidaProductoAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalidaProductoAgregar.AutoSize = true;
            this.BtnSalidaProductoAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalidaProductoAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSalidaProductoAgregar.FlatAppearance.BorderSize = 0;
            this.BtnSalidaProductoAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalidaProductoAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalidaProductoAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalidaProductoAgregar.Image")));
            this.BtnSalidaProductoAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalidaProductoAgregar.Location = new System.Drawing.Point(0, 0);
            this.BtnSalidaProductoAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSalidaProductoAgregar.Name = "BtnSalidaProductoAgregar";
            this.BtnSalidaProductoAgregar.Size = new System.Drawing.Size(221, 50);
            this.BtnSalidaProductoAgregar.TabIndex = 3;
            this.BtnSalidaProductoAgregar.Text = "     Extraer producto";
            this.BtnSalidaProductoAgregar.UseVisualStyleBackColor = false;
            this.BtnSalidaProductoAgregar.Click += new System.EventHandler(this.BtnSalidaProductoAgregar_Click);
            // 
            // SalidaProductos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1168, 749);
            this.Controls.Add(this.BtnSalidaProductoEliminar);
            this.Controls.Add(this.PnlAgregarProdcuto);
            this.Controls.Add(this.DgvSalidaProductos);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.LblSalidaProductos);
            this.Controls.Add(this.PnlLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalidaProductos";
            this.Text = "SalidaProductos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvSalidaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).EndInit();
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            this.PnlLogo.ResumeLayout(false);
            this.PnlAgregarProdcuto.ResumeLayout(false);
            this.PnlAgregarProdcuto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvSalidaProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCantidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumSeleccion;
        private System.Windows.Forms.PictureBox PbxCerrarForm;
        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Label LblSalida;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.Label LblSalidaProductos;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.Button BtnSalidaProductoEliminar;
        private System.Windows.Forms.Panel PnlAgregarProdcuto;
        private System.Windows.Forms.Button BtnSalidaProductoAgregar;
    }
}