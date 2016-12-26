using Microsoft.Win32;
using PluginAPI;
using System;

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

        //Needed only if you are doing semi-advanced things... apparently like I am
        public void LoadMethod()
        {
            throw new NotImplementedException();
        }

        //Loaded after everything else
        public void PostLoadMethod()
        {
            throw new NotImplementedException();
        }

        //Loaded before everything else- obviously
        public void PreloadMethod()
        {
            string ext = (".aqua");
            string aquac = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            string aquaexe = (aquac + "\\AquaConsole.exe");
            string newkeym = @"HKEY_CLASSES_ROOT\.aqua";
            if (Registry.GetValue(newkeym, "AquaConsole", null) == null)
            {
                RegistryKey aquakey = Registry.ClassesRoot.CreateSubKey(ext);
                aquakey.SetValue("", "AquaConsole");
                aquakey.Close();

                aquakey = Registry.ClassesRoot.CreateSubKey(ext + "\\Shell\\Open\\command");
                aquakey = aquakey.CreateSubKey("command");

                aquakey.SetValue("", "\"" + aquaexe + "\" \"%L\"");
                aquakey.Close()
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
