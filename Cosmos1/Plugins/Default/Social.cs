using Cosmos.HAL;
using LyandOS.Addons;
using LyandOS.Commands;
using System;
using System.Collections.Generic;
using System.Text;

using Sys = Cosmos.System;

namespace LyandOS.Plugins.Default
{
    class Social : LyandPlugin
    {
        public override string Name => "social";

        public override string Description => "Shows main dev's socials";

        public override void Load() { }

        public override void Run(string[] argv) => Other.Social();
    }
}
