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
using System.Configuration;
using PROYECTO_CLINICA.Controller;
using PROYECTO_CLINICA.Model;

namespace PROYECTO_CLINICA.View
{
    public partial class CapturarPacientes : Form
    {
        RecetasModel Modelo;
        public CapturarPacientes()
        {
            InitializeComponent();
            btnEliminarReceta.Enabled = false; 
        }

        public void CargarDatos()
        {
            new RecetasController().ListarReceta();

            dgvPacienteExpecifico.DataSource = RecetasModel.getReceta;
        }

        public DataTable llenar_grid_Por_Paciente()
        {
            DataTable dt = new DataTable();
            string sqlConString = ConfigurationManager.ConnectionStrings["CLINICA"].ConnectionString;

            using (SqlConnection sqlCon = new SqlConnection(sqlConString))
            {
                try
                {
                    sqlCon.Open();

                    // Validar que el campo de fecha no esté vacío y tenga el formato correcto
                    string fechaAtencion = this.txtUbicar.Text;
                    if (!DateTime.TryParse(fechaAtencion, out DateTime fecha))
                    {
                        throw new ArgumentException("La fecha de atención no es válida.");
                    }

                    SqlCommand cmd = new SqlCommand("RECETAS_POR_PACIENTE", sqlCon)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@FECHA_ATENCION", SqlDbType.Date).Value = fecha;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Dispose();

                    this.dgvPacienteExpecifico.DataSource = dt;
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




        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //llenar_grid_Expecifico();
            llenar_grid_Por_Paciente();
        }

        private void dgvPacienteExpecifico_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MedicamentosRecetados formu = new MedicamentosRecetados(dgvPacienteExpecifico["ID_MEDICAMENTO_RECETADO", e.RowIndex].Value.ToString());
            formu.Padre = this; //esta variable tiene realcion con el usuario que la invoca
            formu.ShowDialog();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            MedicamentosRecetados recetas = new MedicamentosRecetados();
            recetas.Padre = this; //esta variable tiene realcion con el usuario que la invoca
            recetas.ShowDialog();
        }

        void EliminarRegistros()
        {
            if (MessageBox.Show("Esta seguro de Eliminar el registro ?", "Informacion del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Modelo = new RecetasModel();

                Modelo.ID_PACIENTE = int.Parse(dgvPacienteExpecifico.SelectedCells[0].Value.ToString());

                if (new RecetasController().EliminarReceta(Modelo) == true)
                {
                    MessageBox.Show("Registro Eliminado Correctamente..!!", "Informacion del sistema");
                    CargarDatos();
                }
            }
            btnEliminarReceta.Enabled = false;
        }


        private void btnImprimirReceta_Click(object sender, EventArgs e)
        {
            Reporteador reporte = new Reporteador(3);
            reporte.ShowDialog();
        }

        private void CapturarPacientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dgvPacienteExpecifico_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEliminarReceta.Enabled = true;
        }

        private void dgvPacienteExpecifico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminarReceta.Enabled = false;
        }

        private void btnEliminarReceta_Click(object sender, EventArgs e)
        {
            EliminarRegistros();
        }

        private void txtUbicar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUbicar.Text))
            {
                dgvPacienteExpecifico.DataSource = null;
            }

            //habilita el boton al haber datos en la caja de texto
            btnBuscar.Enabled = !string.IsNullOrWhiteSpace(btnBuscar.Text);
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide(); //cierra formulario y vuele al anterior
            PacientesLista pantallaMenu = new PacientesLista();
            pantallaMenu.ShowDialog();
        }
    }
}
