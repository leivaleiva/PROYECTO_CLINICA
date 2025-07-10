namespace PROYECTO_CLINICA.View
{
    partial class DoctoresCrear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctoresCrear));
            this.comboBoxEspecialidad = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCodigoDoctor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxHorarioAtencion = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTelefonoDoctor = new System.Windows.Forms.TextBox();
            this.txtDireccionDoctor = new System.Windows.Forms.TextBox();
            this.txtApellidoDoctor = new System.Windows.Forms.TextBox();
            this.txtNombreDoctor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEspecialidad
            // 
            this.comboBoxEspecialidad.DisplayMember = "Int";
            this.comboBoxEspecialidad.FormattingEnabled = true;
            this.comboBoxEspecialidad.Location = new System.Drawing.Point(132, 229);
            this.comboBoxEspecialidad.Name = "comboBoxEspecialidad";
            this.comboBoxEspecialidad.Size = new System.Drawing.Size(257, 21);
            this.comboBoxEspecialidad.TabIndex = 58;
            this.comboBoxEspecialidad.ValueMember = "Int";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(746, 190);
            this.dataGridView1.TabIndex = 57;
            // 
            // txtCodigoDoctor
            // 
            this.txtCodigoDoctor.Location = new System.Drawing.Point(132, 109);
            this.txtCodigoDoctor.Multiline = true;
            this.txtCodigoDoctor.Name = "txtCodigoDoctor";
            this.txtCodigoDoctor.Size = new System.Drawing.Size(263, 23);
            this.txtCodigoDoctor.TabIndex = 56;
            this.txtCodigoDoctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoDoctor_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(895, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 48);
            this.button1.TabIndex = 55;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(122, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(638, 55);
            this.label9.TabIndex = 54;
            this.label9.Text = "REGISTRO DE DOCTORES";
            // 
            // listBoxHorarioAtencion
            // 
            this.listBoxHorarioAtencion.FormattingEnabled = true;
            this.listBoxHorarioAtencion.Items.AddRange(new object[] {
            "Matutino 6:00 am a 12:00 am",
            "Vespertino 1:00 pm a 6:00 pm",
            "Nocturno 7:00 pm a 5:00 am"});
            this.listBoxHorarioAtencion.Location = new System.Drawing.Point(594, 229);
            this.listBoxHorarioAtencion.Name = "listBoxHorarioAtencion";
            this.listBoxHorarioAtencion.Size = new System.Drawing.Size(262, 30);
            this.listBoxHorarioAtencion.TabIndex = 53;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(583, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 20);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // txtTelefonoDoctor
            // 
            this.txtTelefonoDoctor.Location = new System.Drawing.Point(545, 112);
            this.txtTelefonoDoctor.Multiline = true;
            this.txtTelefonoDoctor.Name = "txtTelefonoDoctor";
            this.txtTelefonoDoctor.Size = new System.Drawing.Size(263, 23);
            this.txtTelefonoDoctor.TabIndex = 51;
            this.txtTelefonoDoctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoDoctor_KeyPress);
            // 
            // txtDireccionDoctor
            // 
            this.txtDireccionDoctor.Location = new System.Drawing.Point(546, 159);
            this.txtDireccionDoctor.Multiline = true;
            this.txtDireccionDoctor.Name = "txtDireccionDoctor";
            this.txtDireccionDoctor.Size = new System.Drawing.Size(263, 23);
            this.txtDireccionDoctor.TabIndex = 50;
            // 
            // txtApellidoDoctor
            // 
            this.txtApellidoDoctor.Location = new System.Drawing.Point(132, 188);
            this.txtApellidoDoctor.Multiline = true;
            this.txtApellidoDoctor.Name = "txtApellidoDoctor";
            this.txtApellidoDoctor.Size = new System.Drawing.Size(263, 23);
            this.txtApellidoDoctor.TabIndex = 49;
            // 
            // txtNombreDoctor
            // 
            this.txtNombreDoctor.Location = new System.Drawing.Point(132, 149);
            this.txtNombreDoctor.Multiline = true;
            this.txtNombreDoctor.Name = "txtNombreDoctor";
            this.txtNombreDoctor.Size = new System.Drawing.Size(263, 22);
            this.txtNombreDoctor.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(441, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Horario Atención";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(443, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Fecha contratación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(447, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(454, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Especialidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Cod. Doctor";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            this.iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            this.iNICIOToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.iNICIOToolStripMenuItem.Text = "INICIO";
            this.iNICIOToolStripMenuItem.Click += new System.EventHandler(this.iNICIOToolStripMenuItem_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(379, 295);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(149, 45);
            this.btnGuardar.TabIndex = 60;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(778, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(-3, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1006, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(-76, 578);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1006, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // DoctoresCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(892, 595);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.comboBoxEspecialidad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCodigoDoctor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBoxHorarioAtencion);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtTelefonoDoctor);
            this.Controls.Add(this.txtDireccionDoctor);
            this.Controls.Add(this.txtApellidoDoctor);
            this.Controls.Add(this.txtNombreDoctor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DoctoresCrear";
            this.Text = "DoctoresCrear";
            this.Load += new System.EventHandler(this.DoctoresCrear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEspecialidad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCodigoDoctor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxHorarioAtencion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtTelefonoDoctor;
        private System.Windows.Forms.TextBox txtDireccionDoctor;
        private System.Windows.Forms.TextBox txtApellidoDoctor;
        private System.Windows.Forms.TextBox txtNombreDoctor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}