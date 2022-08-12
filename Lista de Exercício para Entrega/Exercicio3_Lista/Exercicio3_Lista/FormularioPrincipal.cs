using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3_Lista
{
    public partial class FormularioPrincipal : Form
    {
        Turma Salas1 = null;//crinado o primeiro objeto
        Turma Salas2 = null;//criando o segundo objeto

        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if(Salas1 == null)
            {
                Salas1 = new Turma();
                Salas1.periodo = combo_periodo.Text;
                Salas1.serie = Convert.ToInt32(combo_num_serie.Text);
                Salas1.sigla = text_sigla.Text;
                //Salas1.tipo_de_ensino = Convert.ToString(rdb_1.Checked);
                //Salas1.tipo_de_ensino = Convert.ToString(rdb2.Checked);
                //Salas1.tipo_de_ensino = Convert.ToString(rdb3.Checked);
            }
            else
            {
                if(Salas2 == null)
                {
                    Salas2 = new Turma();
                    Salas2.periodo = combo_periodo.Text;
                    Salas2.serie = Convert.ToInt32(combo_num_serie.Text);
                    Salas2.sigla = text_sigla.Text;
                    //Salas2.tipo_de_ensino = Convert.ToString(rdb_1.Checked);
                    //Salas2.tipo_de_ensino = Convert.ToString(rdb2.Checked);
                    //Salas2.tipo_de_ensino = Convert.ToString(rdb3.Checked);
                }
                else
                {
                    MessageBox.Show("As Salas já foram cadastradas");
                }
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if(Salas2 != null)
            {
                MessageBox.Show("Periodo: " + Salas2.periodo + "\nSerie: " + Salas2.serie + "\nSigla: " + Salas2.sigla);
            }
            else
            {
                MessageBox.Show("Periodo: " + Salas1.periodo + "\nSerie: " + Salas1.serie + "\nSigla: " + Salas1.sigla);
            }
        }
    }
}
