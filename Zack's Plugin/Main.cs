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
            throw new NotImplementedException();
        }
    }
}
