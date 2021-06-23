using System;
using System.Collections.Generic;
using System.Text;

namespace LyandOS.Addons
{
    class DirectoryManager
    {
        public static void Dir()
        {
            Console.WriteLine(@"Dirs in partition 0: are:");
            Console.WriteLine(@"0:\Calc");
            Console.WriteLine(@"0:\Time");
            Console.WriteLine(@"0:\System");
            Console.WriteLine("");
        }

        public static void DirCalc()
        {
            Console.WriteLine(@"Files in 0:\Calc are:");
            Console.WriteLine("calc.lnd");
            Console.WriteLine("math.lbr");
            Console.WriteLine("");
        }

        public static void DirTime()
        {
            Console.WriteLine(@"Files in 0:\Time are:");
            Console.WriteLine("time.lnd");
            Console.WriteLine("UTC.lbr");
            Console.WriteLine("");
        }

        public static void DirGuess()
        {
            Console.WriteLine(@"Files in 0:\LetMeGuess are:");
            Console.WriteLine("main.lnd");
            Console.WriteLine("Random.lbr");
            Console.WriteLine("");
        }
    }
}
