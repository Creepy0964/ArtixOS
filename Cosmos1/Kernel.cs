using System;
using Sys = Cosmos.System;
using Cosmos.System.FileSystem;
using LyandOS.Addons;

namespace LyandOS
{
    public class Kernel : Sys.Kernel
    {
        public static string input;
        public static string WD = @"0:\";
        public static string WDSymb = ">";
        public string AdminLogin = "root";
        public int AdminPass = 1678;
        public Random rnd = new Random();
        public static CosmosVFS fs = new Sys.FileSystem.CosmosVFS(); // покдлючаем фат32
        protected override void BeforeRun()
        {
            KernelEngine.BeforeRunEngine();
        }

        protected override void Run()
        {            
            Console.Write(WD + WDSymb + " ");
            input = Console.ReadLine();
            switch (WD)
            {
                default:
                    KernelEngine.RunEngine();
                    break;
            }            
        }
    }
}