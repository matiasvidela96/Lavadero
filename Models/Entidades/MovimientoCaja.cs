using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lavadero.Models.Entidades;

namespace Lavadero.Models.Entidades
{
    public class MovimientoCaja
    {
        public int IdMovimientoCaja { get; set; }
        public int tipoMovimientoCaja { get; set; }//enumeracion para distintos tipos
        public DateTime fechaHoraMovimientoCaja { get; set; }
    }
}
