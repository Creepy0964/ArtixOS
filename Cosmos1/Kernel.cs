using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using LyandOS.Commands;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;
using System.ComponentModel;
using System.Runtime.Serialization;
using LyandOS.Utils;
using LyandOS.Addons;

namespace LyandOS
{
    public class Kernel : Sys.Kernel
    {
        public string WD = @"0:\";
        public string AdminLogin = "root";
        public int AdminPass = 1678;
        public Random rnd = new Random();
        private readonly CosmosVFS fs = new Sys.FileSystem.CosmosVFS(); // покдлючаем фат32
        protected override void BeforeRun()
        {
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs); // регистрируем фат32
            Utilities.BootArt();
            Console.WriteLine("Press any key to boot...");
            Console.ReadKey();

            Console.WriteLine("LyandOS booted successfully!");
            Cosmos.HAL.Global.PIT.Wait(2000);
            Console.WriteLine("");
            Console.Clear();
        }

        protected override void Run()
        {            
            Console.Write(WD + "> ");
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
                    SystemFailtureManager.CallKernelPanic("Custom BSOD call", "uhh...", "-1337");
                    break;
                case "help":
                    Utilities.Help();
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
                    switch(WD)
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
                        default:
                            Console.WriteLine("This folder is protected! You can't enter.");
                            Console.WriteLine("");
                            break;
                    }                    
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
                case "cd ..":
                    WD = @"0:\";
                    Console.WriteLine("");
                    break;
                case "cd calc":
                    WD = @"0:\Calc";
                    Console.WriteLine("");
                    break;
                case "cd time":
                    WD = @"0:\Time";
                    Console.WriteLine("");
                    break;
                case "cd guess":
                    WD = @"0:\Guess";
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