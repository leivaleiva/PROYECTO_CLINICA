using PROYECTO_CLINICA.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROYECTO_CLINICA.Controller
{
    internal class FacturaController
    {
        public FacturaController() { }

        public void ListarFacturas()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "Select * FROM MODULO_FACTURACION_E_INVENTARIO";

                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                        LeerDatos.Fill(dt);
                        FacturaModel.GetFactura = dt;
                    }
                    Con.Close();

                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
        public Boolean CrearFacturas(FacturaModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "insert into MODULO_FACTURACION_E_INVENTARIO (N_FACTURA, FECHA_EMISION, FECHA_VENCIMIENTO, FORMA_DE_PAGO, ID_USUARIO, ID_PACIENTE, RTN, CODIGO_ITEM, ID_CITAS, ID_EXAMENES, DESCRIPCION, CANTIDAD, PRECIO, DESCUENTO, SUB_TOTAL, IMPUESTO, TOTAL, EFECTIVO, CAMBIO) select '" + Modelo.N_Factura + "' ,'" + Modelo.FechaEmision + "', '" + Modelo.FechaVencimiento + "', " + Modelo.FormaPago + ", '" + Modelo.IdUsuario + "', '" + Modelo.IdPaciente + "', '" + Modelo.RTN + "', '" + Modelo.CodigoITEM + "', '" + Modelo.IdCitas + "','" + Modelo.IdExamenes + "', '" + Modelo.Descripcion + "', '" + Modelo.Cantidad + "', '" + Modelo.Precio + "', '" + Modelo.Descuento + "', '" + Modelo.Sub_Total + "', '" + Modelo.Impuesto + "', '" + Modelo.Total + "', '" + Modelo.Efectivo + "', '" + Modelo.Cambio + "'";

                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    Con.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Informacion del Sistema");
                return false;
            }
        }
        public Boolean EliminarFactura(FacturaModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "delete MODULO_FACTURACION_E_INVENTARIOS where N_FACTURA = '" + Modelo.N_Factura + "'";
                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Informacion del Sistema");
                return false;
            }
        }
    }
}
