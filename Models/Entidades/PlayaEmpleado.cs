using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lavadero.Models.Entidades;

namespace Lavadero.Models.Entidades
{
    public class PlayaEmpleado
    {
        public int Id { get; set; }
        public DateTime fechaHoraInicioPlayaEmpleado { get; set; }
        public DateTime fechaHoraFinPlayaEmpleado { get; set; }

        public Playa playa { get; set; }
    }
}
