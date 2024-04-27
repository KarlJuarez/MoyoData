namespace MoyoData
{
    partial class EditarTipoProducto
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
            this.BtnActualizarTipoProducto = new System.Windows.Forms.Button();
            this.TbxTipoProducto = new System.Windows.Forms.TextBox();
            this.LblTipoProducto = new System.Windows.Forms.Label();
            this.LblCategoriaTipoProducto = new System.Windows.Forms.Label();
            this.CbxCategoriaTipoProducto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnActualizarTipoProducto
            // 
            this.BtnActualizarTipoProducto.Location = new System.Drawing.Point(332, 256);
            this.BtnActualizarTipoProducto.Name = "BtnActualizarTipoProducto";
            this.BtnActualizarTipoProducto.Size = new System.Drawing.Size(134, 42);
            this.BtnActualizarTipoProducto.TabIndex = 5;
            this.BtnActualizarTipoProducto.Text = "Actualizar";
            this.BtnActualizarTipoProducto.UseVisualStyleBackColor = true;
            this.BtnActualizarTipoProducto.Click += new System.EventHandler(this.BtnActualizarTipoProducto_Click);
            // 
            // TbxTipoProducto
            // 
            this.TbxTipoProducto.Location = new System.Drawing.Point(52, 81);
            this.TbxTipoProducto.Name = "TbxTipoProducto";
            this.TbxTipoProducto.Size = new System.Drawing.Size(233, 22);
            this.TbxTipoProducto.TabIndex = 4;
            // 
            // LblTipoProducto
            // 
            this.LblTipoProducto.AutoSize = true;
            this.LblTipoProducto.Location = new System.Drawing.Point(49, 43);
            this.LblTipoProducto.Name = "LblTipoProducto";
            this.LblTipoProducto.Size = new System.Drawing.Size(92, 16);
            this.LblTipoProducto.TabIndex = 3;
            this.LblTipoProducto.Text = "Tipo Producto";
            // 
            // LblCategoriaTipoProducto
            // 
            this.LblCategoriaTipoProducto.AutoSize = true;
            this.LblCategoriaTipoProducto.Location = new System.Drawing.Point(441, 43);
            this.LblCategoriaTipoProducto.Name = "LblCategoriaTipoProducto";
            this.LblCategoriaTipoProducto.Size = new System.Drawing.Size(66, 16);
            this.LblCategoriaTipoProducto.TabIndex = 6;
            this.LblCategoriaTipoProducto.Text = "Categoría";
            // 
            // CbxCategoriaTipoProducto
            // 
            this.CbxCategoriaTipoProducto.FormattingEnabled = true;
            this.CbxCategoriaTipoProducto.Location = new System.Drawing.Point(444, 78);
            this.CbxCategoriaTipoProducto.Name = "CbxCategoriaTipoProducto";
            this.CbxCategoriaTipoProducto.Size = new System.Drawing.Size(261, 24);
            this.CbxCategoriaTipoProducto.TabIndex = 7;
            // 
            // EditarTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CbxCategoriaTipoProducto);
            this.Controls.Add(this.LblCategoriaTipoProducto);
            this.Controls.Add(this.BtnActualizarTipoProducto);
            this.Controls.Add(this.TbxTipoProducto);
            this.Controls.Add(this.LblTipoProducto);
            this.Name = "EditarTipoProducto";
            this.Text = "EditarTipoProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnActualizarTipoProducto;
        private System.Windows.Forms.TextBox TbxTipoProducto;
        private System.Windows.Forms.Label LblTipoProducto;
        private System.Windows.Forms.Label LblCategoriaTipoProducto;
        private System.Windows.Forms.ComboBox CbxCategoriaTipoProducto;
    }
}