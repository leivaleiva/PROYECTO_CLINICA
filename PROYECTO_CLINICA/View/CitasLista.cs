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
using PROYECTO_CLINICA.Controller;

namespace PROYECTO_CLINICA.View
{
    public partial class CitasLista : Form
    {
        CitasModel Modelo;
        public CitasLista()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            new CitasController().ListarCitas();
            dgvDatos.DataSource = CitasModel.GetCita;
        }

        private void btnNuevaCita_Click(object sender, EventArgs e)
        {
            NuevaCita nuevaCita = new NuevaCita();
            nuevaCita.Padre = this;
            nuevaCita.ShowDialog();
        }

        private void CitasLista_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            CargarDatos();
        }

        void EliminarRegistros()
        {
            if (MessageBox.Show("Esta seguro de Eliminar el registro ?", "Informacion del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Modelo = new CitasModel();

                Modelo.ID_CITA = int.Parse(dgvDatos.SelectedCells[0].Value.ToString());

                if (new CitasController().EliminarCita(Modelo.ID_CITA.ToString()) == true)
                {
                    MessageBox.Show("Registro Eliminado Correctamente..!!", "Informacion del sistema");
                    CargarDatos();
                }
            }
            btnEliminar.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDatos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            NuevaCita nuevaCita = new NuevaCita(dgvDatos["ID_CITA", e.RowIndex].Value.ToString());
            nuevaCita.Padre = this;
            nuevaCita.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistros();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = false;
        }

        private void dgvDatos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private void btnReporteCita_Click(object sender, EventArgs e)
        {
            Reporteador reporte = new Reporteador(2);
            reporte.ShowDialog();
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); //cierra formulario y vuele al anterior
            PantallaMenu pantallaMenu = new PantallaMenu();
            pantallaMenu.ShowDialog();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
    }

        

        
        
        



