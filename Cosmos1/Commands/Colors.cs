using System;
using System.Collections.Generic;
using System.Text;

namespace LyandOS.Commands
{
    class Colors
    {        
        public static void TextColorSet()
        {
            string DarkColorInput;
            Console.WriteLine("Select the color you want to set with the number.");
            Console.WriteLine("1 - Red, 2 - Blue, 3 - Green, 4 - Yellow, 5 - Magenta, 6 - Black, 7 - Cyan, 8 - Gray, 0 - reset.");
            var colorInput = Convert.ToInt32(Console.ReadLine());
            switch(colorInput)
            {
                case 1:
                    Console.WriteLine("Which type of color do you want to use? [default, dark]");
                    DarkColorInput = Console.ReadLine();
                    if(DarkColorInput == "default")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("");
                    }
                    else if(DarkColorInput == "dark")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Unknown input.");
                        Console.WriteLine("");
                    }
                    break;
                case 2:
                    Console.WriteLine("Which type of color do you want to use? [default, dark]");
                    DarkColorInput = Console.ReadLine();
                    if (DarkColorInput == "default")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("");
                    }
                    else if (DarkColorInput == "dark")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Unknown input.");
                        Console.WriteLine("");
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.WriteLine("Which type of color do you want to use? [default, dark]");
                    DarkColorInput = Console.ReadLine();
                    if (DarkColorInput == "default")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("");
                    }
                    else if (DarkColorInput == "dark")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Unknown input.");
                        Console.WriteLine("");
                    }
                    break;
                case 4:
                    Console.WriteLine("Which type of color do you want to use? [default, dark]");
                    DarkColorInput = Console.ReadLine();
                    if (DarkColorInput == "default")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("");
                    }
                    else if (DarkColorInput == "dark")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Unknown input.");
                        Console.WriteLine("");
                    }
                    break;
                case 5:
                    Console.WriteLine("Which type of color do you want to use? [default, dark]");
                    DarkColorInput = Console.ReadLine();
                    if (DarkColorInput == "default")
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("");
                    }
                    else if (DarkColorInput == "dark")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Unknown input.");
                        Console.WriteLine("");
                    }
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("");
                    break;
                case 7:
                    Console.WriteLine("Which type of color do you want to use? [default, dark]");
                    DarkColorInput = Console.ReadLine();
                    if (DarkColorInput == "default")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("");
                    }
                    else if (DarkColorInput == "dark")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Unknown input.");
                        Console.WriteLine("");
                    }
                    break;
                case 8:
                    Console.WriteLine("Which type of color do you want to use? [default, dark]");
                    DarkColorInput = Console.ReadLine();
                    if (DarkColorInput == "default")
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("");
                    }
                    else if (DarkColorInput == "dark")
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Unknown input.");
                        Console.WriteLine("");
                    }
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
            string DarkColorInput;
            Console.WriteLine("Select the color you want to set with the number.");
            Console.WriteLine("1 - Red, 2 - Blue, 3 - Green, 4 - Yellow, 5 - Magenta, 6 - White, 0 - reset.");
            var colorInput = Convert.ToInt32(Console.ReadLine());
            switch (colorInput)
            {
                case 1:
                    Console.WriteLine("Which type of color do you want to use? [default, dark]");
                    DarkColorInput = Console.ReadLine();
                    if (DarkColorInput == "default")
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Clear();
                    }
                    else if (DarkColorInput == "dark")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Unknown input.");
                        Console.Clear();
                    }
                    break;
                case 2:
                    Console.WriteLine("Which type of color do you want to use? [default, dark]");
                    DarkColorInput = Console.ReadLine();
                    if (DarkColorInput == "default")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Clear();
                    }
                    else if (DarkColorInput == "dark")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Unknown input.");
                        Console.Clear();
                    }
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("Which type of color do you want to use? [default, dark]");
                    DarkColorInput = Console.ReadLine();
                    if (DarkColorInput == "default")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Clear();
                    }
                    else if (DarkColorInput == "dark")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Unknown input.");
                        Console.Clear();
                    }
                    break;
                case 4:
                    Console.WriteLine("Which type of color do you want to use? [default, dark]");
                    DarkColorInput = Console.ReadLine();
                    if (DarkColorInput == "default")
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                    }
                    else if (DarkColorInput == "dark")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Unknown input.");
                        Console.Clear();
                    }
                    break;
                case 5:
                    Console.WriteLine("Which type of color do you want to use? [default, dark]");
                    DarkColorInput = Console.ReadLine();
                    if (DarkColorInput == "default")
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.Clear();
                    }
                    else if (DarkColorInput == "dark")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Unknown input.");
                        Console.Clear();
                    }
                    break;
                case 6:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    break;
                case 7:
                    Console.WriteLine("Which type of color do you want to use? [default, dark]");
                    DarkColorInput = Console.ReadLine();
                    if (DarkColorInput == "default")
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                    }
                    else if (DarkColorInput == "dark")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Unknown input.");
                        Console.Clear();
                    }
                    break;
                case 8:
                    Console.WriteLine("Which type of color do you want to use? [default, dark]");
                    DarkColorInput = Console.ReadLine();
                    if (DarkColorInput == "default")
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Clear();
                    }
                    else if (DarkColorInput == "dark")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Unknown input.");
                        Console.Clear();
                    }
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
