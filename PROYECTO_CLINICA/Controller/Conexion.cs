using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; 

namespace PROYECTO_CLINICA.Controller
{
    internal class Conexion
    {
        public Conexion() { }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["CLINICA"].ToString());
        }
    }
}
