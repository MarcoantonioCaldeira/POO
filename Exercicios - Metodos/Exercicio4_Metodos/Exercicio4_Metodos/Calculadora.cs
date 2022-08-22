using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4_Metodos
{
    class Calculadora
    {
        public double num1;
        public double num2;

        public double cacular_Soma()
        {
            return num1 + num2;
        }

        public double cacular_Multiplicacao()
        {
            return num1 * num2;
        }

        public double calcular_Divisao()
        {
            return num1 / num2;
        }

        public double calcular_Subtracao()
        {
            return num1 - num2;
        }
    }
}
