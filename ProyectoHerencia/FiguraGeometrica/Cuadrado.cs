using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia.FiguraGeometrica
{
    public class Cuadrado : Figura
    {
        public Cuadrado(int baseCuadrado, int alturaCuadrado)
        {
            if (baseCuadrado == alturaCuadrado)
            {
                Base = baseCuadrado;
                Altura = alturaCuadrado;
            }
        }
    }
}
