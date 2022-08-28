using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio5_Metodos
{
    public partial class Form1 : Form
    {
        Funcionario Valores = new Funcionario();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_novosalario_Click(object sender, EventArgs e)
        {
            try
            {
                Valores.nome = text_nome.Text;
                Valores.salario = Convert.ToInt32(text_salario.Text);
                double novo_salario = Valores.aumento_Salario();
                text_novosalario.Text = novo_salario.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Algum erro de digitação!!!");
            } 
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Valores.imprimir_Dados());
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
