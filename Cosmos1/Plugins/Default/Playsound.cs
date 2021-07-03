using Cosmos.HAL;
using LyandOS.Addons;
using LyandOS.Commands;
using System;
using System.Collections.Generic;
using System.Text;

using Sys = Cosmos.System;

namespace LyandOS.Plugins.Default
{
    class Playsound : LyandPlugin
    {
        public override string Name => "playsound";

        public override string Description => "Play the sound using motherboard's speaker";

        public override void Load() { }

        public override void Run(string[] argv) => Other.PlaySound();
    }
}
