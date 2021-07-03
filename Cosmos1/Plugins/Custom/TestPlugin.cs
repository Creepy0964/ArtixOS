using System;
using System.Collections.Generic;
using System.Text;

namespace LyandOS.Plugins.Custom
{
    class TestPlugin : LyandPlugin
    {
        public override string Name => "test";

        public override string Description => "I'm a test plugin!";

        public override void Load() => Console.WriteLine("Test plugin loaded!");

        public override void Run(string[] argv) => Console.WriteLine("Test plugin has been called!");
    }
}
