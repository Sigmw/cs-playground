using System;
namespace @const
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = Math.PI;
            Console.WriteLine("{0}", pi.ToString("N4"));
            Console.ReadKey();
        }
    }
}
