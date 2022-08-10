using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio11_Lista
{
    public partial class Form1 : Form
    {
        int num_comeco = 0, num_meio = 0, num_fim = 0, num;
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num_comeco = Convert.ToInt32(digitar_num1.Text);
            num_meio = Convert.ToInt32(digitar_num2.Text);
            num_fim = Convert.ToInt32(digitar_num3.Text);

          
                if (i == 0)
                {
                    num = num_comeco;
                    num = num_meio;
                    num = num_fim;
                }

                if(num > num_comeco)
                {
                     num_comeco = num;
                     re_num1.Text = num_comeco.ToString();
                }

                if (num < num_fim)
                {
                    num_fim = num;
                    re_num3.Text = num_fim.ToString();
                }

                if (num > num_fim && num < num_comeco)
                {
                    num_meio = num;
                    re_num2.Text = num_meio.ToString();
                }
        }
           
               
        }
    }
}
