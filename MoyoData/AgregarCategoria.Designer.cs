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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCategoria));
            this.BtnActualizarCategoria = new System.Windows.Forms.Button();
            this.TbxCategoria = new System.Windows.Forms.TextBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.PbxNombreEmpresa = new System.Windows.Forms.PictureBox();
            this.LblAgregarCategoria = new System.Windows.Forms.Label();
            this.PbxCerrarForm = new System.Windows.Forms.PictureBox();
            this.LblGuionBajo = new System.Windows.Forms.Label();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnActualizarCategoria
            // 
            this.BtnActualizarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.BtnActualizarCategoria.FlatAppearance.BorderSize = 0;
            this.BtnActualizarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizarCategoria.Font = new System.Drawing.Font("Rosario", 10F, System.Drawing.FontStyle.Bold);
            this.BtnActualizarCategoria.Location = new System.Drawing.Point(341, 292);
            this.BtnActualizarCategoria.Name = "BtnActualizarCategoria";
            this.BtnActualizarCategoria.Size = new System.Drawing.Size(134, 42);
            this.BtnActualizarCategoria.TabIndex = 8;
            this.BtnActualizarCategoria.Text = "Actualizar";
            this.BtnActualizarCategoria.UseVisualStyleBackColor = false;
            this.BtnActualizarCategoria.Click += new System.EventHandler(this.BtnActualizarCategoria_Click);
            // 
            // TbxCategoria
            // 
            this.TbxCategoria.BackColor = System.Drawing.Color.White;
            this.TbxCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxCategoria.Font = new System.Drawing.Font("Rosario", 10F);
            this.TbxCategoria.ForeColor = System.Drawing.Color.DimGray;
            this.TbxCategoria.Location = new System.Drawing.Point(281, 219);
            this.TbxCategoria.MaxLength = 45;
            this.TbxCategoria.Name = "TbxCategoria";
            this.TbxCategoria.ShortcutsEnabled = false;
            this.TbxCategoria.Size = new System.Drawing.Size(256, 21);
            this.TbxCategoria.TabIndex = 7;
            this.TbxCategoria.Text = "Escribe aquí";
            this.TbxCategoria.Enter += new System.EventHandler(this.TbxCategoria_Enter);
            this.TbxCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxCategoria_KeyPress);
            this.TbxCategoria.Leave += new System.EventHandler(this.TbxCategoria_Leave);
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.Location = new System.Drawing.Point(347, 170);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(114, 31);
            this.LblCategoria.TabIndex = 6;
            this.LblCategoria.Text = "Categoría";
            // 
            // PnlTitulo
            // 
            this.PnlTitulo.BackColor = System.Drawing.Color.Maroon;
            this.PnlTitulo.Controls.Add(this.PbxNombreEmpresa);
            this.PnlTitulo.Controls.Add(this.LblAgregarCategoria);
            this.PnlTitulo.Controls.Add(this.PbxCerrarForm);
            this.PnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.PnlTitulo.Name = "PnlTitulo";
            this.PnlTitulo.Size = new System.Drawing.Size(800, 73);
            this.PnlTitulo.TabIndex = 50;
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
            // LblAgregarCategoria
            // 
            this.LblAgregarCategoria.AutoSize = true;
            this.LblAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblAgregarCategoria.Font = new System.Drawing.Font("Roboto", 19F, System.Drawing.FontStyle.Bold);
            this.LblAgregarCategoria.Location = new System.Drawing.Point(20, 19);
            this.LblAgregarCategoria.Name = "LblAgregarCategoria";
            this.LblAgregarCategoria.Size = new System.Drawing.Size(345, 38);
            this.LblAgregarCategoria.TabIndex = 1;
            this.LblAgregarCategoria.Text = "AGREGAR CATEGORÍA";
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
            this.LblGuionBajo.Location = new System.Drawing.Point(278, 228);
            this.LblGuionBajo.Name = "LblGuionBajo";
            this.LblGuionBajo.Size = new System.Drawing.Size(273, 16);
            this.LblGuionBajo.TabIndex = 51;
            this.LblGuionBajo.Text = "______________________________________";
            // 
            // AgregarCategoria
            // 
            this.AcceptButton = this.BtnActualizarCategoria;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.BtnActualizarCategoria);
            this.Controls.Add(this.TbxCategoria);
            this.Controls.Add(this.LblCategoria);
            this.Controls.Add(this.LblGuionBajo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarCategoria";
            this.Text = "AgregarCategoria";
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnActualizarCategoria;
        private System.Windows.Forms.TextBox TbxCategoria;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.PictureBox PbxNombreEmpresa;
        private System.Windows.Forms.Label LblAgregarCategoria;
        private System.Windows.Forms.PictureBox PbxCerrarForm;
        private System.Windows.Forms.Label LblGuionBajo;
    }
}