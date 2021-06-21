using System;
using System.Collections.Generic;
using System.Text;

namespace LyandOS.Commands
{
    class Utilities
    {
        public static void Help()
        {
            Console.WriteLine("Commands:");
            Console.WriteLine("shutdown - shuts your computer down");
            Console.WriteLine("help - shows all commands");
            Console.WriteLine("reboot - reboots your computer");
            Console.WriteLine("calc - runs the calculator");
            Console.WriteLine("time - shows time in UTC");
            Console.WriteLine("store - available programs");
            Console.WriteLine("dir - shows all directories on the disk");
            Console.WriteLine("install [program name] - installs the selected program");
            Console.WriteLine("delete [program name] - deletes the selected program");
            Console.WriteLine("info - shows info about the computer");
            Console.WriteLine("color [text, bg] - runs the program to change text/bg color");
            Console.WriteLine("cls - clears the terminal");
            Console.WriteLine("let_me_guess - a game where you need to guess computer's number");
            Console.WriteLine("bsod - causes a bsod for tests");
            Console.WriteLine("error - error list");
            Console.WriteLine("proglist - analog of taskmgr");
            Console.WriteLine("wait - computer will wait 10 minutes");
            Console.WriteLine("social - shows you social networks");
            Console.WriteLine("");
        }
    }
}
