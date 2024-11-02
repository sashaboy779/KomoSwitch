using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CSDeskBand.ContextMenu;
using KomoSwitch.CommandPrompt;
using KomoSwitch.Controls;
using Serilog;

namespace KomoSwitch
{
    [ComVisible(true)]
    [Guid("6F42B9CA-592E-4838-95CA-85CD46C57982")]
    [CSDeskBand.CSDeskBandRegistration(Name = "KomoSwitch", ShowDeskBand = false)]
    public class DeskBand : CSDeskBand.CSDeskBandWin
    {
        private static Control _control;
        private readonly EventListener _listener;

        public DeskBand()
        {
            InitializeLogger();
            InitializeDeskBand();

            _listener = new EventListener();
            _control = new WorkspacesContainer(_listener);
            
            _listener.Start();
        }

        private void InitializeLogger()
        {
            var folder = GetLogsFolder();
            Directory.CreateDirectory(folder);
            
            const string template = "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] {Message} {Properties}{NewLine}";
            var logPath = Path.Combine(folder, "Logs.txt");
            var trace = DateTime.Now.ToString("yyyyMMddHHmmss");            
            
            Log.Logger = new LoggerConfiguration()
                .Enrich.WithProperty("Trace", trace)
                .Enrich.WithThreadId()
                .MinimumLevel.Debug()
                .WriteTo.File(logPath, outputTemplate: template, rollingInterval: RollingInterval.Day, retainedFileCountLimit: 7)
                .CreateLogger();
            
            Log.Information("KomoSwitch is starting");
        }

        private void InitializeDeskBand()
        {
            var logsFolder = GetLogsFolder();
            
            var openLogsAction = new DeskBandMenuAction("Open logs folder");
            openLogsAction.Clicked += (sender, args) => CommandPromptWrapper.OpenFolder(logsFolder);
            
            Options.ContextMenuItems = new List<DeskBandMenuItem> { openLogsAction };
            Options.MinHorizontalSize = new Size(100, 30);
        }

        private string GetLogsFolder()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "KomoSwitch");
        }

        protected override Control Control => _control;

        protected override void DeskbandOnClosed()
        {
            Log.Information("KomoSwitch is closing");

            Log.Information("Stopping event listener");
            _listener.Stop();
            
            Log.Information("Flushing logs");
            Log.CloseAndFlush();
            
            base.DeskbandOnClosed();
        }
    }
}
