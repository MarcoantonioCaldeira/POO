using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio5_Lista
{
    public partial class Form1 : Form
    {
        Produto produto1 = null;
        Produto produto2 = null;
        int preco_Total;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (rdb_produto1.Checked == true)
            {
                if (produto1 == null)
                {
                    produto1 = new Produto();
                    produto1.nome = text_nome.Text;
                    produto1.preco_unitario = Convert.ToInt32(text_preco.Text);
                    produto1.quant = Convert.ToInt32(text_quantidade.Text);
                }
                else
                {
                    MessageBox.Show("O produto 1 já está cadastrado");
                }
            }
            

            else
            {
                if (rdb_produto2.Checked == true)
                {
                    if (produto2 == null)
                    {
                        produto2 = new Produto();
                        produto2.nome = text_nome.Text;
                        produto2.preco_unitario = Convert.ToInt32(text_preco.Text);
                        produto2.quant = Convert.ToInt32(text_quantidade.Text);
                    }
                    else
                    {
                        MessageBox.Show("O produto 2 já está cadastrado");
                    }
                }
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            if(produto2 != null)
            {
                MessageBox.Show("Nome do produto: " + produto1.nome + "Preço unitario: " + produto1.preco_unitario + 
                "Quantidade: " + produto1.quant + "\nNome do produto: " + produto2.nome + "Preço unitario: " + produto2.preco_unitario + "Quantidade: " + produto2.quant);
            }
            else
            {
                MessageBox.Show("Nome do produto: " + produto1.nome + "Preço unitario: " + produto1.preco_unitario +"Quantidade: " + produto1.quant);
            }
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            

            if(rdb_produto2.Checked == true)
            {
                preco_Total = (produto1.quant * produto1.preco_unitario) + (produto2.quant * produto2.preco_unitario);
                text_total.Text = preco_Total.ToString();
            }
            else
            {
                if(rdb_produto1.Checked == true)
                {
                    preco_Total = (produto1.quant * produto1.preco_unitario);
                    text_total.Text = preco_Total.ToString();
                }
            }
        }

        private void text_total_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
