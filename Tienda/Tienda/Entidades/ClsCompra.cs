using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Entidades
{
    class ClsCompra
    {
        private double total;
        private string dia;

        public ClsCompra(double total, string dia)
        {
            this.total = total;
            this.dia = dia;
        }
         public ClsCompra() { }


        public double Total { get => total; set => total = value; }
        public string Dia { get => dia; set => dia = value; }
    }
}
