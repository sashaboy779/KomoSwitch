using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CSDeskBand.ContextMenu;
using Serilog;

namespace KomoSwitch
{
    [ComVisible(true)]
    [Guid("6F42B9CA-592E-4838-95CA-85CD46C57982")]
    [CSDeskBand.CSDeskBandRegistration(Name = "KomoSwitch", ShowDeskBand = false)]
    public class DeskBand : CSDeskBand.CSDeskBandWin
    {
        private static Control _control;

        public DeskBand()
        {
            InitializeLogger();
            InitializeDeskBand();
            
            _control = new WorkspacesContainer(this);
        }

        private void InitializeLogger()
        {
            var folder = GetLogsFolder();
            Directory.CreateDirectory(folder);
            
            var logPath = Path.Combine(folder, "Logs.txt");
            
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File(logPath, rollingInterval: RollingInterval.Day, retainedFileCountLimit: 7)
                .CreateLogger();
            
            Log.Information("KomoSwitch is started");
        }

        private void InitializeDeskBand()
        {
            var logsFolder = GetLogsFolder();
            
            var openLogsAction = new DeskBandMenuAction("Open logs folder");
            openLogsAction.Clicked += (sender, args) => CommandPromptWrapper.OpenFolder(logsFolder);
            
            Options.ContextMenuItems = new List<DeskBandMenuItem> { openLogsAction };
            Options.MinHorizontalSize = new Size(600, 30);
        }

        private string GetLogsFolder()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "KomoSwitch");
        }

        protected override Control Control => _control;

        protected override void DeskbandOnClosed()
        {
            Log.Information("KomoSwitch is closed");
            Log.CloseAndFlush();
            base.DeskbandOnClosed();
        }
    }
}
