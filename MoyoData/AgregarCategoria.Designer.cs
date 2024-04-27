namespace MoyoData
{
    partial class AgregarCategoria
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
            this.BtnActualizarCategoria = new System.Windows.Forms.Button();
            this.TbxCategoria = new System.Windows.Forms.TextBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnActualizarCategoria
            // 
            this.BtnActualizarCategoria.Location = new System.Drawing.Point(322, 247);
            this.BtnActualizarCategoria.Name = "BtnActualizarCategoria";
            this.BtnActualizarCategoria.Size = new System.Drawing.Size(134, 42);
            this.BtnActualizarCategoria.TabIndex = 8;
            this.BtnActualizarCategoria.Text = "Actualizar";
            this.BtnActualizarCategoria.UseVisualStyleBackColor = true;
            this.BtnActualizarCategoria.Click += new System.EventHandler(this.BtnActualizarCategoria_Click);
            // 
            // TbxCategoria
            // 
            this.TbxCategoria.Location = new System.Drawing.Point(275, 182);
            this.TbxCategoria.Name = "TbxCategoria";
            this.TbxCategoria.Size = new System.Drawing.Size(233, 22);
            this.TbxCategoria.TabIndex = 7;
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(272, 144);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(66, 16);
            this.LblCategoria.TabIndex = 6;
            this.LblCategoria.Text = "Categoria";
            // 
            // AgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnActualizarCategoria);
            this.Controls.Add(this.TbxCategoria);
            this.Controls.Add(this.LblCategoria);
            this.Name = "AgregarCategoria";
            this.Text = "AgregarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnActualizarCategoria;
        private System.Windows.Forms.TextBox TbxCategoria;
        private System.Windows.Forms.Label LblCategoria;
    }
}