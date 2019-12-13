using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia.Transporte
{
    public class Vehiculo
    {
        public int CapacidadPasajeros { get; set; }
        public string Marce { get; set; }

        public void ImprimirVehiculo()
        {
            Console.WriteLine("El vehiculo de marca {0} puede llevar {1} pasajeros", Marce, CapacidadPasajeros);
        }
    }
}
