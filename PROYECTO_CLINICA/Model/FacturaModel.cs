using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLINICA.Model
{
    internal class FacturaModel
    {
        public FacturaModel() { }

        public int N_Factura { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string FormaPago { get; set; }
        public int IdUsuario { get; set; }
        public int IdPaciente { get; set; }
        public string RTN { get; set; }
        public int CodigoITEM { get; set; }
        public int IdCitas { get; set; }
        public int IdExamenes { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public float Descuento { get; set; }
        public float Impuesto { get; set; }
        public float Sub_Total { get; set; }
        public float Total { get; set; }
        public int Efectivo { get; set; }
        public float Cambio { get; set; }

        public static DataTable GetFactura { get; set; }
    }
}
