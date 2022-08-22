using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Quadrado
    {
        public int lado;
        public int area;
        public int perimetro;


        public int calcularArea() 
        {
             return area = lado * lado;
        }

        public int calcularPerimetro()
        {
            return perimetro = 4 * lado;
        }

        public string imprimir()
        {
            return "Area: " + area + "\nPerimetro: " + perimetro;
        }

    }
}
