using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lavadero.Models.Entidades;

namespace Lavadero.Models.Entidades
{
    public class Cliente
    {
        public int numeroCliente { get; set; }
        public string nombreCliente { get; set; }
        public int telefonoCliente { get; set; }

        public IEnumerable<Reclamo> reclamo { get; set; }
        //public IEnumerable<Vehiculo> vehiculo { get; set; }
    }
}
