using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05
{
    class Funcionario
    {
        private int idade, anos_servico, salario;

        public Funcionario()
        {

        }

        public Funcionario(int idade, int anos_servico, int salario)
        {
            this.idade = idade;
            this.anos_servico = anos_servico;
            this.salario = salario;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }



        public int getAnos_Servico()
        {
            return anos_servico;
        }

        public void setAnos_Servico(int anos_servico)
        {
            this.anos_servico = anos_servico;
        }


        public int getSalario()
        {
            return salario;
        }

        public void setSalario(int salario)
        {
            this.salario = salario;
        }

        public string Mostrar_Dados()
        {
            return "Idade: " + idade + "\nAnos de Serviço: " + anos_servico + "\nSalario: " + salario;
        }
    }
}
