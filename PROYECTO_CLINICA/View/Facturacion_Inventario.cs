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
using System.Data.SqlClient;

namespace PROYECTO_CLINICA.View
{
    public partial class Facturacion_Inventario : Form
    {
        public int cuenta;
        FacturaModel modelo;
        String modo = "";

        public Listar_Facturas Padre;
        public Facturacion_Inventario()
        {
            InitializeComponent();
        }

        private void cmbServicioBien_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbEleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string DatoSeleccionado = cmbEleccion.Text;

            if (cuenta == 1)
            {
                try
                {
                    using (SqlConnection Con = new Conexion().GetConnection())
                    {
                        Con.Open();
                        string qry = "Select * FROM MODULO_MEDICAMENTOS_E_INSUMOS WHERE NOMBRE_ITEM = @NOMBREITEM";

                        using (SqlCommand cmd = new SqlCommand(qry, Con))
                        {
                            cmd.Parameters.AddWithValue("@NOMBREITEM", DatoSeleccionado);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    lblCodigo.Text = reader["CODIGO_ITEM"].ToString();
                                    lblNombre.Text = reader["NOMBRE_ITEM"].ToString();
                                }

                            }

                        }
                        Con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cuenta == 2)
            {
                try
                {
                    using (SqlConnection Con = new Conexion().GetConnection())
                    {
                        Con.Open();
                        string qry = "Select * FROM MODULO_CITAS WHERE NOMBRES = @NOMBRES";

                        using (SqlCommand cmd = new SqlCommand(qry, Con))
                        {
                            cmd.Parameters.AddWithValue("@NOMBRES", DatoSeleccionado);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    lblCodigo.Text = reader["ID_CITA"].ToString();
                                    lblNombre.Text = reader["NOMBRES"].ToString();
                                }

                            }

                        }
                        Con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (cuenta == 3)
            {
                try
                {
                    using (SqlConnection Con = new Conexion().GetConnection())
                    {
                        Con.Open();
                        string qry = "Select * FROM EXAMENES_COMPLEMENTARIOS WHERE DESCRIPCION_EXAMEN_COMPLEMENTARIO = @EXAMEN";

                        using (SqlCommand cmd = new SqlCommand(qry, Con))
                        {
                            cmd.Parameters.AddWithValue("@EXAMEN", DatoSeleccionado);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    lblCodigo.Text = reader["ID_EXAMEN_COMPLEMENTARIO"].ToString();
                                    lblNombre.Text = reader["DESCRIPCION_EXAMEN_COMPLEMENTARIO"].ToString();
                                }

                            }

                        }
                        Con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("No se encontró el medicamento con el ID especificado.");
            }
        }

        private void cmbServicioBien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nom;

            nom = cmbServicioBien.SelectedItem.ToString();

