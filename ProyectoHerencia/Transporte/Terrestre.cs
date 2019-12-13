using ProyectoHerencia.ClaseAbstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia.Transporte
{
    public class Terrestre : VehiculoAbstracto
    {
        public int ValocidadLineal { get; set; }

        public override void ImprimirVehiculo()
        {
            Console.WriteLine(" vehiculo Terrestre dato velocidad lineal {0} capacidad {1} marca {2}", ValocidadLineal
                , CapacidadPasajeros, Marce);
        }
    }
}
