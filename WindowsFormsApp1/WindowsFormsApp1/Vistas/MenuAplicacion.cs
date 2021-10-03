using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Vistas
{
    public partial class MenuAplicacion : Form
    {
        public MenuAplicacion()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formularioEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiantees estudianteees= new Estudiantees();
            estudianteees.MdiParent = this;
            estudianteees.Show();
        }

        private void formularioProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fmr_Suma suma = new Fmr_Suma();
            suma.MdiParent = this;
            suma.Show();
        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrResta resta = new FmrResta();
            resta.MdiParent = this;
            resta.Show();
        }

        private void multiplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrMultiplicacion multi = new FmrMultiplicacion();
            multi.MdiParent = this;
            multi.Show();
        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrDivision division = new FmrDivision();
            division.MdiParent = this;
            division.Show();
        }

        private void operacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
