using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia.FiguraGeometrica
{
    public class Figura
    {
        public int Altura { get; set; }
        public int Base { get; set; }

        public int AreaFigura()
        {
            return Base * Altura;
        }
    }
}
