using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_06_Locadora
{
    class atendente : imposto
    {
        public override void desconto(double dinheiro)
        {
            Console.WriteLine($"Vale alimentação atendente {dinheiro * 0.02} ");
        }
    }
}
