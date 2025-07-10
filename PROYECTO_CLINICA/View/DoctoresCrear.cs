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
    public partial class DoctoresCrear : Form
    {
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public DoctoresCrear()
        {
            InitializeComponent();
            LoadData();
            LoadEspecialidades();

            // Agregar validación para TextBox
            txtCodigoDoctor.KeyPress += new KeyPressEventHandler(txtCodigoDoctor_KeyPress);
            txtTelefonoDoctor.KeyPress += new KeyPressEventHandler(txtTelefonoDoctor_KeyPress);
        }

        public class EspecialidadItem
        {
            public int ID { get; set; }
            public string Nombre { get; set; }

            public override string ToString()
            {
                return Nombre; // Esto es lo que se mostrará en el ComboBox
            }
        }
        private void LoadData()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CLINICA"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    dataAdapter = new SqlDataAdapter("SELECT * FROM CATALOGO_DOCTORES", connection);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                    // Cambiar los nombres de las columnas
                    dataGridView1.Columns["ID_DOCTOR"].HeaderText = "Codigo";
                    dataGridView1.Columns["NOMBRE"].HeaderText = "Nombre";
                    dataGridView1.Columns["APELLIDO"].HeaderText = "Apellido";
                    dataGridView1.Columns["TELEFONO"].HeaderText = "Telefono";
                    dataGridView1.Columns["DIRECCIÓN"].HeaderText = "Direccion";
                    dataGridView1.Columns["HORARIO_ATENCION"].HeaderText = "Horario";
                    dataGridView1.Columns["ID_DOCTOR_ESPECIALIDAD"].HeaderText = "Especialidad";
                    dataGridView1.Columns["FECHA_CONTRATACION"].HeaderText = "Fecha Contrato";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void LoadEspecialidades()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CLINICA"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT ID_DOCTOR_ESPECIALIDAD, ESPECIALIDAD FROM DOCTOR_ESPECIALIDADES", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    comboBoxEspecialidad.Items.Clear();
                    while (reader.Read())
                    {
                        comboBoxEspecialidad.Items.Add(new EspecialidadItem
                        {
                            ID = Convert.ToInt32(reader["ID_DOCTOR_ESPECIALIDAD"]),
                            Nombre = reader["ESPECIALIDAD"].ToString()
                        });
                    }

                    reader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading specialties: " + ex.Message);
                }
            }
        }


        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); //cierra formulario y vuele al anterior
            PantallaMenu pantallaMenu = new PantallaMenu();
            pantallaMenu.ShowDialog();
        }

        private void txtCodigoDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ClearFields()
        {
            txtCodigoDoctor.Clear();
            txtNombreDoctor.Clear();
            txtApellidoDoctor.Clear();
            txtTelefonoDoctor.Clear();
            txtDireccionDoctor.Clear();
            listBoxHorarioAtencion.Items.Clear();
            comboBoxEspecialidad.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoDoctor.Text) ||
                string.IsNullOrWhiteSpace(txtNombreDoctor.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoDoctor.Text) ||
                string.IsNullOrWhiteSpace(txtTelefonoDoctor.Text) ||
                string.IsNullOrWhiteSpace(txtDireccionDoctor.Text) ||
                listBoxHorarioAtencion.SelectedItem == null ||
                comboBoxEspecialidad.SelectedItem == null)
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID de la especialidad seleccionada
            var selectedEspecialidad = (EspecialidadItem)comboBoxEspecialidad.SelectedItem;
            int especialidadId = selectedEspecialidad.ID;

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CLINICA"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("INSERT INTO CATALOGO_DOCTORES (ID_DOCTOR, NOMBRE, APELLIDO, TELEFONO, FECHA_CONTRATACION, DIRECCIÓN, HORARIO_ATENCION, ID_DOCTOR_ESPECIALIDAD) VALUES (@ID_DOCTOR, @NOMBRE, @APELLIDO, @TELEFONO, @FECHA_CONTRATACION, @DIRECCIÓN, @HORARIO_ATENCION, @ID_DOCTOR_ESPECIALIDAD)", connection);

                    command.Parameters.AddWithValue("@ID_DOCTOR", txtCodigoDoctor.Text);
                    command.Parameters.AddWithValue("@NOMBRE", txtNombreDoctor.Text);
                    command.Parameters.AddWithValue("@APELLIDO", txtApellidoDoctor.Text);
                    command.Parameters.AddWithValue("@TELEFONO", txtTelefonoDoctor.Text);
                    command.Parameters.AddWithValue("@FECHA_CONTRATACION", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@DIRECCIÓN", txtDireccionDoctor.Text);
                    command.Parameters.AddWithValue("@HORARIO_ATENCION", listBoxHorarioAtencion.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@ID_DOCTOR_ESPECIALIDAD", especialidadId);

                    command.ExecuteNonQuery();

                    MessageBox.Show("¡Datos guardados exitosamente!");
                    LoadData(); // Refresh DataGridView
                    ClearFields(); // Clear fields after saving
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving data: " + ex.Message);
                }
            }
        }

        private void txtTelefonoDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DoctoresCrear_Load(object sender, EventArgs e)
        {

        }
    }
}
