namespace MoyoData
{
    partial class Aspectos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aspectos));
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.LblAspectos = new System.Windows.Forms.Label();
            this.PbxCerrarForm = new System.Windows.Forms.PictureBox();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.DgvCategorias = new System.Windows.Forms.DataGridView();
            this.ColumIDCategorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCategoriaCategorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumSeleccionCategorias = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnAgregarCategoria = new System.Windows.Forms.Button();
            this.BtnEditarCategoria = new System.Windows.Forms.Button();
            this.LblCategorias = new System.Windows.Forms.Label();
            this.DgvTiposProductos = new System.Windows.Forms.DataGridView();
            this.ColumIDTiposProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTipoProductoTiposProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCategoriaTiposProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumSeleccionTiposProductos = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DgvUnidadesDeMedida = new System.Windows.Forms.DataGridView();
            this.ColumIDUnidadesMedidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumUnidadMedidadUnidadesMedidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumSeleccionUnidadesMedidas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LblTiposProducto = new System.Windows.Forms.Label();
            this.BtnEditarTipoProducto = new System.Windows.Forms.Button();
            this.BtnAgregarTipoPorducto = new System.Windows.Forms.Button();
            this.LblUnidadesDeMedida = new System.Windows.Forms.Label();
            this.BtnEditarUnidadDeMedida = new System.Windows.Forms.Button();
            this.BtnAgregarUnidadDeMedida = new System.Windows.Forms.Button();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).BeginInit();
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTiposProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUnidadesDeMedida)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.Maroon;
            this.PnlTitulo.Controls.Add(this.LblAspectos);
            this.PnlTitulo.Controls.Add(this.PbxCerrarForm);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 100);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(1186, 73);
            this.PnlTitulo.TabIndex = 14;
            // 
            // LblAspectos
            // 
            this.LblAspectos.AutoSize = true;
            this.LblAspectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblAspectos.Font = new System.Drawing.Font("Roboto", 19F, System.Drawing.FontStyle.Bold);
            this.LblAspectos.ForeColor = System.Drawing.Color.White;
            this.LblAspectos.Location = new System.Drawing.Point(70, 20);
            this.LblAspectos.Name = "LblAspectos";
            this.LblAspectos.Size = new System.Drawing.Size(181, 38);
            this.LblAspectos.TabIndex = 1;
            this.LblAspectos.Text = "ASPECTOS";
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
            // DgvCategorias
            // 
            this.DgvCategorias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgvCategorias.BackgroundColor = System.Drawing.Color.White;
            this.DgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumIDCategorias,
            this.ColumCategoriaCategorias,
            this.ColumSeleccionCategorias});
            this.DgvCategorias.Location = new System.Drawing.Point(55, 315);
            this.DgvCategorias.Name = "DgvCategorias";
            this.DgvCategorias.RowHeadersWidth = 51;
            this.DgvCategorias.RowTemplate.Height = 24;
            this.DgvCategorias.Size = new System.Drawing.Size(334, 418);
            this.DgvCategorias.TabIndex = 15;
            // 
            // ColumIDCategorias
            // 
            this.ColumIDCategorias.HeaderText = "ID";
            this.ColumIDCategorias.MinimumWidth = 6;
            this.ColumIDCategorias.Name = "ColumIDCategorias";
            this.ColumIDCategorias.Width = 125;
            // 
            // ColumCategoriaCategorias
            // 
            this.ColumCategoriaCategorias.HeaderText = "Categoria";
            this.ColumCategoriaCategorias.MinimumWidth = 6;
            this.ColumCategoriaCategorias.Name = "ColumCategoriaCategorias";
            this.ColumCategoriaCategorias.Width = 125;
            // 
            // ColumSeleccionCategorias
            // 
            this.ColumSeleccionCategorias.HeaderText = "Seleccion";
            this.ColumSeleccionCategorias.MinimumWidth = 6;
            this.ColumSeleccionCategorias.Name = "ColumSeleccionCategorias";
            this.ColumSeleccionCategorias.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumSeleccionCategorias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumSeleccionCategorias.Width = 125;
            // 
            // BtnAgregarCategoria
            // 
            this.BtnAgregarCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAgregarCategoria.AutoSize = true;
            this.BtnAgregarCategoria.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregarCategoria.FlatAppearance.BorderSize = 0;
            this.BtnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCategoria.Image = global::MoyoData.Properties.Resources._5_icon__plus_;
            this.BtnAgregarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarCategoria.Location = new System.Drawing.Point(74, 260);
            this.BtnAgregarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregarCategoria.Name = "BtnAgregarCategoria";
            this.BtnAgregarCategoria.Size = new System.Drawing.Size(138, 50);
            this.BtnAgregarCategoria.TabIndex = 16;
            this.BtnAgregarCategoria.Text = "Agregar";
            this.BtnAgregarCategoria.UseVisualStyleBackColor = false;
            this.BtnAgregarCategoria.Click += new System.EventHandler(this.BtnAgregarCategoria_Click);
            // 
            // BtnEditarCategoria
            // 
            this.BtnEditarCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditarCategoria.AutoSize = true;
            this.BtnEditarCategoria.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditarCategoria.FlatAppearance.BorderSize = 0;
            this.BtnEditarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarCategoria.Image = global::MoyoData.Properties.Resources._2_icon__edit_pencil_;
            this.BtnEditarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditarCategoria.Location = new System.Drawing.Point(232, 260);
            this.BtnEditarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditarCategoria.Name = "BtnEditarCategoria";
            this.BtnEditarCategoria.Size = new System.Drawing.Size(123, 50);
            this.BtnEditarCategoria.TabIndex = 38;
            this.BtnEditarCategoria.Text = "    Editar";
            this.BtnEditarCategoria.UseVisualStyleBackColor = false;
            this.BtnEditarCategoria.Click += new System.EventHandler(this.BtnEditarCategoria_Click);
            // 
            // LblCategorias
            // 
            this.LblCategorias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCategorias.AutoSize = true;
            this.LblCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblCategorias.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategorias.ForeColor = System.Drawing.Color.Black;
            this.LblCategorias.Location = new System.Drawing.Point(149, 217);
            this.LblCategorias.Name = "LblCategorias";
            this.LblCategorias.Size = new System.Drawing.Size(125, 31);
            this.LblCategorias.TabIndex = 39;
            this.LblCategorias.Text = "Categorías";
            // 
            // DgvTiposProductos
            // 
            this.DgvTiposProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgvTiposProductos.BackgroundColor = System.Drawing.Color.White;
            this.DgvTiposProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTiposProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumIDTiposProductos,
            this.ColumTipoProductoTiposProductos,
            this.ColumCategoriaTiposProductos,
            this.ColumSeleccionTiposProductos});
            this.DgvTiposProductos.Location = new System.Drawing.Point(445, 315);
            this.DgvTiposProductos.Name = "DgvTiposProductos";
            this.DgvTiposProductos.RowHeadersWidth = 51;
            this.DgvTiposProductos.RowTemplate.Height = 24;
            this.DgvTiposProductos.Size = new System.Drawing.Size(319, 418);
            this.DgvTiposProductos.TabIndex = 40;
            // 
            // ColumIDTiposProductos
            // 
            this.ColumIDTiposProductos.HeaderText = "ID";
            this.ColumIDTiposProductos.MinimumWidth = 6;
            this.ColumIDTiposProductos.Name = "ColumIDTiposProductos";
            this.ColumIDTiposProductos.Width = 125;
            // 
            // ColumTipoProductoTiposProductos
            // 
            this.ColumTipoProductoTiposProductos.HeaderText = "Tipo de producto";
            this.ColumTipoProductoTiposProductos.MinimumWidth = 6;
            this.ColumTipoProductoTiposProductos.Name = "ColumTipoProductoTiposProductos";
            this.ColumTipoProductoTiposProductos.Width = 125;
            // 
            // ColumCategoriaTiposProductos
            // 
            this.ColumCategoriaTiposProductos.HeaderText = "Categoria";
            this.ColumCategoriaTiposProductos.MinimumWidth = 6;
            this.ColumCategoriaTiposProductos.Name = "ColumCategoriaTiposProductos";
            this.ColumCategoriaTiposProductos.Width = 125;
            // 
            // ColumSeleccionTiposProductos
            // 
            this.ColumSeleccionTiposProductos.HeaderText = "Seleccion";
            this.ColumSeleccionTiposProductos.MinimumWidth = 6;
            this.ColumSeleccionTiposProductos.Name = "ColumSeleccionTiposProductos";
            this.ColumSeleccionTiposProductos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumSeleccionTiposProductos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumSeleccionTiposProductos.Width = 125;
            // 
            // DgvUnidadesDeMedida
            // 
            this.DgvUnidadesDeMedida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgvUnidadesDeMedida.BackgroundColor = System.Drawing.Color.White;
            this.DgvUnidadesDeMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUnidadesDeMedida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumIDUnidadesMedidas,
            this.ColumUnidadMedidadUnidadesMedidas,
            this.ColumSeleccionUnidadesMedidas});
            this.DgvUnidadesDeMedida.Location = new System.Drawing.Point(831, 315);
            this.DgvUnidadesDeMedida.Name = "DgvUnidadesDeMedida";
            this.DgvUnidadesDeMedida.RowHeadersWidth = 51;
            this.DgvUnidadesDeMedida.RowTemplate.Height = 24;
            this.DgvUnidadesDeMedida.Size = new System.Drawing.Size(319, 418);
            this.DgvUnidadesDeMedida.TabIndex = 41;
            // 
            // ColumIDUnidadesMedidas
            // 
            this.ColumIDUnidadesMedidas.HeaderText = "ID";
            this.ColumIDUnidadesMedidas.MinimumWidth = 6;
            this.ColumIDUnidadesMedidas.Name = "ColumIDUnidadesMedidas";
            this.ColumIDUnidadesMedidas.Width = 125;
            // 
            // ColumUnidadMedidadUnidadesMedidas
            // 
            this.ColumUnidadMedidadUnidadesMedidas.HeaderText = "Unidad de medida";
            this.ColumUnidadMedidadUnidadesMedidas.MinimumWidth = 6;
            this.ColumUnidadMedidadUnidadesMedidas.Name = "ColumUnidadMedidadUnidadesMedidas";
            this.ColumUnidadMedidadUnidadesMedidas.Width = 125;
            // 
            // ColumSeleccionUnidadesMedidas
            // 
            this.ColumSeleccionUnidadesMedidas.HeaderText = "Seleccion";
            this.ColumSeleccionUnidadesMedidas.MinimumWidth = 6;
            this.ColumSeleccionUnidadesMedidas.Name = "ColumSeleccionUnidadesMedidas";
            this.ColumSeleccionUnidadesMedidas.Width = 125;
            // 
            // LblTiposProducto
            // 
            this.LblTiposProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTiposProducto.AutoSize = true;
            this.LblTiposProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTiposProducto.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTiposProducto.ForeColor = System.Drawing.Color.Black;
            this.LblTiposProducto.Location = new System.Drawing.Point(515, 217);
            this.LblTiposProducto.Name = "LblTiposProducto";
            this.LblTiposProducto.Size = new System.Drawing.Size(206, 31);
            this.LblTiposProducto.TabIndex = 44;
            this.LblTiposProducto.Text = "Tipos de producto";
            // 
            // BtnEditarTipoProducto
            // 
            this.BtnEditarTipoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditarTipoProducto.AutoSize = true;
            this.BtnEditarTipoProducto.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditarTipoProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditarTipoProducto.FlatAppearance.BorderSize = 0;
            this.BtnEditarTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarTipoProducto.Image = global::MoyoData.Properties.Resources._2_icon__edit_pencil_;
            this.BtnEditarTipoProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditarTipoProducto.Location = new System.Drawing.Point(621, 260);
            this.BtnEditarTipoProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditarTipoProducto.Name = "BtnEditarTipoProducto";
            this.BtnEditarTipoProducto.Size = new System.Drawing.Size(123, 50);
            this.BtnEditarTipoProducto.TabIndex = 43;
            this.BtnEditarTipoProducto.Text = "    Editar";
            this.BtnEditarTipoProducto.UseVisualStyleBackColor = false;
            this.BtnEditarTipoProducto.Click += new System.EventHandler(this.BtnEditarTipoProducto_Click);
            // 
            // BtnAgregarTipoPorducto
            // 
            this.BtnAgregarTipoPorducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAgregarTipoPorducto.AutoSize = true;
            this.BtnAgregarTipoPorducto.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarTipoPorducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregarTipoPorducto.FlatAppearance.BorderSize = 0;
            this.BtnAgregarTipoPorducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarTipoPorducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarTipoPorducto.Image = global::MoyoData.Properties.Resources._5_icon__plus_;
            this.BtnAgregarTipoPorducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarTipoPorducto.Location = new System.Drawing.Point(463, 260);
            this.BtnAgregarTipoPorducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregarTipoPorducto.Name = "BtnAgregarTipoPorducto";
            this.BtnAgregarTipoPorducto.Size = new System.Drawing.Size(138, 50);
            this.BtnAgregarTipoPorducto.TabIndex = 42;
            this.BtnAgregarTipoPorducto.Text = "Agregar";
            this.BtnAgregarTipoPorducto.UseVisualStyleBackColor = false;
            this.BtnAgregarTipoPorducto.Click += new System.EventHandler(this.BtnAgregarTipoPorducto_Click);
            // 
            // LblUnidadesDeMedida
            // 
            this.LblUnidadesDeMedida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblUnidadesDeMedida.AutoSize = true;
            this.LblUnidadesDeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblUnidadesDeMedida.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUnidadesDeMedida.ForeColor = System.Drawing.Color.Black;
            this.LblUnidadesDeMedida.Location = new System.Drawing.Point(895, 217);
            this.LblUnidadesDeMedida.Name = "LblUnidadesDeMedida";
            this.LblUnidadesDeMedida.Size = new System.Drawing.Size(232, 31);
            this.LblUnidadesDeMedida.TabIndex = 47;
            this.LblUnidadesDeMedida.Text = "Unidades de medida";
            // 
            // BtnEditarUnidadDeMedida
            // 
            this.BtnEditarUnidadDeMedida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditarUnidadDeMedida.AutoSize = true;
            this.BtnEditarUnidadDeMedida.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditarUnidadDeMedida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditarUnidadDeMedida.FlatAppearance.BorderSize = 0;
            this.BtnEditarUnidadDeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarUnidadDeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarUnidadDeMedida.Image = global::MoyoData.Properties.Resources._2_icon__edit_pencil_;
            this.BtnEditarUnidadDeMedida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditarUnidadDeMedida.Location = new System.Drawing.Point(1004, 260);
            this.BtnEditarUnidadDeMedida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditarUnidadDeMedida.Name = "BtnEditarUnidadDeMedida";
            this.BtnEditarUnidadDeMedida.Size = new System.Drawing.Size(123, 50);
            this.BtnEditarUnidadDeMedida.TabIndex = 46;
            this.BtnEditarUnidadDeMedida.Text = "    Editar";
            this.BtnEditarUnidadDeMedida.UseVisualStyleBackColor = false;
            this.BtnEditarUnidadDeMedida.Click += new System.EventHandler(this.BtnEditarUnidadDeMedida_Click);
            // 
            // BtnAgregarUnidadDeMedida
            // 
            this.BtnAgregarUnidadDeMedida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAgregarUnidadDeMedida.AutoSize = true;
            this.BtnAgregarUnidadDeMedida.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarUnidadDeMedida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregarUnidadDeMedida.FlatAppearance.BorderSize = 0;
            this.BtnAgregarUnidadDeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarUnidadDeMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarUnidadDeMedida.Image = global::MoyoData.Properties.Resources._5_icon__plus_;
            this.BtnAgregarUnidadDeMedida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarUnidadDeMedida.Location = new System.Drawing.Point(846, 260);
            this.BtnAgregarUnidadDeMedida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregarUnidadDeMedida.Name = "BtnAgregarUnidadDeMedida";
            this.BtnAgregarUnidadDeMedida.Size = new System.Drawing.Size(138, 50);
            this.BtnAgregarUnidadDeMedida.TabIndex = 45;
            this.BtnAgregarUnidadDeMedida.Text = "Agregar";
            this.BtnAgregarUnidadDeMedida.UseVisualStyleBackColor = false;
            this.BtnAgregarUnidadDeMedida.Click += new System.EventHandler(this.BtnAgregarUnidadDeMedida_Click);
            // 
            // Aspectos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 796);
            this.Controls.Add(this.LblUnidadesDeMedida);
            this.Controls.Add(this.BtnEditarUnidadDeMedida);
            this.Controls.Add(this.BtnAgregarUnidadDeMedida);
            this.Controls.Add(this.LblTiposProducto);
            this.Controls.Add(this.BtnEditarTipoProducto);
            this.Controls.Add(this.BtnAgregarTipoPorducto);
            this.Controls.Add(this.DgvUnidadesDeMedida);
            this.Controls.Add(this.DgvTiposProductos);
            this.Controls.Add(this.LblCategorias);
            this.Controls.Add(this.BtnEditarCategoria);
            this.Controls.Add(this.BtnAgregarCategoria);
            this.Controls.Add(this.DgvCategorias);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.PnlLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Aspectos";
            this.Text = "Aspectos";
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).EndInit();
            this.PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTiposProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUnidadesDeMedida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Label LblAspectos;
        private System.Windows.Forms.PictureBox PbxCerrarForm;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.DataGridView DgvCategorias;
        private System.Windows.Forms.Button BtnAgregarCategoria;
        private System.Windows.Forms.Button BtnEditarCategoria;
        private System.Windows.Forms.Label LblCategorias;
        private System.Windows.Forms.DataGridView DgvTiposProductos;
        private System.Windows.Forms.DataGridView DgvUnidadesDeMedida;
        private System.Windows.Forms.Label LblTiposProducto;
        private System.Windows.Forms.Button BtnEditarTipoProducto;
        private System.Windows.Forms.Button BtnAgregarTipoPorducto;
        private System.Windows.Forms.Label LblUnidadesDeMedida;
        private System.Windows.Forms.Button BtnEditarUnidadDeMedida;
        private System.Windows.Forms.Button BtnAgregarUnidadDeMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumIDCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCategoriaCategorias;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumSeleccionCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumIDTiposProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTipoProductoTiposProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCategoriaTiposProductos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumSeleccionTiposProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumIDUnidadesMedidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumUnidadMedidadUnidadesMedidas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumSeleccionUnidadesMedidas;
    }
}