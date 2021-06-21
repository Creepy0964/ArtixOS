using LyandOS.Utils;
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
            Console.WriteLine("Admin pass:");
            var adminPassCheck = Convert.ToInt32(Console.ReadLine());

            if (adminNickCheck == "root")
            {
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
            Console.WriteLine("Version: 0.1");
            Console.WriteLine("Programming language: C# with using Cosmos Kernel");
            Console.WriteLine("Developer: LyandCorp");
            string fs_type = Sys.FileSystem.VFS.VFSManager.GetFileSystemType("0:/");
            Console.WriteLine("File System Type: " + fs_type);
            Console.WriteLine("");
        }

        public static void Bsod()
        {
            SystemFailtureManager.CallKernelPanic("Intentional BSOD test", "No tracelog required", "0");
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
    }
}
