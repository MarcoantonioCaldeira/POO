using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_07
{
    public partial class Form1 : Form
    {
        Circulo circulo1 = new Circulo();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            circulo1.setRaio(Convert.ToDouble(text_raio.Text));

            MessageBox.Show("Calculo feito com sucesso!!!" + "\n" + circulo1.MostrarDados() + "\n" +
            "Valor da area: "+ circulo1.CalcularArea() + "\n" + "Valor do perimetro: " + circulo1.CalcularPerimetro());
        }
    }
}
