using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_area_Click(object sender, EventArgs e)
        {
            Quadrado calculo = new Quadrado();

            calculo.setTamanho(Convert.ToDouble(text_lado.Text));


            MessageBox.Show("Valor da area: " + calculo.Calcular_Area());
        }
    }
}
