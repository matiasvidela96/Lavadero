using Lavadero.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lavadero.Models.Entidades
{
    public class Empleado
    {
        public int Id { get; set; }
        public string nombreEmpleado { get; set; }
        public int dniEmpleado { get; set; }
        public DateTime? fechaBaja { get; set; }

        public IEnumerable<PlayaEmpleado> playaEmpleado { get; set; }
        public TipoEmpleado tipoEmpleado { get; set; }
        public IEnumerable<EmpleadoConceptoPago> empleadoConceptoPago { get; set; }
    }
}
