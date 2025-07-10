using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_CLINICA.Controller;
using PROYECTO_CLINICA.Model;
using PROYECTO_CLINICA.View;

namespace PROYECTO_CLINICA.View
{
    public partial class NuevaCita : Form
    {
        CitasModel Modelo;
        string Modo = "";
        public CitasLista Padre;
        public NuevaCita()
        {
            InitializeComponent();
            Modo = "Agregando";
        }

        public NuevaCita(string ID_CITA)
        {
            InitializeComponent();
            Modo = "Actualizando";
            txtCodCita.Text = ID_CITA;
            txtCodCita.Enabled = false;

            foreach (DataRow Fila in CitasModel.GetCita.Rows)
            {
                if (Fila["ID_CITA"].ToString() == ID_CITA.ToString())
                {
                    txtNombres.Text = Fila["NOMBRES"].ToString();
                    txtApellidos.Text = Fila["APELLIDOS"].ToString();
                    txtTelefono.Text = Fila["No_TELEFONO"].ToString();
                    txtIdDoctor.Text = Fila["ID_DOCTOR"].ToString();
                    txtMotivoCita.Text = Fila["MOTIVO_CITA"].ToString();
                    break;
                }
            }
        }

        Boolean Validando()
        {
            Boolean valida = true;
            if (string.IsNullOrEmpty(txtCodCita.Text))
            {
                valida = false;
                txtCodCita.Focus();
                MessageBox.Show("CodigoCita No puede quedar vacio");
            }
            else
            {
                if (string.IsNullOrEmpty(txtNombres.Text))
                {
                    valida = false;
                    txtNombres.Focus();
                    MessageBox.Show("Nombre no puede quedar vacio");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtApellidos.Text))
                    {
                        valida = false;
                        txtApellidos.Focus();
                        MessageBox.Show("Apellidos no puede quedar vacio");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtTelefono.Text))
                        {
                            valida = false;
                            txtTelefono.Focus();
                            MessageBox.Show("Telefono no puede quedar vacio");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtIdDoctor.Text))
                            {
                                valida = false;
                                txtIdDoctor.Focus();
                                MessageBox.Show("IdDoctor no puede quedar vacio");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(txtMotivoCita.Text))
                                {
                                    valida = false;
                                    txtMotivoCita.Focus();
                                    MessageBox.Show("Motivo de cita no puede quedar vacio");
                                }
                            }
                        }
                    }
                }
            }
            return valida;
        }

        void Salvar()
        {
            Modelo = new CitasModel();
            Modelo.ID_CITA = int.Parse(txtCodCita.Text);
            Modelo.NOMBRES = txtNombres.Text;
            Modelo.APELLIDOS = txtApellidos.Text;
            Modelo.No_TELEFONO = txtTelefono.Text;
            Modelo.ID_DOCTOR = int.Parse(txtIdDoctor.Text);
            Modelo.FECHA_HORACITA = dateTimePicker1.Value;
            Modelo.MOTIVO_CITA = txtMotivoCita.Text;
            Modelo.USER_CREACION = "REDMART";

            if (Modo == "Agregando")
            {
                if (new CitasController().CrearCita(Modelo) == true)
                {
                    MessageBox.Show("Registro Agregado Exitosamente...!!");
                    Padre.CargarDatos(); // para refrezcar el datagridview
                    this.Close();
                }
                else
                    MessageBox.Show("Error al crear cita", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (new CitasController().ActualizarCita(Modelo) == true)
                {
                    Padre.CargarDatos(); // para refrezcar el datagridview
                    MessageBox.Show("Registro Editado Exitosamente...!!");
                    this.Close();
                }
                else
                    MessageBox.Show("Error al Editar Cita", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validando() == true)
            {
                Salvar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevaCita_Load(object sender, EventArgs e)
        {
            txtCodCita.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            txtCodCita.Focus();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}

    
