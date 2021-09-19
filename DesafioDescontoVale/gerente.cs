using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_06_Locadora
{
    class gerente:imposto
    {
        public override void desconto(double dinheiro)
        {
            Console.WriteLine($"Vale alimentação gerente {dinheiro * 0.05} ");
        }

        
    }
}
