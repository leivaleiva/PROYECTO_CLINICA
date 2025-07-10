namespace PROYECTO_CLINICA.View
{
    partial class Catalogo_Medicamentos_Listar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogo_Medicamentos_Listar));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.DGVMedicamentos = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label17 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedicamentos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(776, 425);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 46);
            this.btnEliminar.TabIndex = 43;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Filtrar Medicamento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(11, 67);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(343, 26);
            this.txtFiltro.TabIndex = 41;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Location = new System.Drawing.Point(666, 425);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(104, 46);
            this.btnReporte.TabIndex = 40;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // DGVMedicamentos
            // 
            this.DGVMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMedicamentos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DGVMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMedicamentos.Location = new System.Drawing.Point(7, 118);
            this.DGVMedicamentos.Name = "DGVMedicamentos";
            this.DGVMedicamentos.RowHeadersWidth = 62;
            this.DGVMedicamentos.Size = new System.Drawing.Size(875, 301);
            this.DGVMedicamentos.TabIndex = 38;
            this.DGVMedicamentos.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVMedicamentos_RowHeaderMouseDoubleClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.YellowGreen;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(554, 425);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(106, 46);
            this.btnNuevo.TabIndex = 37;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(894, 30);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // iNICIOToolStripMenuItem
            // 
            this.iNICIOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("iNICIOToolStripMenuItem.Image")));
            this.iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            this.iNICIOToolStripMenuItem.Size = new System.Drawing.Size(78, 28);
            this.iNICIOToolStripMenuItem.Text = "INICIO";
            this.iNICIOToolStripMenuItem.Click += new System.EventHandler(this.iNICIOToolStripMenuItem_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(2, 517);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(892, 13);
            this.label17.TabIndex = 148;
            this.label17.Text = resources.GetString("label17.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(-39, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1006, 13);
            this.label3.TabIndex = 149;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Catalogo_Medicamentos_Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(894, 527);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.DGVMedicamentos);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Catalogo_Medicamentos_Listar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo_Medicamentos_Listar";
            this.Load += new System.EventHandler(this.Catalogo_Medicamentos_Listar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedicamentos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.DataGridView DGVMedicamentos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label3;
    }
}