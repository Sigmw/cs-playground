using System;

namespace consolefmt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            n1 = 10; n2 = 20; n3 = 30;
            Console.Write("n1 = {0}\nn2 = {1}\nn3 = {2}\n4 = {3}\n", n1, n2, n3, 4);
            double fmt = 5.50;
            Console.WriteLine("{0,800}", fmt); // "800" indica o tamanho do espaçamento
            Console.WriteLine("{0,15:c}", fmt); // :c coloca o R$
            Console.WriteLine("{0,15:p}", fmt); // porcentagem
            Console.ReadKey();
        }
    }
}
