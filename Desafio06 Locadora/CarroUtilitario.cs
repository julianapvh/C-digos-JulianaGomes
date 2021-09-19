using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio06_Locadora
{
    class CarroUtilitario : Locadora
    {
        public override void ValorDasDiarias(int diaria)
        {
            float diarias = (float)400.00;
            float porcentagem = (float)0.25;
            float calculo = (diarias * diaria) * porcentagem;
            Console.WriteLine($"Valor R$ 400\n Quantidade de diárias:  {diaria}\n Valor do seguro: {calculo.ToString("C")} ");

        }
    }
}
