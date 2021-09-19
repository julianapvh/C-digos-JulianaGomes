using System;

namespace Desafio06_Locadora
{
    class Program
    {
        static void Main(string[] args)
        {
            AluguelDeCarros();
        }
        enum Aluguel { CarroPopular = 1 , CarroLuxo, CarroUtilitario, VoltarAoMenuInicial}
        static void AluguelDeCarros()
        {

            bool ClicouEmVoltar = false;

            while (ClicouEmVoltar == false)
            {

                Console.WriteLine("      LokAqui\n");
                Console.WriteLine(" 1 - Carro Polular\n 2 - Carro de Luxo\n 3 - Carro Ultilitário\n 4 - Voltar\n");
                Console.Write("Escolha uma opção de carro: ");

                int opcaoescolhida = int.Parse(Console.ReadLine());

                Aluguel Veiculos = (Aluguel)opcaoescolhida;
                
                if (opcaoescolhida > 0 && opcaoescolhida <= 4)
                {
                    switch (Veiculos)
                    {
                        case Aluguel.CarroPopular:
                            Locadora LokAqui = new CarroPopular();
                            Console.Write("Digite quantas diárias você utilizou: ");
                            LokAqui.ValorDasDiarias(int.Parse(Console.ReadLine()));

                            break;
                        case Aluguel.CarroLuxo:
                            Locadora LokAqui2 = new CarroLuxo();
                            Console.Write("Digite quantas diárias você utilizou: ");
                            LokAqui2.ValorDasDiarias(int.Parse(Console.ReadLine()));
                            break;
                        case Aluguel.CarroUtilitario:
                            Locadora LokAqui3 = new CarroUtilitario();
                            Console.Write("Digite quantas diárias você utilizou: ");
                            LokAqui3.ValorDasDiarias(int.Parse(Console.ReadLine()));
                            break;
                        case Aluguel.VoltarAoMenuInicial:
                            ClicouEmVoltar = true;
                            Console.Beep();
                            Console.Clear();
                            break;
                        default:
                            break;
                    }




                }
                if (ClicouEmVoltar == false)
                {
                    Console.ReadKey();

                }


                Console.Clear();
            }

        }
    }
}
