using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLINICA.Model
{
    internal class MedicamentosModel
    {

        public MedicamentosModel() { }

        public int CodigoITEM { get; set; }
        public string NombreITEM { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public int cantidad_disponible { get; set; }
        public float precio { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public string proveedor { get; set; }
        public string indicaciones { get; set; }
        public string contraindicaciones { get; set; }
        public string ubicacion_almacen { get; set; }
        public string Unidad_Medida { get; set; }
        public Boolean Estado { get; set; }

        public static DataTable GetMedicamentos { get; set; }
    }
}
