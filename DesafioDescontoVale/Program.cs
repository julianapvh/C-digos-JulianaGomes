using System;

namespace Desafio_06_Locadora
{
    class Program
    {
        static void Main(string[] args)
        {
            imposto Alimentacao = new estagiario();
            Alimentacao.desconto(1000);


            Console.WriteLine(Alimentacao);
            imposto Vale = new atendente();
            Vale.desconto(2000);
            Console.WriteLine(Vale);

            imposto Combustivel = new gerente();
            Combustivel.desconto(5000);
            Console.WriteLine(Combustivel);
            Console.Beep();
            Console.Write("\a");
             


            Console.ReadKey();


        }
    }
}
