﻿using ProyectoHerencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerencia.FiltrosNumericos
{
    public class FiltrarPares : IFiltro
    {
        public bool FiltrarNumero(int numero)
        {
            return numero % 2 == 0;
        }
    }
}
