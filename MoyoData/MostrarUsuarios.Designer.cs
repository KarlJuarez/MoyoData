namespace MoyoData
{
    partial class MostrarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MostrarUsuarios));
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.LblUsuarios = new System.Windows.Forms.Label();
            this.PbxCerrarForm = new System.Windows.Forms.PictureBox();
            this.PnlLogo = new System.Windows.Forms.Panel();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.ColumIDUsuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumUsuarioUsuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumPasswordUsuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumRolUsuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumSeleccionUsuarios = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnEliminarUsuario = new System.Windows.Forms.Button();
            this.BtnEditarUsuario = new System.Windows.Forms.Button();
            this.PnlAgregarProdcuto = new System.Windows.Forms.Panel();
            this.BtnAgregarUsuario = new System.Windows.Forms.Button();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).BeginInit();
            this.PnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.PnlAgregarProdcuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.Maroon;
            this.PnlTitulo.Controls.Add(this.LblUsuarios);
            this.PnlTitulo.Controls.Add(this.PbxCerrarForm);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 100);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(1186, 73);
            this.PnlTitulo.TabIndex = 16;
            // 
            // LblUsuarios
            // 
            this.LblUsuarios.AutoSize = true;
            this.LblUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblUsuarios.Font = new System.Drawing.Font("Roboto", 19F, System.Drawing.FontStyle.Bold);
            this.LblUsuarios.Location = new System.Drawing.Point(70, 20);
            this.LblUsuarios.Name = "LblUsuarios";
            this.LblUsuarios.Size = new System.Drawing.Size(172, 38);
            this.LblUsuarios.TabIndex = 1;
            this.LblUsuarios.Text = "USUARIOS";
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
            this.PnlLogo.TabIndex = 15;
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
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.AllowUserToDeleteRows = false;
            this.DgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumIDUsuarios,
            this.ColumUsuarioUsuarios,
            this.ColumPasswordUsuarios,
            this.ColumRolUsuarios,
            this.ColumSeleccionUsuarios});
            this.DgvUsuarios.Location = new System.Drawing.Point(49, 280);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.RowHeadersWidth = 51;
            this.DgvUsuarios.RowTemplate.Height = 24;
            this.DgvUsuarios.Size = new System.Drawing.Size(1084, 482);
            this.DgvUsuarios.TabIndex = 17;
            // 
            // ColumIDUsuarios
            // 
            this.ColumIDUsuarios.HeaderText = "ID";
            this.ColumIDUsuarios.MinimumWidth = 6;
            this.ColumIDUsuarios.Name = "ColumIDUsuarios";
            this.ColumIDUsuarios.Width = 125;
            // 
            // ColumUsuarioUsuarios
            // 
            this.ColumUsuarioUsuarios.HeaderText = "Usuario";
            this.ColumUsuarioUsuarios.MinimumWidth = 6;
            this.ColumUsuarioUsuarios.Name = "ColumUsuarioUsuarios";
            this.ColumUsuarioUsuarios.Width = 125;
            // 
            // ColumPasswordUsuarios
            // 
            this.ColumPasswordUsuarios.HeaderText = "Contraseña";
            this.ColumPasswordUsuarios.MinimumWidth = 6;
            this.ColumPasswordUsuarios.Name = "ColumPasswordUsuarios";
            this.ColumPasswordUsuarios.Width = 125;
            // 
            // ColumRolUsuarios
            // 
            this.ColumRolUsuarios.HeaderText = "Rol";
            this.ColumRolUsuarios.MinimumWidth = 6;
            this.ColumRolUsuarios.Name = "ColumRolUsuarios";
            this.ColumRolUsuarios.Width = 125;
            // 
            // ColumSeleccionUsuarios
            // 
            this.ColumSeleccionUsuarios.HeaderText = "Selección";
            this.ColumSeleccionUsuarios.MinimumWidth = 6;
            this.ColumSeleccionUsuarios.Name = "ColumSeleccionUsuarios";
            this.ColumSeleccionUsuarios.Width = 125;
            // 
            // BtnEliminarUsuario
            // 
            this.BtnEliminarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminarUsuario.AutoSize = true;
            this.BtnEliminarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEliminarUsuario.FlatAppearance.BorderSize = 0;
            this.BtnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarUsuario.Image = global::MoyoData.Properties.Resources._2_icon__trash_;
            this.BtnEliminarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarUsuario.Location = new System.Drawing.Point(694, 208);
            this.BtnEliminarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminarUsuario.Name = "BtnEliminarUsuario";
            this.BtnEliminarUsuario.Size = new System.Drawing.Size(245, 50);
            this.BtnEliminarUsuario.TabIndex = 39;
            this.BtnEliminarUsuario.Text = "     Eliminar usuario";
            this.BtnEliminarUsuario.UseVisualStyleBackColor = false;
            this.BtnEliminarUsuario.Click += new System.EventHandler(this.BtnEliminarUsuario_Click);
            // 
            // BtnEditarUsuario
            // 
            this.BtnEditarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditarUsuario.AutoSize = true;
            this.BtnEditarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditarUsuario.FlatAppearance.BorderSize = 0;
            this.BtnEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarUsuario.Image = global::MoyoData.Properties.Resources._2_icon__edit_pencil_;
            this.BtnEditarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditarUsuario.Location = new System.Drawing.Point(945, 208);
            this.BtnEditarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditarUsuario.Name = "BtnEditarUsuario";
            this.BtnEditarUsuario.Size = new System.Drawing.Size(123, 50);
            this.BtnEditarUsuario.TabIndex = 40;
            this.BtnEditarUsuario.Text = "    Editar";
            this.BtnEditarUsuario.UseVisualStyleBackColor = false;
            this.BtnEditarUsuario.Click += new System.EventHandler(this.BtnEditarUsuario_Click);
            // 
            // PnlAgregarProdcuto
            // 
            this.PnlAgregarProdcuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlAgregarProdcuto.Controls.Add(this.BtnAgregarUsuario);
            this.PnlAgregarProdcuto.Location = new System.Drawing.Point(468, 208);
            this.PnlAgregarProdcuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlAgregarProdcuto.Name = "PnlAgregarProdcuto";
            this.PnlAgregarProdcuto.Size = new System.Drawing.Size(221, 50);
            this.PnlAgregarProdcuto.TabIndex = 38;
            // 
            // BtnAgregarUsuario
            // 
            this.BtnAgregarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregarUsuario.AutoSize = true;
            this.BtnAgregarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAgregarUsuario.FlatAppearance.BorderSize = 0;
            this.BtnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarUsuario.Image = global::MoyoData.Properties.Resources._5_icon__plus_;
            this.BtnAgregarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarUsuario.Location = new System.Drawing.Point(0, 0);
            this.BtnAgregarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAgregarUsuario.Name = "BtnAgregarUsuario";
            this.BtnAgregarUsuario.Size = new System.Drawing.Size(221, 50);
            this.BtnAgregarUsuario.TabIndex = 3;
            this.BtnAgregarUsuario.Text = "     Agregar usuario";
            this.BtnAgregarUsuario.UseVisualStyleBackColor = false;
            this.BtnAgregarUsuario.Click += new System.EventHandler(this.BtnAgregarUsuario_Click);
            // 
            // MostrarUsuarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 796);
            this.Controls.Add(this.BtnEliminarUsuario);
            this.Controls.Add(this.BtnEditarUsuario);
            this.Controls.Add(this.PnlAgregarProdcuto);
            this.Controls.Add(this.DgvUsuarios);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.PnlLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MostrarUsuarios";
            this.Text = "Usuarios";
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).EndInit();
            this.PnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.PnlAgregarProdcuto.ResumeLayout(false);
            this.PnlAgregarProdcuto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.Label LblUsuarios;
        private System.Windows.Forms.PictureBox PbxCerrarForm;
        private System.Windows.Forms.Panel PnlLogo;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Button BtnEliminarUsuario;
        private System.Windows.Forms.Button BtnEditarUsuario;
        private System.Windows.Forms.Panel PnlAgregarProdcuto;
        private System.Windows.Forms.Button BtnAgregarUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumIDUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumUsuarioUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumPasswordUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumRolUsuarios;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumSeleccionUsuarios;
    }
}