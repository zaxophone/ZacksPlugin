using PluginAPI;
using System;
using System.IO;
using System.Net;
//necessary for compression
using Ionic.Zip;
using System.Threading;
using System.Reflection;

class update : ICommand
{
    public string Command
    {
        get
        {
            return "update";
        }
    }

    public string HelpText
    {
        get
        {
            return "Tries to update.";
        }
    }

    public void CommandMethod(string[] p)
    {
        string cheese = (string.Join("", p));
        string release = cheese;
        string remoteUri = ("https://github.com/lukasdragon/AquaConsole/releases/download/" + release + "/AquaConsole.zip");
        string fileName = Assembly.GetExecutingAssembly().Location;
        string zipname = (fileName + "\\AquaConsole.zip");
        string releaseFolder = (fileName + "\\" + release);
        string pluginsFolder = (fileName + "\\plugins");
        string newPluginsFolder = (releaseFolder + "\\plugins");

        if (release == ("help"))
        {
            Console.WriteLine("Usage: update (version)");
        }
        else
        {
            using (var client = new WebClient())
            {
                if (!Utility.FileOrDirectoryExists(fileName))
                {
                    Console.WriteLine("AquaConsole release already found! Please delete directory \\" + release + " and try again.");
                }
                else
                {
                    WebClient temporaryw = new WebClient();
                    temporaryw.DownloadFile(remoteUri, zipname);
                    using (ZipFile zip1 = ZipFile.Read(zipname))
                    {
                        zip1.ExtractAll(releaseFolder);
                    }
                    File.Delete(zipname);
                    Console.WriteLine("Added version " + release + " in new folder");
                    Directory.CreateDirectory(newPluginsFolder);

                    string zippi = (newPluginsFolder + "\\temp.zip");
                    using (ZipFile zip2 = new ZipFile())
                    {
                        zip2.AddDirectory(pluginsFolder, "");
                        zip2.Save(zippi);
                    }
                    using (ZipFile zip3 = ZipFile.Read(zippi))
                    {
                        zip3.ExtractAll(newPluginsFolder);
                    }
                    Console.WriteLine("Successfully copied over plugins");
                    Thread.Sleep(8000);
                    File.Delete(zippi);
                }
            }
        }
    }
}
