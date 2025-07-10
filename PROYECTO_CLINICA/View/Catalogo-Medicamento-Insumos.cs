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
    public partial class Catalogo_Medicamento_Insumos : Form
    {
        MedicamentosModel modelo;
        String modo = "";


        public Catalogo_Medicamentos_Listar Padre;
        public Catalogo_Medicamento_Insumos()
        {
            InitializeComponent();
            modo = "Agregando";
        }

        public Catalogo_Medicamento_Insumos(string CodigoITEM)
        {
            InitializeComponent();
            modo = "Actualizando";
            txtCodigo.Text = CodigoITEM;
            txtCodigo.Enabled = false;

            foreach (DataRow Fila in MedicamentosModel.GetMedicamentos.Rows)
            {
                if (Fila["CODIGO_ITEM"].ToString() == CodigoITEM)
                {
                    txtNombre.Text = Fila["NOMBRE_ITEM"].ToString();
                    txtDescripcion.Text = Fila["DESCRIPCION"].ToString();
                    txtCategoria.Text = Fila["CATEGORIA"].ToString();
                    txtAlmacen.Text = Fila["UBICACION_ALMACEN"].ToString();
                    txtUDM.Text = Fila["UNIDAD_MEDIDA"].ToString();
                    txtCantDisp.Text = Fila["CANTIDAD_DISPONIBLE"].ToString();
                    txtCantidadPrecio.Text = Fila["PRECIO"].ToString();
                    txtIndicaciones.Text = Fila["INDICACIONES"].ToString();
                    txtContraindicaciones.Text = Fila["CONTRAINDICACIONES"].ToString();
                    DtpIngreso.Value = DateTime.Parse(Fila["FECHA_INGRESO"].ToString());
                    DtpVencimiento.Value = DateTime.Parse(Fila["FECHA_VENCIMIENTO"].ToString());
                    txtProveedor.Text = Fila["PROVEEDOR"].ToString();
                    ChkEstado.Checked = Boolean.Parse(Fila["ESTADO"].ToString());
                }
            }
        }

        void Guardar()
        {
            modelo = new MedicamentosModel();
            DtpIngreso.MinDate = DateTime.Now;
            DtpVencimiento.MinDate = DateTime.Now;

            modelo.CodigoITEM = int.Parse(txtCodigo.Text);
            modelo.NombreITEM = txtNombre.Text;
            modelo.Descripcion = txtDescripcion.Text;
            modelo.Categoria = txtCategoria.Text;
            modelo.ubicacion_almacen = txtAlmacen.Text;
            modelo.Unidad_Medida = txtUDM.Text;
            modelo.cantidad_disponible = int.Parse(txtCantDisp.Text);
            modelo.precio = float.Parse(txtCantidadPrecio.Text);
            modelo.indicaciones = txtIndicaciones.Text;
            modelo.contraindicaciones = txtContraindicaciones.Text;
            modelo.fecha_ingreso = DtpIngreso.Value;
            modelo.fecha_vencimiento = DtpVencimiento.Value;
            modelo.proveedor = txtProveedor.Text;
            modelo.Estado = ChkEstado.Checked;


            if (modo == "Agregando")
            {
                if (new MedicamentosController().CrearMedicamentos(modelo) == true)
                {
                    Padre.CargarDatos();
                    MessageBox.Show("Registro Agregado Exitosamente..!!");
                    this.Close();
                }
            }
            else
            {
                if (new MedicamentosController().ActualizarMedicamentos(modelo) == true)
                {
                    Padre.CargarDatos();
                    MessageBox.Show("Registro Editado Exitosamente..!!");
                    this.Close();
                }
            }
        }

        Boolean Validando()
        {
            Boolean Valida = true;
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                Valida = false;
                txtCodigo.Focus();
                MessageBox.Show("Codigo de ITEM no debe de quedar vacío..!!");
            }
            else
            {
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    Valida = false;
                    txtNombre.Focus();
                    MessageBox.Show("Nombre de ITEM no debe de quedar vacío..!!");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtDescripcion.Text))
                    {
                        Valida = false;
                        txtDescripcion.Focus();
                        MessageBox.Show("Descripcion del medicamento no debe de quedar vacío..!!");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtCategoria.Text))
                        {
                            Valida = false;
                            txtCategoria.Focus();
                            MessageBox.Show("Categoria no debe de quedar vacío..!!");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(txtAlmacen.Text))
                            {
                                Valida = false;
                                txtAlmacen.Focus();
                                MessageBox.Show("Ubicacion en almacen no debe de quedar vacío..!!");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(txtCategoria.Text))
                                {
                                    Valida = false;
                                    txtCategoria.Focus();
                                    MessageBox.Show("Tarjeta no debe de quedar vacío..!!");
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(txtUDM.Text))
                                    {
                                        Valida = false;
                                        txtUDM.Focus();
                                        MessageBox.Show("Unidad de medida no debe de quedar vacío..!!");
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(txtCategoria.Text))
                                        {
                                            Valida = false;
                                            txtCategoria.Focus();
                                            MessageBox.Show("Categoria no debe de quedar vacío..!!");
                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(txtCantDisp.Text))
                                            {
                                                Valida = false;
                                                txtCantDisp.Focus();
                                                MessageBox.Show("Cantidad Disponible no debe de quedar vacío..!!");
                                            }
                                            else
                                            {
                                                if (string.IsNullOrEmpty(txtCantidadPrecio.Text))
                                                {
                                                    Valida = false;
                                                    txtCantidadPrecio.Focus();
                                                    MessageBox.Show("Precio no debe de quedar vacío..!!");
                                                }
                                                else
                                                {
                                                    if (string.IsNullOrEmpty(txtIndicaciones.Text))
                                                    {
                                                        Valida = false;
                                                        txtIndicaciones.Focus();
                                                        MessageBox.Show("Indicaciones no debe de quedar vacío..!!");
                                                    }
                                                    else
                                                    {
                                                        if (string.IsNullOrEmpty(txtContraindicaciones.Text))
                                                        {
                                                            Valida = false;
                                                            txtContraindicaciones.Focus();
                                                            MessageBox.Show("Contraindicaciones no debe de quedar vacío..!!");
                                                        }
                                                        else
                                                        {
                                                            if (DtpIngreso.Value == null)
                                                            {
                                                                Valida = false;
                                                                DtpIngreso.Focus();
                                                                MessageBox.Show("Fecha de ingreso no debe de quedar vacío..!!");
                                                            }
                                                            else
                                                            {
                                                                if (DtpVencimiento.Value == null)
                                                                {
                                                                    Valida = false;
                                                                    DtpVencimiento.Focus();
                                                                    MessageBox.Show("Fecha de vencimiento no debe de quedar vacío..!!");
                                                                }
                                                                else
                                                                {
                                                                    if (string.IsNullOrEmpty(txtProveedor.Text))
                                                                    {
                                                                        Valida = false;
                                                                        txtProveedor.Focus();
                                                                        MessageBox.Show("Proveedor no debe de quedar vacío..!!");
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
                            }
                        }
                    }

                }
            }
            return Valida;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validando() == true)
            {
                Guardar();
                this.Close();
            }
        }

        private void Catalogo_Medicamento_Insumos_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
