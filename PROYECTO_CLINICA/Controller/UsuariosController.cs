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
    internal class UsuariosController
    {
        public UsuariosController() { }

        public void ListarUsuarios()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "select * from CATALOGO_USUARIOS";

                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        SqlDataAdapter LeerDatos = new SqlDataAdapter(cmd);
                        LeerDatos.Fill(dt);
                        UsuariosModel.GetUsuarios = dt;

                    }
                    Con.Close();
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);

            }
        }

        public Boolean CrearUsuarios(UsuariosModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "insert into CATALOGO_USUARIOS (ID_USUARIO,NOMBRE,APELLIDO,CONTRASENA,ID_NIVEL_USUARIO,ID_DOCTOR,EMAIL,ID_ROL_USUARIO,USER_CREACION,FECHA_CREACION,ACTIVO) select '" + Modelo.ID_USUARIO + "','" + Modelo.NOMBRE + "', '" + Modelo.APELLIDO + "','" + Modelo.CONTRASENA + "','" + Modelo.ID_NIVEL_USUARIO + "'," + "'" + Modelo.ID_DOCTOR + "','" + Modelo.EMAIL + "','" + Modelo.ID_ROL_USUARIO + "', '" + Modelo.USER_CREACION + "',getdate(),'" + Modelo.ACTIVO + "'";
                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {

                        cmd.ExecuteNonQuery();

                    }

                }

                return true;
            }
            catch (Exception e)
            {
                return false;
            }


        }

        public Boolean ActualizarUsuarios(UsuariosModel Modelo)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "UPDATE CATALOGO_USUARIOS SET " +
                                            "NOMBRE = '" + Modelo.NOMBRE + "', " +
                                            "APELLIDO = '" + Modelo.APELLIDO + "', " +
                                            "CONTRASENA = '" + Modelo.CONTRASENA + "', " +
                                            "ID_NIVEL_USUARIO = " + Modelo.ID_NIVEL_USUARIO + ", " +
                                            "ID_DOCTOR = " + Modelo.ID_DOCTOR + ", " +
                                            "EMAIL = '" + Modelo.EMAIL + "', " +
                                            "ID_ROL_USUARIO = " + Modelo.ID_ROL_USUARIO + ", " +
                                            "USER_UPDATE = '" + Modelo.USER_UPDATE + "', " +
                                            "FECHA_UPDATE = GETDATE(), " +
                                            "ACTIVO = '" + Modelo.ACTIVO + "' " +
                                            "WHERE ID_USUARIO = " + Modelo.ID_USUARIO;

                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Boolean EliminarUsuario(String ID_USUARIO)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    string qry = "delete CATALOGO_USUARIOS where ID_USUARIO = '" + ID_USUARIO + "'";
                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Boolean ActualizaHuellaUsuario(string ID_USUARIO, DPFP.Template HUELLA)
        {
            try
            {
                using (SqlConnection Con = new Conexion().GetConnection())
                {
                    Con.Open();
                    byte[] ImagenHuella = HUELLA.Bytes;
                    string qry = "update CATALOGO_USUARIOS set HUELLA= @HUELLA where ID_USUARIO = '" + ID_USUARIO + "'";
                    using (SqlCommand cmd = new SqlCommand(qry, Con))
                    {
                        cmd.Parameters.Add("@HUELLA", SqlDbType.VarBinary).Value = ImagenHuella;
                        cmd.ExecuteNonQuery();

                    }

                }
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;

            }


        }
    }
}
