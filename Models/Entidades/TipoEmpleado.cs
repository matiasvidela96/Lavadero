using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lavadero.Models.Entidades;

namespace Lavadero.Models.Entidades
{
    public class TipoEmpleado
    {
        public int Id { get; set; }
        public string nombreTipoEmpleado { get; set; }
        public string descripcionTipoEmpleado { get; set; }
        public DateTime fechaBajaTipoEmpleado { get; set; }
    }
}
