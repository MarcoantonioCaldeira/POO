using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6_Metodos
{
    class Paciente
    {
        public string nome;
        public double peso;
        public double altura;
        public double valor_imc;
        public string classificar;

        public double calcular_IMC()
        {
            valor_imc = peso / (altura * altura);
            return valor_imc;
        }

        public string classificar_IMC()
        {
            if(valor_imc <= 18.5)
            {
                classificar =  "Abaixo do peso";
            }
            else
            {
                if(valor_imc <= 24.9)
                {
                    classificar = "Peso ideal(parabéns)";
                }
                else
                {
                    if(valor_imc >= 25.0 && valor_imc <= 29.9)
                    {
                        classificar = "Levemente acima do peso";
                    }
                    else
                    {
                        if(valor_imc>=30.0 && valor_imc<= 34.9)
                        {
                            classificar = "Obesidade grau 1";
                        }
                        else
                        {
                            if (valor_imc>=35.0 && valor_imc<=39.9)
                            {
                                classificar = "Obesidade grau 2";
                            }
                            else
                            {
                                if (valor_imc >= 40)
                                {
                                    classificar = "Obesidade grau 3";
                                }
                            }
                        }
                    }
                }
            }

            return classificar;

        }

        public string imprimir_Dados()
        {
            return "Nome do paciente: " + nome + "\nAltura:" + altura + "\nPeso: " + peso + "kg";
        }
    }
}
