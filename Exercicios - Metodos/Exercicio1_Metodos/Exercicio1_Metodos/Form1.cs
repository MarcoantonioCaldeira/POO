using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1_Metodos
{
    public partial class frm_CadastroEmpregado : Form
    {
        Funcionario Funcionario1 = new Funcionario();

        public frm_CadastroEmpregado()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {

            Funcionario1.calculaSalarioMensal();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Funcionario1.nome = txt_nome.Text;
            Funcionario1.departamento = txt_departamento.Text;

            try//Verificar se o programa der errado
            {
                Funcionario1.horasTrabalhadasNoMes = Convert.ToDouble(txt_horas.Text);
                Funcionario1.salarioPorHora = Convert.ToDouble(txt_salario.Text);

                if(Funcionario1.horasTrabalhadasNoMes < 5)
                {
                    throw new Minha_excesao();
                }
            }
            catch(Minha_excesao)
            {
                MessageBox.Show("O valor da hora trabalhada deve ser menor ou igual ah 5");
                txt_horas.Focus();//O cursor ja vai para o campo que o usuario vai corrigir
            }

            
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Funcionario1.mostraDados());
        }
    }
}
