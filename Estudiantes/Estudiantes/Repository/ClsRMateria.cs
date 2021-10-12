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
    class ClsRMateria : IMateria
    {
        public void CReate(materia materia)
        {
            using (EstudiantessEntities conexionbd = new EstudiantessEntities())
            {
                try {
                    materia mate = new materia();
                    mate.nombreMateria = materia.nombreMateria;

                    conexionbd.materias.Add(mate);
                    conexionbd.SaveChanges();
                    MessageBox.Show("Save");


                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Error de base de datos" + ex);
                }
                {

                }
            }



        }

        public void Delete(materia materia)
        {
            
        }

        public void Save(materia materia)
        {
            throw new NotImplementedException();
        }
    }


}
