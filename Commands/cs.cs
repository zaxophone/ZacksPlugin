using PluginAPI;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System;

namespace AquaConsole.Commands
{
    class csdo : ICommand
    {
        public string Command
        {
            get
            {
                return "csdo";
            }
        }

        public string HelpText
        {
            get
            {
                return "Dev command that crashes AquaConsole";
            }
        }

        public void CommandMethod(string[] p)
        {
            string c = string.Join("", p);
            Type t = c.GetType();
            MethodInfo method = t.GetMethod("showMessage");
            method.Invoke(t, null);
        }
    }
}