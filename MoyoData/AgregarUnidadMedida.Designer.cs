namespace MoyoData
{
    partial class AgregarUnidadMedida
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
            this.BtnAgregarUnidadMedida = new System.Windows.Forms.Button();
            this.TbxUnidadMedida = new System.Windows.Forms.TextBox();
            this.LblUnidadMedida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAgregarUnidadMedida
            // 
            this.BtnAgregarUnidadMedida.Location = new System.Drawing.Point(103, 153);
            this.BtnAgregarUnidadMedida.Name = "BtnAgregarUnidadMedida";
            this.BtnAgregarUnidadMedida.Size = new System.Drawing.Size(134, 42);
            this.BtnAgregarUnidadMedida.TabIndex = 5;
            this.BtnAgregarUnidadMedida.Text = "Agregar";
            this.BtnAgregarUnidadMedida.UseVisualStyleBackColor = true;
            this.BtnAgregarUnidadMedida.Click += new System.EventHandler(this.BtnAgregarUnidadMedida_Click);
            // 
            // TbxUnidadMedida
            // 
            this.TbxUnidadMedida.Location = new System.Drawing.Point(56, 88);
            this.TbxUnidadMedida.Name = "TbxUnidadMedida";
            this.TbxUnidadMedida.Size = new System.Drawing.Size(233, 22);
            this.TbxUnidadMedida.TabIndex = 4;
            // 
            // LblUnidadMedida
            // 
            this.LblUnidadMedida.AutoSize = true;
            this.LblUnidadMedida.Location = new System.Drawing.Point(53, 50);
            this.LblUnidadMedida.Name = "LblUnidadMedida";
            this.LblUnidadMedida.Size = new System.Drawing.Size(97, 16);
            this.LblUnidadMedida.TabIndex = 3;
            this.LblUnidadMedida.Text = "UnidadMedida";
            // 
            // AgregarUnidadMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnAgregarUnidadMedida);
            this.Controls.Add(this.TbxUnidadMedida);
            this.Controls.Add(this.LblUnidadMedida);
            this.Name = "AgregarUnidadMedida";
            this.Text = "AgregarUnidadMedida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAgregarUnidadMedida;
        private System.Windows.Forms.TextBox TbxUnidadMedida;
        private System.Windows.Forms.Label LblUnidadMedida;
    }
}