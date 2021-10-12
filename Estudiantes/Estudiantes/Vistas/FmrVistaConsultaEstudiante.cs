using Estudiantes.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes.Vistas
{
    public partial class FmrVistaConsultaEstudiante : Form
    {
        public FmrVistaConsultaEstudiante()
        {
            InitializeComponent();
        }

        private void FmrVistaConsultaEstudiante_Load(object sender, EventArgs e)
        {
            ClsEstudiante estudiante = new ClsEstudiante();
            var ok = estudiante.ListFinal();

            foreach (var iterar in ok )
            {
                ListStudent.Rows.Add(iterar.nombresEstudiante, iterar.apellidos, iterar.usuario);
            }
        }

        
    }
}
