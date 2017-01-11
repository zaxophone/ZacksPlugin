using PluginAPI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AquaConsole.FileAssociations
{
    class nf : IAssociatedFile
    {
        public string Extension
        {
            get
            {
                return "aqua";
            }
        }

        public void CommandMethod(string file)
        {
            if (Utility.FileOrDirectoryExists(file))
            {
                List<List<string>> groups = new List<List<string>>();
                foreach (var line in File.ReadAllLines(file))
                {
                    string AquaConsoleExe = (Assembly.GetExecutingAssembly().Location + "\\AquaConsole.exe");
                    string[] readText = File.ReadAllLines(file);

                    Process ac = new Process();
                    ac.StartInfo.FileName = AquaConsoleExe;
                    ac.StartInfo.UseShellExecute = false;
                    ac.StartInfo.RedirectStandardInput = true;

                    ac.Start();

                    StreamWriter acsw = ac.StandardInput;
                    acsw.WriteLine(line);
                }
            }
            else
                Utility.ErrorWriteLine("Warning- File is nonexistent or you have insufficient permissions to access it or your file system is corrupt or there's a system I/O error");
        }
    }
}
