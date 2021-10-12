using Estudiantes.Data;
using Estudiantes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes.Repository
{
    class ClsREstudiante : IEstudiante
    {
        public void CReate(estudiante estudiante)
        {
           using (EstudiantessEntities conexionbd = new EstudiantessEntities())
            {
                try {
                    

                    conexionbd.estudiantes.Add(estudiante);
                    conexionbd.SaveChanges();
                    MessageBox.Show("Save");
                        
                        
                } catch(Exception ex)
                {
                    MessageBox.Show("Error de base de datos"+ex);
                }
            }
        }

        public void Delete(estudiante estudiante)
        {
         
        }

        public List<estudiante> ListOfDataOfTableEstudiante()
        {
            using (EstudiantessEntities conexionbd = new EstudiantessEntities())
            {
                List<estudiante> ListaOfData = conexionbd.estudiantes.ToList();
                {
                    return ListaOfData;
                }
            }
        }
    }
}
