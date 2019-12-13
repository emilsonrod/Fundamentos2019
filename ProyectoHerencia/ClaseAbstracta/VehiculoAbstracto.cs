using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia.ClaseAbstracta
{
    public abstract class VehiculoAbstracto
    {
        public int CapacidadPasajeros { get; set; }
        public string Marce { get; set; }

        public abstract void ImprimirVehiculo();
    }
}
