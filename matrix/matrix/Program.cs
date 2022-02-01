using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 2];
            /*
             Matriz de 5 linhas, e 2 colunas.
            1 2
            1 2
            1 2
            1 2
            1 2
             */
            int[,] num = new int[2, 2] { {10, 15}, {20, 40} };
            matrix[0, 0] = 1;
            matrix[1, 0] = 2;
            matrix[2, 0] = 3;
            matrix[3, 0] = 4;
        }
    }
}
