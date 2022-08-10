using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio10_Lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sexo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void text_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            if (rdb1.Checked)
            {
                MessageBox.Show("Dados do funcionario \n" + "Nome: " + text_nome.Text + "\n Sexo: " +  sexo.Text + "\n Possui Dependentes: Sim" );
            }
            else
            {
                if (rdb2.Checked)
                {
                    MessageBox.Show("Dados do funcionario \n" + "Nome: " + text_nome.Text + "\n Sexo: " + sexo.Text + "\n Possui Dependentes: Não");
                }
            }
        }
    }
}
