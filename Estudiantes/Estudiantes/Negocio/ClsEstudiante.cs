using Estudiantes.Data;
using Estudiantes.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes.Negocio
{
    class ClsEstudiante : ClsREstudiante
    {
        public void Guardar(estudiante es) {

        CReate(es);
        }
        public List<estudiante>  ListFinal()
        {
            List<estudiante> list = ListOfDataOfTableEstudiante();
            return list;
        }
    }
}
