using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia.CursosOfrecidos
{
    public class Curso
    {
        public string NombreCurso { get; set; }
        public DateTime FechaInicio { get; set; }
        public int DuracionDias { get; set; }
        public int CantidadSubcursos { get; set; }

        public void PublicitarCurso()
        {
            Console.WriteLine("Se ofrece el siguiente curso {0} con una duracion de {1} dias, inicia en {2}",
                NombreCurso, DuracionDias, FechaInicio);
        }
    }
}