            switch (nom)
            {
                case "MEDICAMENTO":
                    try
                    {
                        using (SqlConnection Con = new Conexion().GetConnection())
                        {
                            Con.Open();
                            string qry = "Select * FROM CATALOGO_MEDICAMENTOS_E_INSUMOS";

                            using (SqlCommand cmd = new SqlCommand(qry, Con))
                            {
                                SqlDataReader reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    cmbEleccion.Items.Add(reader["NOMBRE_ITEM"].ToString());
                                }
                            }
                            Con.Close();
                            cuenta = 1;
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    ;
                    break;

                case "CITA":
                    try
                    {
                        using (SqlConnection Con = new Conexion().GetConnection())
                        {
                            Con.Open();
                            string qry = "Select * FROM MODULO_CITAS";

                            using (SqlCommand cmd = new SqlCommand(qry, Con))
                            {
                                SqlDataReader reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    cmbEleccion.Items.Add(reader["NOMBRES"].ToString());
                                }
                            }
                            Con.Close();
                            cuenta = 2;
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    ;
                    break;

                //EXAMENES
                default:
                    try
                    {
                        using (SqlConnection Con = new Conexion().GetConnection())
                        {
                            Con.Open();
                            string qry = "Select * FROM EXAMENES_COMPLEMENTARIOS";

                            using (SqlCommand cmd = new SqlCommand(qry, Con))
                            {
                                SqlDataReader reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    cmbEleccion.Items.Add(reader["DESCRIPCION_EXAMEN_COMPLEMENTARIO"].ToString());
                                }
                            }
                            Con.Close();
                            cuenta = 3;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    ;
                    break;

            }
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "Select * FROM CATALOGO_USUARIOS";

                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cmbUsuario.Items.Add(reader["NOMBRE"].ToString());
                        }
                    }
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "Select * FROM CATALOGO_PACIENTES";

                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cmbPaciente.Items.Add(reader["NOMBRES"].ToString());
                        }
                    }
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvItems);

            file.Cells[0].Value = lblCodigo.Text;
            file.Cells[1].Value = lblNombre.Text;
            file.Cells[2].Value = txtPrecio.Text;
            file.Cells[3].Value = txtCant.Text;
            file.Cells[4].Value = txtDescuento.Text;
            file.Cells[5].Value = txtImpuesto.Text;
            file.Cells[6].Value = (float.Parse(txtPrecio.Text) * float.Parse(txtCant.Text)).ToString();

            dgvItems.Rows.Add(file);

            lblCodigo.Text = lblNombre.Text = "";

            ObtenerTotal();
        }

        public void ObtenerTotal()
        {
            float Total = 0;
            int Contador = 0;

            Contador = dgvItems.RowCount;

            for (int i = 0; i < Contador; i++)
            {
                Total += float.Parse(dgvItems.Rows[i].Cells[6].Value.ToString());
            }

            lblTotal.Text = Total.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rppta = MessageBox.Show("¿Desea eliminar el registro?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rppta == DialogResult.Yes)
                {
                    dgvItems.Rows.Remove(dgvItems.CurrentRow);
                }

            }
            catch
            {

            }
            ObtenerTotal();
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblCambio.Text = (float.Parse(txtEfectivo.Text) - float.Parse(lblTotal.Text)).ToString();
            }
            catch { }
        }

        void Guardar()
        {
            modelo = new FacturaModel();
            dtpEmision.MinDate = DateTime.Now;
            dtpVencimiento.MinDate = DateTime.Now;

            modelo.N_Factura = int.Parse(txtFactura.Text);
            modelo.FechaEmision = dtpEmision.Value;
            modelo.FechaVencimiento = dtpVencimiento.Value;
            modelo.FormaPago = "";
            modelo.IdUsuario = cmbUsuario.SelectedIndex;
            modelo.IdPaciente = cmbPaciente.SelectedIndex;
            modelo.RTN = txtRTN.Text;

            if (cuenta == 1)
            {
                modelo.CodigoITEM = cmbEleccion.SelectedIndex;
            }
            else if (cuenta == 2)
            {
                modelo.IdCitas = cmbEleccion.SelectedIndex;
            }
            else if (cuenta == 3)
            {
                modelo.IdExamenes = cmbEleccion.SelectedIndex;
            }

            modelo.Descripcion = "";
            modelo.Cantidad = int.Parse(txtCant.Text);
            modelo.Precio = float.Parse(txtPrecio.Text);
            modelo.Descuento = float.Parse(txtDescuento.Text);
            modelo.Sub_Total = (float.Parse(txtPrecio.Text) * float.Parse(txtCant.Text));
            modelo.Impuesto = float.Parse(txtImpuesto.Text);
            modelo.Total = float.Parse(lblTotal.Text);
            modelo.Efectivo = int.Parse(txtEfectivo.Text);
            modelo.Cambio = float.Parse(lblCambio.Text);


            if (modo == "Agregando")
            {
                if (new FacturaController().CrearFacturas(modelo) == true)
                {
                    //Padre.CargarDatos();
                    MessageBox.Show("Registro Agregado Exitosamente..!!");
                    this.Close();
                }
            }
            /*else
            {
                if (new MedicamentosController().ActualizarMedicamentos(modelo) == true)
                {
                    //Padre.CargarDatos();
                    MessageBox.Show("Registro Editado Exitosamente..!!");
                    this.Close();
                }
            }*/
        }

        Boolean Validando()
        {
            Boolean Valida = true;
            if (string.IsNullOrEmpty(txtFactura.Text))
            {
                Valida = false;
                txtFactura.Focus();
                MessageBox.Show("El Numero de la Factura no debe de quedar vacío..!!");
            }
            else
            {
                if (string.IsNullOrEmpty(dtpEmision.Text))
                {
                    Valida = false;
                    dtpEmision.Focus();
                    MessageBox.Show("La fecha de Emision no debe de quedar sin rellenar..!!");
                }
                else
                {
                    if (string.IsNullOrEmpty(dtpVencimiento.Text))
                    {
                        Valida = false;
                        dtpVencimiento.Focus();
                        MessageBox.Show("La fecha de vencimiento no debe de quedar sin rellenar..!!");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(cmbUsuario.Text))
                        {
                            Valida = false;
                            cmbUsuario.Focus();
                            MessageBox.Show("Usuario no debe de quedar vacío..!!");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(cmbPaciente.Text))
                            {
                                Valida = false;
                                cmbPaciente.Focus();
                                MessageBox.Show("Paciente no debe de quedar vacío..!!");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(txtCant.Text))
                                {
                                    Valida = false;
                                    txtCant.Focus();
                                    MessageBox.Show("Cantidad no debe de quedar vacío..!!");
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(txtPrecio.Text))
                                    {
                                        Valida = false;
                                        txtPrecio.Focus();
                                        MessageBox.Show("Precio no debe de quedar vacío..!!");
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(txtDescuento.Text))
                                        {
                                            Valida = false;
                                            txtDescuento.Focus();
                                            MessageBox.Show("Descuento no debe de quedar vacío..!!");
                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(txtImpuesto.Text))
                                            {
                                                Valida = false;
                                                txtImpuesto.Focus();
                                                MessageBox.Show("Impuesto Disponible no debe de quedar vacío..!!");
                                            }
                                            else
                                            {
                                                if (string.IsNullOrEmpty(txtEfectivo.Text))
                                                {
                                                    Valida = false;
                                                    txtEfectivo.Focus();
                                                    MessageBox.Show("Efectivo no debe de quedar vacío..!!");
                                                }

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            return Valida;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (Validando() == true)
            {
                Guardar();
                this.Close();
            }
        }
    }
 }


