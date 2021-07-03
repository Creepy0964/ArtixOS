using Cosmos.HAL;
using LyandOS.Addons;
using System;
using System.Collections.Generic;
using System.Text;

using Sys = Cosmos.System;

namespace LyandOS.Plugins.Default
{
    class Bsod : LyandPlugin
    {
        public override string Name => "bsod";

        public override string Description => "Throws PC into an \"kernel panic\" state";

        public override void Load() { }

        public override void Run(string[] argv) => SystemFailtureManager.CallKernelPanic("Custom BSOD call", "uhh...", "-1337");
    }
}
