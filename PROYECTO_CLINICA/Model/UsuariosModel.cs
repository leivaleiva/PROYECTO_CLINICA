using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLINICA.Model
{
    internal class UsuariosModel
    {
        public UsuariosModel() { }
        public string ID_USUARIO { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string CONTRASENA { get; set; }
        public int ID_NIVEL_USUARIO { get; set; }
        public int ID_DOCTOR { get; set; }
        public string EMAIL { get; set; }
        public int ID_ROL_USUARIO { get; set; }
        public string USER_CREACION { get; set; }
        public DateTime FECHA_CREACION { get; set; }
        public string USER_UPDATE { get; set; }
        public DateTime FECHA_UPDATE { get; set; }
        public Boolean ACTIVO { get; set; }

        public static DataTable GetUsuarios { get; set; }
    }
}
