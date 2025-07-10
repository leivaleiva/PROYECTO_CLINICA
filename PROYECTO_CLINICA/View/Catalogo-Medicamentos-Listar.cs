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
    public partial class Catalogo_Medicamentos_Listar : Form
    {
        MedicamentosModel Modelo;
        public Catalogo_Medicamentos_Listar()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            new MedicamentosController().ListarMedicamentos();
            DGVMedicamentos.DataSource = MedicamentosModel.GetMedicamentos;
        }

        private void Catalogo_Medicamentos_Listar_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Catalogo_Medicamento_Insumos medicamentos_insert = new Catalogo_Medicamento_Insumos();
            medicamentos_insert.Padre = this;
            medicamentos_insert.ShowDialog();
        }

        private void DGVMedicamentos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Catalogo_Medicamento_Insumos medicamentos_insert = new Catalogo_Medicamento_Insumos(DGVMedicamentos["CODIGO_ITEM", e.RowIndex].Value.ToString());
            medicamentos_insert.Padre = this;
            medicamentos_insert.ShowDialog();
        }

        void Filtrar()  ///este codigo sirve para filtrar registros
        {
            MedicamentosModel.GetMedicamentos.DefaultView.RowFilter = $"CODIGO_ITEM+NOMBRE_ITEM+CATEGORIA+PROVEEDOR+DESCRIPCION like '%{txtFiltro.Text}%'";
        }

        void Eliminar()
        {
            Modelo = new MedicamentosModel();

            Modelo.CodigoITEM = int.Parse(DGVMedicamentos.SelectedCells[0].Value.ToString());

            if (new MedicamentosController().EliminarMedicamentos(Modelo) == true)
            {
                MessageBox.Show("Registro Eliminado Correctamente..!!", "Informacion del sistema");
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Verifica si hay un registro seleccionado
            if (DGVMedicamentos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Esta seguro de Eliminar el registro ?", "Informacion del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in DGVMedicamentos.SelectedRows)
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

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); //cierra formulario y vuele al anterior
            PantallaMenu pantallaMenu = new PantallaMenu();
            pantallaMenu.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

