﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IPL_IDE_Advanced_Editor
{
    class Settings
    {
        public static string ini = "settings.ini";

        public static string default_raw = "" +
            "; IPL/IDE Advanced Editor - Settings File" + "\r\n" +
            "; =======================================" + "\r\n" +
            "; Add as many Maps as you want with names \"Map\"+i." + "\r\n" +
            "; If you need to restore default settings, just delete this file and run once again 'IPL/IDE Advanced Editor.exe'" + "\r\n" +
            "" + "\r\n" +
            "[General]" + "\r\n" +
            "DefaultSelected = 1" + "\r\n" +
            "" + "\r\n" +
            "[Map1]" + "\r\n" +
            "name = GTA III" + "\r\n" +
            "path = input" + "\r\n" +
            "" + "\r\n" +
            "";

        public static Dictionary<string, Dictionary<string, string>> Data;

        public static void Initialize()
        {
            Settings.Data = new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase);

            string raw = Editor.GetRaw(Settings.ini);
            string[] lines = Regex.Split(raw, "\r\n");
            string section = "", key = "", value = "";
            foreach (string line in lines)
            {
                if (line.StartsWith(";") || line.StartsWith("#") || line.StartsWith("//"))
                    continue;
                if (line.StartsWith("[") && line.EndsWith("]"))
                {
                    section = line.Substring(1, line.Length - 2);
                    Settings.Data.Add(section, new Dictionary<string, string>());
                }
                else if (line.Split('=').Length > 1)
                {
                    key = line.Split('=')[0].Trim();
                    value = line.Split('=')[1].Trim();

                    if (section != String.Empty)
                        Settings.Data[section].Add(key, value);
                }
            }
        }

        public static void Save()
        {
            List<string> save = new List<string>();
            string raw = Editor.GetRaw(Settings.ini);
            string[] lines = Regex.Split(raw, "\r\n");
            string section = "", key = "";
            foreach (string line in lines)
            {
                if (line.StartsWith(";") || line.StartsWith("#") || line.StartsWith("//"))
                {
                    save.Add(line);
                }
                else if (line.StartsWith("[") && line.EndsWith("]"))
                {
                    section = line.Substring(1, line.Length - 2);
                    save.Add(line);
                }
                else if (line.Split('=').Length > 1)
                {
                    key = line.Split('=')[0].Trim();

                    if (section != String.Empty && key != String.Empty)
                        save.Add(String.Format("{0} = {1}", key, Settings.Data[section][key]));
                }
                else
                    save.Add(line);
            }
            Editor.StoreRaw(Settings.ini, String.Join("\r\n", save));
        }

        public static int GetSelected()
        {
            int defaultSelected;
            try
            {
                defaultSelected = Int32.Parse(Settings.Data["General"]["DefaultSelected"]);
            }
            catch
            {
                defaultSelected = 1;
            }
            return defaultSelected;
        }

        public static List<string> GetAllFilesFrom(string path, string filetype)
        {
            List<string> files = new List<string>();
            string[] subfiles = System.IO.Directory.GetFiles(path, filetype, SearchOption.AllDirectories);
            foreach (string file in subfiles)
                files.Add(file);
            return files;
        }
    }
}
