using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lavadero.Models.Entidades;

namespace Lavadero.Models.Entidades
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string patenteVehiculo { get; set; }
        public string modeloVehiculo { get; set; }
        public string marcaVehiculo { get; set; }
        public string colorVehiculo { get; set; }

        public Cliente cliente { get; set; }
        public TipoVehiculo tipoVehiculo { get; set; }
        public Playa playa { get; set; }
        public IEnumerable<Pertenencia> pertenencia { get; set; }

    }
}
