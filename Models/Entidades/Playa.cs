using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lavadero.Models.Entidades;

namespace Lavadero.Models.Entidades
{
    public class Playa
    {
        public int Id { get; set; }
        public string nombrePlaya { get; set; }
        public string ubicacionPlaya { get; set; }//en enumeracion
        public string estadoPlaya { get; set; }//en enumeracion

        public IEnumerable<MovimientoCaja> movimientoCaja { get; set; }
        public PlayaEstado playaEstado { get; set; }

    }
}
