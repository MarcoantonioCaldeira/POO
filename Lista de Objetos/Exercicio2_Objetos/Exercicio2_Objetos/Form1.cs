using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2_Objetos
{
    public partial class Form1 : Form
    {
        List<Refrigerante> listaRefrigerantes = new List<Refrigerante>();
        Refrigerante Refrigerantes = new Refrigerante();
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
          

            Refrigerantes.setNome(text_nome.Text);
            Refrigerantes.setPreco(Convert.ToDouble(text_preco.Text));
            Refrigerantes.setQtdEstoque(Convert.ToInt32(text_quant.Text));

            MessageBox.Show("Cadastro feito com sucesso!!!");

            listaRefrigerantes.Add(Refrigerantes);
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            foreach (Refrigerante r in listaRefrigerantes)
            {
                list_produtos.Items.Add("Nome: " + r.getNome() + " \nPreco: " + r.getPreco() + " \nQuantidade de estoque: " + r.getQtdEstoque());
            }
        }

        private void btn_venda_Click(object sender, EventArgs e)
        {
            int quant_compra = (Convert.ToInt32(text_quant_compra.Text));

            if (Refrigerantes.getQtdEstoque() <= quant_compra)
            {
                MessageBox.Show("Compra Efetuada com sucesso!!!"
            + "\n\nValor da venda: " + Refrigerantes.EfetuarVenda(quant_compra));
            }
            else
            {
                MessageBox.Show("Estoque não tem quantidade suficiente para efetuar essa compra!!!");
            }

           
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
        
                list_produtos.Items.RemoveAt(list_produtos.SelectedIndex);
           
        }
    }
}
