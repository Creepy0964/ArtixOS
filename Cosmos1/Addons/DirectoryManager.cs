using System;
using System.Collections.Generic;
using System.Text;

namespace LyandOS.Addons
{
    class DirectoryManager
    {
        public static void Dir() // корневая папка
        {
            Console.WriteLine(@"Dirs in partition 0: are:");
            Console.WriteLine(@"0:\Calc");
            Console.WriteLine(@"0:\Time");
            Console.WriteLine(@"0:\System");
            Console.WriteLine("");
        }

        public static void DirCalc() // калькулятор
        {
            Console.WriteLine(@"Files in 0:\Calc are:");
            Console.WriteLine("calc.lnd");
            Console.WriteLine("math.lbr");
            Console.WriteLine("");
        }

        public static void DirTime() // время
        {
            Console.WriteLine(@"Files in 0:\Time are:");
            Console.WriteLine("time.lnd");
            Console.WriteLine("UTC.lbr");
            Console.WriteLine("");
        }

        public static void DirGuess() // угадайка
        {
            Console.WriteLine(@"Files in 0:\LetMeGuess are:");
            Console.WriteLine("main.lnd");
            Console.WriteLine("Random.lbr");
            Console.WriteLine("");
        }

        public static void DirMgr() // обработчик
        {
            switch (Kernel.WD)
            {
                case @"0:\":
                    DirectoryManager.Dir();
                    break;
                case @"0:\Time":
                    DirectoryManager.DirTime();
                    break;
                case @"0:\Calc":
                    DirectoryManager.DirCalc();
                    break;
                case @"0:\Guess":
                    DirectoryManager.DirGuess();
                    break;
                case @"0:\System":
                    Console.WriteLine("This folder is protected! You can't enter.");
                    Console.WriteLine("");
                    break;
            }
        }
    }
}
