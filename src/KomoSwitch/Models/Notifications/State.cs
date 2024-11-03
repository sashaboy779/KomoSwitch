using Newtonsoft.Json;

namespace KomoSwitch.Models.Notifications
{
    public class State
    {
        [JsonProperty("monitors")]
        public Monitor Monitors { get; set; }
    }
}