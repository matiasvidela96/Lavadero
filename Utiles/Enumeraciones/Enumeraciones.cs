using System;
using System.Collections.Generic;
using System.Text;

namespace Utiles.Enumeraciones
{
    class Enumeraciones
    {
        public enum TipoMovimientoCaja
        {
            Ingreso = 1,
            Egreso = 2
        }

        public enum ubicacionPlaya
        {
            Este = 1,            
            Oeste = 2
        }
        public enum PlayaEstado
        {
            Abierta = 1,
            Cerrada = 2,
            Inactiva = 3
        }

        public enum OrdenServicioEstado
        {
            EnProceso = 1,
            Ejecutada = 2,
            Cancelada = 3
        }
    }
}
