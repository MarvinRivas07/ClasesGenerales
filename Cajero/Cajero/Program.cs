using Cajero.Entidades;
using Cajero.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsCajero constructor = new ClsCajero();
            NClsCajero nclcajero = new NClsCajero();

            

            int opcion=1;
            int dato;
            while (opcion==1)
            { 
                Console.WriteLine("Ingrese la cantidad que desea retirar");
                 dato = Convert.ToInt32(Console.ReadLine());
                constructor.Dato=dato;
                Console.WriteLine(nclcajero.SacarDinero(constructor));

            }
           
            
        }
    }
}
