using ProyectoHerencia.ClaseAbstracta;
using System;

namespace ProyectoHerencia.Transporte
{
    public class Aereo : VehiculoAbstracto
    {
        public int VelocidadCrucero { get; set; }

        public override void ImprimirVehiculo()
        {
            Console.WriteLine(" vehiculo Aereo dato velocidad crucero {0} capacidad {1} marca {2}", VelocidadCrucero
                , CapacidadPasajeros, Marce);
        }
    }
}
