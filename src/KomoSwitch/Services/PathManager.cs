using System;
using System.IO;

namespace KomoSwitch.Services
{
    public static class PathManager
    {
        public static string WorkspacesJson => Path.Combine(AppDataFolder, $"{KomoSwitch}\\workspaces.json");
        public static string SettingsJson => Path.Combine(AppDataFolder, $"{KomoSwitch}\\settings.json");
        public static string LogsFolder => Path.Combine(AppDataFolder, $"{KomoSwitch}\\Logs");
        private static string AppDataFolder => Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private static string KomoSwitch => "KomoSwitch";
    }
}