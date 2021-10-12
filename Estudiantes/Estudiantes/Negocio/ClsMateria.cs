using Estudiantes.Data;
using Estudiantes.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes.Negocio
{
    class ClsMateria : ClsRMateria
    {
        public void Guardar(materia mat)
        {

            CReate(mat);
        }
    }
}
