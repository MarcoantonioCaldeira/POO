using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Revisao
{
    public partial class UserControl1: UserControl
    {
        Adicao operacao1 = null;
        Subtracao operacao2 = new Subtracao();
        Multiplicacao opercacao3 = new Multiplicacao();
        Divisao operacao4 = new Divisao();

        public UserControl1()
        {
            InitializeComponent();
        }

        private void btn_adicao_Click(object sender, EventArgs e)
        {
            operacao1 = new Adicao();
            int num1, num2;

            num1 = (Convert.ToInt32(text_num1.Text));
            num2 = (Convert.ToInt32(text_num2.Text));

            MessageBox.Show("Resultado: " + operacao1.calcular(num1, num2));

        }
    }
}
