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
using System.Data.SqlClient;
using System.Configuration;
using System.Reflection;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace PROYECTO_CLINICA.View
{
    public partial class MedicamentosRecetados : Form
    {
        RecetasModel Modelo; // se crea una variable para usar la capa controladora 
        String Modo;
        public CapturarPacientes Padre; //esta variable se crea para usar en el metodo salva y que el datagrdview se refresce con el registro nuevo
        public MedicamentosRecetados()
        {
            InitializeComponent();
            Modo = "Agregando";
            //lblModo.Text = Modo;

            //esta linea de codigo me permite vaciar el data grid cuando borre los datos de la caja de texto
            txtBuscarpaciente.TextChanged += new EventHandler(txtBuscarpaciente_TextChanged);

            btnBuscarPaciente.Enabled = false;
        }


        public void CargarDatos()
        {
            new RecetasController().ListarReceta();

            dgvDatos.DataSource = RecetasModel.getReceta;
        }
        public MedicamentosRecetados(string ID_MEDICAMENTO_RECETADO)
        {
            InitializeComponent();// este nos permite ver que estamos actualizando
            Modo = "Actualizando";
            //lblModo.Text = Modo;
            txtCodigoMedicamento.Text = ID_MEDICAMENTO_RECETADO;
            txtCodigoMedicamento.Enabled = false;


            foreach (DataRow Fila in RecetasModel.getReceta.Rows)
            {
                if (Fila["ID_MEDICAMENTO_RECETADO"].ToString() == ID_MEDICAMENTO_RECETADO)
                {
                    dtpFechaAtencion.Text = Fila["FECHA_ATENCION"].ToString();
                    txtCodPaciente.Text = Fila["ID_PACIENTE"].ToString(); 
                    cmbServicio.SelectedText = Fila["ID_SERVICIO"].ToString();
                    cmbSexo.SelectedText = Fila["ID_SEXO"].ToString();
                    txtMedicamento.Text = Fila["MEDICAMENTO"].ToString();
                    txtConsentracion.Text = Fila["CONCENTRACION"].ToString();
                    txtPresentacion.Text = Fila["PRESENTACION"].ToString();
                    txtDosis.Text = Fila["DOSIS"].ToString();
                    txtCantidadIndicada.Text = Fila["CANTIDAD_INDICADA"].ToString();
                    txtDuracion.Text = Fila["DURACION"].ToString();
                    cmbMedico.SelectedText = Fila["ID_DOCTOR"].ToString();
                    break;
                }
            }
        }


        public void Guardar()
        {
            try
            {
                Modelo = new RecetasModel();

                Modelo.ID_MEDICAMENTO_RECETADO = int.Parse(txtCodigoMedicamento.Text);
                Modelo.FECHA_ATENCION = dtpFechaAtencion.Value.Date; // Asegurarse de que solo se guarde la fecha
                Modelo.ID_PACIENTE = int.Parse(txtCodPaciente.Text);
                Modelo.ID_SERVICIO = int.Parse(cmbServicio.SelectedValue.ToString());
                Modelo.ID_SEXO = int.Parse(cmbSexo.SelectedValue.ToString());
                Modelo.MEDICAMENTO = txtMedicamento.Text;
                Modelo.CONCENTRACION = txtConsentracion.Text;
                Modelo.PRESENTACION = txtPresentacion.Text;
                Modelo.DOSIS = txtDosis.Text;
                Modelo.CANTIDAD_INDICADA = txtCantidadIndicada.Text;
                Modelo.DURACION = txtDuracion.Text;
                Modelo.ID_DOCTOR = int.Parse(cmbMedico.SelectedValue.ToString());

                if (Modo == "Agregando")
                {
                    if (new RecetasController().CrearReceta(Modelo))
                    {
                        MessageBox.Show("Registro Agregado Exitosamente...!!");
                        Padre.CargarDatos(); // para refrescar el DataGridView
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al Insertar Receta", "Información del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (new RecetasController().ActualizarRecetasPacientes(Modelo))
                    {
                        Padre.CargarDatos(); // para refrescar el DataGridView
                        MessageBox.Show("Registro Editado Exitosamente...!!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al Editar Receta", "Información del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //metodo para registrar medicamentos recetados usando procedimiento almacenado


        Boolean validando()
        {
            Boolean valida = true;

            if (string.IsNullOrEmpty(txtCodigoMedicamento.Text))
            {
                valida = false;
                txtCodigoMedicamento.Focus();
                MessageBox.Show("codigo de medicamento no puede quedar vacio...!!");
            }
            else
            {
                if (string.IsNullOrEmpty(dtpFechaAtencion.Text))
                {
                    valida = false;
                    dtpFechaAtencion.Focus();
                    MessageBox.Show("Registre la fecha de atencion...!!");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtCodPaciente.Text))
                    {
                        valida = false;
                        txtCodPaciente.Focus();
                        MessageBox.Show("paciente no puede quedar vacio...!!");
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
                            if(string.IsNullOrEmpty(txtDNI.Text))
                            {
                                valida=false;
                                cmbServicio.Focus();
                                MessageBox.Show("Registre el servicio que se brindo...!!");
                            }
                            else  
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
                                    if (string.IsNullOrEmpty(txtMedicamento.Text))
                                    {
                                        valida = false;
                                        txtMedicamento.Focus();
                                        MessageBox.Show("Registre el medicamento...!!");
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(txtConsentracion.Text))
                                        {
                                            valida = false;
                                            txtConsentracion.Focus();
                                            MessageBox.Show("Valide la concentracion...!!");
                                        }
                                        else
                                            if(string.IsNullOrEmpty (cmbMedico.Text))
                                        {
                                            valida =false;
                                            cmbMedico.Focus();
                                            MessageBox.Show("Registre el medico que atendio...!!");
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


        //se usa un procedimiento para ver pacientes con datos especificos
        public DataTable llenar_grid_Por_Paciente()
        {
            DataTable dt = new DataTable();
            string sqlConString = ConfigurationManager.ConnectionStrings["CLINICA"].ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection(sqlConString))
            {
                try
                {
                    sqlCon.Open();

                    // Validar que el campo DNI no esté vacío y tenga la longitud correcta
                    string dni = this.txtBuscarpaciente.Text;
                    if (string.IsNullOrWhiteSpace(dni) || dni.Length != 15) // Asumiendo que el DNI debe tener 13 caracteres
                    {
                        throw new ArgumentException("El número de identidad debe tener 13 caracteres.");
                    }

                    SqlCommand cmd = new SqlCommand("RECETAS_POR_PACIENTE", sqlCon)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@DNI", SqlDbType.VarChar).Value = dni;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Dispose();

                    this.dgvDatos.DataSource = dt;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ocurrió un error al acceder a la base de datos: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                    {
                        sqlCon.Close();
                    }
                }
            }
            return dt;
        }



        private void MedicamentosRecetados_Load(object sender, EventArgs e)
        {
            llenar_combo_servicio();
            llenar_combo_genero();
            llenar_combo_medicos();
            CargarDatos();
        }


        //para vaciar el data grid
        private void txtBuscarpaciente_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarpaciente.Text))
            {
                dgvDatos.DataSource = null;
            }

            //habilita el boton al haber datos en la caja de texto
            btnBuscarPaciente.Enabled = !string.IsNullOrWhiteSpace(txtBuscarpaciente.Text);
        }


        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            //llenar_grid_Por_Paciente();

            //codigo para buscar por DNI y llenar las cajas de texto con la info
            using (SqlConnection Con = new Conexion().GetConnection())

            {

                string CONSULTA = "SELECT * FROM CATALOGO_PACIENTES WHERE DNI ='" + txtBuscarpaciente.Text + "'";
                SqlCommand COMANDO = new SqlCommand(CONSULTA, Con);
                Con.Open();

                SqlDataReader LEER = COMANDO.ExecuteReader();
                if (LEER.Read() == true)
                {
                    txtCodPaciente.Text = LEER["ID_PACIENTE"].ToString();
                    txtNombrePaciente.Text = LEER["NOMBRES"].ToString();
                    txtDNI.Text = LEER["DNI"].ToString();
                    txtEdad.Text = LEER["EDAD"].ToString();
                    cmbSexo.Text = LEER["ID_SEXO"].ToString();
                }
            }
        }

        //aqui llenamos combo con el genero
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
            MedicamentosRecetados opcar = new MedicamentosRecetados();
            var dt = opcar.llenar_genero();

            cmbSexo.ValueMember = "ID_SEXO";
            cmbSexo.DisplayMember = "DESCRIPCION_SEXO";
            cmbSexo.DataSource = dt;
            cmbSexo.SelectedIndex = 0;
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
            MedicamentosRecetados opcar = new MedicamentosRecetados();
            var dt = opcar.llenar_medicos();

            cmbMedico.ValueMember = "ID_DOCTOR";
            cmbMedico.DisplayMember = "NOMBRE_COMPLETO";
            cmbMedico.DataSource = dt;
            cmbMedico.SelectedIndex = 0;
        }

        // LLENAREMOS EL COMBO BOX DE SERVICIO 
        public DataTable llenar_servicio() ///llenamos el datatable con sl script de la tabla
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
        public void llenar_combo_servicio() /// llenamos el combo con los datos del datatable
        {
            MedicamentosRecetados opcar = new MedicamentosRecetados();
            var dt = opcar.llenar_servicio();

            cmbServicio.ValueMember = "ID_SERVICIO";
            cmbServicio.DisplayMember = "DESCRIPCION_SERVICIO";
            cmbServicio.DataSource = dt;
            cmbServicio.SelectedIndex = 0;
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validando() == true)
                Guardar();
            
                //InsertarDatosRecetaSP();
        }

        private void btnImprimirReceta_Click(object sender, EventArgs e)
        {
            Reporteador reporte = new Reporteador(3);
            reporte.ShowDialog();
        }
    }
}
