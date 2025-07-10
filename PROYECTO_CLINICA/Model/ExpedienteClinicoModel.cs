using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_CLINICA.Model
{
    internal class ExpedienteClinicoModel
    {
        public ExpedienteClinicoModel() { }

        public int  ID_EXPEDIENTE {  get; set; }
        public int ID_PACIENTE { get; set; }
        public String ESTABLECIMIENTO { get; set; }
        public int ID_SEXO {  get; set; }
        public int ID_ESTADO_CIVIL { get; set; }
        public String NOMBRE_PADRE {  get; set; }
        public String NOMBRE_MADRE { get; set; }
        public String CONTACTO_EMERGENCIA { get; set; }
        public String TELEFONO_C_E {  get; set; }
        public int ID_INGRESO { get; set; }
        public int ID_SERVICIO { get; set; }
        public int ID_HOSPITALIZACION { get; set; }
        public String DIAGNOSTICO_INGRESO { get; set; }
        public DateTime FECHA_INGRESO { get; set; }
        public String ANTECEDENTE_ENFERMEDAD {  get; set; }
        public String NOTAS_EVOLUCION { get; set; }
        public int ID_MEDICO {  get; set; }

        public static DataTable GetExpediente {  get; set; }
    }
}
