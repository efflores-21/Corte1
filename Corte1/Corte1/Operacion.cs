using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1
{
    internal class Operacion
    {
        public Operacion() { }
        public DateTime FechaNac { get; set; }
        public int CalcularEdad()
        {
            int edad = 0;
            try
            {
                edad = DateTime.Now.Year - FechaNac.Year;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error:{ex.Message}");
            }
            return edad;
        }
        public string EvaluarEdad()
        {
            if (CalcularEdad() <= 18)
            {
                return "Menor de Edad";
            }
            else if (CalcularEdad() >= 18 && CalcularEdad() < 60)
            {
                return "Adulto";
            }
            else
            {
                return "Adulto Mayor";
            }
        }
    }
}

