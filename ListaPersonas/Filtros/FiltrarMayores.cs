using ListaPersonas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaPersonas.Models;

namespace ListaPersonas.Filtros
{
    public class FiltrarMayores : IFiltro
    {
        public bool FiltrarPersona(Persona persona)
        {
            return persona.Edad > 18;
        }
    }
}
