using System;

namespace enums
{
    internal class Program
    {
        enum Dias
        {
            Domingo,
            Segunda,
            Terca,
            Quarta,
            Quinta,
            Sexta,
            Sabado
        }
        static void Main(string[] args)
        {
            Dias sexta = Dias.Sexta;
            Dias dias = (Dias)3;
            Console.WriteLine($"sexta = {sexta}, dia 3 = {dias}");
            Console.WriteLine($"Número do dia terça: {(int)Dias.Terca}");
            while (true)
            {
                int dia;
                Console.Write("\nQual o dia da semana você quer? (1-6): ");
                try
                {
                    dia = Convert.ToUInt16(Console.ReadLine());
                    Console.WriteLine((Dias)dia);
                } catch
                {
                   Console.WriteLine("Ou tá vazio, ou você não colocou um inteiro.");
                }
            }
        }
    }
}
