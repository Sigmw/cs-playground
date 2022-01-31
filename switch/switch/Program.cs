using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempo;
            while (true)
            {
                try
                {
                    Console.WriteLine("Viagem: Belo Horizonte/MG -> Vitória/ES");
                    Console.Write("Escolha o transporte [A] - Avião | [B] - Carro | [C] - Ônibus: ");
                    char transporte = char.Parse(Console.ReadLine().Trim().ToLower());
                    switch (transporte)
                    {
                        case 'a':
                            tempo = 50;
                            Console.WriteLine($"Você optou por avião, isso dá exatamente: {tempo} minutos.");

                            break;
                        case 'b':
                            tempo = 480;
                            Console.WriteLine($"Você optou por Carro, isso dá exatamente: {tempo} minutos.");

                            break;
                        case 'c':
                            tempo = 660;
                            Console.WriteLine($"Você optou por Ônibus, isso dá exatamente: {tempo} minutos.");

                            break;
                        default:
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Opção inválida!");
                }
            }

        }
    }
}
