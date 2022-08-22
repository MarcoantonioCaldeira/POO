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
                Salas1.periodo = Convert.ToString(combo_periodo.SelectedItem);
                Salas1.serie = Convert.ToInt32(combo_num_serie.SelectedValue);
                Salas1.sigla = text_sigla.Text;
                Salas1.ensino = Convert.ToString(combo_ensino.SelectedItem);
            }
            else
            {
                if(Salas2 == null)
                {
                    Salas2 = new Turma();
                    Salas2.periodo = Convert.ToString(combo_periodo.SelectedItem);
                    Salas2.serie = Convert.ToInt32(combo_num_serie.SelectedValue);
                    Salas2.sigla = text_sigla.Text;
                    Salas2.ensino = Convert.ToString(combo_ensino.SelectedItem);

                    if(Salas2.sigla == Salas1.sigla)
                    {
                        MessageBox.Show("!!!Sigla incorreta");//As siglas não podem ser iguais
                    }
                }
                else
                {
                    MessageBox.Show("As Salas já foram cadastradas");//Só podem ser cadastradas duas salas
                }
            }
        }

        private void btn_visualisar_Click(object sender, EventArgs e)
        {
            if(Salas2 != null)
            {
                MessageBox.Show("Periodo: " + Salas2.periodo + " Serie: " + Salas2.serie + " Sigla: "  + Salas2.sigla + " Tipo de Ensino: "
                    + Salas2.ensino + "\nPeriodo: " + Salas1.periodo + " Serie: " + Salas1.serie + " Sigla: " + Salas1.sigla + " Tipo de Ensino: " + Salas1.ensino);
            }
            else
            {
                MessageBox.Show("\nPeriodo: " + Salas1.periodo + " Serie: " + Salas1.serie + " Sigla: " + Salas1.sigla + " Tipo de Ensino: " + Salas1.ensino);
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
