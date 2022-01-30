using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scopes
{
    internal class Program
    {
        static int num = 10;
        static void Main(string[] args)
        {
            Console.WriteLine("Função main.");
            teste();
            Console.ReadLine();
        }
        static void teste()
        {
            Console.WriteLine(num);
        }
    }
}
