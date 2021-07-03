using Cosmos.HAL;
using LyandOS.Addons;
using System;
using System.Collections.Generic;
using System.Text;

using Sys = Cosmos.System;

namespace LyandOS.Plugins.Default
{
    class Reboot : LyandPlugin
    {
        public override string Name => "reboot";

        public override string Description => "Restart the system";

        public override void Load() { }

        public override void Run(string[] argv)
        {
            Console.WriteLine("Rebooting in 3 seconds.");
            Global.PIT.TimespanBasedWait(5000);
            Sys.Power.Reboot();
        }
    }
}
