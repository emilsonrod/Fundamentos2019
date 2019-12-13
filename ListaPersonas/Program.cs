using ListaPersonas.Filtros;
using ListaPersonas.Interfaces;
using ListaPersonas.ManejadorPersonas;
using ListaPersonas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPersonas
{
    class Program
    {
        static void Main(string[] args)
        {
            IFiltro[] listaFiltro = { new FiltrarMayores(), new FiltrarMenores(), new FiltrarLetra() };
            Persona per1 = new Persona() { Edad = 18, Nombre = "Juan" };
            Persona per2 = new Persona() { Edad = 10, Nombre = "Carla" };
            Persona per3 = new Persona() { Edad = 25, Nombre = "Esteban" };
            Persona per4 = new Persona() { Edad = 31, Nombre = "Marcos" };
            Persona per5 = new Persona() { Edad = 5, Nombre = "Pamela" };
            Persona per6 = new Persona() { Edad = 2, Nombre = "Junior" };
            Persona per7 = new Persona() { Edad = 35, Nombre = "Pablo" };
            ManajerPersonas manajer = new ManajerPersonas();
            manajer.AddPerson(per1);
            manajer.AddPerson(per2);
            manajer.AddPerson(per3);
            manajer.AddPerson(per4);
            manajer.AddPerson(per5);
            manajer.AddPerson(per6);
            manajer.AddPerson(per7);
            Console.WriteLine("1 para filtrar mayores, 2 para menores, 3 por letra");
            ImprimirLista(manajer.FiltrarLista(listaFiltro[Convert.ToInt32(Console.ReadLine()) - 1]));
        }

        private static void ImprimirLista(List<Persona> listaPersonas)
        {
            foreach (Persona item in listaPersonas)
            {
                item.Presentarse();
            }
        }
    }
}
