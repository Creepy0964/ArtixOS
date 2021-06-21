using System;
using System.Collections.Generic;
using System.Text;

namespace LyandOS.Commands
{
    class Install_Delete
    {
        public static int installCalc = 0; // переменная установки калькулятора
        public static int installTime = 0; // переменная установки часов
        public static void InstallCalculator()
        {
            Console.WriteLine("Installing...");
            installCalc = 1;
            Console.WriteLine("Installed!");
            Console.WriteLine("");
        }

        public static void InstallClock()
        {
            Console.WriteLine("Installing...");
            installTime = 1;
            Console.WriteLine("Installed!");
            Console.WriteLine("");
        }

        public static void DeleteCalculator()
        {
            Console.WriteLine("Deleting...");
            installCalc = 0;
            Console.WriteLine("Deleted!");
            Console.WriteLine("");
        }

        public static void DeleteClock()
        {
            Console.WriteLine("Deleting...");
            installTime = 0;
            Console.WriteLine("Deleted!");
            Console.WriteLine("");
        }
    }
}
