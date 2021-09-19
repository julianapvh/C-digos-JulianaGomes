using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_06_Locadora
{
    class imposto
    {
        public virtual void desconto(double dinheiro)
        {
            Console.WriteLine($"Vale alimentação estagiário {dinheiro * 0.01}");
        }
    }
}
