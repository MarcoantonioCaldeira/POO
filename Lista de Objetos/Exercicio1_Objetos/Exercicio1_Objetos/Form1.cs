using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1_Objetos
{
    public partial class Form1 : Form
    {
        List<Produto> listaProdutos = new List<Produto>();
        Produto produtoTeste = null;
        //bool achou = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {


            produtoTeste = new Produto();

            produtoTeste.setNome(text_nome.Text);
            produtoTeste.setPreco(Convert.ToDouble(text_preco.Text));
            produtoTeste.setSaldo(Convert.ToInt32(text_saldo.Text));

            MessageBox.Show("Produto Cadastrado com sucesso!!!");

            listaProdutos.Add(produtoTeste); 


        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            foreach (Produto p in listaProdutos)
            {
               
                list_produtos.Items.Add("Nome: " + p.getNome() + "\n" + "Preço do produto: " + p.getPreco() + "\n" +
                p.getSaldo() + "\n" + p.TotalProduto());
                
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
           
             list_produtos.Items.RemoveAt(list_produtos.SelectedIndex);
            
        }

        private void btn_esvaziar_Click(object sender, EventArgs e)
        {
            list_produtos.Items.Clear();
        }
    }
}
