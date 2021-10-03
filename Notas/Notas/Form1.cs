using Notas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Notas.Negocio;

namespace Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CalcularNota_Click(object sender, EventArgs e)
        {
            
            ClsNotas notas = new ClsNotas();
            notas.Lab1 = Convert.ToDouble(Lab1.Text);
            notas.Parcial1 = Convert.ToDouble(Parcial1.Text);
            notas.Lab2 = Convert.ToDouble(Lab2.Text);
            notas.Parcial2 = Convert.ToDouble(Parcial2.Text);
            notas.Lab3 = Convert.ToDouble(Lab3.Text);
            notas.Parcial3 = Convert.ToDouble(Parcial3.Text);

            NClsNotas nclsnotas = new NClsNotas();


            MessageBox.Show(nclsnotas.periodo1(notas));
            MessageBox.Show(nclsnotas.periodo2(notas));
            MessageBox.Show(nclsnotas.periodo3(notas));
            MessageBox.Show(nclsnotas.ciclo1(notas));

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
