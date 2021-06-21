using Cosmos.HAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace LyandOS.Utils
{
    class ConsoleGraphics
    {
        public static void BootArt()
        {
            Console.WriteLine(@" _                           _ _____ _____ ");
            Global.PIT.Wait(500);
            Console.WriteLine(@"| |                         | |  _  /  ___|");
            Global.PIT.Wait(500);
            Console.WriteLine(@"| |    _   _  __ _ _ __   __| | | | \ `--. ");
            Global.PIT.Wait(500);
            Console.WriteLine(@"| |   | | | |/ _` | '_ \ / _` | | | |`--. \");
            Global.PIT.Wait(500);
            Console.WriteLine(@"| |___| |_| | (_| | | | | (_| \ \_/ /\__/ /");
            Global.PIT.Wait(500);
            Console.WriteLine(@"\_____/\__, |\__,_|_| |_|\__,_|\___/\____/ ");
            Global.PIT.Wait(500);
            Console.WriteLine(@"        __/ |                              ");
            Global.PIT.Wait(500);
            Console.WriteLine(@"       |___/                               ");
            Global.PIT.Wait(500);
        }

        public static void Help()
        {
            OutputFormatter.WriteLine("&9Commands:");
            OutputFormatter.WriteLine(" &7shutdown               &8- &9shuts your computer down");
            OutputFormatter.WriteLine(" &7help                   - &9shows all commands");
            OutputFormatter.WriteLine(" &7reboot                 - &9reboots your computer");
            OutputFormatter.WriteLine(" &7calc                   - &9runs the calculator");
            OutputFormatter.WriteLine(" &7time                   - &9shows time in UTC");
            OutputFormatter.WriteLine(" &7store                  - &9available programs");
            OutputFormatter.WriteLine(" &7dir                    - &9shows all directories on the disk");
            OutputFormatter.WriteLine(" &7install &6[program name] - &9installs the selected program");
            OutputFormatter.WriteLine(" &7delete &6[program name]  - &9deletes the selected program");
            OutputFormatter.WriteLine(" &7info                   - &9shows info about the computer");
            OutputFormatter.WriteLine(" &7color &6[text, bg]       - &9runs the program to change text/bg color");
            OutputFormatter.WriteLine(" &7cls                    - &9clears the terminal");
            OutputFormatter.WriteLine(" &7let_me_guess           - &9a game where you need to guess computer's number");
            OutputFormatter.WriteLine(" &7bsod                   - &9causes a bsod for tests");
            OutputFormatter.WriteLine(" &7error                  - &9error list");
            OutputFormatter.WriteLine(" &7proglist               - &9analog of taskmgr");
            OutputFormatter.WriteLine(" &7wait                   - &9computer will wait 10 minutes");
            OutputFormatter.WriteLine(" &7social                 - &9shows you social networks");
            Console.WriteLine("");
        }
    }
}
