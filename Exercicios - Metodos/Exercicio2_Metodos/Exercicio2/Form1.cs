using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2
{
    public partial class Form1 : Form
    {

        Quadrado quadrado = new Quadrado();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_perimetro_Click(object sender, EventArgs e)
        {
            quadrado.calcularPerimetro();

            MessageBox.Show(quadrado.imprimir());
        }

        private void btn_area_Click(object sender, EventArgs e)
        {
            try
            {
                quadrado.calcularArea();
            }
            catch()
            {
                MessageBox.Show()
            }
            MessageBox.Show(quadrado.imprimir());
        }

        private void text_lado_TextChanged(object sender, EventArgs e)
        {
            quadrado.lado = Convert.ToInt32(text_lado.Text);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
