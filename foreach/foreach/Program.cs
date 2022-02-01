using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3]{11, 12, 13};
            foreach(int numero in num)
            {
                Console.WriteLine(numero);
            }
            Console.ReadLine();
        }
    }
}
