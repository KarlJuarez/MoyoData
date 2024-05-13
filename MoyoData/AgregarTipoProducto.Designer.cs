namespace MoyoData
{
    partial class AgregarTipoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarTipoProducto));
            this.CbxCategoriaTipoProducto = new System.Windows.Forms.ComboBox();
            this.LblCategoriaTipoProducto = new System.Windows.Forms.Label();
            this.BtnAgregarTipoProducto = new System.Windows.Forms.Button();
            this.TbxTipoProducto = new System.Windows.Forms.TextBox();
            this.LblTipoProducto = new System.Windows.Forms.Label();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.PbxNombreEmpresa = new System.Windows.Forms.PictureBox();
            this.LblAgregarTipoProducto = new System.Windows.Forms.Label();
            this.PbxCerrarForm = new System.Windows.Forms.PictureBox();
            this.LblGuionBajo = new System.Windows.Forms.Label();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxCategoriaTipoProducto
            // 
            this.CbxCategoriaTipoProducto.BackColor = System.Drawing.Color.White;
            this.CbxCategoriaTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategoriaTipoProducto.FormattingEnabled = true;
            this.CbxCategoriaTipoProducto.Location = new System.Drawing.Point(479, 233);
            this.CbxCategoriaTipoProducto.Name = "CbxCategoriaTipoProducto";
            this.CbxCategoriaTipoProducto.Size = new System.Drawing.Size(261, 24);
            this.CbxCategoriaTipoProducto.TabIndex = 12;
            // 
            // LblCategoriaTipoProducto
            // 
            this.LblCategoriaTipoProducto.AutoSize = true;
            this.LblCategoriaTipoProducto.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoriaTipoProducto.Location = new System.Drawing.Point(473, 185);
            this.LblCategoriaTipoProducto.Name = "LblCategoriaTipoProducto";
            this.LblCategoriaTipoProducto.Size = new System.Drawing.Size(114, 31);
            this.LblCategoriaTipoProducto.TabIndex = 11;
            this.LblCategoriaTipoProducto.Text = "Categoría";
            // 
            // BtnAgregarTipoProducto
            // 
            this.BtnAgregarTipoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.BtnAgregarTipoProducto.FlatAppearance.BorderSize = 0;
            this.BtnAgregarTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarTipoProducto.Font = new System.Drawing.Font("Rosario", 10F, System.Drawing.FontStyle.Bold);
            this.BtnAgregarTipoProducto.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarTipoProducto.Location = new System.Drawing.Point(335, 319);
            this.BtnAgregarTipoProducto.Name = "BtnAgregarTipoProducto";
            this.BtnAgregarTipoProducto.Size = new System.Drawing.Size(134, 42);
            this.BtnAgregarTipoProducto.TabIndex = 10;
            this.BtnAgregarTipoProducto.Text = "Agregar";
            this.BtnAgregarTipoProducto.UseVisualStyleBackColor = false;
            this.BtnAgregarTipoProducto.Click += new System.EventHandler(this.BtnAgregarTipoProducto_Click);
            // 
            // TbxTipoProducto
            // 
            this.TbxTipoProducto.BackColor = System.Drawing.Color.White;
            this.TbxTipoProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxTipoProducto.Font = new System.Drawing.Font("Rosario", 10F);
            this.TbxTipoProducto.ForeColor = System.Drawing.Color.DimGray;
            this.TbxTipoProducto.Location = new System.Drawing.Point(76, 232);
            this.TbxTipoProducto.MaxLength = 30;
            this.TbxTipoProducto.Name = "TbxTipoProducto";
            this.TbxTipoProducto.ShortcutsEnabled = false;
            this.TbxTipoProducto.Size = new System.Drawing.Size(270, 21);
            this.TbxTipoProducto.TabIndex = 9;
            this.TbxTipoProducto.Text = "Escribe aquí";
            this.TbxTipoProducto.Enter += new System.EventHandler(this.TbxTipoProducto_Enter);
            this.TbxTipoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxTipoProducto_KeyPress);
            this.TbxTipoProducto.Leave += new System.EventHandler(this.TbxTipoProducto_Leave);
            // 
            // LblTipoProducto
            // 
            this.LblTipoProducto.AutoSize = true;
            this.LblTipoProducto.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoProducto.Location = new System.Drawing.Point(70, 185);
            this.LblTipoProducto.Name = "LblTipoProducto";
            this.LblTipoProducto.Size = new System.Drawing.Size(195, 31);
            this.LblTipoProducto.TabIndex = 8;
            this.LblTipoProducto.Text = "Tipo de producto";
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.Maroon;
            this.PnlTitulo.Controls.Add(this.PbxNombreEmpresa);
            this.PnlTitulo.Controls.Add(this.LblAgregarTipoProducto);
            this.PnlTitulo.Controls.Add(this.PbxCerrarForm);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(800, 73);
            this.PnlTitulo.TabIndex = 51;
            this.PnlTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitulo_MouseDown);
            // 
            // PbxNombreEmpresa
            // 
            this.PbxNombreEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("PbxNombreEmpresa.Image")));
            this.PbxNombreEmpresa.Location = new System.Drawing.Point(425, 23);
            this.PbxNombreEmpresa.Name = "PbxNombreEmpresa";
            this.PbxNombreEmpresa.Size = new System.Drawing.Size(276, 28);
            this.PbxNombreEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxNombreEmpresa.TabIndex = 12;
            this.PbxNombreEmpresa.TabStop = false;
            // 
            // LblAgregarTipoProducto
            // 
            this.LblAgregarTipoProducto.AutoSize = true;
            this.LblAgregarTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblAgregarTipoProducto.Font = new System.Drawing.Font("Roboto", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAgregarTipoProducto.ForeColor = System.Drawing.Color.White;
            this.LblAgregarTipoProducto.Location = new System.Drawing.Point(20, 25);
            this.LblAgregarTipoProducto.Name = "LblAgregarTipoProducto";
            this.LblAgregarTipoProducto.Size = new System.Drawing.Size(358, 30);
            this.LblAgregarTipoProducto.TabIndex = 1;
            this.LblAgregarTipoProducto.Text = "AGREGAR TIPO DE PRODUCTO";
            // 
            // PbxCerrarForm
            // 
            this.PbxCerrarForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbxCerrarForm.Image = ((System.Drawing.Image)(resources.GetObject("PbxCerrarForm.Image")));
            this.PbxCerrarForm.Location = new System.Drawing.Point(731, 22);
            this.PbxCerrarForm.Name = "PbxCerrarForm";
            this.PbxCerrarForm.Size = new System.Drawing.Size(35, 29);
            this.PbxCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxCerrarForm.TabIndex = 11;
            this.PbxCerrarForm.TabStop = false;
            this.PbxCerrarForm.Click += new System.EventHandler(this.PbxCerrarForm_Click);
            // 
            // LblGuionBajo
            // 
            this.LblGuionBajo.AutoSize = true;
            this.LblGuionBajo.Location = new System.Drawing.Point(73, 241);
            this.LblGuionBajo.Name = "LblGuionBajo";
            this.LblGuionBajo.Size = new System.Drawing.Size(273, 16);
            this.LblGuionBajo.TabIndex = 52;
            this.LblGuionBajo.Text = "______________________________________";
            // 
            // AgregarTipoProducto
            // 
            this.AcceptButton = this.BtnAgregarTipoProducto;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.CbxCategoriaTipoProducto);
            this.Controls.Add(this.LblCategoriaTipoProducto);
            this.Controls.Add(this.BtnAgregarTipoProducto);
            this.Controls.Add(this.TbxTipoProducto);
            this.Controls.Add(this.LblTipoProducto);
            this.Controls.Add(this.LblGuionBajo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarTipoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar tipo de producto";
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxCategoriaTipoProducto;
        private System.Windows.Forms.Label LblCategoriaTipoProducto;
        private System.Windows.Forms.Button BtnAgregarTipoProducto;
        private System.Windows.Forms.TextBox TbxTipoProducto;
        private System.Windows.Forms.Label LblTipoProducto;
        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.PictureBox PbxNombreEmpresa;
        private System.Windows.Forms.Label LblAgregarTipoProducto;
        private System.Windows.Forms.PictureBox PbxCerrarForm;
        private System.Windows.Forms.Label LblGuionBajo;
    }
}