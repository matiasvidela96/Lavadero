using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lavadero.Models.Entidades
{
    public class ConceptoPago
    {
        public int Id { get; set; }
        public string nombreConceptoPago { get; set; }
        public string descripcionConceptoPago { get; set; }
        public DateTime fechaBajaConceptoPago { get; set; }
        
    }
}
