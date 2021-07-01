using System;
using LyandOS.Commands;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem;
using LyandOS.Addons;
using Cosmos.HAL;

namespace LyandOS.Addons
{
    class KernelEngine
    {
        public static void RunEngine()
        {
            switch (Kernel.input)
            {
                case "shutdown":
                    Console.WriteLine("Shutdowning in 5 seconds.");
                    Global.PIT.TimespanBasedWait(5000);
                    Sys.Power.Shutdown();
                    break;
                case "cls":
                    Console.Clear();
                    break;
                case "bsod":
                    SystemFailtureManager.CallKernelPanic("Custom BSOD call", "uhh...", "-1337");
                    break;
                case "play sound":
                    Other.PlaySound();
                    break;
                case "notepad":
                    Utilities.Notepad();
                    break;
                case "notepad -read":
                    Utilities.NotepadRead();
                    break;
                case "notepad -write":
                    Utilities.NotepadWrite();
                    break;
                case "help":
                    Utilities.Help();
                    break;
                case "social":
                    Other.Social();
                    break;
                case "reboot":
                    Console.WriteLine("Rebooting in 3 seconds.");
                    Global.PIT.TimespanBasedWait(5000);
                    Sys.Power.Reboot();
                    break;
                case "let_me_guess":
                    if (Kernel.WD != @"0:\Guess")
                    {
                        Console.WriteLine("Unknown input.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Games.LetMeGuess();
                        Console.WriteLine("");
                    }
                    break;
                case "adminFAT":
                    Other.AdminFAT();
                    break;
                case "info":
                    Other.Info();
                    break;
                case "user":
                    Utilities.User();
                    break;
                case "calc":
                    if (Kernel.WD != @"0:\Calc")
                    {
                        Console.WriteLine("Unknown input.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.Write("Enter the math symbol(*, /, +, -, ^, %) or type 'sqrt': ");
                        string one = Console.ReadLine();
                        Console.Write("Enter the first number: ");
                        int two = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        int three = Convert.ToInt32(Console.ReadLine());
                        Programs.Calc(one, two, three);
                    }
                    break;
                case "store":
                    Other.Store();
                    Console.WriteLine("");
                    break;
                case "time":
                    if (Kernel.WD != @"0:\Time")
                    {
                        Console.WriteLine("Unknown input.");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine(DateTime.UtcNow);
                        Console.WriteLine("");
                    }
                    break;
                case "dir":
                    DirectoryManager.DirMgr();
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
                    Kernel.WD = @"0:\";
                    Console.WriteLine("");
                    break;
                case "cd calc":
                    Kernel.WD = @"0:\Calc";
                    Console.WriteLine("");
                    break;
                case "cd time":
                    Kernel.WD = @"0:\Time";
                    Console.WriteLine("");
                    break;
                case "cd guess":
                    Kernel.WD = @"0:\Guess";
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
                case "taskkill":
                    Console.WriteLine("Enter program's name: ");
                    var taskkillInput = Console.ReadLine();
                    switch (taskkillInput)
                    {
                        case "System.lnd.prt":
                            SystemFailtureManager.CallKernelPanic("System process dead", "No tracelog required", "-1");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Unknown input. Type 'help' for commands.");
                    Console.WriteLine("");
                    break;
            }
        }

        public static void BeforeRunEngine()
        {
            Console.WriteLine("ATTENTION: This system is not designed to run on a real PC! If you are running LyandOS on a real PC, please, test it on a VM. Press any key if you anyway want to run OS.");
            Console.ReadKey();
            Console.Clear();

            Sys.FileSystem.VFS.VFSManager.RegisterVFS(Kernel.fs); // регистрируем фат32
            Global.PIT.TimespanBasedWait(3000);
            Console.Clear();
            Utilities.BootArt();
            Console.WriteLine("Press any key to boot...");
            Console.ReadKey();

            Console.WriteLine("LyandOS booted successfully!");
            Cosmos.HAL.Global.PIT.Wait(2000);
            Console.WriteLine("");
            Console.Clear();
        }
    }
}
