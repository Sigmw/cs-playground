using System;

namespace operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res = 10 + 5 * 2;
            bool varmenorque5 = res < 5;
            int num = 1;
            num++;//num += 1; num = num + 1;
            num *= 2;
            bool op = (5 > 3) && (1 > 3);
            Console.WriteLine(num);
            Console.WriteLine(res);
            Console.WriteLine(varmenorque5);
            Console.WriteLine(op);
            Console.ReadKey();

        }
    }
}
