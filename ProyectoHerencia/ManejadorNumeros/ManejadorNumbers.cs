using ProyectoHerencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia.ManejadorNumeros
{
    public class ManejadorNumbers
    {
        List<int> listaNumeros;

        public ManejadorNumbers()
        {
            listaNumeros = new List<int>();
        }

        public void LLenarLista(int tamanio)
        {
            Random random = new Random();
            for (int count = 0; count < tamanio; count++)
            {
                listaNumeros.Add(random.Next(1000));
            }
        }

        public List<int> FiltrarNumeros(IFiltro filtro)
        {
            List<int> resultado = new List<int>();
            foreach (int numero in listaNumeros)
            {
                if (filtro.FiltrarNumero(numero))
                {
                    resultado.Add(numero);
                }
            }

            return resultado;
        }
    }
}
