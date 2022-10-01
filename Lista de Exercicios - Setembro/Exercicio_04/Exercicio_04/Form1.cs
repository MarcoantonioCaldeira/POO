using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            Aluno media_aluno = new Aluno();

            media_aluno.setNome(text_nome.Text);
            media_aluno.setNota1(Convert.ToDouble(text_nota1.Text));
            media_aluno.setNota2(Convert.ToDouble(text_nota2.Text));

            MessageBox.Show(media_aluno.Imprime_Dados() + media_aluno.Calcular_Media());
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
