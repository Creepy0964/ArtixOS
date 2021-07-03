using Cosmos.HAL;
using LyandOS.Addons;
using LyandOS.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Sys = Cosmos.System;

namespace LyandOS.Plugins.Default
{
    class Help : LyandPlugin
    {
        public override string Name => "help";

        public override string Description => "Shows info about all the commands";

        public override void Load() { }

        public static void ListAlt(int space, string symbol, Dictionary<string, string> dict) // Credits to "pLib" by Popdash
        {
            int longestWordLength = 0;
            foreach (var item in dict.Keys)
                if (item.Length > longestWordLength)
                    longestWordLength = item.Length;
            foreach (var keypair in dict)
                Console.WriteLine($"{keypair.Key.PadRight(longestWordLength)}{new string(' ', space)}{symbol}{new string(' ', space)}{keypair.Value}");
        }

        public override void Run(string[] argv)
        {
            var commands = PluginManager.Plugins;
            Dictionary<string, string> help = new Dictionary<string, string>();

            foreach (var command in commands)
                help.Add(command.Name, command.Description);

            ListAlt(1, "-", help);
        }
    }
}
