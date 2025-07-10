using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_CLINICA.Controller;
using PROYECTO_CLINICA.Model;

namespace PROYECTO_CLINICA.View
{
    public partial class PacientesPerfil : Form
    {
        PacientesModel Modelo; // se crea una variable para usar la capa controladora 
        String Modo;
        public PacientesLista Padre; //esta variable se crea para usar en el metodo salva y que el datagrdview se refresce con el registro nuevo

        public PacientesPerfil()
        {
            InitializeComponent();
            Modo = "Agregando";
            //LblModo.Text = Modo;

            // Configurar el formato del DateTimePicker
            dtpNacimiento.Format = DateTimePickerFormat.Custom;
            dtpNacimiento.CustomFormat = "yyyy-MM-dd HH:mm:ss" ; // Formato deseado
        }

        private void PacientesPerfil_Load(object sender, EventArgs e)
        {
            llenar_combo_genero();

            // Configurar el formato del DateTimePicker
            dtpNacimiento.Format = DateTimePickerFormat.Custom;
            dtpNacimiento.CustomFormat = "yyyy-MM-dd"; // Formato deseado
        }

        public PacientesPerfil(string ID_PACIENTE)
        {
            InitializeComponent();// este nos permite ver que estamos actualizando
            Modo = "Actualizando";
            //LblModo.Text = Modo;
            txtCodigoPaciente.Text = ID_PACIENTE;
            txtCodigoPaciente.Enabled = false;


            foreach (DataRow Fila in PacientesModel.GetPaciente.Rows)
            {
                if (Fila["ID_PACIENTE"].ToString() == ID_PACIENTE)
                {
                    txtNombres.Text = Fila["NOMBRES"].ToString();
                    txtApellidos.Text = Fila["APELLIDOS"].ToString();
                    txtDNI.Text = Fila["DNI"].ToString();
                    txtEdad.SelectedText = Fila["EDAD"].ToString();
                    cmbSexo.SelectedText = Fila["ID_SEXO"].ToString();
                    txtTelefono.SelectedText = Fila["TELEFONO"].ToString();
                    txtDireccion.SelectedText = Fila["DIRECCION"].ToString();
                    txtPA.Text = Fila["PA"].ToString();
                    txtFC.Text = Fila["FC"].ToString();
                    txtFR.Text = Fila["FR"].ToString();
                    txtSaturacion.Text = Fila["SatO2"].ToString();
                    txtTemperatura.Text = Fila["TEMPERATURA"].ToString();
                    txtPeso.Text = Fila["PESO"].ToString();
                    txtTalla.Text = Fila["TALLA"].ToString();
                    txtIMC.Text = Fila["IMC"].ToString();
                    break;
                }
            }
        }


