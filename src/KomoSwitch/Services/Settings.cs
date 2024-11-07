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
    }
}