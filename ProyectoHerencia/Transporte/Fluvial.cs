using ProyectoHerencia.ClaseAbstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia.Transporte
{
    public class Fluvial : VehiculoAbstracto
    {
        public override void ImprimirVehiculo()
        {
            Console.WriteLine(" vehiculo Fluvial dato capacidad {0} marca {1}", CapacidadPasajeros, Marce);
        }
    }
}
