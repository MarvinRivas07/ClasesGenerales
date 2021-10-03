using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entidades;
using WindowsFormsApp1.Negocio;

namespace WindowsFormsApp1.Vistas
{
    public partial class FmrDivision : Form
    {
        public FmrDivision()
        {
            InitializeComponent();
        }

        private void FmrDivision_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            operaciones division = new operaciones();
            division.Dato1 = Convert.ToDouble(Dato1.Text);
            division.Dato2 = Convert.ToDouble(Dato2.Text);

            ClsOperaciones nclsoperaciones = new ClsOperaciones();
            MessageBox.Show(nclsoperaciones.Division(division));
        
    }
    }
}
