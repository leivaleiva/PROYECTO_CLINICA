using PROYECTO_CLINICA.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using PROYECTO_CLINICA.Controller;
using System.Data.SqlClient;

namespace PROYECTO_CLINICA.View
{
    public partial class Examenes : Form
    {

        ExamenesModel Modelo; // se crea una variable para usar la capa controladora 
        String Modo;
        public ExamenesLista Padre;
        public Examenes()
        {
            InitializeComponent();
            Modo = "Agregando";
        }

        public Examenes(string ID_EXAMENES)
        {
            InitializeComponent();
            Modo = "Actualizando";
            txtCodigoExamen.Text = ID_EXAMENES;
            txtCodigoExamen.Enabled = false;

            foreach (DataRow Fila in ExamenesModel.GetExamenes.Rows)
            {
                if (Fila["ID_EXAMENES"].ToString() == ID_EXAMENES.ToString())
                {
                    txtCodigoExamen.Text = Fila["ID_EXAMENES"].ToString();
                    dateTimePicker1.Text = Fila["FECHA_REGISTRO"].ToString();
                    txtCodigoPaciente.Text = Fila["ID_PACIENTE"].ToString();
                    txtDatospositivos.Text = Fila["DATOS_POSITIVOS"].ToString();
                    cmbTipoExamen.Text = Fila["ID_EXAMEN_COMPLEMENTARIO"].ToString();

                    break;
                }

            }
        }

        void salvar()
        {

            Modelo = new ExamenesModel();

            Modelo.ID_EXAMENES = int.Parse(txtCodigoExamen.Text);
            Modelo.FECHA_REGISTRO = dateTimePicker1.Value;
            Modelo.ID_PACIENTE = int.Parse(txtCodigoPaciente.Text);
            Modelo.DATOS_POSITIVOS = txtDatospositivos.Text;
            Modelo.ID_EXAMEN_COMPLEMENTARIO = int.Parse(cmbTipoExamen.SelectedValue.ToString()); ;


            if (Modo == "Agregando")
            {
                if (new ExamenesController().CrearExamen(Modelo) == true)
                {
                    MessageBox.Show("Registro Agregado Exitosamente...!!");
                    Padre.CargarDatos(); // para refrezcar el datagridview
                    this.Close();
                }
                else
                    MessageBox.Show("Error al Insertar examen", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (new ExamenesController().ActualizarExamen(Modelo) == true)
                {
                    Padre.CargarDatos(); // para refrezcar el datagridview
                    MessageBox.Show("Registro Editado Exitosamente...!!");
                    this.Close();
                }
                else
                    MessageBox.Show("Error al Editar Examen", "Informacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        Boolean validando()
        {
            Boolean valida = true;

            if (string.IsNullOrEmpty(txtCodigoExamen.Text))
            {
                valida = false;
                txtCodigoExamen.Focus();
                MessageBox.Show("CodigoExamen No puede quedar vacio");
            }
            else
            {
                if (string.IsNullOrEmpty(dateTimePicker1.Text))
                {
                    valida = false;
                    dateTimePicker1.Focus();
                    MessageBox.Show("Nombre no puede quedar sin seleccionar...!!");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtCodigoPaciente.Text))
                    {
                        valida = false;
                        txtCodigoPaciente.Focus();
                        MessageBox.Show("Paciente no puede quedar vacio...!!");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtDatospositivos.Text))
                        {
                            valida = false;
                            txtDatospositivos.Focus();
                            MessageBox.Show("Datos positivos no puede quedar vacio...!!");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(cmbTipoExamen.Text))
                            {
                                valida = false;
                                cmbTipoExamen.Focus();
                                MessageBox.Show("Examenes complementarios no puede quedar vacio...!!");
                            }


                        }
                    }

                }
            }
            return valida;
        }

        ///llenamos el datatable con sl script de la tabla
        public DataTable llenar_examenescomplemetarios()
        {
            DataTable dt = new DataTable();

            SqlConnection sqlCon = null;
            String SqlconString = ConfigurationManager.ConnectionStrings["CLINICA"].ConnectionString;

            using (sqlCon = new SqlConnection(SqlconString))
            {
                sqlCon.Open();

                string query = "select ID_EXAMEN_COMPLEMENTARIO ,DESCRIPCION_EXAMEN_COMPLEMENTARIO from EXAMENES_COMPLEMENTARIOS";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        /// llenamos el combo con los datos del datatable
        public void llenar_combo_examenes() /// llenamos el combo con los datos del datatable
        {
            Examenes opcar = new Examenes();
            var dt = opcar.llenar_examenescomplemetarios();

            cmbTipoExamen.ValueMember = "ID_EXAMEN_COMPLEMENTARIO";
            cmbTipoExamen.DisplayMember = "DESCRIPCION_EXAMEN_COMPLEMENTARIO";
            cmbTipoExamen.DataSource = dt;
            //CMBTipoLogueo.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validando() == true)
            {
                salvar();
            }
        }

        private void Examenes_Load(object sender, EventArgs e)
        {
            llenar_combo_examenes();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
