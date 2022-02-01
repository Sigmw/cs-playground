using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 111;
            arr[1] = 222;
            arr[2] = 333;
            arr[3] = 444;
            arr[4] = 555;
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            int[] arr2 = { 1, 2, 3, 4, 5};
            string[] veiculo = new string[3];
            veiculo[0] = "carro";
            veiculo[1] = "avião";
            veiculo[2] = "onibus";
            for(int i = 0; i < veiculo.Length; i++)
            {
                Console.WriteLine(veiculo[i]);
            }
            Console.Write(arr2[0]);
            Console.ReadLine();
        }
    }
}
