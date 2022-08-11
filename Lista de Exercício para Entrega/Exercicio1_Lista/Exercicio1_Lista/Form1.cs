using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1_Lista
{
    public partial class Form1 : Form
    {
        Empregado Dados = new Empregado();  //criando o objeto

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            Dados.nome = text_nome.Text;
            Dados.idade = Convert.ToInt32(text_idade.Text);


            text_mostrar_nome.Text = Dados.nome.ToString();
            text_mostrar_idade.Text = Dados.idade.ToString();
        }
    }
}
