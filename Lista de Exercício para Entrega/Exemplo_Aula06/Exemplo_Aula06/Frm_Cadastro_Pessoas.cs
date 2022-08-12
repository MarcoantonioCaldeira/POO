using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_Aula06
{
    public partial class Frm_Cadastro_Pessoas : Form
    {
        Pessoa p1 = null;
        Pessoa p2 = null;

        public Frm_Cadastro_Pessoas()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (p1 == null)
            {
                p1 = new Pessoa();
                p1.nome = text_nome.Text;
                p1.idade = Convert.ToInt32(text_idade.Text);

                btn_Imprimir.Enabled = true;
            }
            else
            {
                if(p2 == null)
                {
                    p2 = new Pessoa();
                    p2.nome = text_nome.Text;
                    p2.idade = Convert.ToInt32(text_idade.Text);

                    btn_Imprimir.Enabled = true;
                }
                else
                {
                    MessageBox.Show("As pessoas já estão cadastradas!");
                }
            }
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            if(p2 != null)
            {
                MessageBox.Show("Nome: " + p1.nome + " Idade: " + p1.idade + 
                "\n\nNome: " + p2.nome + " Idade: " + p2.idade);
            }
            else
            {
                MessageBox.Show("Nome: " + p1.nome + " Idade: " + p1.idade);
            }
        }
    }
}
