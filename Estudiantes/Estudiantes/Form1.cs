using Estudiantes.Data;
using Estudiantes.Negocio;
using Estudiantes.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            estudiante es = new estudiante();
            es.nombresEstudiante = textNombre.Text;
            es.apellidos = textApellidos.Text;
            es.usuario = textUsuario.Text;
            es.contrasenia = textPassword.Text;

            ClsEstudiante clsEstudiante = new ClsEstudiante();
            clsEstudiante.Guardar(es);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FmrVistaConsultaEstudiante formulario = new FmrVistaConsultaEstudiante();
            formulario.Show();
        }
    }
}
