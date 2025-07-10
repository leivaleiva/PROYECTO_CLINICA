using PROYECTO_CLINICA.Controller;
using PROYECTO_CLINICA.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PROYECTO_CLINICA.View
{
    public partial class PacientesLista : Form
    {
        PacientesModel Modelo;
        public PacientesLista()
        {
            InitializeComponent();
            BTNEliminar.Enabled = false;
        }

        public void CargarDatos()
        {
            new PacientesController().ListarPaciente();

            DGVDatos.DataSource = PacientesModel.GetPaciente;
        }

        private void PacientesLista_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PacientesPerfil formu = new PacientesPerfil();
            formu.Padre = this; //esta variable tiene realcion con el usuario que la invoca
            formu.ShowDialog();
        }

        void EliminarRegistros()
        {
            if (MessageBox.Show("Esta seguro de Eliminar el registro ?", "Informacion del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Modelo = new PacientesModel();

                Modelo.ID_PACIENTE = int.Parse(DGVDatos.SelectedCells[0].Value.ToString());

                if (new PacientesController().EliminarPaciente(Modelo) == true)
                {
                    MessageBox.Show("Registro Eliminado Correctamente..!!", "Informacion del sistema");
                    CargarDatos();
                }
            }
            BTNEliminar.Enabled = false;
        }



        public DataTable llenar_grid()
        {
            DataTable dt = new DataTable();

            SqlConnection sqlCon = null;
            String SqlconString = ConfigurationManager.ConnectionStrings["CLINICA"].ConnectionString;

            using (sqlCon = new SqlConnection(SqlconString))
            {

                sqlCon.Open();

                SqlCommand cmd = new SqlCommand("sp_BuscarPacientePorDNI", sqlCon);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@DNI", SqlDbType.VarChar).Value = this.txtUbicar.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                da.Dispose();

                this.DGVDatos.DataSource = dt;

                sqlCon.Close();
            }
            return dt;
        }

        private void DGVDatos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PacientesPerfil formu = new PacientesPerfil(DGVDatos["ID_PACIENTE", e.RowIndex].Value.ToString());
            formu.Padre = this; //esta variable tiene realcion con el usuario que la invoca
            formu.ShowDialog();
        }

        private void DGVDatos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BTNEliminar.Enabled = true;
        }

        private void DGVDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BTNEliminar.Enabled = false;
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistros();
        }

        private void txtUbicar_TextChanged(object sender, EventArgs e)
        {
            //Filtrando();
        }

        private void BTNReporte_Click(object sender, EventArgs e)
        {
            Reporteador reporte = new Reporteador(1);
            reporte.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); //cierra formulario y vuele al anterior
            PantallaMenu pantallaMenu = new PantallaMenu();
            pantallaMenu.ShowDialog();
        }

        private void eXAMENESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.ExamenesLista examen = new View.ExamenesLista();
            this.Hide();
            examen.ShowDialog();
            this.Show();
        }

        private void rECEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.CapturarPacientes recetas = new View.CapturarPacientes();
            this.Hide();
            recetas.ShowDialog();
            this.Show();
        }

        private void eXPEDIENTECLINICOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.ExpedienteClinicoListar expediente = new View.ExpedienteClinicoListar();
            this.Hide();
            expediente.ShowDialog();
            this.Show();
        }

        private void eNFERMEDADESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Enfermedades enfermedades = new View.Enfermedades();
            this.Hide();
            enfermedades.ShowDialog();
            this.Show();
        }
    }
 }


