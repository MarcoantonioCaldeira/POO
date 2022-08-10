using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2_Lista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string Verificar = "";

            if(checkDormir.Checked)
            {
                Verificar = Verificar + "Dormir\n";
            }

            if (checkComer.Checked)
            {
                Verificar = Verificar + "Comer\n";
            }

            if (checkCinema.Checked)
            {
                Verificar = Verificar + "ir ao cinema\n";
            }

            if (checkLivro.Checked)
            {
                Verificar = Verificar + "Ler um livro\n";
            }

            if (checkEstudar.Checked)
            {
                Verificar = Verificar + "Estudar\n";
            }

            if (Verificar == "")
            {
                MessageBox.Show("Nenhuma opção selecionada");
            }
            else
            {
                MessageBox.Show("Opções selecionadas: \n" + Verificar);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
