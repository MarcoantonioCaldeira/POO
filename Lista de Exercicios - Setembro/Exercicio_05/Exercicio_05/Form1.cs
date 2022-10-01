using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_05
{
    public partial class Form1 : Form
    {
        Funcionario f1 = null, f2 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            int idade, anos_servico, salario;

            idade = Convert.ToInt32(text_idade.Text);
            anos_servico = Convert.ToInt32(text_anos.Text);
            salario = Convert.ToInt32(text_salario.Text);

            f2 = new Funcionario(idade, anos_servico, salario);

            MessageBox.Show("Funcionario 2 cadastrado!!!" + "\n" + f2.Mostrar_Dados());

            if (f2.getIdade() > 65 && f2.getAnos_Servico() >= 35)
            {
                MessageBox.Show( "Aposentado por tempo de serviço!!!");
            }
            else
            {
                MessageBox.Show( "Não pode se aposentar!!!");
            }

            btn_2.Enabled = false;
        }





        private void btn_f1_Click(object sender, EventArgs e)
        {
            int idade, anos_servico, salario;

            idade = Convert.ToInt32(text_idade.Text);
            anos_servico = Convert.ToInt32(text_anos.Text);
            salario = Convert.ToInt32(text_salario.Text);

            f1 = new Funcionario(idade, anos_servico, salario);

            MessageBox.Show("Funcionario 1 cadastrado!!!" + "\n" + f1.Mostrar_Dados());

            if (f1.getIdade() > 65 && f1.getAnos_Servico() >= 35)
            {
                MessageBox.Show("Aposentado por tempo de serviço!!!");
            }
            else
            {
                MessageBox.Show("Não pode se aposentar!!!");
            }

            btn_f1.Enabled = false;
        }
    }
}
