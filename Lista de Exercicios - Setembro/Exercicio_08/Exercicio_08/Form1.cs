using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_08
{
    public partial class Form1 : Form
    {
        Televisao tv = new Televisao();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_mostrar_dados_Click(object sender, EventArgs e)
        {
            tv.setMarca(text_marca.Text);
            tv.setModelo(text_modelo.Text);
            tv.setData_lancamento(Convert.ToDateTime(text_datalancamento.Text));
            tv.setPreco_custo(Convert.ToDouble(text_precocusto.Text));
            tv.setLcd(Convert.ToDouble(text_lcd.Text));
            tv.setPolegada(Convert.ToInt32(text_polegada.Text));

            MessageBox.Show("Dados Cadastrados!!!" + "\n\n" + tv.Mostra_Dados());

            text_marca.Clear();
            text_modelo.Clear();
            text_datalancamento.Clear();
            text_precocusto.Clear();
            text_lcd.Clear();
            text_polegada.Clear();

            btn_mostrar_dados.Enabled = false;
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Preço da Venda: " + tv.Preco_Venda());
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
