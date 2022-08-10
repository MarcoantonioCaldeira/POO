namespace Exercicio7
{
    public partial class Form1 : Form
    {
        int num = 0;
        int sucessor = 0, antecessor = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void btncalc_Click(object sender, EventArgs e)
        {

            num = Convert.ToInt32(textnum.Text);
            sucessor = num + 1;
            antecessor = num - 1;

            textnum.Text = sucessor.ToString();
            textnum.Text = antecessor.ToString();
        }
    }
}