using Loader.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loader.Utils
{
    public class InstallationUtils
    {
        public static string LoaderCache = GetPath("%appdata%\\LioatDS3OS\\cache");
        public static string LoaderCacheGoldberg = GetPath("%appdata%\\LioatDS3OS\\goldberg");
        public static string LoaderData = GetPath("%appdata%\\LioatDS3OS");
        public static string LoaderDataGoldberg = GetPath("%appdata%\\Goldberg SteamEmu Saves\\settings");
        public static string LoaderConfig = GetPath("%appdata%\\LioatDS3OS\\lioat.ds3config");
        
        private static string GetPath(string path)
        {
            return Environment.ExpandEnvironmentVariables(path);
        }

        public static void CheckRuntime(string path, bool debug = false)
        {
            if (!File.Exists(LoaderCache) || debug)
            {
                path = path.Replace("DarkSoulsIII.exe", "");
                string backupPath = String.Format("{0}backup\\", path);
                if (!Directory.Exists(backupPath))
                {
                    Directory.CreateDirectory(backupPath);
                }
                //clean installation
                string[] res = { "DarkSoulsIII.exe", "steam_interfaces.txt"/*"generate_interfaces_file.exe"*/, "steam_api.dll", "steam_api64.dll" };

                //initial resourcemanager
                Assembly assembly = Assembly.GetEntryAssembly();
                ResourceManager resourceManager = new ResourceManager("Loader.Properties.Resources", assembly);

                //copying system file
                foreach (string s in res)
                {
                    string p = String.Format("{0}{1}", path, s);
                    string newp = String.Format("{0}{1}", backupPath, s);
                    if (File.Exists(p))
                    {
                        File.Move(p, newp, true);
                    }
                    File.Create(p).Close();
                    if (s == "steam_interfaces.txt")
                    {
                        File.WriteAllText(p, (string)resourceManager.GetObject(s));
                        continue;
                    }
                    File.WriteAllBytes(p, (byte[])resourceManager.GetObject(s));
                    //generate interface, now use static interface file
                    //if (s == "generate_interfaces_file.exe")
                    //{
                    //    Process process = new Process();
                    //    process.StartInfo.FileName = String.Format("{0}{1}", path, res[1]);
                    //    process.StartInfo.Arguments = String.Format("{0}{1}", path, $"\"{res[3]}\"");
                    //    process.StartInfo.RedirectStandardInput = true;
                    //    process.StartInfo.RedirectStandardOutput = true;
                    //    process.StartInfo.RedirectStandardError = true;
                    //    process.StartInfo.CreateNoWindow = true;
                    //    process.Start();
                    //    Debug.WriteLine(process.StandardOutput.ReadToEnd());
                    //    process.WaitForExit();
                    //    process.Close();
                    //    //Process.Start(String.Format("{0}{1}", path, res[1]), String.Format("{0}{1}", path, $"\"{res[3]}\""));
                    //}
                }
                File.Create(LoaderCache).Close();
            }
        }

        public static void RestoreSteam(string path)
        {
            path = path.Replace("DarkSoulsIII.exe", "");

            //initial resourcemanager
            Assembly assembly = Assembly.GetEntryAssembly();
            ResourceManager resourceManager = new ResourceManager("Loader.Properties.ResourcesSteam", assembly);

            //restore steam file
            string[] res = { "DarkSoulsIII.exe", "steam_api64.dll" };
            foreach (string s in res)
            {
                string p = String.Format("{0}{1}", path, s);
                File.Delete(p);
                File.Create(p).Close();
                File.WriteAllBytes(p, (byte[])resourceManager.GetObject(s));
            }
            File.Delete(LoaderCache);
            File.Delete(LoaderConfig);
            File.Delete(LoaderCacheGoldberg);
        }

    }
}
