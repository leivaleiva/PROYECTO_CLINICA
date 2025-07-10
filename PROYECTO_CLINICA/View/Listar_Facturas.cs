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
    public partial class Listar_Facturas : Form
    {
        FacturaModel Modelo;
        public Listar_Facturas()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            new FacturaController().ListarFacturas();
            dgvFacturaslista.DataSource = FacturaModel.GetFactura;
        }

        private void Listar_Facturas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Facturacion_Inventario Factura_insert = new Facturacion_Inventario();
            Factura_insert.Padre = this;
            Factura_insert.ShowDialog();
        }

        void Eliminar()
        {
            Modelo = new FacturaModel();

            Modelo.N_Factura = int.Parse(dgvFacturaslista.SelectedCells[0].Value.ToString());

            if (new FacturaController().EliminarFactura(Modelo) == true)
            {
                MessageBox.Show("Registro Eliminado Correctamente..!!", "Informacion del sistema");
                CargarDatos();
            }
        }

        void Filtrar()  ///este codigo sirve para filtrar registros
        {
            FacturaModel.GetFactura.DefaultView.RowFilter = $"N_FACTURA+FECHA_EMISION+ID_USUARIO+ID_PACIENTE+TOTAL like '%{txtFiltro.Text}%'";
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Verifica si hay un registro seleccionado
            if (dgvFacturaslista.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Esta seguro de Eliminar el registro ?", "Informacion del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvFacturaslista.SelectedRows)
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

        private void dgvFacturaslista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
 }

