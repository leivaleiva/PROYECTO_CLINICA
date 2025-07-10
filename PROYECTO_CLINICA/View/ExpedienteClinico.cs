using PROYECTO_CLINICA.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PROYECTO_CLINICA.Model;
using System.Reflection;
using System.Configuration;

namespace PROYECTO_CLINICA.View
{
    public partial class ExpedienteClinico : Form
    {

        ExpedienteClinicoModel Modelo; // se crea una variable para usar la capa controladora 
        String Modo;


        public ExpedienteClinicoListar Padre; //esta variable se crea para usar en el metodo salva y que el datagrdview se refresce con el registro nuevo
        public ExpedienteClinico()
        {
            InitializeComponent();
            Modo = "Agregando";
            //LblModo.Text = Modo;
        }

        public ExpedienteClinico(string ID_EXPEDIENTE)
        {
            InitializeComponent();
            Modo = "Actualizando";
            //LblModo.Text = Modo;
            txtCodExpediente.Text = ID_EXPEDIENTE;
            txtCodExpediente.Enabled = false;


            foreach (DataRow Fila in ExpedienteClinicoModel.GetExpediente.Rows)
            {
                if (Fila["ID_EXPEDIENTE"].ToString() == ID_EXPEDIENTE)
                {
                    txtCodPaciente.Text = Fila["ID_PACIENTE"].ToString();
                    txtEstablecimiento.Text = Fila["ESTABLECIMIENTO"].ToString();
                    txtPadre.Text = Fila["NOMBRE_PADRE"].ToString();
                    txtMadre.Text = Fila["NOMBRE_MADRE"].ToString();
                    cmbSexo.SelectedText = Fila["ID_SEXO"].ToString();
                    cmbEstadoCivil.SelectedText = Fila["ID_ESTADO_CIVIL"].ToString();
                    txtDiagnostico.Text = Fila["DIAGNOSTICO_INGRESO"].ToString();
                    txtAntecedentes.Text = Fila["ANTECEDENTE_ENFERMEDAD"].ToString();
                    txtContactoEmerg.Text = Fila["CONTACTO_EMERGENCIA"].ToString();
                    txtTelefonoEmerg.Text = Fila["TELEFONO_C_E"].ToString();
                    cmbServicio.SelectedText = Fila["ID_SERVICIO"].ToString();
                    cmbIngresoPor.SelectedText = Fila["ID_INGRESO"].ToString();
                    cmbHospitalizacion.SelectedText = Fila["ID_HOSPITALIZACION"].ToString();
                    dtpFechaIngreso.Text = Fila["FECHA_INGRESO"].ToString(); 
                    txtEvolucion.Text = Fila["NOTAS_EVOLUCION"].ToString();
                    cmbMedico.SelectedText = Fila["ID_MEDICO"].ToString();
                    break;
                }
            }
        }
    

