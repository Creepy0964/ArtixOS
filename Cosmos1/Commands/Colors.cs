using System;
using System.Collections.Generic;
using System.Text;

namespace LyandOS.Commands
{
    class Colors
    {
        public static void TextColorSet()
        {
            Console.WriteLine("Select the color you want to set with the number.");
            Console.WriteLine("1 - Red, 2 - Blue, 3 - Green, 4 - Yellow, 5 - Magenta, 6 - Black, 0 - reset.");
            var colorInput = Convert.ToInt32(Console.ReadLine());
            switch(colorInput)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("");
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    break;
                case 0:
                    Console.ResetColor();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Incorrect input!");
                    Console.WriteLine("");
                    break;
            }
        }
        public static void BGColorSet()
        {
            Console.WriteLine("Select the color you want to set with the number.");
            Console.WriteLine("1 - Red, 2 - Blue, 3 - Green, 4 - Yellow, 5 - Magenta, 6 - White, 0 - reset.");
            var colorInput = Convert.ToInt32(Console.ReadLine());
            switch (colorInput)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    break;
                case 4:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    break;
                case 5:
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Clear();
                    break;
                case 6:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    break;
                case 0:
                    Console.ResetColor();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Incorrect input!");
                    Console.WriteLine("");
                    break;
            }
        }

        public static void Themes()
        {
            Console.Write("There is only one available theme, 'Inverse', now. Do you want to apply it?(Type 'y' if yes, else type any letter. If you want to reset, type '0'.)");
            var theme = Console.ReadLine();
            switch(theme)
            {
                case "y":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "0":
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.WriteLine("OK.");
                    Console.WriteLine("");
                    break;
            }
        }
    }
}
