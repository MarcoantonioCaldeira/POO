using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_Objetos
{
    class Refrigerante
    {
        private string nome;
        private double preco;
        private int qtdEstoque;

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


        public int getQtdEstoque()
        {
            return qtdEstoque;
        }

        public void setQtdEstoque(int qtd_estoque)
        {
            this.qtdEstoque = qtd_estoque;
        }

        public double EfetuarVenda(int quant_compra)
        {
            return preco * quant_compra;
        }
    }
}
