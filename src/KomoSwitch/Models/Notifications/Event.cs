using Newtonsoft.Json;

namespace KomoSwitch.Models.Notifications
{
    public class Event
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("content")]
        public object Content { get; set; }
    }
}