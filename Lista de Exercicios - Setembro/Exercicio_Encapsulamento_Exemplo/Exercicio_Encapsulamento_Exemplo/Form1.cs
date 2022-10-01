using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Encapsulamento_Exemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            Pessoa p1 = new Pessoa();


            try{
                p1.setNome(text_nome.Text);
                p1.setIdade(Convert.ToInt32(text_idade.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Algum campo esta incorreto");
            }
            


            MessageBox.Show("Nome:" + p1.getNome() +  "\nIdade: " + p1.getIdade()); 
        }
    }
}
