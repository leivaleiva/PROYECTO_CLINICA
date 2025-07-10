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
    internal class MedicamentosController
    {
        public void ListarMedicamentos()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "Select * FROM CATALOGO_MEDICAMENTOS_E_INSUMOS";

                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                        LeerDatos.Fill(dt);
                        MedicamentosModel.GetMedicamentos = dt;
                    }
                    Con.Close();

                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
        public Boolean CrearMedicamentos(MedicamentosModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string Fecha_ingreso = Modelo.fecha_ingreso.Year + "-" + Modelo.fecha_ingreso.Month + "-" + Modelo.fecha_ingreso.Day+" "+Modelo.fecha_ingreso.Hour+":"+Modelo.fecha_ingreso.Minute;
                    string Fecha_VENCIMIENTO = Modelo.fecha_vencimiento.Year + "-" + Modelo.fecha_vencimiento.Month + "-" + Modelo.fecha_vencimiento.Day + " " + Modelo.fecha_vencimiento.Hour + ":" + Modelo.fecha_vencimiento.Minute;
                    string qry = "insert into CATALOGO_MEDICAMENTOS_E_INSUMOS (CODIGO_ITEM, NOMBRE_ITEM, DESCRIPCION, CATEGORIA, CANTIDAD_DISPONIBLE, PRECIO, FECHA_INGRESO, FECHA_VENCIMIENTO, PROVEEDOR, INDICACIONES, CONTRAINDICACIONES, UBICACION_ALMACEN, UNIDAD_MEDIDA, ESTADO) select '" + Modelo.CodigoITEM + "' ,'" + Modelo.NombreITEM + "', '" + Modelo.Descripcion + "', '" + Modelo.Categoria + "', '" + Modelo.cantidad_disponible + "', '" + Modelo.precio + "', '" + Fecha_ingreso + "', '" + Fecha_VENCIMIENTO+ "', '" + Modelo.proveedor + "','" + Modelo.indicaciones + "', '" + Modelo.contraindicaciones + "', '" + Modelo.ubicacion_almacen + "', '" + Modelo.Unidad_Medida + "', '" + Modelo.Estado + "'";

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
        public Boolean ActualizarMedicamentos(MedicamentosModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string Fecha_ingreso = Modelo.fecha_ingreso.Year + "-" + Modelo.fecha_ingreso.Month + "-" + Modelo.fecha_ingreso.Day;
                    string Fecha_VENCIMIENTO = Modelo.fecha_vencimiento.Year + "-" + Modelo.fecha_vencimiento.Month + "-" + Modelo.fecha_vencimiento.Day;

                    string qry = "update CATALOGO_MEDICAMENTOS_E_INSUMOS set NOMBRE_ITEM = '" + Modelo.NombreITEM + "', DESCRIPCION = '" + Modelo.Descripcion + "', CATEGORIA = '" + Modelo.Categoria + "', CANTIDAD_DISPONIBLE = '" + Modelo.cantidad_disponible + "', PRECIO = '" + Modelo.precio + "', FECHA_INGRESO = '" + Fecha_ingreso + "', FECHA_VENCIMIENTO = '" + Fecha_VENCIMIENTO + "', PROVEEDOR = '" + Modelo.proveedor + "', INDICACIONES = '" + Modelo.indicaciones + "', CONTRAINDICACIONES = '" + Modelo.contraindicaciones + "', UBICACION_ALMACEN = '" + Modelo.ubicacion_almacen + "', UNIDAD_MEDIDA = '" + Modelo.Unidad_Medida + "', ESTADO = '" + Modelo.Estado + "' where CODIGO_ITEM= '" + Modelo.CodigoITEM + "'";

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

        public Boolean EliminarMedicamentos(MedicamentosModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "delete CATALOGO_MEDICAMENTOS_E_INSUMOS where CODIGO_ITEM = '" + Modelo.CodigoITEM + "'";
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
