using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_CLINICA.Model;
using PROYECTO_CLINICA.Controller;

namespace PROYECTO_CLINICA.View
{
    public partial class UsuariosLista : Form
    {
        UsuariosModel Modelo;
        public UsuariosLista()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            new UsuariosController().ListarUsuarios();
            DGVDatos.DataSource = UsuariosModel.GetUsuarios;
        }

        private void UsuariosLista_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            UsuariosPerfil Formu = new UsuariosPerfil();
            Formu.Padre = this;
            Formu.ShowDialog();
        }

        void EliminarRegistros()
        {
            if (MessageBox.Show("Esta seguro de Eliminar el registro ?", "Informacion del Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Modelo = new UsuariosModel();

                Modelo.ID_USUARIO = (DGVDatos.SelectedCells[0].Value.ToString());

                if (new UsuariosController().EliminarUsuario(Modelo.ID_USUARIO.ToString()) == true)
                {
                    MessageBox.Show("Registro Eliminado Correctamente..!!", "Informacion del sistema");
                    CargarDatos();
                }
            }
            btnEliminar.Enabled = false;
        }

        private void DGVDatos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UsuariosPerfil Formu = new UsuariosPerfil(DGVDatos["ID_USUARIO", e.RowIndex].Value.ToString());
            Formu.Padre = this;
            Formu.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarRegistros();
        }

        private void DGVDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private void DGVDatos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); //cierra formulario y vuele al anterior
            PantallaMenu pantallaMenu = new PantallaMenu();
            pantallaMenu.ShowDialog();
        }
    }
}
