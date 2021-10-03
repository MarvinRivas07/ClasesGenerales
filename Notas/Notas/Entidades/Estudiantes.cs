using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas.Entidades
{
    class Estudiantes : ClsNotas
    {
        private string carrera;
        private string direccion;
        private int fechanacimiento;
        private string genero;

        public string Carrera { get => carrera; set => carrera = value; }
    }
}
