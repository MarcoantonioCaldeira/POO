using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Revisao
{
    internal class Subtracao:Operacao_Matematica
    {
        public int calcular(int a, int b)
        {
             return  a - b;
        }
    }
}