using PluginAPI;

namespace AquaConsole.Commands
{
    class nyan : ICommand
    {
        public string Command
        {
            get
            {
                return "nyan";
            }
        }

        public string HelpText
        {
            get
            {
                return "meow";
            }
        }

        public void CommandMethod(string p)
        {
            System.Diagnostics.Process.Start("http://www.nyan.cat");
            Utility.ErrorWriteLine("meow meow meow Meow Meow Meow MEow MEow MEow " +
                "MEOw MEOw MEOw MEOW MEOW MEOW MEOW MEOW MEOW MEOW MEOW MEOW MEOW MEOW" +
                "MEOW MEOW!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        }
    }
    class cheese : ICommand
    {
        public string Command
        {
            get
            {
                return "cheese";
            }
        }
        public string HelpText
        {
            get
            {
                return "find out more about this amazing product (cheese)";
            }
        }
        public void CommandMethod(string b)
        {
            System.Diagnostics.Process.Start("http://www.cheese.com/");
            Utility.ErrorWriteLine("cheese is good to you, be good to it.");
        }
    }
}