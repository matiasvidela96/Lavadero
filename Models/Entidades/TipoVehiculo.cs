using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lavadero.Models.Entidades;

namespace Lavadero.Models.Entidades
{
    public class TipoVehiculo
    {
        public int Id { get; set; }
        public string nombreTipoVehiculo { get; set; }
        public string descripcionTipoVehiculo { get; set; }
        public DateTime fechaBajaTipoVehiculo { get; set; }
    }
}
