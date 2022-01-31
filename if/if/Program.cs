using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Verdadeiro ou falso (false-true): ");
                try {
                    bool condicao = Convert.ToBoolean(Console.ReadLine());
                    if (condicao)
                    {
                        Console.WriteLine("Então é verdadeiro.");
                    }
                    else
                    {
                        Console.WriteLine("Então é falso");
                    }
                } catch
                {
                    Console.WriteLine($"not a boolean! (true-false)");
                }
            }

        }
    }
}
