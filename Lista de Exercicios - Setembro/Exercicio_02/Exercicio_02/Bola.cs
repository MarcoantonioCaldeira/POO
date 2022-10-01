using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    class Bola
    {
        private string cor;
        private double circunferencia;
        private string material;

        public string getCor()
        {
            return cor;
        }

        public void setCor(string cor)
        {
            this.cor = cor;
        }



        public double getCircunferencia()
        {
            return circunferencia;
        }

        public void setCircunferencia(double circunferencia)
        {
            this.circunferencia = circunferencia;
        }
        


        public string getMaterial()
        {
            return material;
        }

        public void setMaterial(string material)
        {
            this.material = material;
        }


    }
}
