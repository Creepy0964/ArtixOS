using System;
using Sys = Cosmos.System;

namespace LyandOS.Commands
{
    class Other
    {
        public static void AdminFAT()
        {
            Console.WriteLine("Admin login:");
            var adminNickCheck = Console.ReadLine();
            if (adminNickCheck == "root")
            {
                Console.WriteLine("Admin pass:");
                var adminPassCheck = Convert.ToInt32(Console.ReadLine());
                if (adminPassCheck == 1678)
                {
                    long available_space = Sys.FileSystem.VFS.VFSManager.GetAvailableFreeSpace("0:/");
                    Console.WriteLine("Available Free Space: " + available_space);

                    string fs_type = Sys.FileSystem.VFS.VFSManager.GetFileSystemType("0:/");
                    Console.WriteLine("File System Type: " + fs_type);
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Incorrect password!");
                }
            }
            else
            {
                Console.WriteLine("Incorrect login!");
            }
        }

        public static void Info()
        {
            Console.WriteLine("Computer: LyandComp Rev. 1");
            Console.WriteLine("OS: LyandOS");
            Console.WriteLine("Version: 0.4");
            Console.WriteLine("Programming language: C# with using Cosmos Kernel");
            Console.WriteLine("Developer: LyandCorp, EGA Team");
            string fs_type = Sys.FileSystem.VFS.VFSManager.GetFileSystemType(@"0:\");
            Console.WriteLine("File System Type: " + fs_type);
            Console.WriteLine("");            
        }

        public static void Bsod()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Oops! We caught an exception, and your computer needs to reboot. Press any key to continue...");
            Console.ReadKey();
            Sys.Power.Reboot();
        }

        public static void Store()
        {
            Console.WriteLine("Name       |   Info");
            Console.WriteLine("");
            Console.WriteLine("Calc       |   Helps you to calculate something.");
            Console.WriteLine("Time       |   Shows you the time.");
            Console.WriteLine("Proglist   |   Shows you all running processes.");
            Console.WriteLine("Error      |   Shows you all available errors.");
            Console.WriteLine("");
        }

        public static void Social()
        {
            Console.WriteLine("Discord: https://discord.gg/BdHymp8ZZ9");
            Console.WriteLine("");
        }
        
        public static void PlaySound()
        {
            Sys.PCSpeaker.Beep();
        }

        public static void Test()
        {
            
        }
    }
}
