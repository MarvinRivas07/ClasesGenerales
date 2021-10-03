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
    public partial class FmrResta : Form
    {
        public FmrResta()
        {
            InitializeComponent();
        }

        private void IngreseUnValor_Click(object sender, EventArgs e)
        {

        }

        private void Resultado_Click(object sender, EventArgs e)
        {
            operaciones resta = new operaciones();
            resta.Dato1 = Convert.ToDouble(Dato1.Text);
            resta.Dato2 = Convert.ToDouble(Dato2.Text);

            ClsOperaciones nclsoperaciones = new ClsOperaciones();
            MessageBox.Show(nclsoperaciones.Resta(resta));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
