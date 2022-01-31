using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitwise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // >> deslocamento de bits para a direita (dobra)
            // << deslocamento de bits para a esquerda (diminui pela metade)
            int num = 10;
            num <<= 4; // 20 40 80 160
            Console.WriteLine(num);
            num = 20;
            num >>= 2; // 10 5
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
