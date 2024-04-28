namespace MoyoData
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.LblRegistrar = new System.Windows.Forms.Label();
            this.PbxCerrarForm = new System.Windows.Forms.PictureBox();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.BtnEliminarProductoInventario = new System.Windows.Forms.Button();
            this.BtnEditarProducto = new System.Windows.Forms.Button();
            this.PnlAgregarProdcuto = new System.Windows.Forms.Panel();
            this.BtnAgregarProductoInventario = new System.Windows.Forms.Button();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.ColumIDInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumProductoInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumStockInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCantidadInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTipoInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCategoriaInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumSeleccionInventario = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).BeginInit();
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            this.PnlAgregarProdcuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.Maroon;
            this.PnlTitulo.Controls.Add(this.LblRegistrar);
            this.PnlTitulo.Controls.Add(this.PbxCerrarForm);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 100);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(1186, 73);
            this.PnlTitulo.TabIndex = 34;
            // 
            // LblRegistrar
            // 
            this.LblRegistrar.AutoSize = true;
            this.LblRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblRegistrar.Font = new System.Drawing.Font("Roboto", 19F, System.Drawing.FontStyle.Bold);
            this.LblRegistrar.Location = new System.Drawing.Point(70, 20);
            this.LblRegistrar.Name = "LblRegistrar";
            this.LblRegistrar.Size = new System.Drawing.Size(202, 38);
            this.LblRegistrar.TabIndex = 1;
            this.LblRegistrar.Text = "INVENTARIO";
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
            this.PnlLogo.TabIndex = 27;
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
            // BtnEliminarProductoInventario
            // 
            this.BtnEliminarProductoInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarProductoInventario.AutoSize = true;
            this.BtnEliminarProductoInventario.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarProductoInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEliminarProductoInventario.FlatAppearance.BorderSize = 0;
            this.BtnEliminarProductoInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarProductoInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarProductoInventario.Image = global::MoyoData.Properties.Resources._2_icon__trash_;
            this.BtnEliminarProductoInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarProductoInventario.Location = new System.Drawing.Point(699, 198);
            this.BtnEliminarProductoInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminarProductoInventario.Name = "BtnEliminarProductoInventario";
            this.BtnEliminarProductoInventario.Size = new System.Drawing.Size(245, 50);
            this.BtnEliminarProductoInventario.TabIndex = 36;
            this.BtnEliminarProductoInventario.Text = "     Eliminar producto";
            this.BtnEliminarProductoInventario.UseVisualStyleBackColor = false;
            this.BtnEliminarProductoInventario.Click += new System.EventHandler(this.BtnEliminarProductoInventario_Click);
            // 
            // BtnEditarProducto
            // 
            this.BtnEditarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditarProducto.AutoSize = true;
            this.BtnEditarProducto.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditarProducto.FlatAppearance.BorderSize = 0;
            this.BtnEditarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarProducto.Image = global::MoyoData.Properties.Resources._2_icon__edit_pencil_;
            this.BtnEditarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditarProducto.Location = new System.Drawing.Point(950, 198);
            this.BtnEditarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditarProducto.Name = "BtnEditarProducto";
            this.BtnEditarProducto.Size = new System.Drawing.Size(123, 50);
            this.BtnEditarProducto.TabIndex = 37;
            this.BtnEditarProducto.Text = "    Editar";
            this.BtnEditarProducto.UseVisualStyleBackColor = false;
            this.BtnEditarProducto.Click += new System.EventHandler(this.BtnEditarProducto_Click);
            // 
            // PnlAgregarProdcuto
            // 
            this.PnlAgregarProdcuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlAgregarProdcuto.Controls.Add(this.BtnAgregarProductoInventario);
            this.PnlAgregarProdcuto.Location = new System.Drawing.Point(473, 198);
            this.PnlAgregarProdcuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlAgregarProdcuto.Name = "PnlAgregarProdcuto";
            this.PnlAgregarProdcuto.Size = new System.Drawing.Size(221, 50);
            this.PnlAgregarProdcuto.TabIndex = 35;
            // 
            // BtnAgregarProductoInventario
            // 
            this.BtnAgregarProductoInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregarProductoInventario.AutoSize = true;
            this.BtnAgregarProductoInventario.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarProductoInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregarProductoInventario.FlatAppearance.BorderSize = 0;
            this.BtnAgregarProductoInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarProductoInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarProductoInventario.Image = global::MoyoData.Properties.Resources._5_icon__plus_;
            this.BtnAgregarProductoInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarProductoInventario.Location = new System.Drawing.Point(0, 0);
            this.BtnAgregarProductoInventario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregarProductoInventario.Name = "BtnAgregarProductoInventario";
            this.BtnAgregarProductoInventario.Size = new System.Drawing.Size(221, 50);
            this.BtnAgregarProductoInventario.TabIndex = 3;
            this.BtnAgregarProductoInventario.Text = "     Agregar producto";
            this.BtnAgregarProductoInventario.UseVisualStyleBackColor = false;
            this.BtnAgregarProductoInventario.Click += new System.EventHandler(this.BtnAgregarProductoInventario_Click);
            // 
            // DgvProductos
            // 
            this.DgvProductos.AllowUserToAddRows = false;
            this.DgvProductos.AllowUserToDeleteRows = false;
            this.DgvProductos.AllowUserToOrderColumns = true;
            this.DgvProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvProductos.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(37)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(37)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumIDInventario,
            this.ColumProductoInventario,
            this.ColumStockInventario,
            this.ColumCantidadInventario,
            this.ColumTipoInventario,
            this.ColumCategoriaInventario,
            this.ColumSeleccionInventario});
            this.DgvProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.DgvProductos.ImeMode = System.Windows.Forms.ImeMode.On;
            this.DgvProductos.Location = new System.Drawing.Point(12, 265);
            this.DgvProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.RowHeadersWidth = 51;
            this.DgvProductos.RowTemplate.Height = 24;
            this.DgvProductos.Size = new System.Drawing.Size(1140, 506);
            this.DgvProductos.TabIndex = 38;
            this.DgvProductos.TabStop = false;
            // 
            // ColumIDInventario
            // 
            this.ColumIDInventario.HeaderText = "ID";
            this.ColumIDInventario.MinimumWidth = 6;
            this.ColumIDInventario.Name = "ColumIDInventario";
            // 
            // ColumProductoInventario
            // 
            this.ColumProductoInventario.HeaderText = "Producto";
            this.ColumProductoInventario.MinimumWidth = 6;
            this.ColumProductoInventario.Name = "ColumProductoInventario";
            // 
            // ColumStockInventario
            // 
            this.ColumStockInventario.HeaderText = "Stock";
            this.ColumStockInventario.MinimumWidth = 6;
            this.ColumStockInventario.Name = "ColumStockInventario";
            // 
            // ColumCantidadInventario
            // 
            this.ColumCantidadInventario.HeaderText = "Cantidad";
            this.ColumCantidadInventario.MinimumWidth = 6;
            this.ColumCantidadInventario.Name = "ColumCantidadInventario";
            // 
            // ColumTipoInventario
            // 
            this.ColumTipoInventario.HeaderText = "Tipo";
            this.ColumTipoInventario.MinimumWidth = 6;
            this.ColumTipoInventario.Name = "ColumTipoInventario";
            // 
            // ColumCategoriaInventario
            // 
            this.ColumCategoriaInventario.HeaderText = "Categoría";
            this.ColumCategoriaInventario.MinimumWidth = 6;
            this.ColumCategoriaInventario.Name = "ColumCategoriaInventario";
            // 
            // ColumSeleccionInventario
            // 
            this.ColumSeleccionInventario.HeaderText = "Selección";
            this.ColumSeleccionInventario.MinimumWidth = 6;
            this.ColumSeleccionInventario.Name = "ColumSeleccionInventario";
            this.ColumSeleccionInventario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumSeleccionInventario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Inventario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 796);
            this.Controls.Add(this.DgvProductos);
            this.Controls.Add(this.BtnEliminarProductoInventario);
            this.Controls.Add(this.BtnEditarProducto);
            this.Controls.Add(this.PnlAgregarProdcuto);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.PnlLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).EndInit();
            this.PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            this.PnlAgregarProdcuto.ResumeLayout(false);
            this.PnlAgregarProdcuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Label LblRegistrar;
        private System.Windows.Forms.PictureBox PbxCerrarForm;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.Button BtnEliminarProductoInventario;
        private System.Windows.Forms.Button BtnEditarProducto;
        private System.Windows.Forms.Panel PnlAgregarProdcuto;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumIDInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumProductoInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumStockInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCantidadInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTipoInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCategoriaInventario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumSeleccionInventario;
        private System.Windows.Forms.Button BtnAgregarProductoInventario;
    }
}