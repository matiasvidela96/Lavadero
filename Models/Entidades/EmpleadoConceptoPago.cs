using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lavadero.Models.Entidades
{
    public class EmpleadoConceptoPago
    {
        public int IdEmpleadoConceptoPago { get; set; }
        public DateTime fechaHoraInicioEmpleadoConceptoPago { get; set; }
        public DateTime fechaHoraFinEmpleadoConceptoPago { get; set; }

        public ConceptoPago conceptoPago { get; set; }
    }
}
