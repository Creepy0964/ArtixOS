using LyandOS.Plugins.Custom;
using LyandOS.Plugins.Default;
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
            // Test
            Plugins.Add(new TestPlugin());

            // Core
            Plugins.Add(new Bsod());
            Plugins.Add(new Cls());
            Plugins.Add(new Help());
            Plugins.Add(new Notepad());
            Plugins.Add(new Playsound());
            Plugins.Add(new Reboot());
            Plugins.Add(new Shutdown());
            Plugins.Add(new Social());
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
