using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3_Metodos
{
    public partial class Form1 : Form
    {
        Retangulo valor_retangulo = new Retangulo();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mostrardados_Click(object sender, EventArgs e)
        {
            try
            {
                valor_retangulo.altura_retangulo = Convert.ToInt32(text_base.Text);
                valor_retangulo.base_retangulo = Convert.ToInt32(text_altura.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Algum erro no codigo");
            }

            MessageBox.Show(valor_retangulo.retornar_Valores());
        }

        private void btn_carea_Click(object sender, EventArgs e)
        {
            double valor_do_Area = valor_retangulo.calcular_Area();
            text_area.Text = valor_do_Area.ToString();

            double valor_Perimetro = valor_retangulo.calcular_Perimetro();
            text_perimetro.Text = valor_Perimetro.ToString();


        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
