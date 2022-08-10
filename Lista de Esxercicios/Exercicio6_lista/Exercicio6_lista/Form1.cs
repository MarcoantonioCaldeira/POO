using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio6_lista
{
    public partial class Form1 : Form
    {
        double i, fatorial, num;

        private void text_num_TextChanged(object sender, EventArgs e)
        {
            //num = double.Parse(Console.ReadLine());
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            int i, f = 1, num;

            num = Convert.ToInt32(text_num.Text);
            for(i=1; i<=num; i++)
            {
                f = f * i;
                text_resultado.Text = f.ToString();
            }
        }
    }
}
