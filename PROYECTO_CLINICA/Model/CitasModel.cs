using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLINICA.Model
{
    internal class CitasModel
    {
        public CitasModel() { }

        public int ID_CITA { get; set; }
        public string NOMBRES { get; set; }
        public string APELLIDOS { get; set; }
        public string No_TELEFONO { get; set; }
        public int ID_DOCTOR { get; set; }
        public DateTime FECHA_HORACITA { get; set; }
        public string MOTIVO_CITA { get; set; }
        public string USER_CREACION { get; set; }
        public DateTime FECHA_CREACION { get; set; }
        public DateTime FECHA_UPDATE { get; set; }
        public static DataTable GetCita { get; set; }

    }
}
