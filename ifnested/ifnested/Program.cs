using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifnested
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Digite algo: ");
                string nome = Console.ReadLine().Trim();
                if(nome.StartsWith("L"))
                {
                    Console.WriteLine("Começa com L!");
                    if(nome.EndsWith("s"))
                    {
                        Console.WriteLine("Termina com s!");
                        if(nome.Length == 5)
                        {
                            Console.WriteLine("Possui 5 letras.");
                        }
                    }
                } else if(nome.StartsWith("R"))
                {
                    Console.WriteLine("Começa com R!");
                    if(nome.EndsWith("o"))
                    {
                        Console.WriteLine("Termina com o!");
                        if(nome.Length == 7)
                        {
                            Console.WriteLine("Possui 7 letras!");
                        }
                    }
                }
            }
        }
    }
}
