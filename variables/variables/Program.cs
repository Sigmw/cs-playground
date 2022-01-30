using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 10; // entre 0 e 255
            int num = 10;
            char letra = 'a';
            float valor = 5.3f;
            string nome = "Lucas";
            int n2 = num + n1;
            var aux = valor;
            Console.WriteLine(aux);
            Console.WriteLine(aux.GetType());
            Console.WriteLine(n2);
            Console.ReadKey();
        }
    }
}
