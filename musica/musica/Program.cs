using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace musica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = Environment.CurrentDirectory + "\\africa-toto.wav";
            Console.Title = "Curta as melhores!";
            Console.WriteLine("          ____                                                             ");
            Console.WriteLine("        ,'  , `.                                                           ");
            Console.WriteLine("     , -+-,.' _ |                            ,--,                           ");
            Console.WriteLine("  ,-+-. ;   , ||         ,--,             ,--.'|                           ");
            Console.WriteLine(" ,--.'|'   |  ;|       ,'_ /|   .--.--.   |  |,                            ");
            Console.WriteLine("|   |  ,', |  ':  .--. |  | :  /  /    '  `--'_       ,---.     ,--.--.    ");
            Console.WriteLine("|   | /  | |  ||,'_ /| :  . | |  :  /`./  ,' ,'|     /     \\   /       \\   ");
            Console.WriteLine("'   | :  | :  |,|  ' | |  . . |  :  ;_    '  | |    /    / '  .--.  .-. |  ");
            Console.WriteLine(";   . |  ; |--' |  | ' |  | |  \\  \\    `. |  | :   .    ' /    \\__\\/: . .  ");
            Console.WriteLine("|   : |  | ,    :  | : ;  ; |   `----.   \'  : |__ '   ; :__   ,.--.; |");
            Console.WriteLine("|   : '  |/     '  :  `--'   \\ /  /`--'  /|  | '.'|'   | '.'| /  /  ,.  |  ");
            Console.WriteLine(";   | |`-'      :  ,      .-./'--'.     / ;  :    ;|   :    :;  :   .'   \\ ");
            Console.WriteLine("|   ;/           `--`----'      `--'---'  |  ,   /  \\   \\  / |  ,     .-./ ");
            Console.WriteLine("'---'                                      ---`-'    `----'   `--`---'     ");
            try
            {
                player.Play();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
