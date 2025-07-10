using PROYECTO_CLINICA.Controller;
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

namespace PROYECTO_CLINICA.View
{
    public partial class ExpedienteClinicoListar : Form
    {
        ExpedienteClinicoModel Modelo;
        public ExpedienteClinicoListar()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            new ExpedienteClinicoController().ListarExpediente();
            dgvDatosExpediente.DataSource = ExpedienteClinicoModel.GetExpediente;
        }

        private void ExpedienteClinicoListar_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ExpedienteClinico expediente = new ExpedienteClinico();
            expediente.Padre = this;
            expediente.ShowDialog();
        }

        private void dgvDatosExpediente_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ExpedienteClinico expediente = new ExpedienteClinico(dgvDatosExpediente["ID_EXPEDIENTE", e.RowIndex].Value.ToString());
            expediente.Padre = this;
            expediente.ShowDialog();
        }

        void Filtrar()  ///este codigo sirve para filtrar registros
        {
            ExpedienteClinicoModel.GetExpediente.DefaultView.RowFilter =$"CONVERT(ID_PACIENTE, 'System.String') LIKE '%{txtFiltroExpediente.Text}%'";

            if (int.TryParse(txtFiltroExpediente.Text, out int filtroValor))
            {
                ExpedienteClinicoModel.GetExpediente.DefaultView.RowFilter =
                    $"ID_PACIENTE = {filtroValor}";
            }
            else
            {
                // Manejar el caso en que el texto no sea un número válido
                MessageBox.Show("Por favor, ingrese un valor numérico.");
            }

        }

        void Eliminar()
        {
            Modelo = new ExpedienteClinicoModel();

            Modelo.ID_EXPEDIENTE = int.Parse(dgvDatosExpediente.SelectedCells[0].Value.ToString());

            if (new ExpedienteClinicoController().EliminarExpediente(Modelo) == true)
            {
                MessageBox.Show("Registro Eliminado Correctamente..!!", "Informacion del sistema");
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            //Verifica si hay un registro seleccionado
            if (dgvDatosExpediente.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Esta seguro de Eliminar el registro ?", "Informacion del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvDatosExpediente.SelectedRows)
                    {
                        Eliminar();
                        //DGVDatos.Rows.Remove(row);
                        CargarDatos();
                    }
                }
                else
                {
                    MessageBox.Show("Registro no eliminado", "Informacion del sistema");
                }
            }
            else
            {
                MessageBox.Show("Selecciona una casilla para eliminar", "Informacion del Sistema");
            }
        }

        private void txtFiltroExpediente_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }
    }
}
