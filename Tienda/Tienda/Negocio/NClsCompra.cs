using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Entidades;

namespace Tienda.Negocio
{
    class NClsCompra
    {
        public string RealizarCompra(ClsCompra compra)
        {
            if (compra.Dia=="Martes" ||  compra.Dia=="Jueves")
            {
                double descuento = compra.Total * 0.15%;

                return "total" + compra.Total + "" +
                    "\n descuento:" + descuento + "" +
                    "\n total con descuento" + (compra.Total - descuento);


            }
            else
            {
                return "Total a pagar:" + compra.Total;
            }
        }




    }
}
