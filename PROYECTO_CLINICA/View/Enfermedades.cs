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
using System.Reflection;

namespace PROYECTO_CLINICA.View
{
    public partial class Enfermedades : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public Enfermedades()
        {
            InitializeComponent();
            LoadComboBoxes(); // Llama al método para llenar los ComboBox
        }

        public class ComboBoxItem
        {
            public int ID { get; set; }
            public string Nombre { get; set; }

            public override string ToString()
            {
                return Nombre; // Esto es lo que se mostrará en el ComboBox
            }
        }

        private void Enfermedades_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CLINICA"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))

                try
                {
                    connection.Open();
                    dataAdapter = new SqlDataAdapter("SELECT * FROM CATALOGO_ENFERMEDADES", connection);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }

        }

        private void LoadComboBoxes()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CLINICA"].ConnectionString;
            // Cargar Pacientes en el ComboBox
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT ID_PACIENTE, NOMBRES FROM CATALOGO_PACIENTES", connection);
                    SqlDataReader reader = command.ExecuteReader();
                    comboBoxPaciente.Items.Clear(); // Limpiar antes de cargar
                    while (reader.Read())
                    {
                        comboBoxPaciente.Items.Add(new ComboBoxItem
                        {
                            ID = Convert.ToInt32(reader["ID_PACIENTE"]),
                            Nombre = reader["NOMBRES"].ToString()
                        });
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar pacientes: " + ex.Message);
                }
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodEnfermedad.Text) ||
                comboBoxPaciente.SelectedItem == null ||
                string.IsNullOrWhiteSpace(NombreEnfermedad.Text) ||
                string.IsNullOrWhiteSpace(ListaTratamientos.Text) ||
                string.IsNullOrWhiteSpace(DescripcionEnfermedad.Text) ||
                string.IsNullOrWhiteSpace(PrevencionEnfermedad.Text) ||
                string.IsNullOrWhiteSpace(SintomasEnfermedad.Text) ||
                string.IsNullOrWhiteSpace(CausasEnfermedad.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CLINICA"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))

                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("INSERT INTO CATALOGO_ENFERMEDADES (ID_ENFERMEDAD, ID_PACIENTE, NOMBRE_ENFERMEDAD, TRATAMIENTO, FECHA_REGISTRO, DESCRIPCIÓN, PREVENCIÓN, SINTOMAS, CAUSAS) VALUES (@ID_ENFERMEDAD, @ID_PACIENTE, @NOMBRE_ENFERMEDAD, @TRATAMIENTO, @FECHA_REGISTRO, @DESCRIPCIÓN, @PREVENCIÓN, @SINTOMAS, @CAUSAS)", connection);

                    command.Parameters.AddWithValue("@ID_ENFERMEDAD", (txtCodEnfermedad.Text));
                    command.Parameters.AddWithValue("@ID_PACIENTE", ((ComboBoxItem)comboBoxPaciente.SelectedItem).ID);
                    command.Parameters.AddWithValue("@NOMBRE_ENFERMEDAD", NombreEnfermedad.Text);
                    command.Parameters.AddWithValue("@TRATAMIENTO", ListaTratamientos.Text);
                    command.Parameters.AddWithValue("@FECHA_REGISTRO", FechaRegistro.Value);
                    command.Parameters.AddWithValue("@DESCRIPCIÓN", DescripcionEnfermedad.Text);
                    command.Parameters.AddWithValue("@PREVENCIÓN", PrevencionEnfermedad.Text);
                    command.Parameters.AddWithValue("@SINTOMAS", SintomasEnfermedad.Text);
                    command.Parameters.AddWithValue("@CAUSAS", CausasEnfermedad.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("¡Datos guardados exitosamente!");
                    LoadData(); // Refresh DataGridView
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving data: " + ex.Message);
                }
        }
        private void ClearFields()
        {
            txtCodEnfermedad.Text = string.Empty;
            comboBoxPaciente.SelectedIndex = -1;
            NombreEnfermedad.Text = string.Empty;
            ListaTratamientos.Text = string.Empty;
            DescripcionEnfermedad.Text = string.Empty;
            PrevencionEnfermedad.Text = string.Empty;
            SintomasEnfermedad.Text = string.Empty;
            CausasEnfermedad.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NombreEnfermedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void CausasEnfermedad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

