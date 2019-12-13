using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPersonas.Models
{
    public class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }

        public void Presentarse()
        {
            Console.WriteLine("Hola mi nombre es {0} y mi edad es {1}", Nombre, Edad);
        }
    }
}
