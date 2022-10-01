using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_07
{
    class Circulo
    {
        private double raio, area, perimetro;

        public double getRaio()
        {
            return raio;
        }

        public void setRaio(double raio)
        {
            this.raio = raio;
        }

        public double getArea()
        {
            return area;
        }

        public void setArea(double area)
        {
            this.area = area;
        }

        public double getPerimetro()
        {
            return perimetro;
        }

        public void setPerimetro(double perimetro)
        {
            this.perimetro = perimetro;
        }

        public double CalcularArea()
        {
            return area = (3.14 * raio * raio);
        }

        public double CalcularPerimetro()
        {
            return perimetro = (2 * 3.14 * raio);
        }

        public string MostrarDados()
        {
            return "Valor do raio" + raio;
        }
    }
}
