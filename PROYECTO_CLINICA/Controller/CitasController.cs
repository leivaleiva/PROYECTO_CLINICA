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
    internal class CitasController
    {
        public CitasController() { }

        public void ListarCitas()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "select * from MODULO_CITAS";

                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        SqlDataAdapter leerDatos = new SqlDataAdapter(cmd);
                        leerDatos.Fill(dt);
                        CitasModel.GetCita = dt;
                    }
                    Con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public Boolean CrearCita(CitasModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string Fecha = Modelo.FECHA_HORACITA.Year + "-" + Modelo.FECHA_HORACITA.Month + "-" + Modelo.FECHA_HORACITA.Day;
                    string qry = "INSERT INTO MODULO_CITAS (ID_CITA, NOMBRES, APELLIDOS, No_TELEFONO, ID_DOCTOR, FECHA_HORACITA, MOTIVO_CITA, USER_CREACION, FECHA_CREACION) " +
                    "SELECT '" + Modelo.ID_CITA + "', '" + Modelo.NOMBRES + "', '" + Modelo.APELLIDOS + "', '" + Modelo.No_TELEFONO + "', '" + Modelo.ID_DOCTOR + "', '" + Fecha + "', '" + Modelo.MOTIVO_CITA + "', '" + Modelo.USER_CREACION + "', GETDATE()";



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
                MessageBox.Show(e.Message, "Se ha guardado cita en el Sistema");
                return false;
            }
        }

        public Boolean ActualizarCita(CitasModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string Fecha = Modelo.FECHA_HORACITA.Year + "-" + Modelo.FECHA_HORACITA.Month + "-" + Modelo.FECHA_HORACITA.Day;
                    string qry = "Update MODULO_CITAS set NOMBRES='" + Modelo.NOMBRES + "', APELLIDOS='" + Modelo.APELLIDOS + "', No_TELEFONO='" + Modelo.No_TELEFONO + "', ID_DOCTOR='" + Modelo.ID_DOCTOR + "', FECHA_HORACITA='" + Fecha + "', MOTIVO_CITA='" + Modelo.MOTIVO_CITA + "', USER_CREACION='" + Modelo.USER_CREACION + "',FECHA_UPDATE= Getdate() where ID_CITA='" + Modelo.ID_CITA + "'";

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
                MessageBox.Show(e.Message, "Se ha guardado cita en el Sistema");
                return false;
            }
        }

        public Boolean EliminarCita(string ID_CITA)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "delete MODULO_CITAS where ID_CITA = '" + ID_CITA + "'";
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
