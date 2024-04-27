namespace MoyoData
{
    partial class EditarUnidadMedida
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
            this.LblUnidadMedida = new System.Windows.Forms.Label();
            this.TbxUnidadMedida = new System.Windows.Forms.TextBox();
            this.BtnActualizarUnidadMedida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblUnidadMedida
            // 
            this.LblUnidadMedida.AutoSize = true;
            this.LblUnidadMedida.Location = new System.Drawing.Point(76, 59);
            this.LblUnidadMedida.Name = "LblUnidadMedida";
            this.LblUnidadMedida.Size = new System.Drawing.Size(100, 16);
            this.LblUnidadMedida.TabIndex = 0;
            this.LblUnidadMedida.Text = "Unidad Medida";
            // 
            // TbxUnidadMedida
            // 
            this.TbxUnidadMedida.Location = new System.Drawing.Point(79, 97);
            this.TbxUnidadMedida.Name = "TbxUnidadMedida";
            this.TbxUnidadMedida.Size = new System.Drawing.Size(233, 22);
            this.TbxUnidadMedida.TabIndex = 1;
            // 
            // BtnActualizarUnidadMedida
            // 
            this.BtnActualizarUnidadMedida.Location = new System.Drawing.Point(126, 162);
            this.BtnActualizarUnidadMedida.Name = "BtnActualizarUnidadMedida";
            this.BtnActualizarUnidadMedida.Size = new System.Drawing.Size(134, 42);
            this.BtnActualizarUnidadMedida.TabIndex = 2;
            this.BtnActualizarUnidadMedida.Text = "Actualizar";
            this.BtnActualizarUnidadMedida.UseVisualStyleBackColor = true;
            this.BtnActualizarUnidadMedida.Click += new System.EventHandler(this.BtnActualizarUnidadMedida_Click);
            // 
            // EditarUnidadMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnActualizarUnidadMedida);
            this.Controls.Add(this.TbxUnidadMedida);
            this.Controls.Add(this.LblUnidadMedida);
            this.Name = "EditarUnidadMedida";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUnidadMedida;
        private System.Windows.Forms.TextBox TbxUnidadMedida;
        private System.Windows.Forms.Button BtnActualizarUnidadMedida;
    }
}