using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beepfuck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                Console.WriteLine("Too args!");
            } else if(args.Length == 0)
            {
                Console.WriteLine("You need 1 arg!");
            }
            else
            {
                try
                {
                    int number = int.Parse(args[0]);
                    for (int i = 0; i < number; i++)
                    {
                        Console.Beep();
                    }
                }
                catch
                {
                    Console.WriteLine("Not a integer!");
                }
            }
        }
    }
}
