using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Objetos
{
    class Produto
    {
        private string nome;
        private double preco;
        private int saldo;

        public string getNome()
        {
            return nome;
        }

        public void setNome(string Nome)
        {
            this.nome = Nome;
        }

        public double getPreco()
        {
            return preco;
        }

        public void setPreco(double Preco)
        {
            this.preco = Preco;
        }


        public int getSaldo()
        {
            return saldo;
        }

        public void setSaldo(int Saldo)
        {
            this.saldo = Saldo;
        }

        public double TotalProduto()
        {
            return saldo * preco;

        }


    }

}
