using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CSDeskBand.ContextMenu;
using KomoSwitch.CommandPrompt;
using KomoSwitch.Controls;
using KomoSwitch.Services;
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
        private SettingsForm _currentSettingsForm;

        public DeskBand()
        {
            InitializeLogger();
            InitializeSettings();

            _listener = new EventListener();
            var workspacesContainer = new WorkspacesContainer(_listener, new Storage());
            _control = workspacesContainer;
            
            InitializeDeskBand(workspacesContainer);
            
            _listener.Start();
        }

        private void InitializeLogger()
        {
            var folder = PathManager.LogsFolder;
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

        private void InitializeSettings()
        {
            try
            {
                Settings.Load();

            }
            catch (Exception e)
            {
                Log.Fatal(e, "Unable to initialize settings: {Message}", e.Message);
                
                MessageBox.Show($"Unable to run KomoSwitch because of an error in settings.json:{Environment.NewLine}" +
                    e.Message, 
                    "KomoSwitch", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                
                throw;
            }
        }

        private void InitializeDeskBand(WorkspacesContainer workspacesContainer)
        {
            var logsFolder = PathManager.LogsFolder;
            
            var settingsAction = new DeskBandMenuAction("KomoSwitch Settings");
            settingsAction.Clicked += (sender, args) =>
            {
                if (_currentSettingsForm != null && !_currentSettingsForm.IsDisposed && !_currentSettingsForm.IsDisposed)
                {
                    _currentSettingsForm.Activate();
                }
                else
                {
                    _currentSettingsForm = new SettingsForm(workspacesContainer);
                    _currentSettingsForm.Show();
                }
            };
            
            var openLogsAction = new DeskBandMenuAction("Open logs folder");
            openLogsAction.Clicked += (sender, args) => CommandPromptWrapper.OpenFolder(logsFolder);
            
            Options.ContextMenuItems = new List<DeskBandMenuItem> { settingsAction, openLogsAction };
            Options.MinHorizontalSize = new Size(Settings.Instance.AppMinWidth, 30);
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
