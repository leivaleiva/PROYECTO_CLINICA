using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLINICA.Model
{
    internal class PacientesModel
    {
        public PacientesModel() { }

        public int ID_PACIENTE { get; set; }
        public string NOMBRES {  get; set; }
        public string APELLIDOS { get; set; }
        public int ID_SEXO { get; set; }
        public string DIRECCION { get; set; }
        public int TELEFONO { get; set; }
        public string DNI {  get; set; }
        public DateTime FECHA_NACIMIENTO { get; set; }
        public string USER_CREACION { get; set; }
        public DateTime FECHA_CREACION { get; set; }
        public int EDAD {  get; set; }
        public string PA {  get; set; }
        public string FC { get; set; }
        public string SatO2 { get; set; }
        public string FR { get; set; }
        public string TEMPERATURA { get; set; }
        public string PESO { get; set; }
        public string TALLA { get; set; }
        public string IMC { get; set; }

        public static DataTable GetPaciente {  get; set; }
    }
}
