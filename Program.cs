using System;

namespace Gravidade_dos_Casos
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Digite a gravidade do seu caso");
                int gravidade = int.Parse(Console.ReadLine());

                if (gravidade >= 0 && gravidade <= 3)
                {
                    Console.WriteLine("Seu grau de gravidade é baixo!");
                }
                else if (gravidade >= 3 && gravidade <= 6)
                {
                    Console.WriteLine("Seu grau de gravidade é médio!");
                }
                else if (gravidade >= 6 && gravidade <= 9)

                    Console.WriteLine("Seu grau de gravidade é alto!");






                Console.ReadLine();
            }
        }
    }


    
