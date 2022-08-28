using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio6_Metodos
{
    public partial class Form1 : Form
    {
        Paciente resultado = new Paciente();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Calculo feito com sucesso" + "\nValor: " + resultado.calcular_IMC());
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {

            MessageBox.Show(resultado.imprimir_Dados() +"\n"+ resultado.classificar_IMC());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            resultado.nome = text_nome.Text;
            try
            {
                resultado.altura = Convert.ToDouble(text_altura.Text);
                resultado.peso = Convert.ToDouble(text_peso.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Algum erro de digitação!!!");
            }
        }
    }
}
