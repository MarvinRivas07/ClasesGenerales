using Estudiantes.Data;
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
    public partial class Materia : Form
    {
        public Materia()
        {
            InitializeComponent();
        }

        private void Guaradar_Click(object sender, EventArgs e)
        {
            materia ma = new materia();
            ma.nombreMateria = textMateria.Text;

            ClsMateria clsMateria = new ClsMateria();
            clsMateria.Guardar(ma);
            
        }
    }
}

