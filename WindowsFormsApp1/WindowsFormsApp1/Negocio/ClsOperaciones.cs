using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.Negocio
{
    class ClsOperaciones
    {
        public string Suma(operaciones suma)
        {
            suma.Resultado = suma.Dato1 + suma.Dato2;
            return "El resultado es:" + suma.Resultado;
        }
        public string Resta(operaciones resta)
        {
            resta.Resultado = resta.Dato1 - resta.Dato2;
            return "El resultado es:" + resta.Resultado;

        }
        public string Multiplicacion(operaciones multiplicacion)
        {
            multiplicacion.Resultado = multiplicacion.Dato1 * multiplicacion.Dato2;
            return " El resultado es :" + multiplicacion.Resultado;
        }
        public string Division(operaciones division)
        {
            division.Resultado = division.Dato1 / division.Dato2;
            return " El resultado es :" + division.Resultado;
        }
    }
}
