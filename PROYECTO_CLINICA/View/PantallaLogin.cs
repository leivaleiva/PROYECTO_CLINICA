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

namespace PROYECTO_CLINICA.View
{
    public partial class PantallaLogin : Form
    {
        public PantallaLogin()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server =DESKTOP-9BHGGLA;database=DB_CLINICA; integrated security=true ");

        void InvocandoHuella()
        {
            VerificandoHuella formulario = new VerificandoHuella();
            formulario.ShowDialog();

        }
        private void BTNHuella_Click(object sender, EventArgs e)
        {
            InvocandoHuella();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "select * from CATALOGO_USUARIOS where USER_CREACION = '" + textBox1.Text + "' and CONTRASENA= '" + textBox2.Text + "'";
            SqlCommand Comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = Comando.ExecuteReader();

            if (lector.HasRows == true)
            {

                PantallaMenu frmbienvenido = new PantallaMenu();
                this.Hide();
                frmbienvenido.Show();
            }

            else
            {

                MessageBox.Show(" Usuario o contraseña incorrectos");
            }

            conexion.Close();
        }

        private void PantallaLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


