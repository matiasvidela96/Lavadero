using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lavadero.Models.Entidades;

namespace Lavadero.Models.Entidades
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public string nombreServicio { get; set; }
        public string descripcionServicio { get; set; }
        public DateTime fechaBajaServicio { get; set; }

        public TipoServicio tipoServicio { get; set; }
        public IEnumerable<Empleado> empleado { get; set; }
    }
}
