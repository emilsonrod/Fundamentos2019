using ListaPersonas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaPersonas.Models;

namespace ListaPersonas.Filtros
{
    public class FiltrarLetra : IFiltro
    {
        public char Letra { get; set; }

        public bool FiltrarPersona(Persona persona)
        {
            IniciarLetra();
            return persona.Nombre[0] == Letra;
        }

        public void IniciarLetra()
        {
            if (Letra == 0)
            {
                Console.WriteLine("Ingrese la letra a filtrar");
                Letra = Console.ReadLine()[0];
            }
        }
    }
}
