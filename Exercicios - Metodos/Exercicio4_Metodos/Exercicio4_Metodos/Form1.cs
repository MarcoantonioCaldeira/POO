using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio4_Metodos
{
    public partial class Form1 : Form
    {
        Calculadora numeros = new Calculadora();


        public Form1()
        {
            InitializeComponent();
        }


        private void btn_adicao_Click(object sender, EventArgs e)
        {
         
            double calculo_soma = numeros.cacular_Soma();
            text_resultado.Text = calculo_soma.ToString();
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
      
            double calculo_subtracao = numeros.calcular_Subtracao();
            text_resultado.Text = calculo_subtracao.ToString();
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
     
            double calculo_multiplicacao = numeros.cacular_Multiplicacao();
            text_resultado.Text = calculo_multiplicacao.ToString();
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
         

            double calculo_divisao = numeros.calcular_Divisao();
            text_resultado.Text = calculo_divisao.ToString();
        }

        private void group_operacoes_Enter(object sender, EventArgs e)
        {
            try
            {
                numeros.num1 = Convert.ToDouble(text_num1.Text);
                numeros.num2 = Convert.ToDouble(text_num2.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Algum erro no codigo");
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
