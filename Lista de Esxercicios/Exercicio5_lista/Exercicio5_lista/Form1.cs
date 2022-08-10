using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio5_lista
{
    public partial class Form1 : Form
    {
        int clique;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clique_Click(object sender, EventArgs e)
        {
            this.clique++;
            text_result.Text = this.clique.ToString();
        }
    }
}
