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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarUnidadMedida));
            this.LblUnidadMedida = new System.Windows.Forms.Label();
            this.BtnActualizarUnidadMedida = new System.Windows.Forms.Button();
            this.PnlTitulo = new System.Windows.Forms.Panel();
            this.PbxNombreEmpresa = new System.Windows.Forms.PictureBox();
            this.LblAgregarCategoria = new System.Windows.Forms.Label();
            this.PbxCerrarForm = new System.Windows.Forms.PictureBox();
            this.TbxUnidadMedida = new System.Windows.Forms.TextBox();
            this.LblGuionBajo = new System.Windows.Forms.Label();
            this.PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).BeginInit();
            this.SuspendLayout();
            // 
            // LblUnidadMedida
            // 
            this.LblUnidadMedida.AutoSize = true;
            this.LblUnidadMedida.Font = new System.Drawing.Font("Rosario", 15F, System.Drawing.FontStyle.Bold);
            this.LblUnidadMedida.Location = new System.Drawing.Point(297, 165);
            this.LblUnidadMedida.Name = "LblUnidadMedida";
            this.LblUnidadMedida.Size = new System.Drawing.Size(210, 36);
            this.LblUnidadMedida.TabIndex = 0;
            this.LblUnidadMedida.Text = "Unidad de medida";
            // 
            // BtnActualizarUnidadMedida
            // 
            this.BtnActualizarUnidadMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(20)))));
            this.BtnActualizarUnidadMedida.FlatAppearance.BorderSize = 0;
            this.BtnActualizarUnidadMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizarUnidadMedida.Font = new System.Drawing.Font("Rosario", 10F, System.Drawing.FontStyle.Bold);
            this.BtnActualizarUnidadMedida.ForeColor = System.Drawing.Color.White;
            this.BtnActualizarUnidadMedida.Location = new System.Drawing.Point(335, 286);
            this.BtnActualizarUnidadMedida.Name = "BtnActualizarUnidadMedida";
            this.BtnActualizarUnidadMedida.Size = new System.Drawing.Size(134, 42);
            this.BtnActualizarUnidadMedida.TabIndex = 2;
            this.BtnActualizarUnidadMedida.Text = "Actualizar";
            this.BtnActualizarUnidadMedida.UseVisualStyleBackColor = false;
            this.BtnActualizarUnidadMedida.Click += new System.EventHandler(this.BtnActualizarUnidadMedida_Click);
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
            // LblAgregarCategoria
            // 
            this.LblAgregarCategoria.AutoSize = true;
            this.LblAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblAgregarCategoria.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAgregarCategoria.ForeColor = System.Drawing.Color.White;
            this.LblAgregarCategoria.Location = new System.Drawing.Point(20, 24);
            this.LblAgregarCategoria.Name = "LblAgregarCategoria";
            this.LblAgregarCategoria.Size = new System.Drawing.Size(369, 34);
            this.LblAgregarCategoria.TabIndex = 1;
            this.LblAgregarCategoria.Text = "EDITAR UNIDAD DE MEDIDA";
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
            // TbxUnidadMedida
            // 
            this.TbxUnidadMedida.BackColor = System.Drawing.Color.White;
            this.TbxUnidadMedida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxUnidadMedida.Font = new System.Drawing.Font("Rosario", 10F);
            this.TbxUnidadMedida.ForeColor = System.Drawing.Color.DimGray;
            this.TbxUnidadMedida.Location = new System.Drawing.Point(284, 220);
            this.TbxUnidadMedida.MaxLength = 30;
            this.TbxUnidadMedida.Name = "TbxUnidadMedida";
            this.TbxUnidadMedida.ShortcutsEnabled = false;
            this.TbxUnidadMedida.Size = new System.Drawing.Size(256, 21);
            this.TbxUnidadMedida.TabIndex = 52;
            this.TbxUnidadMedida.Text = "Escribe aquí";
            this.TbxUnidadMedida.Enter += new System.EventHandler(this.TbxUnidadMedida_Enter);
            this.TbxUnidadMedida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxUnidadMedida_KeyPress);
            this.TbxUnidadMedida.Leave += new System.EventHandler(this.TbxUnidadMedida_Leave);
            // 
            // LblGuionBajo
            // 
            this.LblGuionBajo.AutoSize = true;
            this.LblGuionBajo.Location = new System.Drawing.Point(281, 229);
            this.LblGuionBajo.Name = "LblGuionBajo";
            this.LblGuionBajo.Size = new System.Drawing.Size(273, 16);
            this.LblGuionBajo.TabIndex = 53;
            this.LblGuionBajo.Text = "______________________________________";
            // 
            // EditarUnidadMedida
            // 
            this.AcceptButton = this.BtnActualizarUnidadMedida;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbxUnidadMedida);
            this.Controls.Add(this.LblGuionBajo);
            this.Controls.Add(this.PnlTitulo);
            this.Controls.Add(this.BtnActualizarUnidadMedida);
            this.Controls.Add(this.LblUnidadMedida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditarUnidadMedida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar unidad de medida";
            this.PnlTitulo.ResumeLayout(false);
            this.PnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxNombreEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxCerrarForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUnidadMedida;
        private System.Windows.Forms.Button BtnActualizarUnidadMedida;
        private System.Windows.Forms.Panel PnlTitulo;
        private System.Windows.Forms.PictureBox PbxNombreEmpresa;
        private System.Windows.Forms.Label LblAgregarCategoria;
        private System.Windows.Forms.PictureBox PbxCerrarForm;
        private System.Windows.Forms.TextBox TbxUnidadMedida;
        private System.Windows.Forms.Label LblGuionBajo;
    }
}