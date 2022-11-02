using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1_Vetores
{
    public partial class Form1 : Form
    {
        Pessoa[] vetPessoa = new Pessoa[3];//criando o vetor pessoa
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            if (i < 3)
            {
                text_nome.Clear();
                text_idade.Clear();


                text_nome.Focus();
            }
            else
            {
                MessageBox.Show("O vetor já está cheio!!!");
            }
                
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            vetPessoa[i] = new Pessoa();
            vetPessoa[i].setNome(text_nome.Text);
            vetPessoa[i].setIdade(Convert.ToInt32(text_idade.Text));
            i++;

            MessageBox.Show("Pessoa cadastrada com sucesso!!!");
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            int x;

            for (x = 0; x < vetPessoa.Length; x++)
            {
                MessageBox.Show(vetPessoa[x].getNome() + " " + Convert.ToString(vetPessoa[x].getIdade()));
            }
        }
    }
}
