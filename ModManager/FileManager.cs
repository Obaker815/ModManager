using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib;
using ICSharpCode.SharpZipLib.Zip;

namespace ModManager
{
    internal class FileManager
    {
        private static string gamesPath = @".\Games\";

        public static string exeLocation;
        public static string gamePath;
        public static string profilePath;

        public static Task UpdatePaths()
        {
            FormModManager activemain = FormModManager.activeMain;
            string activeDirectory = Directory.GetCurrentDirectory();

            gamePath    = gamesPath + activemain.ActiveGame + @"\";
            profilePath = gamePath + activemain.ActiveProfile + @"\";

            return Task.CompletedTask;
        }
        public static async void GetGames()
        {
            FormModManager activemain = FormModManager.activeMain;
            await UpdatePaths();
            activemain._cbGames.Items.Clear();

            foreach (string p in Directory.GetDirectories(gamesPath))
            {
                activemain._cbGames.Items.Add(p.Remove(0, gamesPath.Length));
            }
        }
        public static async void GetProfiles()
        {
            FormModManager activemain = FormModManager.activeMain;
            await UpdatePaths();
            activemain._cbProfiles.Items.Clear();
            exeLocation = File.ReadAllText(gamePath + @"\exeLocation.txt");

            foreach (string p in Directory.GetDirectories(gamePath))
            {
                activemain._cbProfiles.Items.Add(p.Remove(0, gamePath.Length));
            }
        }
        public static async void GetMods()
        {
            FormModManager activemain = FormModManager.activeMain;
            await UpdatePaths();

            foreach (Control c in activemain._panMods.Controls)
            {
                c.Dispose();
            }
            activemain.numFiles = 0;

            foreach (string p in Directory.GetDirectories(profilePath))
            {
                activemain.AddNewFile(p);
            }
        }
        public static void AddMod(string path)
        {
            string name = path;
            if (name.EndsWith(@"\"))
            {
                name = name.Remove(name.Length - 2, 1);
            }

            for (int i = name.Length - 1; i > 0; i--)
            {
                if (name[i] == '\\')
                {
                    name = name.Remove(0, i + 1);
                    break;
                }
            }
            File.Copy(path, profilePath + name);

            foreach (string p in Directory.GetFiles(profilePath))
            {
                if (p.ToLower().EndsWith(".zip"))
                {
                    FastZip fastZip = new FastZip();
                    fastZip.ExtractZip(p, p.Substring(0, p.Length - 4) + @"\", null);
                    File.Delete(p);
                }
            }

            GetMods();
        }
    }
}
