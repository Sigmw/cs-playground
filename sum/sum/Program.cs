using System;

namespace CLI_Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            switch (args.Length)
            {
                case 0:
                    Console.WriteLine("You dont have args. (Usage: sum n1 n2)");
                    return;
                case 1:
                    Console.WriteLine("You have a single args. (Usage: sum n1 n2)");
                    return;
                case 2:
                    break;
                default:
                    Console.WriteLine("Too args! (Usage: sum n1 n2");
                    return;
            }
            try
            {
                int n1 = Convert.ToInt32(args[0]);
                int n2 = Convert.ToInt32(args[1]);
                Console.WriteLine(n1 + n2);
            }
            catch (Exception)
            {
                Console.WriteLine("We need to sum just numbers!");
            }
        }
    }
}
