using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5_Metodos
{
    class Funcionario
    {
        public string nome;
        public double salario;
        public double novo_salario;

        public double aumento_Salario()
        {
            if (salario <= 1500)
            {
                return novo_salario = ((salario * 25) / 100 ) + salario;
            }
            else
            {
                if(salario>1500 && salario <= 4000)
                {
                    return novo_salario = ((salario * 20) / 100) + salario;
                }
                else
                {
                    if(salario>4000 && salario <= 6500)
                    {
                        return novo_salario = ((salario * 15) / 100) + salario;
                    }
                }
            }

            return novo_salario;
        }


        public string imprimir_Dados()
        {
            return "Nome: " + nome + "\nNovo Salario: " + novo_salario;
        }
    }
}
