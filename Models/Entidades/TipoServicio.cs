using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lavadero.Models.Entidades;

namespace Lavadero.Models.Entidades
{
    public class TipoServicio
    {
        public int Id { get; set; }
        public string nombreTipoServicio { get; set; }
        public string descripcionTipoServicio { get; set; }
        public DateTime fechaBajaTipoServicio { get; set; }
    }
}
