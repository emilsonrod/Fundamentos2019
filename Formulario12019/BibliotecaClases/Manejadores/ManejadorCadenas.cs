using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Manejadores
{
    public class ManejadorCadenas
    {
        public string CambiarCaracteres(string frase, char original, char nuevoCaracter)
        {
            string nuevaCadena = string.Empty;
            for (int index = 0; index < frase.Length; index++)
            {
                nuevaCadena = frase[index].Equals(original)? nuevaCadena + nuevoCaracter : nuevaCadena + frase[index];
            }
            return nuevaCadena;
        }
    }
}
