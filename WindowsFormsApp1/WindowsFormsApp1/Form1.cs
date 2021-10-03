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
using WindowsFormsApp1.Vistas;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Venta venta = new Venta();

        private void button1_Click(object sender, EventArgs e)
        {

            //ClsPersona per = new ClsPersona();
            //per.Nombre = CaptDatos.Text;
            //NClsPersona nclspersona = new NClsPersona();
            //String nombre = nclspersona.MostrarNombre(per);
            // MessageBox.Show(nombre);

            ClsPersona per = new ClsPersona();
            NClsPersona nclsper = new NClsPersona();

            per.Nombre = TxtName.Text;
            per.Contra = TxtPass.Text;

            int valor = nclsper.Acceso(per);

            //_ = valor;

            if (valor == 1)
            {
                //MessageBox.Show("Bienvenido");
                venta.Show();
            }

            else
            {
                MessageBox.Show("ERROR NO COINCIDEN EL USUARIO CON LA CONTRASEÑA");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
