using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;

namespace WindowsFormsApp1.Negocio
{
    class NClsPersona
    {

        public String MostrarNombre(ClsPersona per)
        {
            return per.Nombre;
        }

        public int Acceso (ClsPersona per)
        {
            if (per.Nombre == "Marvin" && per.Contra == "123")
            {
                return 1;
            }

            else
            {
                return 0;
            }
        }
    }
}
