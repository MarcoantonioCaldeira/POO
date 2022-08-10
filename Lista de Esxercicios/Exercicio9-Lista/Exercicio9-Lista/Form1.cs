using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio9_Lista
{
    

    public partial class Form1 : Form
    {
        double conceito_Nota;

        public Form1()
        {
            InitializeComponent();
        }


        private void btn_conceito_Click(object sender, EventArgs e)
        {
            conceito_Nota = Convert.ToDouble(text_nota.Text);


            if (conceito_Nota<=4.9 && conceito_Nota>=0.0)
            {
                MessageBox.Show(text_nome.Text + " Conceito D");
            }
            else
            {

                if (conceito_Nota >=5 && conceito_Nota <=6.9)
                {
                    MessageBox.Show(text_nome.Text + " Conceito C");
                }
                else
                {
                    if (conceito_Nota >=7.0 && conceito_Nota<=8.9) 
                    {
                        MessageBox.Show(text_nome.Text + " Conceito B");
                    }
                    else
                    {
                        if (conceito_Nota >= 9.0 && conceito_Nota <= 10)
                        {
                            MessageBox.Show(text_nome.Text + " Conceito A");
                        }
                    }
                }
            }
        }

        private void text_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
