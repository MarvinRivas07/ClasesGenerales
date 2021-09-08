using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Entidades;
using Tienda.Negocio;

namespace Tienda
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsCompra compra = new ClsCompra();
            NClsCompra nclcompra = new NClsCompra();

            Console.WriteLine("Que dia es hoy");
            compra.Dia= Console.ReadLine();
            Console.WriteLine("Ingrese el total a pagar");
            compra.Total = double.Parse(Console.ReadLine());

            Console.WriteLine(nclcompra.RealizarCompra(compra));
            Console.ReadLine();






        }
    }
}
