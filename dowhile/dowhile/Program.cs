using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            do
            {
                Console.WriteLine(num);
                num++;
            } while (num <= 10);
            Console.ReadLine();
        }
        
    }
}
