using PluginAPI;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System;

namespace AquaConsole.Commands
{
    class e : ICommand
    {
        public string Command
        {
            get
            {
                return ".";
            }
        }

        public string HelpText
        {
            get
            {
                return "Echoes back- for AQUA files";
            }
        }

        public void CommandMethod(string[] p)
        {
            string c = string.Join(" ", p);
            Console.Write(c);
        }
    }
}