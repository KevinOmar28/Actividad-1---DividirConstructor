using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___Actividad_1___Dividir
{
    internal class Divicion
    {
        public double num1;
        public double num2;

        public Divicion()
        {
        }

        public Divicion(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public double divide()
        {
            return num1 / num2;
        }
    }
}
