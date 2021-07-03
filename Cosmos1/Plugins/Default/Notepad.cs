using Cosmos.HAL;
using LyandOS.Addons;
using LyandOS.Commands;
using System;
using System.Collections.Generic;
using System.Text;

using Sys = Cosmos.System;

namespace LyandOS.Plugins.Default
{
    class Notepad : LyandPlugin
    {
        public override string Name => "notepad";

        public override string Description => "Simple notepad";

        public override void Load() { }

        public override void Run(string[] argv)
        {
            if (argv.Length == 1)
                Utilities.Notepad();
            else
            {
                if (argv[1] == "-write")
                    Utilities.NotepadWrite();
                if (argv[1] == "-read")
                    Utilities.NotepadRead();
            }
        }
    }
}
