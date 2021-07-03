using System;
using System.Collections.Generic;
using System.Text;

namespace LyandOS.Plugins
{
    public abstract class LyandPlugin
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract void Run(string[] argv);
        public abstract void Load();
    }
}
