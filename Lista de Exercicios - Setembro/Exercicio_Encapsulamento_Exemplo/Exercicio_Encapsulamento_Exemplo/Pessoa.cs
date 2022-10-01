using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Encapsulamento_Exemplo
{
    class Pessoa
    {
        private string Nome;
        private int idade;

        public string getNome()
        {
            return Nome;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }
    }
}
