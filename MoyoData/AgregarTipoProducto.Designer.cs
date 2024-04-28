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
            this.CbxCategoriaTipoProducto = new System.Windows.Forms.ComboBox();
            this.LblCategoriaTipoProducto = new System.Windows.Forms.Label();
            this.BtnAgregarTipoProducto = new System.Windows.Forms.Button();
            this.TbxTipoProducto = new System.Windows.Forms.TextBox();
            this.LblTipoProducto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CbxCategoriaTipoProducto
            // 
            this.CbxCategoriaTipoProducto.FormattingEnabled = true;
            this.CbxCategoriaTipoProducto.Location = new System.Drawing.Point(431, 93);
            this.CbxCategoriaTipoProducto.Name = "CbxCategoriaTipoProducto";
            this.CbxCategoriaTipoProducto.Size = new System.Drawing.Size(261, 24);
            this.CbxCategoriaTipoProducto.TabIndex = 12;
            // 
            // LblCategoriaTipoProducto
            // 
            this.LblCategoriaTipoProducto.AutoSize = true;
            this.LblCategoriaTipoProducto.Location = new System.Drawing.Point(428, 58);
            this.LblCategoriaTipoProducto.Name = "LblCategoriaTipoProducto";
            this.LblCategoriaTipoProducto.Size = new System.Drawing.Size(66, 16);
            this.LblCategoriaTipoProducto.TabIndex = 11;
            this.LblCategoriaTipoProducto.Text = "Categoría";
            // 
            // BtnAgregarTipoProducto
            // 
            this.BtnAgregarTipoProducto.Location = new System.Drawing.Point(319, 271);
            this.BtnAgregarTipoProducto.Name = "BtnAgregarTipoProducto";
            this.BtnAgregarTipoProducto.Size = new System.Drawing.Size(134, 42);
            this.BtnAgregarTipoProducto.TabIndex = 10;
            this.BtnAgregarTipoProducto.Text = "Agregar";
            this.BtnAgregarTipoProducto.UseVisualStyleBackColor = true;
            this.BtnAgregarTipoProducto.Click += new System.EventHandler(this.BtnAgregarTipoProducto_Click);
            // 
            // TbxTipoProducto
            // 
            this.TbxTipoProducto.Location = new System.Drawing.Point(39, 96);
            this.TbxTipoProducto.Name = "TbxTipoProducto";
            this.TbxTipoProducto.Size = new System.Drawing.Size(233, 22);
            this.TbxTipoProducto.TabIndex = 9;
            // 
            // LblTipoProducto
            // 
            this.LblTipoProducto.AutoSize = true;
            this.LblTipoProducto.Location = new System.Drawing.Point(36, 58);
            this.LblTipoProducto.Name = "LblTipoProducto";
            this.LblTipoProducto.Size = new System.Drawing.Size(92, 16);
            this.LblTipoProducto.TabIndex = 8;
            this.LblTipoProducto.Text = "Tipo Producto";
            // 
            // AgregarTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CbxCategoriaTipoProducto);
            this.Controls.Add(this.LblCategoriaTipoProducto);
            this.Controls.Add(this.BtnAgregarTipoProducto);
            this.Controls.Add(this.TbxTipoProducto);
            this.Controls.Add(this.LblTipoProducto);
            this.Name = "AgregarTipoProducto";
            this.Text = "AgregarTipoProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxCategoriaTipoProducto;
        private System.Windows.Forms.Label LblCategoriaTipoProducto;
        private System.Windows.Forms.Button BtnAgregarTipoProducto;
        private System.Windows.Forms.TextBox TbxTipoProducto;
        private System.Windows.Forms.Label LblTipoProducto;
    }
}