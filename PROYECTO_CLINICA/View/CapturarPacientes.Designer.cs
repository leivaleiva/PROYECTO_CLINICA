namespace PROYECTO_CLINICA.View
{
    partial class CapturarPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CapturarPacientes));
            this.dgvPacienteExpecifico = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUbicar = new System.Windows.Forms.TextBox();
            this.btnImprimirReceta = new System.Windows.Forms.Button();
            this.btnEliminarReceta = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienteExpecifico)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPacienteExpecifico
            // 
            this.dgvPacienteExpecifico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacienteExpecifico.Location = new System.Drawing.Point(8, 20);
            this.dgvPacienteExpecifico.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPacienteExpecifico.Name = "dgvPacienteExpecifico";
            this.dgvPacienteExpecifico.RowHeadersWidth = 62;
            this.dgvPacienteExpecifico.RowTemplate.Height = 28;
            this.dgvPacienteExpecifico.Size = new System.Drawing.Size(795, 275);
            this.dgvPacienteExpecifico.TabIndex = 0;
            this.dgvPacienteExpecifico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacienteExpecifico_CellClick);
            this.dgvPacienteExpecifico.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPacienteExpecifico_RowHeaderMouseClick);
            this.dgvPacienteExpecifico.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPacienteExpecifico_RowHeaderMouseDoubleClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAgregar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(379, 448);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(134, 32);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPacienteExpecifico);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 138);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(823, 306);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar pacientes y Generar Recetas";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightYellow;
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(468, 77);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 56);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(39, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Buscar Receta del Paciente por Fecha";
            // 
            // txtUbicar
            // 
            this.txtUbicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicar.Location = new System.Drawing.Point(43, 99);
            this.txtUbicar.Name = "txtUbicar";
            this.txtUbicar.Size = new System.Drawing.Size(373, 26);
            this.txtUbicar.TabIndex = 32;
            this.txtUbicar.TextChanged += new System.EventHandler(this.txtUbicar_TextChanged);
            // 
            // btnImprimirReceta
            // 
            this.btnImprimirReceta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnImprimirReceta.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirReceta.Location = new System.Drawing.Point(54, 448);
            this.btnImprimirReceta.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimirReceta.Name = "btnImprimirReceta";
            this.btnImprimirReceta.Size = new System.Drawing.Size(111, 32);
            this.btnImprimirReceta.TabIndex = 35;
            this.btnImprimirReceta.Text = "Imprimir Receta";
            this.btnImprimirReceta.UseVisualStyleBackColor = false;
            this.btnImprimirReceta.Click += new System.EventHandler(this.btnImprimirReceta_Click);
            // 
            // btnEliminarReceta
            // 
            this.btnEliminarReceta.BackColor = System.Drawing.Color.Red;
            this.btnEliminarReceta.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarReceta.Location = new System.Drawing.Point(691, 448);
            this.btnEliminarReceta.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarReceta.Name = "btnEliminarReceta";
            this.btnEliminarReceta.Size = new System.Drawing.Size(127, 32);
            this.btnEliminarReceta.TabIndex = 36;
            this.btnEliminarReceta.Text = "Eliminar Receta";
            this.btnEliminarReceta.UseVisualStyleBackColor = false;
            this.btnEliminarReceta.Click += new System.EventHandler(this.btnEliminarReceta_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(865, 30);
            this.menuStrip1.TabIndex = 37;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(-3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1006, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(-14, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1006, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // CapturarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(865, 542);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarReceta);
            this.Controls.Add(this.btnImprimirReceta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUbicar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CapturarPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapturarPacientes";
            this.Load += new System.EventHandler(this.CapturarPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienteExpecifico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPacienteExpecifico;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUbicar;
        private System.Windows.Forms.Button btnImprimirReceta;
        private System.Windows.Forms.Button btnEliminarReceta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}