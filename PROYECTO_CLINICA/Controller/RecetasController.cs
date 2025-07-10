using PROYECTO_CLINICA.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace PROYECTO_CLINICA.Controller
{
    internal class RecetasController
    {
        public RecetasController() { }

        public void ListarReceta()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "select * from MEDICAMENTOS_RECETADOS";

                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                        LeerDatos.Fill(dt);
                        RecetasModel.getReceta = dt;
                    }
                    Con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        public bool CrearReceta(RecetasModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string Fecha = Modelo.FECHA_ATENCION.Year + "-" + Modelo.FECHA_ATENCION.Month + "-" + Modelo.FECHA_ATENCION.Day;
                    string qry = "insert into MEDICAMENTOS_RECETADOS (ID_MEDICAMENTO_RECETADO, FECHA_ATENCION, ID_PACIENTE, ID_SERVICIO, ID_SEXO, MEDICAMENTO, CONCENTRACION, PRESENTACION, DOSIS, CANTIDAD_INDICADA, DURACION, ID_DOCTOR ) select '" + Modelo.ID_MEDICAMENTO_RECETADO + "', '"+Fecha+"' , '"+Modelo.ID_PACIENTE+"' , '" + Modelo.ID_SERVICIO + "', '" + Modelo.ID_SEXO + "', '" + Modelo.MEDICAMENTO + "', '" + Modelo.CONCENTRACION + "', '" + Modelo.PRESENTACION + "', '" + Modelo.DOSIS + "', '" + Modelo.CANTIDAD_INDICADA + "', '" + Modelo.DURACION + "', '" + Modelo.ID_DOCTOR + "'";

                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        //cmd.CommandTimeout = 300;
                        cmd.ExecuteNonQuery();
                    }
                    Con.Close();
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public Boolean ActualizarRecetasPacientes(RecetasModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string Fecha = Modelo.FECHA_ATENCION.Year + "-" + Modelo.FECHA_ATENCION.Month + "-" + Modelo.FECHA_ATENCION.Day;
                    string qry = "update MEDICAMENTOS_RECETADOS set FECHA_ATENCION = '"+Fecha+"', ID_PACIENTE = '" + Modelo.ID_PACIENTE + "', ID_SERVICIO = '" + Modelo.ID_SERVICIO + "', ID_SEXO = '" + Modelo.ID_SEXO + "', MEDICAMENTO = '" + Modelo.MEDICAMENTO + "', CONCENTRACION = '" + Modelo.CONCENTRACION + "', PRESENTACION = '" + Modelo.PRESENTACION + "', DOSIS = '" + Modelo.DOSIS + "', CANTIDAD_INDICADA = '" + Modelo.CANTIDAD_INDICADA + "', DURACION = '" + Modelo.DURACION + "', ID_DOCTOR = '" + Modelo.ID_DOCTOR + "' where ID_MEDICAMENTO_RECETADO = '" + Modelo.ID_MEDICAMENTO_RECETADO + "'";

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
        public Boolean EliminarReceta(RecetasModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "delete MEDICAMENTOS_RECETADOS where ID_MEDICAMENTO_RECETADO = '" + Modelo.ID_MEDICAMENTO_RECETADO + "'";
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
