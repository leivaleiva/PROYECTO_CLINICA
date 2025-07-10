namespace PROYECTO_CLINICA.View
{
    partial class PacientesLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacientesLista));
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.BTNReporte = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUbicar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXAMENESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rECEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eNFERMEDADESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXPEDIENTECLINICOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVDatos
            // 
            this.DGVDatos.AllowUserToAddRows = false;
            this.DGVDatos.AllowUserToDeleteRows = false;
            this.DGVDatos.AllowUserToOrderColumns = true;
            this.DGVDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DGVDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.Location = new System.Drawing.Point(15, 186);
            this.DGVDatos.Margin = new System.Windows.Forms.Padding(2);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.ReadOnly = true;
            this.DGVDatos.RowHeadersWidth = 62;
            this.DGVDatos.RowTemplate.Height = 28;
            this.DGVDatos.Size = new System.Drawing.Size(958, 127);
            this.DGVDatos.TabIndex = 0;
            this.DGVDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDatos_CellClick);
            this.DGVDatos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVDatos_RowHeaderMouseClick);
            this.DGVDatos.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVDatos_RowHeaderMouseDoubleClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.YellowGreen;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(670, 135);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(104, 31);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // BTNReporte
            // 
            this.BTNReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTNReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNReporte.Location = new System.Drawing.Point(779, 136);
            this.BTNReporte.Name = "BTNReporte";
            this.BTNReporte.Size = new System.Drawing.Size(104, 30);
            this.BTNReporte.TabIndex = 28;
            this.BTNReporte.Text = "Reportes";
            this.BTNReporte.UseVisualStyleBackColor = false;
            this.BTNReporte.Click += new System.EventHandler(this.BTNReporte_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.BackColor = System.Drawing.Color.Red;
            this.BTNEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNEliminar.Location = new System.Drawing.Point(890, 136);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(103, 30);
            this.BTNEliminar.TabIndex = 26;
            this.BTNEliminar.Text = "  Eliminar";
            this.BTNEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNEliminar.UseVisualStyleBackColor = false;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(20, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Filtrar Paciente por DNI    ";
            // 
            // txtUbicar
            // 
            this.txtUbicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicar.Location = new System.Drawing.Point(12, 140);
            this.txtUbicar.Name = "txtUbicar";
            this.txtUbicar.Size = new System.Drawing.Size(233, 26);
            this.txtUbicar.TabIndex = 29;
            this.txtUbicar.TextChanged += new System.EventHandler(this.txtUbicar_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(250, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 31;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIOToolStripMenuItem,
            this.eXAMENESToolStripMenuItem,
            this.rECEToolStripMenuItem,
            this.eNFERMEDADESToolStripMenuItem,
            this.eXPEDIENTECLINICOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(993, 30);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            this.iNICIOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("iNICIOToolStripMenuItem.Image")));
            this.iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            this.iNICIOToolStripMenuItem.Size = new System.Drawing.Size(78, 28);
            this.iNICIOToolStripMenuItem.Text = "INICIO";
            this.iNICIOToolStripMenuItem.Click += new System.EventHandler(this.iNICIOToolStripMenuItem_Click);
            // 
            // eXAMENESToolStripMenuItem
            // 
            this.eXAMENESToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eXAMENESToolStripMenuItem.Image")));
            this.eXAMENESToolStripMenuItem.Name = "eXAMENESToolStripMenuItem";
            this.eXAMENESToolStripMenuItem.Size = new System.Drawing.Size(102, 28);
            this.eXAMENESToolStripMenuItem.Text = "EXAMENES";
            this.eXAMENESToolStripMenuItem.Click += new System.EventHandler(this.eXAMENESToolStripMenuItem_Click);
            // 
            // rECEToolStripMenuItem
            // 
            this.rECEToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rECEToolStripMenuItem.Image")));
            this.rECEToolStripMenuItem.Name = "rECEToolStripMenuItem";
            this.rECEToolStripMenuItem.Size = new System.Drawing.Size(90, 28);
            this.rECEToolStripMenuItem.Text = "RECETAS";
            this.rECEToolStripMenuItem.Click += new System.EventHandler(this.rECEToolStripMenuItem_Click);
            // 
            // eNFERMEDADESToolStripMenuItem
            // 
            this.eNFERMEDADESToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eNFERMEDADESToolStripMenuItem.Image")));
            this.eNFERMEDADESToolStripMenuItem.Name = "eNFERMEDADESToolStripMenuItem";
            this.eNFERMEDADESToolStripMenuItem.Size = new System.Drawing.Size(130, 28);
            this.eNFERMEDADESToolStripMenuItem.Text = "ENFERMEDADES";
            this.eNFERMEDADESToolStripMenuItem.Click += new System.EventHandler(this.eNFERMEDADESToolStripMenuItem_Click);
            // 
            // eXPEDIENTECLINICOToolStripMenuItem
            // 
            this.eXPEDIENTECLINICOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eXPEDIENTECLINICOToolStripMenuItem.Image")));
            this.eXPEDIENTECLINICOToolStripMenuItem.Name = "eXPEDIENTECLINICOToolStripMenuItem";
            this.eXPEDIENTECLINICOToolStripMenuItem.Size = new System.Drawing.Size(157, 28);
            this.eXPEDIENTECLINICOToolStripMenuItem.Text = "EXPEDIENTE CLINICO";
            this.eXPEDIENTECLINICOToolStripMenuItem.Click += new System.EventHandler(this.eXPEDIENTECLINICOToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(258, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 55);
            this.label1.TabIndex = 33;
            this.label1.Text = "Catalogo de Pacientes";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Navy;
            this.label29.Location = new System.Drawing.Point(-83, 30);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(1186, 13);
            this.label29.TabIndex = 71;
            this.label29.Text = resources.GetString("label29.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(-83, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1186, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // PacientesLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(993, 530);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUbicar);
            this.Controls.Add(this.BTNReporte);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.DGVDatos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PacientesLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PacientesLista";
            this.Load += new System.EventHandler(this.PacientesLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button BTNReporte;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUbicar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXAMENESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rECEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eNFERMEDADESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXPEDIENTECLINICOToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label3;
    }
}