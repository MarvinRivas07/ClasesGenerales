using Notas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas.Negocio
{
    class NClsNotas
    {  public string periodo1(ClsNotas  notas)
        {
            notas.Periodo1 = (notas.Lab1 * 0.40) + (notas.Parcial1 * 0.60);
            return "Notas del periodo 1: " + notas.Periodo1;


        }
        public string periodo2(ClsNotas notas)
        {
            notas.Periodo2 = (notas.Lab2 * 0.40) + (notas.Parcial2 * 0.60);
            return "Notas del periodo 2: " + notas.Periodo2;

        }
        public string periodo3(ClsNotas notas)
        {
            notas.Periodo3 = (notas.Lab3 * 0.40) + (notas.Parcial3 * 0.60);
            return "Notas del periodo 3: " + notas.Periodo3;

        }
        public string ciclo1(ClsNotas notas)
        {
            notas.Ciclo1 = (notas.Periodo1 + notas.Periodo2 + notas.Periodo3) / 3;
            return "Notas del ciclo: " + notas.Ciclo1;
        }
    }
}
