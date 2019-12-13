using ListaPersonas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPersonas.Interfaces
{
    public interface IFiltro
    {
        bool FiltrarPersona(Persona persona);
    }
}
