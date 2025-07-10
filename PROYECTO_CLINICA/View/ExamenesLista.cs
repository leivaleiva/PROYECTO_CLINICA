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
using System.Data.SqlClient;
using PROYECTO_CLINICA.Controller;

namespace PROYECTO_CLINICA.View
{
    public partial class ExamenesLista : Form
    {
        ExamenesModel Modelo;
        public ExamenesLista()
        {
            InitializeComponent();
            btnEliminar.Enabled = false;
        }

        public void CargarDatos()
        {
            new ExamenesController().ListarExamnes();
            dataGridView1.DataSource = ExamenesModel.GetExamenes;
        }

        void EliminarRegistros()
        {
            if (MessageBox.Show("Esta seguro de Eliminar el registro ?", "Informacion del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Modelo = new ExamenesModel();

                Modelo.ID_EXAMENES = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());

                if (new ExamenesController().EliminarExamen(Modelo.ID_EXAMENES) == true)
                {
                    MessageBox.Show("Registro Eliminado Correctamente..!!", "Informacion del sistema");
                    CargarDatos();
                }
            }
            btnEliminar.Enabled = false;
        }
        public DataTable llenar_grid()
        {
            DataTable dt = new DataTable();

            SqlConnection sqlCon = null;
            String SqlconString = ConfigurationManager.ConnectionStrings["CLINICA"].ConnectionString;

            using (sqlCon = new SqlConnection(SqlconString))
            {

                sqlCon.Open();

                SqlCommand cmd = new SqlCommand("sp_BuscarExamenesPorID_EXAMENES", sqlCon);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID_EXAMENES", SqlDbType.VarChar).Value = this.txtubicar.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                da.Dispose();

                this.dataGridView1.DataSource = dt;

                sqlCon.Close();
            }
            return dt;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Examenes formu = new Examenes();
            formu.Padre = this; //esta variable tiene realcion con el usuario que la invoca
            formu.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistros();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = false;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Examenes formu = new Examenes(dataGridView1["ID_EXAMENES", e.RowIndex].Value.ToString());
            formu.Padre = this;
            formu.ShowDialog();
        }

        private void ExamenesLista_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); //cierra formulario y vuele al anterior
            PacientesLista pantallasubMenu = new PacientesLista();
            pantallasubMenu.ShowDialog();
        }
    }
}
