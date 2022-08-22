using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1_Metodos
{
    class Funcionario
    {
        public string nome, departamento;
        public double horasTrabalhadasNoMes, salarioPorHora;

        public string mostraDados()
        {
            return "Nome: " + nome  + "\nDepartamento: " + departamento 
            + "\nHoras trabalhadas: " + horasTrabalhadasNoMes + 
            "\nSalario por hora: " + salarioPorHora;
        }

        public double calculaSalarioMensal()
        {

            return horasTrabalhadasNoMes * salarioPorHora; 
        }

    }
}
