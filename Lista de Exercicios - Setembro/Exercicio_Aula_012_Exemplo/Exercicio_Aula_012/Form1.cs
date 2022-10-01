using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Aula_012
{
    public partial class Form1 : Form
    {
        Departamento dep1 = null, dep2 = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_dep2_Click(object sender, EventArgs e)
        {
            int codigo, quant_Empregados;
            string nome;

            codigo = Convert.ToInt32(text_codigo.Text);
            quant_Empregados = Convert.ToInt32(text_quantidade.Text);
            nome = (text_nome.Text);

            dep2 = new Departamento(codigo, quant_Empregados, nome);

            MessageBox.Show("Departamento 2 cadastrado!!!");
            btn_dep2.Enabled = false;
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            //departamento 1 maior
            if(dep1.getquant_Empregados() > dep2.getquant_Empregados())
            {
                MessageBox.Show(dep1.imprimeDados());
            }
            else{ //departamento 2 maior

                if (dep2.getquant_Empregados() > dep1.getquant_Empregados())
                {
                    MessageBox.Show(dep2.imprimeDados());
                }
                else //são iguais
                {
                    if (dep2.getquant_Empregados() == dep1.getquant_Empregados())
                    {
                        MessageBox.Show(dep2.imprimeDados() + "\n\n" + dep1.imprimeDados());
                    }
                }
            }
        }

        private void btn_dep1_Click(object sender, EventArgs e)
        {
            dep1 = new Departamento();
            dep1.setCodigo(Convert.ToInt32(text_codigo.Text));
            dep1.setquant_Empregados(Convert.ToInt32(text_quantidade.Text));
            dep1.setNome(text_nome.Text);

            MessageBox.Show("Departamento 1 cadastrado!!!");
            btn_dep1.Enabled = false;

            text_codigo.Clear();
            text_quantidade.Clear();
            text_nome.Clear();
            text_codigo.Focus();
        }

        
    }
}
