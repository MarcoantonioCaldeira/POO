using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            Bola bolas = new Bola();

            bolas.setCor(text_cor.Text);
            bolas.setCircunferencia(Convert.ToDouble(text_circunferencia.Text));
            bolas.setMaterial(text_material.Text);

            MessageBox.Show("Cor: " +  bolas.getCor() + "\nCircunferencia: " + bolas.getCircunferencia() + "\nMaterial: " + bolas.getMaterial());
        }
    }
}
