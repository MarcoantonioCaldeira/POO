using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_06
{
    class Questionario
    {
        private string nome = "O Ms Anderson";
        private string sobrenome = " Cruz";
        private string sexo = " MS";
        private string naturalidade = " é natural de São Leopoldo";
        private string endereco = " e hoje reside na rua xxxx, 123";
        private string cidade = " São Leopoldo";
        private string estado = " RS";

        //nome
        public string getNome()//get retorna
        {
            return nome;
        }

        public void setNome(string nome)//set não retorna
        {
            this.nome = nome;
        }

        //sobrenome
        public string getSobrenome()
        {
            return sobrenome;
        } 

        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        //sexo
        public string getSexo()
        {
            return sexo;
        }

        public void setSexo(string sexo)
        {
            this.sexo = sexo;
        }

        //naturalidade
        public string getNaturalidade()
        {
            return naturalidade;
        }

        public void setNaturalidade(string naturalidade)
        {
            this.naturalidade = naturalidade;
        }

        //endereco
        public string getEndereco()
        {
            return endereco;
        }

        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        //cidade
        public string getCidade()
        {
            return cidade;
        }

        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }

        //estado
        public string getEstado()
        {
            return estado;
        }

        public void setEstado(string estado)
        {
            this.estado = estado;
        }

        //mostrar dados
        public string Mostrar_Dados()
        {
            return nome + sobrenome + naturalidade + endereco + cidade + estado;
        }
    }
}
