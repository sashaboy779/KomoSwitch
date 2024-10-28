using System.Diagnostics;

namespace KomoSwitch
{
    public static class CommandPromptWrapper
    {
        public static void FocusWorkspace(int index)
        {
            RunCommand("komorebic.exe", $"focus-workspace {index}");
        }
        
        public static void SubscribePipe(string pipeName)
        {
            RunCommand("komorebic.exe", $"subscribe-pipe {pipeName}");
        }
        
        public static void UnsubscribePipe(string pipeName)
        {
            RunCommand("komorebic.exe", $"unsubscribe-pipe {pipeName}");
        }

        public static void OpenFolder(string logsFolderPath)
        {
            RunCommand("explorer.exe", logsFolderPath, isHidden: false);
        }

        private static void RunCommand(string command, string arguments, bool isHidden = true)
        {
            var process = new Process();
            var startInfo = new ProcessStartInfo
            {
                WindowStyle = isHidden ? ProcessWindowStyle.Hidden : ProcessWindowStyle.Normal,
                FileName = command,
                Arguments = arguments
            };
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}