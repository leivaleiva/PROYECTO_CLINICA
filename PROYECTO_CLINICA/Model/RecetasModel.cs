using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLINICA.Model
{
    internal class RecetasModel
    {
        public RecetasModel() { }

        public int ID_MEDICAMENTO_RECETADO {  get; set; }

        public int ID_PACIENTE {  get; set; }
        public DateTime FECHA_ATENCION { get; set; }
        public int ID_SERVICIO { get; set; }
        public int ID_SEXO { get; set; }
        public string MEDICAMENTO { get; set; }
        public string CONCENTRACION { get; set; }
        public string PRESENTACION { get; set; }
        public string DOSIS { get; set; }
        public string CANTIDAD_INDICADA { get; set; }
        public string DURACION { get; set; }
        public int ID_DOCTOR { get; set; }


        public static DataTable getReceta {  get; set; }

    }
}
