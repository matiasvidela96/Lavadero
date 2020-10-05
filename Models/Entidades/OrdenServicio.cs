using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lavadero.Models.Entidades;
namespace Lavadero.Models.Entidades
{
    public class OrdenServicio
    {
        public int Id { get; set; }
        public DateTime fechaHoraIngreso { get; set; }
        public DateTime fechaHoraEgreso { get; set; }

        public IEnumerable<EstadoOrdenServicio> estadoOrdenServicio { get; set; }
        public Vehiculo vehiculo { get; set; }
        public IEnumerable<OrdenServicioServicio> ordenServicioServicio { get; set; }

    }
}
