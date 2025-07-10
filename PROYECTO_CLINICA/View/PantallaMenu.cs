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
    public partial class PantallaMenu : Form
    {
        public PantallaMenu()
        {
            InitializeComponent();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            View.PacientesLista frme = new View.PacientesLista();
            this.Hide();
            frme.ShowDialog();
            this.Show();
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            Catalogo_Medicamentos_Listar catalogo = new Catalogo_Medicamentos_Listar();
            this.Hide();
            catalogo.ShowDialog();
            this.Show();


        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            View.UsuariosLista usuario = new View.UsuariosLista();
            this.Hide();
            usuario.ShowDialog();
            this.Show();
        }

        private void btnControlCitas_Click(object sender, EventArgs e)
        {
            View.CitasLista controlCitas = new View.CitasLista();
            this.Hide();
            controlCitas.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View.DoctoresCrear controlCitas = new View.DoctoresCrear();
            this.Hide();
            controlCitas.ShowDialog();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            View.Listar_Facturas factura = new View.Listar_Facturas();
            this.Hide();
            factura.ShowDialog();
            this.Show();
        }

        private void PantallaMenu_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
