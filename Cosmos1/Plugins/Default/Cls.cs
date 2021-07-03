using Cosmos.HAL;
using LyandOS.Addons;
using System;
using System.Collections.Generic;
using System.Text;

using Sys = Cosmos.System;

namespace LyandOS.Plugins.Default
{
    class Cls : LyandPlugin
    {
        public override string Name => "cls";

        public override string Description => "Clears the screen";

        public override void Load() { }

        public override void Run(string[] argv) => Console.Clear();
    }
}