        void salvar()
        {
            Modelo = new PacientesModel();

            int idPaciente;
            if (!int.TryParse(txtCodigoPaciente.Text, out idPaciente))
            {
                MessageBox.Show("El código de paciente debe ser un número entero válido.");
                return;
            }
            Modelo.ID_PACIENTE = idPaciente;


            Modelo.NOMBRES = txtNombres.Text;
            Modelo.APELLIDOS = txtApellidos.Text;

            int idSexo;
            if (!int.TryParse(cmbSexo.SelectedValue.ToString(), out idSexo))
            {
                MessageBox.Show("El sexo seleccionado debe ser un número entero válido.");
                return;
            }
            Modelo.ID_SEXO = idSexo;

            Modelo.DIRECCION = txtDireccion.Text;

            int telefono;
            if (!int.TryParse(txtTelefono.Text, out telefono))
            {
                MessageBox.Show("El teléfono debe ser un número entero válido.");
                return;
            }
            Modelo.TELEFONO = telefono;

            Modelo.DNI = txtDNI.Text;
            Modelo.FECHA_NACIMIENTO = dtpNacimiento.Value;
            Console.WriteLine("HELLO"+ Modelo.FECHA_NACIMIENTO);
            Modelo.USER_CREACION = "EDRASP";

            int edad;
            if (!int.TryParse(txtEdad.Text, out edad))
            {
                MessageBox.Show("La edad debe ser un número entero válido.");
                return;
            }
            Modelo.EDAD = edad;

            Modelo.PA = txtPA.Text;
            Modelo.FC = txtFC.Text;
            Modelo.FR = txtFR.Text;
            Modelo.SatO2 = txtSaturacion.Text;
            Modelo.TEMPERATURA = txtTemperatura.Text;
            Modelo.TALLA = txtTalla.Text;
            Modelo.PESO = txtPeso.Text;
            Modelo.IMC = txtIMC.Text;

            if (Modo == "Agregando")
            {
                if (new PacientesController().CrearPacientes(Modelo) == true)
                {
                    MessageBox.Show("Registro Agregado Exitosamente...!!");
                    Padre.CargarDatos(); // para refrezcar el datagridview
                    this.Close();
                }
                else
                    MessageBox.Show("Error al Insertar paciente", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (new PacientesController().ActualizarPacientes(Modelo) == true)
                {
                    Padre.CargarDatos(); // para refrezcar el datagridview
                    MessageBox.Show("Registro Editado Exitosamente...!!");
                    this.Close();
                }
                else
                    MessageBox.Show("Error al Editar Paciente", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean validando()
        {
            Boolean valida = true;

            if (string.IsNullOrEmpty(txtCodigoPaciente.Text))
            {
                valida = false;
                txtCodigoPaciente.Focus();
                MessageBox.Show("codigo de paciente no puede quedar vacio...!!");
            }
            else
            {
                if (string.IsNullOrEmpty(txtNombres.Text))
                {
                    valida = false;
                    txtNombres.Focus();
                    MessageBox.Show("Nombres usuario no puede quedar vacio...!!");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtApellidos.Text))
                    {
                        valida = false;
                        txtApellidos.Focus();
                        MessageBox.Show("Apellidos no puede quedar vacio...!!");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtDNI.Text))
                        {
                            valida = false;
                            txtDNI.Focus();
                            MessageBox.Show("DNI no puede quedar vacio...!!");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtEdad.Text))
                            {
                                valida = false;
                                txtEdad.Focus();
                                MessageBox.Show("DNI no puede quedar vacio...!!");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(cmbSexo.Text))
                                {
                                    valida = false;
                                    cmbSexo.Focus();
                                    MessageBox.Show("debe seleccionar un genero especifico...!!");
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(dtpNacimiento.Text))
                                    {
                                        valida = false;
                                        dtpNacimiento.Focus();
                                        MessageBox.Show("la fecha de nacimiento no puede quedar vacio...!!");
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(txtDireccion.Text))
                                        {
                                            valida = false;
                                            txtDireccion.Focus();
                                            MessageBox.Show("Direccion no puede quedar vacio...!!");
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            return valida;
        }

        public DataTable llenar_genero() ///llenamos el datatable con sl script de la tabla
        {
            DataTable dt = new DataTable();

            SqlConnection sqlCon = null;
            String SqlconString = ConfigurationManager.ConnectionStrings["CLINICA"].ConnectionString;

            using (sqlCon = new SqlConnection(SqlconString))
            {
                sqlCon.Open();

                string query = "select ID_SEXO, DESCRIPCION_SEXO from PACIENTE_TIPO_SEXO";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
        public void llenar_combo_genero() /// llenamos el combo con los datos del datatable
        {
            PacientesPerfil opcar = new PacientesPerfil();
            var dt = opcar.llenar_genero();

            cmbSexo.ValueMember = "ID_SEXO";
            cmbSexo.DisplayMember = "DESCRIPCION_SEXO";
            cmbSexo.DataSource = dt;
            //CMBTipoLogueo.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validando() == true)
                salvar();
            this.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dtpNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
