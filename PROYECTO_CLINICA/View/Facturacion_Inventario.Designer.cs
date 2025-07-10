namespace PROYECTO_CLINICA.View
{
    partial class Facturacion_Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion_Inventario));
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpEmision = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.cmbEleccion = new System.Windows.Forms.ComboBox();
            this.txtRTN = new System.Windows.Forms.TextBox();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cmbServicioBien = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(315, 93);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(151, 20);
            this.txtFactura.TabIndex = 37;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(557, 40);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(119, 13);
            this.label25.TabIndex = 39;
            this.label25.Text = "FECHA VENCIMIENTO";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(69, 40);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 13);
            this.label24.TabIndex = 38;
            this.label24.Text = "FECHA EMISION";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.CustomFormat = "dd--MM--yyyy";
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVencimiento.Location = new System.Drawing.Point(566, 60);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(116, 20);
            this.dtpVencimiento.TabIndex = 36;
            // 
            // dtpEmision
            // 
            this.dtpEmision.CustomFormat = "dd--MM--yyyy";
            this.dtpEmision.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmision.Location = new System.Drawing.Point(73, 60);
            this.dtpEmision.Name = "dtpEmision";
            this.dtpEmision.Size = new System.Drawing.Size(96, 20);
            this.dtpEmision.TabIndex = 35;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(305, 657);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(203, 44);
            this.btnConfirmar.TabIndex = 34;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 37);
            this.label1.TabIndex = 33;
            this.label1.Text = " # FACTURA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.txtDescuento);
            this.panel1.Controls.Add(this.txtImpuesto);
            this.panel1.Controls.Add(this.txtCant);
            this.panel1.Controls.Add(this.cmbEleccion);
            this.panel1.Controls.Add(this.txtRTN);
            this.panel1.Controls.Add(this.cmbPaciente);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.cmbUsuario);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtEfectivo);
            this.panel1.Controls.Add(this.lblCambio);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.cmbServicioBien);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvItems);
            this.panel1.Location = new System.Drawing.Point(73, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 502);
            this.panel1.TabIndex = 32;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(275, 63);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(52, 20);
            this.txtPrecio.TabIndex = 36;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(275, 110);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(52, 20);
            this.txtDescuento.TabIndex = 35;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(102, 110);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(52, 20);
            this.txtImpuesto.TabIndex = 34;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(275, 87);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(52, 20);
            this.txtCant.TabIndex = 32;
            // 
            // cmbEleccion
            // 
            this.cmbEleccion.FormattingEnabled = true;
            this.cmbEleccion.Location = new System.Drawing.Point(210, 34);
            this.cmbEleccion.Name = "cmbEleccion";
            this.cmbEleccion.Size = new System.Drawing.Size(150, 21);
            this.cmbEleccion.TabIndex = 33;
            this.cmbEleccion.SelectedIndexChanged += new System.EventHandler(this.cmbEleccion_SelectedIndexChanged);
            // 
            // txtRTN
            // 
            this.txtRTN.Location = new System.Drawing.Point(69, 137);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Size = new System.Drawing.Size(197, 20);
            this.txtRTN.TabIndex = 32;
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(412, 83);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(190, 21);
            this.cmbPaciente.TabIndex = 29;
            this.cmbPaciente.SelectedIndexChanged += new System.EventHandler(this.cmbPaciente_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(546, 67);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 28;
            this.label23.Text = "PACIENTE";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(33, 140);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 13);
            this.label21.TabIndex = 26;
            this.label21.Text = "RTN";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(192, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "DESCUENTO";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "IMPUESTO";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(412, 34);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(190, 21);
            this.cmbUsuario.TabIndex = 21;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(546, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "USUARIO";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(280, 380);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(100, 20);
            this.txtEfectivo.TabIndex = 19;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(489, 380);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(28, 13);
            this.lblCambio.TabIndex = 18;
            this.lblCambio.Text = "- - - -";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(140, 380);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(28, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "- - - -";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(478, 353);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "CAMBIO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(301, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "EFECTIVO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "TOTAL A PAGAR";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(101, 90);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(28, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "- - - -";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(101, 67);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(28, 13);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "- - - -";
            // 
            // cmbServicioBien
            // 
            this.cmbServicioBien.FormattingEnabled = true;
            this.cmbServicioBien.Items.AddRange(new object[] {
            "MEDICAMENTO",
            "CITA",
            "EXAMEN"});
            this.cmbServicioBien.Location = new System.Drawing.Point(36, 34);
            this.cmbServicioBien.Name = "cmbServicioBien";
            this.cmbServicioBien.Size = new System.Drawing.Size(165, 21);
            this.cmbServicioBien.TabIndex = 8;
            this.cmbServicioBien.SelectedIndexChanged += new System.EventHandler(this.cmbServicioBien_SelectedIndexChanged);
            this.cmbServicioBien.TextChanged += new System.EventHandler(this.cmbServicioBien_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(516, 130);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(413, 130);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "CANTIDAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "PRECIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CODIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SERVICIO O BIEN";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvItems.Location = new System.Drawing.Point(22, 168);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowHeadersWidth = 62;
            this.dgvItems.Size = new System.Drawing.Size(608, 169);
            this.dgvItems.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CODIGO";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOMBRE";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PRECIO";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "CANTIDAD";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DESCUENTO";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "IMPUESTO";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "SUB-TOTAL";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(703, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Navy;
            this.label29.Location = new System.Drawing.Point(-323, 9);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(1186, 13);
            this.label29.TabIndex = 74;
            this.label29.Text = resources.GetString("label29.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(-198, 711);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1186, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // Facturacion_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(810, 740);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.dtpEmision);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Facturacion_Inventario";
            this.Text = "Facturacion_Inventario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.DateTimePicker dtpEmision;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.ComboBox cmbEleccion;
        private System.Windows.Forms.TextBox txtRTN;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cmbServicioBien;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label7;
    }
}