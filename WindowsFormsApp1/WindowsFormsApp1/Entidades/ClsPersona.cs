using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entidades
{
    class ClsPersona
    {
        private String nombre;
        private String contra;

        public ClsPersona()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contra { get => contra; set => contra = value; }
    }
}
