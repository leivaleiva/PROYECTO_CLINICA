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
    internal class ExamenesController
    {
        public ExamenesController() { }

        public void ListarExamnes()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "select * from CATALOGO_EXAMENES";

                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        SqlDataAdapter leerDatos = new SqlDataAdapter(cmd);
                        leerDatos.Fill(dt);
                        ExamenesModel.GetExamenes = dt;
                    }
                    Con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public Boolean CrearExamen(ExamenesModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string Fecha = Modelo.FECHA_REGISTRO.Year + "-" + Modelo.FECHA_REGISTRO.Month + "-" + Modelo.FECHA_REGISTRO.Day ;
                    string qry = "INSERT INTO CATALOGO_EXAMENES (ID_EXAMENES, FECHA_REGISTRO, DATOS_POSITIVOS,ID_EXAMEN_COMPLEMENTARIO,ID_PACIENTE) " + "Select '" + Modelo.ID_EXAMENES + "', '" + Fecha + "', '" + Modelo.DATOS_POSITIVOS + "', '" + Modelo.ID_EXAMEN_COMPLEMENTARIO + "', '" + Modelo.ID_PACIENTE + "'";

                    

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
                MessageBox.Show(e.Message, "Se ha guardado el Examen en el Sistema");
                return false;
            }
        }

        public Boolean ActualizarExamen(ExamenesModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string Fecha = Modelo.FECHA_REGISTRO.Year + "-" + Modelo.FECHA_REGISTRO.Month + "-" + Modelo.FECHA_REGISTRO.Day;
                    string qry = "Update CATALOGO_EXAMENES set ID_EXAMENES='" + Modelo.ID_EXAMENES + "', FECHA_REGISTRO='" + Fecha + "', DATOS_POSITIVOS='" + Modelo.DATOS_POSITIVOS + "', ID_EXAMEN_COMPLEMENTARIO='" + Modelo.ID_EXAMEN_COMPLEMENTARIO + "' where ID_PACIENTE='" + Modelo.ID_PACIENTE + "'";

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
                MessageBox.Show(e.Message, "Se ha guardado el Examen en el Sistema");
                return false;
            }
        }

        public Boolean EliminarExamen(int ID_EXAMENES)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "delete CATALOGO_EXAMENES where ID_EXAMENES = '" + ID_EXAMENES + "'";
                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Se elimino Informacion del Sistema");
                return false;
            }
        }
    }
}
