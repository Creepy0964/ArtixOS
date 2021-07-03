using LyandOS.Plugins.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace LyandOS.Plugins
{
    class PluginManager
    {
        public static List<LyandPlugin> Plugins { get; set; } = new List<LyandPlugin>();

        public static void LoadPlugins()
        {
            Plugins.Add(new TestPlugin());
        }

        public static bool TryHandleCommand(string command)
        {
            string[] argv = command.Split(' ');

            if (argv.Length == 0)
                return false;

            foreach (var plugin in Plugins)
                if (argv[0] == plugin.Name)
                {
                    plugin.Run(argv);
                    return true;
                }

            return false;
        }
    }
}
