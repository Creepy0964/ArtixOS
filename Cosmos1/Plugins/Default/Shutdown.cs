using Cosmos.HAL;
using LyandOS.Addons;
using System;
using System.Collections.Generic;
using System.Text;

using Sys = Cosmos.System;

namespace LyandOS.Plugins.Default
{
    class Shutdown : LyandPlugin
    {
        public override string Name => "shutdown";

        public override string Description => "Shuts the computer down";

        public override void Load() { }

        public override void Run(string[] argv)
        {
            Console.WriteLine("Shutting down in 5 seconds.");
            Global.PIT.TimespanBasedWait(5000);
            Sys.Power.Shutdown();
        }
    }
}
