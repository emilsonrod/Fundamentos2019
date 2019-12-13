using ListaPersonas.Interfaces;
using ListaPersonas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPersonas.ManejadorPersonas
{
    public class ManajerPersonas
    {
        List<Persona> listaPersonas;
        public ManajerPersonas()
        {
            listaPersonas = new List<Persona>();
        }

        public void AddPerson(Persona persona)
        {
            listaPersonas.Add(persona);
        }

        public List<Persona> FiltrarLista(IFiltro filtro)
        {
            List<Persona> resultado = new List<Persona>();
            foreach (Persona per in listaPersonas)
            {
                if (filtro.FiltrarPersona(per))
                    resultado.Add(per);
            }

            return resultado;
        }
    }
}
