using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_06
{
    public partial class Form1 : Form
    {
        Questionario frase = new Questionario();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clique_aqui_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Frase" + "\n\n" + frase.Mostrar_Dados());
        }
    }
}
