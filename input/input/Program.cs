using System;

namespace input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, soma;
            string nome;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Digite seu nome: ");
            Console.Title = "Input";
            nome = Console.ReadLine().Trim();

            Console.Write("Beleza {0}, me indica o primeiro valor que você deseja somar: ", nome);
            v1 = int.Parse(Console.ReadLine().Trim());
            Console.Write("Ok... {0}, o segundo número agora: ", v1);
            v2 = int.Parse(Console.ReadLine().Trim());
            soma = v1 + v2;
            Console.WriteLine("{0} + {1}... Isso dá {2}.", v1, v2, soma);
            Console.ReadLine();
        }
    }
}
