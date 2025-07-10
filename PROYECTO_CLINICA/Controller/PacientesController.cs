using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_CLINICA.Model;

namespace PROYECTO_CLINICA.Controller
{
    internal class PacientesController
    {
        public PacientesController() { }

        public void ListarPaciente()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "select * from CATALOGO_PACIENTES";

                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                        LeerDatos.Fill(dt);
                        PacientesModel.GetPaciente = dt;
                    }
                    Con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public Boolean CrearPacientes(PacientesModel Modelo)  /////estos eventos si reciben un parametro 
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open(); 
                    string Fecha = Modelo.FECHA_NACIMIENTO.Year + "-" + Modelo.FECHA_NACIMIENTO.Month + "-" + Modelo.FECHA_NACIMIENTO.Day;
                    string qry = "insert into CATALOGO_PACIENTES (ID_PACIENTE, NOMBRES, APELLIDOS, ID_SEXO, DIRECCION, TELEFONO, DNI, FECHA_NACIMIENTO, USER_CREACION, FECHA_CREACION, EDAD, PA, FC, SatO2, FR, TEMPERATURA, PESO, TALLA, IMC ) select '"+Modelo.ID_PACIENTE+"' ,'" + Modelo.NOMBRES + "', '" + Modelo.APELLIDOS + "', " + Modelo.ID_SEXO + ", '" + Modelo.DIRECCION + "', '" + Modelo.TELEFONO + "', '" + Modelo.DNI + "', '" + Fecha + "', '"+Modelo.USER_CREACION+"',getdate(), '"+Modelo.EDAD+"', '"+Modelo.PA+"', '"+Modelo.FC+"', '"+Modelo.SatO2+"', '"+Modelo.FR+"', '"+Modelo.TEMPERATURA+"', '"+Modelo.PESO+"', '"+Modelo.TALLA+"', '"+Modelo.IMC+"'";

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

        public Boolean ActualizarPacientes(PacientesModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string Fecha = Modelo.FECHA_NACIMIENTO.Year + "-" + Modelo.FECHA_NACIMIENTO.Month + "-" + Modelo.FECHA_NACIMIENTO.Day;
                    string qry = "update CATALOGO_PACIENTES set NOMBRES = '" + Modelo.NOMBRES + "', APELLIDOS = '" + Modelo.APELLIDOS + "', ID_SEXO = '" + Modelo.ID_SEXO + "', DIRECCION = '" + Modelo.DIRECCION + "', TELEFONO = '" + Modelo.TELEFONO + "', DNI = '" + Modelo.DNI + "', FECHA_NACIMIENTO = '"+Fecha+"', EDAD = '" + Modelo.EDAD + "', PA = '"+Modelo.PA+"', FC = '"+Modelo.FC+"', SatO2 = '"+Modelo.SatO2+"', FR = '"+Modelo.FR+"', TEMPERATURA = '"+Modelo.TEMPERATURA+"', PESO = '"+Modelo.PESO+"', TALLA = '"+Modelo.TALLA+"', IMC = '"+Modelo.IMC+"' where ID_PACIENTE = '" + Modelo.ID_PACIENTE + "'";

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
        public Boolean EliminarPaciente(PacientesModel  Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "delete CATALOGO_PACIENTES where ID_PACIENTE = '" + Modelo.ID_PACIENTE + "'";
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
