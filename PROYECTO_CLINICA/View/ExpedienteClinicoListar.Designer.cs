namespace PROYECTO_CLINICA.View
{
    partial class ExpedienteClinicoListar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpedienteClinicoListar));
            this.dgvDatosExpediente = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltroExpediente = new System.Windows.Forms.TextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosExpediente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosExpediente
            // 
            this.dgvDatosExpediente.AllowUserToAddRows = false;
            this.dgvDatosExpediente.AllowUserToDeleteRows = false;
            this.dgvDatosExpediente.AllowUserToOrderColumns = true;
            this.dgvDatosExpediente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatosExpediente.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatosExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosExpediente.Location = new System.Drawing.Point(11, 172);
            this.dgvDatosExpediente.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatosExpediente.Name = "dgvDatosExpediente";
            this.dgvDatosExpediente.ReadOnly = true;
            this.dgvDatosExpediente.RowHeadersWidth = 62;
            this.dgvDatosExpediente.RowTemplate.Height = 28;
            this.dgvDatosExpediente.Size = new System.Drawing.Size(843, 196);
            this.dgvDatosExpediente.TabIndex = 0;
            this.dgvDatosExpediente.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDatosExpediente_RowHeaderMouseDoubleClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.YellowGreen;
            this.btnNuevo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(532, 130);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(103, 37);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Filtrar Expediente por cod Paciente";
            // 
            // txtFiltroExpediente
            // 
            this.txtFiltroExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroExpediente.Location = new System.Drawing.Point(16, 126);
            this.txtFiltroExpediente.Name = "txtFiltroExpediente";
            this.txtFiltroExpediente.Size = new System.Drawing.Size(343, 26);
            this.txtFiltroExpediente.TabIndex = 45;
            this.txtFiltroExpediente.TextChanged += new System.EventHandler(this.txtFiltroExpediente_TextChanged);
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(641, 130);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(97, 37);
            this.btnReporte.TabIndex = 44;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(744, 130);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 37);
            this.btnEliminar.TabIndex = 47;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(785, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Navy;
            this.label29.Location = new System.Drawing.Point(-291, 67);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(1186, 13);
            this.label29.TabIndex = 74;
            this.label29.Text = resources.GetString("label29.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(-195, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1186, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(-321, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1186, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.Location = new System.Drawing.Point(272, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 55);
            this.label4.TabIndex = 81;
            this.label4.Text = "EXPEDIENTE";
            // 
            // ExpedienteClinicoListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(859, 399);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltroExpediente);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvDatosExpediente);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExpedienteClinicoListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpedienteClinicoListar";
            this.Load += new System.EventHandler(this.ExpedienteClinicoListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosExpediente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosExpediente;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltroExpediente;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}