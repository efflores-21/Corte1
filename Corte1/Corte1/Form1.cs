using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Operacion operacion = new Operacion();
            operacion.FechaNac = Fecha.Value;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            Persona persona = new Persona();
            persona.Nombre = registro.ToString;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Operacion operacion = new Operacion();
        }

        private void Fecha_ValueChanged(object sender, EventArgs e)
        {
            Operacion operacion = new Operacion();
      }
    }
}
