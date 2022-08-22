using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio04_Lista
{
    public partial class Form1 : Form
    {
        //criando o objeto
        Aluno aluno1 = null;
        Aluno aluno2 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if(aluno1 == null)
            {
                aluno1 = new Aluno();

                aluno1.nome = text_nome.Text;
                aluno1.media = Convert.ToInt32(text_media.Text);
                aluno1.data_de_nascimento = Convert.ToDateTime(data_aluno.Text);

                btn_visualizar.Enabled = true;
            }
            else
            {
                if (aluno2 == null)
                {
                    aluno2 = new Aluno();

                    aluno2.nome = text_nome.Text;
                    aluno2.media = Convert.ToInt32(text_media.Text);
                    aluno2.data_de_nascimento = Convert.ToDateTime(data_aluno.Text);

                    btn_visualizar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Os alunos já estão cadastrados");
                }
            }
        }

        private void btn_visualizar_Click(object sender, EventArgs e)
        {
            if(aluno2 != null)
            {
                MessageBox.Show("Nome: " + aluno1.nome + ", " + "Media: " + aluno1.media +  ", " + " Data de Nascimento: " + aluno1.data_de_nascimento + "\nNome:  " + aluno2.nome + " Media: " + aluno2.media + " Data de Nascimento: " + aluno2.data_de_nascimento);

                //Verificação da maior media
                if (aluno1.media > aluno2.media)
                {
                    MessageBox.Show("A maior media é do aluno: " + aluno1.nome);
                }
                else
                {
                    MessageBox.Show("A maior media é do aluno: " + aluno2.nome);
                }
            }
            else
            {
                MessageBox.Show("\nNome: " + aluno1.nome + ", " + " Media: " + aluno1.media + ", " + " Data de Nascimento: " + aluno1.data_de_nascimento);
            }     
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
