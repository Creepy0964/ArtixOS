using System;
using System.Collections.Generic;
using System.Text;
using Cosmos.HAL;

namespace LyandOS.Addons
{
    static class Utilities
    {
        public static string NotepadInput;
        public static void Help()
        {
            Console.WriteLine("Name         |        About");
            Console.WriteLine("shutdown     |        shuts your computer down");
            Console.WriteLine("help         |        shows all commands");
            Console.WriteLine("reboot       |        reboots your computer");
            Console.WriteLine("calc         |        runs the calculator");
            Console.WriteLine("time         |        shows time in UTC");
            Console.WriteLine("store        |        available programs");
            Console.WriteLine("dir          |        shows all directories and files on the disk/in folder");
            Console.WriteLine("info - shows info about the computer");
            Console.WriteLine("color [text, bg] - runs the program to change text/bg color");
            Console.WriteLine("cls - clears the terminal");
            Console.WriteLine("let_me_guess - a game where you need to guess computer's number");
            Console.WriteLine("bsod - causes a bsod for tests");
            Console.WriteLine("error - error list");
            Console.WriteLine("proglist - analog of taskmgr");
            Console.WriteLine("social - shows you social networks");
            Console.WriteLine("user - shows you user info");
            Console.WriteLine("theme       |         shows allowed themes to apply");
            Console.WriteLine("notepad     |         runs notepad");
            Console.WriteLine("");
        }
        public static void BootArt()
        {
            Console.WriteLine(@" _                           _ _____ _____ "); Global.PIT.Wait(500);
            Console.WriteLine(@"| |                         | |  _  /  ___|"); Global.PIT.Wait(500);
            Console.WriteLine(@"| |    _   _  __ _ _ __   __| | | | \ `--. "); Global.PIT.Wait(500);
            Console.WriteLine(@"| |   | | | |/ _` | '_ \ / _` | | | |`--. \"); Global.PIT.Wait(500);
            Console.WriteLine(@"| |___| |_| | (_| | | | | (_| \ \_/ /\__/ /"); Global.PIT.Wait(500);
            Console.WriteLine(@"\_____/\__, |\__,_|_| |_|\__,_|\___/\____/ "); Global.PIT.Wait(500);
            Console.WriteLine(@"        __/ |                              "); Global.PIT.Wait(500);
            Console.WriteLine(@"       |___/      Wowie! Notepad!          "); Global.PIT.Wait(500);
        }

        public static void User()
        {
            Console.WriteLine("User info: ");
            Console.WriteLine("User: Default");
            Console.WriteLine("Password: -");
            Console.WriteLine("");
        }
        public static void TimespanBasedWait(this PIT pit, int ms)
        {
            DateTime timeStart = DateTime.Now;
            while (DateTime.Now - timeStart < TimeSpan.FromMilliseconds(ms)) pit.Wait(1);
        }

        public static void NotepadWrite()
        {
            Console.WriteLine("Write your text below! Remember: maximum value of symbols is 2147483647");
            NotepadInput = Console.ReadLine();
            Console.WriteLine("Excellent! To read your new record, type 'notepad -read'.");
            Global.PIT.TimespanBasedWait(1000);
            Console.WriteLine("");
        }
        
        public static void NotepadRead()
        {
            Console.WriteLine("Here is your record.");
            Console.WriteLine(NotepadInput);
            Console.WriteLine("");
        }
        
        public static void Notepad()
        {
            Console.WriteLine("Notepad arguments:");
            Console.WriteLine("-write: creates new record to write");
            Console.WriteLine("-read: reads your record");
        }
    }
}
