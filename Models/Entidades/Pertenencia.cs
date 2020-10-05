using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lavadero.Models.Entidades;

namespace Lavadero.Models.Entidades
{
    public class Pertenencia
    {
        public int Id { get; set; }
        public string nombrePertenencia { get; set; }
        public string descripcionPertenencia { get; set; }

        public TipoPertenencia tipoPertenencia { get; set; }
    }
}
