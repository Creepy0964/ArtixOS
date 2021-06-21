using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using LyandOS.Commands;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;
using LyandOS.Utils;

namespace LyandOS
{
    public class Kernel : Sys.Kernel
    {
        public string AdminLogin = "root";
        public int AdminPass = 1678;
        public Random rnd = new Random();
        private readonly CosmosVFS fs = new Sys.FileSystem.CosmosVFS(); // покдлючаем фат32
        protected override void BeforeRun()
        {
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs); // регистрируем фат32
            ConsoleGraphics.BootArt();
            Console.WriteLine("Press any key to boot...");
            Console.ReadKey();

            Console.WriteLine("LyandOS booted successfully!");
            Cosmos.HAL.Global.PIT.Wait(2000);
            Console.WriteLine("");
            Console.Clear();
        }

        protected override void Run()
        {            
            Console.Write(@"0:\> ");
            var input = Console.ReadLine();
            switch(input)
            {
                case "shutdown":
                    Console.WriteLine("Shutdowning in 5 seconds. We hope you are glad to use LyandOS! Goodbye!");
                    Cosmos.HAL.Global.PIT.Wait(5000);
                    Sys.Power.Shutdown();
                    break;
                case "cls":
                    Console.Clear();
                    break;
                case "bsod":
                    Other.Bsod();
                    break;
                case "help":
                    ConsoleGraphics.Help();
                    break;
                case "social":
                    Other.Social();
                    break;
                case "reboot":
                    Console.WriteLine("Rebooting in 5 seconds.");
                    Cosmos.HAL.Global.PIT.Wait(5000);
                    Sys.Power.Reboot();
                    break;
                case "wait":
                    Console.WriteLine("OK. Now, waiting 10 minutes.");
                    Cosmos.HAL.Global.PIT.Wait(600000);
                    break;
                case "let_me_guess":
                    Games.LetMeGuess();
                    break;
                case "adminFAT":
                    Other.AdminFAT();
                    break;
                case "info":
                    Other.Info();
                    break;
                case "calc":
                    Programs.Calc();
                    break;
                case "store":
                    Other.Store();
                    Console.WriteLine("");
                    break;
                case "time":
                    Console.WriteLine(DateTime.UtcNow);
                    Console.WriteLine("");
                    break;
                case "dir":
                    Console.WriteLine(@"Dirs in partition 0: are:");
                    Console.WriteLine(@"0:\Calc");
                    Console.WriteLine(@"0:\Time");
                    Console.WriteLine(@"0:\System");
                    Console.WriteLine("");
                    break;
                case "color text":
                    Colors.TextColorSet();
                    break;
                case "themes":
                    Colors.Themes();
                    break;
                case "color bg":
                    Colors.BGColorSet();
                    break;
                case "dir calc":
                    Console.WriteLine(@"Files in 0:\Calc are:");
                    Console.WriteLine("calc.lnd");
                    Console.WriteLine("math.lbr");
                    Console.WriteLine("");
                    break;
                case "dir time":
                    Console.WriteLine(@"Files in 0:\Time are:");
                    Console.WriteLine("time.lnd");
                    Console.WriteLine("UTC.lbr");
                    Console.WriteLine("");
                    break;
                case "dir system":
                    Console.WriteLine("This folder is protected! You can't enter.");
                    Console.WriteLine("");
                    break;
                case @"dir system\drivers":
                    Console.WriteLine("This folder is protected! You can't enter.");
                    Console.WriteLine("");
                    break;
                case "error":
                    Console.WriteLine("Error list:");
                    Console.WriteLine("Fatal error with code -1.");
                    Console.WriteLine("DivideByZeroException with code -1073741510.");
                    Console.WriteLine("");
                    break;
                case "proglist":
                    Console.WriteLine("Running programs:");
                    Console.WriteLine(@"System.lnd.prt [0:\System]");
                    Console.WriteLine(@"Display.drv [0:\System\Drivers]");
                    Console.WriteLine(@"Peripherals.drv [0:\System\Drivers]");
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Unknown input. Type 'help' for commands.");
                    Console.WriteLine("");
                    break;
            }            
        }
    }
}