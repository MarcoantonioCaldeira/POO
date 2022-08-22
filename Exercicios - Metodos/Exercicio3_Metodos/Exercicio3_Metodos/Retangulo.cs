using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3_Metodos
{
    class Retangulo
    {
        public double base_retangulo;
        public double altura_retangulo;


        public double calcular_Area()
        {
           return base_retangulo* altura_retangulo;
        }

        public double calcular_Perimetro()
        {
            return 2 * (base_retangulo + altura_retangulo);
        }

        public string retornar_Valores()
        {
            return "Valor da base: " + base_retangulo + "\nValor da altura: " + altura_retangulo;
        }
    }
}
