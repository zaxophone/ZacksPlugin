using Microsoft.Win32;
using Microsoft;
using Microsoft.Win32.SafeHandles;
using PluginAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZacksPlugin
{
    class Main : IPlugin
    {
        public string name
        {
            get
            {
                return "Zack's Plugin";
            }
        }

        //Needed only if you are doing advanced things... 
        public void LoadMethod()
        {
            throw new NotImplementedException();
        }

        //Loaded after everything else
        public void PostLoadMethod()
        {
            throw new NotImplementedException();
        }

        //Loaded before everything else
        public void PreloadMethod()
        {
            string ext = ".aqua";
            string aquac = Directory.GetCurrentDirectory();
            public static DirectoryInfo GetParent(aquac)
            string aquaexe = (aquac + "\\AquaConsole.exe");
            RegistryKey key = Registry.ClassesRoot.CreateSubKey(ext);
            key.SetValue("", "AquaConsole");
            key.Close();

            key = Registry.ClassesRoot.CreateSubKey(ext + "\\Shell\\Open\\command");
            //key = key.CreateSubKey("command");

            key.SetValue("", "\"" + Application.ExecutablePath + "\" \"%L\"");
            key.Close();
        }
    }
}
