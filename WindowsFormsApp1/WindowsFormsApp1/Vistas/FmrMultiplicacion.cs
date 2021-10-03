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
    public partial class FmrMultiplicacion : Form
    {
        public FmrMultiplicacion()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            operaciones multiplicacion = new operaciones();
            multiplicacion.Dato1 = Convert.ToDouble(Dato1.Text);
            multiplicacion.Dato2 = Convert.ToDouble(Dato2.Text);

            ClsOperaciones nclsoperaciones = new ClsOperaciones();
            MessageBox.Show(nclsoperaciones.Multiplicacion(multiplicacion));
         
        }
    }
}
