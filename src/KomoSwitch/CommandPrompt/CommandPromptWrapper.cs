using System.Diagnostics;

namespace KomoSwitch.CommandPrompt
{
    public static class CommandPromptWrapper
    {
        public static void FocusWorkspace(int index)
        {
            RunCommand("komorebic.exe", $"focus-workspace {index}");
        }
        
        public static CommandResult SubscribePipe(string pipeName)
        {
            return RunCommandWithResult("komorebic.exe", $"subscribe-pipe {pipeName}");
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

        private static CommandResult RunCommandWithResult(string command, string arguments, bool isHidden = true)
        {
            var process = new Process();
            var startInfo = new ProcessStartInfo
            {
                WindowStyle = isHidden ? ProcessWindowStyle.Hidden : ProcessWindowStyle.Normal,
                FileName = command,
                Arguments = arguments,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };
            process.StartInfo = startInfo;
            process.Start();
            
            var output = process.StandardOutput.ReadToEnd();
            var error = process.StandardError.ReadToEnd();
            
            process.WaitForExit();
            
            return new CommandResult(output, error);
        }
    }
}