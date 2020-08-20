using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lavadero.Models.Entidades;

namespace Lavadero.Models.Entidades
{
    public class TipoPertenencia
    {
        public int IdTipoPertenencia { get; set; }
        public string nombreTipoPertenencia { get; set; }
        public string descripcionTipoPertenencia { get; set; }
        public DateTime fechaBajaTipoPertenencia { get; set; }

    }
}
