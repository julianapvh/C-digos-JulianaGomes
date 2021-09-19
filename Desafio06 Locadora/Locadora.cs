using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio06_Locadora
{
    class Locadora
    {
        public virtual void ValorDasDiarias(int diaria)
        {
            float diarias =(float) 100.00;
            float porcentagem = (float)0.1;
            float calculo = (diarias * diaria) * porcentagem;
            Console.WriteLine($"Valor R$ 100\n Quantidade de diárias:  {diaria}\n Valor do seguro: {calculo.ToString("C")} ");
        }
    }
}
