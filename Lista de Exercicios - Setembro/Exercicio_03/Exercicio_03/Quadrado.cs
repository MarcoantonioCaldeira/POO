using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    class Quadrado
    {
        private double tamanho_lado;


        public double getTamanho()
        {
            return tamanho_lado;
        }

        public void setTamanho(double tamanho)
        {
            this.tamanho_lado = tamanho;
        }

        public double Calcular_Area()
        {
            return tamanho_lado * tamanho_lado;
        }
    }
}
