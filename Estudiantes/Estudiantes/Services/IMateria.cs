
using Estudiantes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudiantes.Services
{
    interface IMateria
    {
        //C
        void Save(materia materia);
        //D
        void Delete(materia materia);
    }
}
   