        void salvar()
        {
            Modelo = new ExpedienteClinicoModel();

            Modelo.ID_EXPEDIENTE = int.Parse(txtCodExpediente.Text);
            Modelo.ID_PACIENTE = int.Parse(txtCodPaciente.Text);
            Modelo.ESTABLECIMIENTO = txtEstablecimiento.Text;
            Modelo.ID_SEXO = int.Parse(cmbSexo.SelectedValue.ToString());
            Modelo.ID_ESTADO_CIVIL = int.Parse(cmbEstadoCivil.SelectedValue.ToString());//este codigo convierte a int lo que hay en el combo box
            Modelo.NOMBRE_PADRE = txtPadre.Text;
            Modelo.NOMBRE_MADRE = txtMadre.Text;
            Modelo.CONTACTO_EMERGENCIA = txtContactoEmerg.Text;
            Modelo.TELEFONO_C_E = txtTelefonoEmerg.Text;
            Modelo.ID_INGRESO = int.Parse(cmbIngresoPor.SelectedValue.ToString());
            Modelo.ID_SERVICIO = int.Parse(cmbServicio.SelectedValue.ToString());
            Modelo.ID_HOSPITALIZACION = int.Parse(cmbHospitalizacion.SelectedValue.ToString());
            Modelo.DIAGNOSTICO_INGRESO = txtDiagnostico.Text;
            Modelo.FECHA_INGRESO = dtpFechaIngreso.Value;
            Modelo.ANTECEDENTE_ENFERMEDAD = txtAntecedentes.Text;
            Modelo.NOTAS_EVOLUCION = txtEvolucion.Text;
            Modelo.ID_MEDICO = int.Parse(cmbMedico.SelectedValue.ToString());


            if (Modo == "Agregando")
            {
                if (new ExpedienteClinicoController().CrearExpedienteClinico(Modelo) == true)
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
                if (new ExpedienteClinicoController().ActualizarExpediente(Modelo) == true)
                {
                    Padre.CargarDatos(); // para refrezcar el datagridview
                    MessageBox.Show("Registro Editado Exitosamente...!!");
                    this.Close();
                }
                else
                    MessageBox.Show("Error al Editar Expediente", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Boolean validando()
        {
            Boolean valida = true;

            if (string.IsNullOrEmpty(txtCodExpediente.Text))
            {
                valida = false;
                txtCodExpediente.Focus();
                MessageBox.Show("codigo de expediente no puede quedar vacio...!!");
            }
            else
            {
                if (string.IsNullOrEmpty(txtCodPaciente.Text))
                {
                    valida = false;
                    txtCodPaciente.Focus();
                    MessageBox.Show("cod de paciente no puede quedar vacio...!!");
                }
                else
                {
                    if (string.IsNullOrEmpty(cmbSexo.Text))
                    {
                        valida = false;
                        cmbSexo.Focus();
                        MessageBox.Show("valide el genero...!!");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(cmbEstadoCivil.Text))
                        {
                            valida = false;
                            cmbEstadoCivil.Focus();
                            MessageBox.Show("valide el estado civil...!!");
                        }
                        else
                        {
                            //if (string.IsNullOrEmpty(txtEdad.Text))
                            //{
                            //    valida = false;
                            //    txtEdad.Focus();
                            //    MessageBox.Show("DNI no puede quedar vacio...!!");
                            //}
                            //else
                            {
                                if (string.IsNullOrEmpty(cmbSexo.Text))
                                {
                                    valida = false;
                                    cmbSexo.Focus();
                                    MessageBox.Show("debe seleccionar un genero especifico...!!");
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(cmbIngresoPor.Text))
                                    {
                                        valida = false;
                                        cmbIngresoPor.Focus();
                                        MessageBox.Show("valide el ingreso del paciente...!!");
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(cmbServicio.Text))
                                        {
                                            valida = false;
                                            cmbServicio.Focus();
                                            MessageBox.Show("valide a que servicio se ingresa el paciente...!!");
                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty (cmbHospitalizacion.Text))
                                            {
                                                valida = false;
                                                cmbHospitalizacion.Focus();
                                                MessageBox.Show("valide a que servicio de hospitalizacion se ingresa el paciente...!!");
                                            }
                                            else
                                            {
                                                if (string.IsNullOrEmpty (cmbMedico.Text))
                                                {
                                                    valida = false;
                                                    cmbServicio.Focus();
                                                    MessageBox.Show("valide el medico que hizo el ingreso o la nota...!!");
                                                }
                                            }    
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
            ExpedienteClinico opcar = new ExpedienteClinico();
            var dt = opcar.llenar_genero();

            cmbSexo.ValueMember = "ID_SEXO";
            cmbSexo.DisplayMember = "DESCRIPCION_SEXO";
            cmbSexo.DataSource = dt;
            //CMBTipoLogueo.SelectedIndex = 0;
        }


        //LLENAMOS ELCOMBO BOX DE MEDICOS 
        public DataTable llenar_medicos() ///llenamos el datatable con sl script de la tabla
        {
            DataTable dt = new DataTable();

            SqlConnection sqlCon = null;
            String SqlconString = ConfigurationManager.ConnectionStrings["CLINICA"].ConnectionString;

            using (sqlCon = new SqlConnection(SqlconString))
            {
                sqlCon.Open();

                string query = "SELECT ID_DOCTOR, NOMBRE + ' ' + APELLIDO AS NOMBRE_COMPLETO\r\nFROM CATALOGO_DOCTORES;";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public void llenar_combo_medicos() /// llenamos el combo con los datos del datatable
        {
            ExpedienteClinico opcar = new ExpedienteClinico();
            var dt = opcar.llenar_medicos();

            cmbMedico.ValueMember = "ID_DOCTOR";
            cmbMedico.DisplayMember = "NOMBRE_COMPLETO";
            cmbMedico.DataSource = dt;
            cmbMedico.SelectedIndex = 0;
        }

        //llenamos combo de ingreso si fue por consulta o emergencia
        public DataTable llenar_Ingreso_por() ///llenamos el datatable con sl script de la tabla
        {
            DataTable dt = new DataTable();

            SqlConnection sqlCon = null;
            String SqlconString = ConfigurationManager.ConnectionStrings["CLINICA"].ConnectionString;

            using (sqlCon = new SqlConnection(SqlconString))
            {
                sqlCon.Open();

                string query = "select ID_INGRESO, DESCRIPCION_INGRESO from PACIENTE_INGRESO_POR";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        //llenamos combo de ingreso si fue por consulta o emergencia
        public void llenar_combo_ingresoPor() /// llenamos el combo con los datos del datatable
        {
            ExpedienteClinico opcar = new ExpedienteClinico();
            var dt = opcar.llenar_Ingreso_por();

            cmbIngresoPor.ValueMember = "ID_INGRESO";
            cmbIngresoPor.DisplayMember = "DESCRIPCION_INGRESO";
            cmbIngresoPor.DataSource = dt;
            cmbIngresoPor.SelectedIndex = 0;
        }


        //llenamos combo de ingreso si fue por consulta o emergencia
        public DataTable llenar_Ingreso_hospitalizacion() ///llenamos el datatable con sl script de la tabla
        {
            DataTable dt = new DataTable();

            SqlConnection sqlCon = null;
            String SqlconString = ConfigurationManager.ConnectionStrings["CLINICA"].ConnectionString;

            using (sqlCon = new SqlConnection(SqlconString))
            {
                sqlCon.Open();

                string query = "select ID_HOSPITALIZACION, DESCRIPCION_HOSPITALIZACION from PACIENTE_HOSPITALIZACION_SALA";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        //llenamos combo de hospitalizacion
        public void llenar_combo_hospitalizacion() /// llenamos el combo con los datos del datatable
        {
            ExpedienteClinico opcar = new ExpedienteClinico();
            var dt = opcar.llenar_Ingreso_hospitalizacion();

            cmbHospitalizacion.ValueMember = "ID_HOSPITALIZACION";
            cmbHospitalizacion.DisplayMember = "DESCRIPCION_HOSPITALIZACION";
            cmbHospitalizacion.DataSource = dt;
            cmbHospitalizacion.SelectedIndex = 0;
        }


        //llenamos combo de ingreso a la expecializad
        public DataTable llenar_Ingreso_servicio() ///llenamos el datatable con sl script de la tabla
        {
            DataTable dt = new DataTable();

            SqlConnection sqlCon = null;
            String SqlconString = ConfigurationManager.ConnectionStrings["CLINICA"].ConnectionString;

            using (sqlCon = new SqlConnection(SqlconString))
            {
                sqlCon.Open();

                string query = "select ID_SERVICIO, DESCRIPCION_SERVICIO from PACIENTE_SERVICIO_POR";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        //llenamos combo de hospitalizacion
        public void llenar_combo_hospitalizacion_servicio() /// llenamos el combo con los datos del datatable
        {
            ExpedienteClinico opcar = new ExpedienteClinico();
            var dt = opcar.llenar_Ingreso_servicio();

            cmbServicio.ValueMember = "ID_SERVICIO";
            cmbServicio.DisplayMember = "DESCRIPCION_SERVICIO";
            cmbServicio.DataSource = dt;
            cmbServicio.SelectedIndex = 0;
        }

        // LLENAREMOS EL COMBO BOX DE estado civil
        public DataTable llenar_estadocivil() ///llenamos el datatable con sl script de la tabla
        {
            DataTable dt = new DataTable();

            SqlConnection sqlCon = null;
            String SqlconString = ConfigurationManager.ConnectionStrings["CLINICA"].ConnectionString;

            using (sqlCon = new SqlConnection(SqlconString))
            {
                sqlCon.Open();

                string query = "select ID_ESTADO_CIVIL, PACIENTE_ESTADO_CIVIL from PACIENTE_ESTADO_CIVIL";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
        public void llenar_combo_estado_civil() /// llenamos el combo con los datos del datatable
        {
            ExpedienteClinico opcar = new ExpedienteClinico();
            var dt = opcar.llenar_estadocivil();

            cmbEstadoCivil.ValueMember = "ID_ESTADO_CIVIL";
            cmbEstadoCivil.DisplayMember = "PACIENTE_ESTADO_CIVIL";
            cmbEstadoCivil.DataSource = dt;
            cmbEstadoCivil.SelectedIndex = 0;
        }



        private void historiaClinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void BTNBUSCAR_Click(object sender, EventArgs e)
        {
            using (SqlConnection Con = new Conexion().GetConnection())

            {

                string CONSULTA = "SELECT * FROM CATALOGO_PACIENTES WHERE DNI ='" + TXTBUSCAR.Text + "'";
                SqlCommand COMANDO = new SqlCommand(CONSULTA, Con);
                Con.Open();

                SqlDataReader LEER = COMANDO.ExecuteReader();
                if (LEER.Read() == true)
                {
                    txtCodExpediente.Text = LEER["ID_PACIENTE"].ToString();
                    txtDNI.Text = LEER["DNI"].ToString();
                    txtNombres.Text = LEER["NOMBRES"].ToString();
                    txtApellidos.Text = LEER["APELLIDOS"].ToString();
                    txtEdad.Text = LEER["EDAD"].ToString();
                    cmbSexo.Text = LEER["ID_SEXO"].ToString();
                    //txtTelefono.Text = LEER["TELEFONO"].ToString();
                    TXTFECNAC.Text = LEER["FECHA_NACIMIENTO"].ToString();
                    RHDIRECCION.Text = LEER["DIRECCION"].ToString();
                    //txtPA.Text = LEER["PA"].ToString();
                    //txtFC.Text = LEER["FC"].ToString();
                    //txtSaturacion.Text = LEER["SatO2"].ToString();
                    //txtFR.Text = LEER["FR"].ToString();
                    //txtTemperatura.Text = LEER["TEMPERATURA"].ToString();
                    //txtPeso.Text = LEER["PESO"].ToString();
                    //txtTalla.Text = LEER["TALLA"].ToString();
                    //txtIMC.Text = LEER["IMC"].ToString();
                }

            }
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); //cierra formulario y vuele al anterior
            View.PacientesLista pantallasubmenu = new View.PacientesLista();
            pantallasubmenu.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ExpedienteClinico_Load(object sender, EventArgs e)
        {
            llenar_combo_genero();
            llenar_combo_medicos();
            llenar_combo_estado_civil();
            llenar_combo_ingresoPor();
            llenar_combo_hospitalizacion();
            llenar_combo_hospitalizacion_servicio();

        }

        private void gUARDAREXPEDIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (validando() == true)
                salvar();
            //this.Close();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}

