using System.Collections.Generic;
using System.IO;
using KomoSwitch.Models.Settings;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace KomoSwitch.Services
{
    public class Settings
    {
        public EStatusLineLocation StatusLineLocation { get; set; } = EStatusLineLocation.Bottom;
        
        public int AppMinWidth { get; set; } = 200;
        
        public string Font { get; set; } = "Microsoft Sans Serif, 9pt";
        
        public int WorkspaceWidth { get; set; } = 35;
        
        public int WorkspaceGap { get; set; } = 3;
        
        public bool SyncWithWindowsTheme { get; set; } = true;

        public WorkspaceColorSettings WorkspaceColors { get; } = new WorkspaceColorSettings();
        
        public WorkspaceBackgroundColorSettings WorkspaceBackgroundColors { get; } = new WorkspaceBackgroundColorSettings();

        public StatusLineColorSettings StatusLineColors { get; } = new StatusLineColorSettings();
        
        public class WorkspaceColorSettings
        {
            public string Default { get; set; } = "#FFFFFF";

            public string Active { get; set; } = "#0078d7";
        
            public string Waiting { get; set; } = "#696969";
        
            public string Error { get; set; } = "#B93139";
        }
    
        public class WorkspaceBackgroundColorSettings
        {
            public string Default { get; set; } = "#00000000";
        
            public string Active { get; set; } = "#32808080";
        
            public string Hover { get; set; } = "#19808080";
        
            public string HoverWhenActive { get; set; } = "#4B808080";
        }
    
        public class StatusLineColorSettings
        {
            public string Active { get; set; } = "#0078d7";
        
            public string ActiveWhenWaiting { get; set; } = "#FFF5F5F5";
        
            public string Waiting { get; set; } = "#696969";
        
            public string Error { get; set; } = "#B93139";
        }
        
        public static Settings Instance
        {
            get
            {
                if (_instance is null)
                    Load();

                return _instance;
            }
            private set => _instance = value;
        }

        private static Settings _instance;

        private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            Converters = new List<JsonConverter>
            {
                new StringEnumConverter(new CamelCaseNamingStrategy())
            }
        };

        public static void Load()
        {
            var path = PathManager.SettingsJson;
            if (!File.Exists(path))
            {
                InitializeSettingsFile(path);
            }

            var json = File.ReadAllText(path);
            Instance = JsonConvert.DeserializeObject<Settings>(json);
        }

        private static void InitializeSettingsFile(string path)
        {
            var settings = new Settings();
            var json = JsonConvert.SerializeObject(settings, SerializerSettings);
            File.WriteAllText(path, json);
        }

        public static void Save()
        {
            var json = JsonConvert.SerializeObject(Instance, SerializerSettings);
            File.WriteAllText(PathManager.SettingsJson, json);
        }
    }
}