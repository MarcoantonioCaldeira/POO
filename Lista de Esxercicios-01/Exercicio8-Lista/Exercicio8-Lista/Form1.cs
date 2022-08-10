namespace Exercicio8_Lista
{
    public partial class Form1 : Form
    {
        int soma = 0, subtracao = 0, divisao = 0, multiplicacao = 0;
        int num1, num2;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {


            num1 = Convert.ToInt32(textname1.Text);
            num2 = Convert.ToInt32(textname2.Text);

            if (radioSoma.Checked)
            {
                soma = num1 + num2;
                textResultado.Text = soma.ToString();
            }

            if (radioSubtracao.Checked)
            {
                subtracao = num1 - num2;
                textResultado.Text = subtracao.ToString();
            }

            if (radioDivisao.Checked)
            {
                divisao = num1 / num2;
                textResultado.Text = divisao.ToString();
            }

            if (radioMultiplicacao.Checked)
            {
                multiplicacao = num1 * num2;
                textResultado.Text = multiplicacao.ToString();
            }   
        }
    }
}