using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Vetores
{
    class Pessoa
    {
        private string nome;
        private int idade;

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string Nome)
        {
            this.nome = Nome;
        }

        public int getIdade()
        {
            return this.idade;
        }

        public void setIdade(int Idade)
        {
            this.idade = Idade;
        }
    }
}
