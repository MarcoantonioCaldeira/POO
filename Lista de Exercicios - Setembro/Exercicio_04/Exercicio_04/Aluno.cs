using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04
{
    class Aluno
    {
        private string nome;
        private double nota1;
        private double nota2;

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }



        public double getNota1()
        {
            return nota1;
        }

        public void setNota1(double nota1)
        {
            this.nota1 = nota1;
        }



        public double getNota2()
        {
            return nota2;
        }

        public void setNota2(double nota2)
        {
            this.nota2 = nota2;
        }



        public double Calcular_Media()
        {
            return (nota1 + nota2) / 2;
        }

        public string Imprime_Dados()
        {
            return "A media do aluno" + nome +" eh igual ah: ";
        }
    }
}
