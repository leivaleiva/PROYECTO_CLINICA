using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLINICA.Model
{
    internal class ExamenesModel
    {
        public ExamenesModel() { }

        public int ID_EXAMENES { get; set; }
        public DateTime FECHA_REGISTRO { get; set; }
        public string DATOS_POSITIVOS { get; set; }

        public int ID_EXAMEN_COMPLEMENTARIO { get; set; }
        public int ID_PACIENTE { get; set; }

        public static DataTable GetExamenes { get; set; }
    }
}
