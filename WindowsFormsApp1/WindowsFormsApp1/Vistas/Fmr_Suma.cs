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
    public partial class Fmr_Suma : Form
    {
        public Fmr_Suma()
        {
            InitializeComponent();
        }

        private void Fmr_Suma_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operaciones suma = new operaciones();
            suma.Dato1 = Convert.ToDouble(Dato1.Text);
            suma.Dato2 = Convert.ToDouble(Dato2.Text);

            ClsOperaciones nclsoperaciones = new ClsOperaciones();
            MessageBox.Show(nclsoperaciones.Suma(suma));
        }   

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
