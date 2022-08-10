using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio4
{
    public partial class Form1 : Form
    {
        float media, numero_1, numero_2, numero_3, numero_4;//Veriaveis Globais

        private void text_re_TextChanged(object sender, EventArgs e)
        {
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Media_Click(object sender, EventArgs e)
        {

            numero_1 = float.Parse(text_num1.Text);
            numero_2 = float.Parse(text_num2.Text);
            numero_3 = float.Parse(text_num3.Text);
            numero_4 = float.Parse(text_num4.Text);

            media = (numero_1 + numero_2 + numero_3 + numero_4)/4;

            text_re.Text = media.ToString();//Exibir o resultado
        }
    }
}
