using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lavadero.Models.Entidades
{
    public class EstadoOrdenServicio
    {
        public int Id { get; set; }
        public DateTime fechaHoraInicioEstadoOrdenServicio { get; set; }
        public DateTime fechaHoraFinEstadoOrdenServicio { get; set; }

        public OrdenServicioEstado ordenServicioEstado { get; set; }

    }
}
