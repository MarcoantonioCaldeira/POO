using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Aula_012
{
    class Departamento
    {
        private int codigo, quant_Empregados;
        string nome;

        public Departamento()
        {

        }


        public Departamento(int codigo, int quant_Empregados, string nome)
        {
            this.codigo = codigo;
            this.quant_Empregados = quant_Empregados;
            this.nome = nome;
        }

        //get e set do codigo
        public int getCodigo()
        {
            return codigo;
        }

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        //get e set da quantidade de empregados
        public int getquant_Empregados()
        {
            return quant_Empregados;
        }

        public void setquant_Empregados(int quant_Empregados)
        {
            this.quant_Empregados = quant_Empregados;
        }

        //get e set do nome
        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string imprimeDados()
        {
            return "Departamento: " + nome + "\nCodigo: " + codigo + "\nQuantidade de Empregados: " + quant_Empregados;
        }
    }
}
