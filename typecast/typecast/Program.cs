using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1 = 1.221f;
            int n2 = (int)n1;
            Console.Write(n1 + " " + n2);
            float numero = 1.121f;
            int numerotyped = (int)numero;
            Console.ReadKey();
        }
    }
}
