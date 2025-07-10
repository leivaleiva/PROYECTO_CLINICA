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
    internal class ExpedienteClinicoController
    {
        public ExpedienteClinicoController() { }

        public void ListarExpediente()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "select * from EXPEDIENTE_CLINICO";

                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                        LeerDatos.Fill(dt);
                        ExpedienteClinicoModel.GetExpediente = dt;
                    }
                    Con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public Boolean CrearExpedienteClinico(ExpedienteClinicoModel Modelo)  /////estos eventos si reciben un parametro 
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "insert into EXPEDIENTE_CLINICO (ID_EXPEDIENTE, ID_PACIENTE, ESTABLECIMIENTO, ID_SEXO, ID_ESTADO_CIVIL, NOMBRE_PADRE, NOMBRE_MADRE, CONTACTO_EMERGENCIA, TELEFONO_C_E, ID_INGRESO, ID_SERVICIO, ID_HOSPITALIZACION, DIAGNOSTICO_INGRESO, FECHA_INGRESO, ANTECEDENTE_ENFERMEDAD, NOTAS_EVOLUCION, ID_MEDICO) select '" + Modelo.ID_EXPEDIENTE + "' ,'" + Modelo.ID_PACIENTE + "', '" + Modelo.ESTABLECIMIENTO + "', " + Modelo.ID_SEXO + ", '" + Modelo.ID_ESTADO_CIVIL + "', '" + Modelo.NOMBRE_PADRE + "', '" + Modelo.NOMBRE_MADRE + "', '" + Modelo.CONTACTO_EMERGENCIA + "', '" + Modelo.TELEFONO_C_E + "', '" + Modelo.ID_INGRESO + "', '" + Modelo.ID_SERVICIO + "', '" + Modelo.ID_HOSPITALIZACION + "', '" + Modelo.DIAGNOSTICO_INGRESO + "', '" + Modelo.FECHA_INGRESO + "', '" + Modelo.ANTECEDENTE_ENFERMEDAD + "', '" + Modelo.NOTAS_EVOLUCION + "', '" + Modelo.ID_MEDICO + "'";

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

        public Boolean ActualizarExpediente(ExpedienteClinicoModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "update EXPEDIENTE_CLINICO set CONTACTO_EMERGENCIA = '" + Modelo.CONTACTO_EMERGENCIA + "', TELEFONO_C_E = '" + Modelo.TELEFONO_C_E + "', ID_SERVICIO = '" + Modelo.ID_SERVICIO + "', NOTAS_EVOLUCION = '" + Modelo.NOTAS_EVOLUCION + "', ID_MEDICO = '" + Modelo.ID_MEDICO + "'";

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
        public Boolean EliminarExpediente(ExpedienteClinicoModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "delete EXPEDIENTE_CLINICO where ID_EXPEDIENTE = '" + Modelo.ID_EXPEDIENTE + "'";
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
