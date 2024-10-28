using Newtonsoft.Json;

namespace KomoSwitch.Models.Notifications
{
    public class Notification
    {
        [JsonProperty("event")]
        public Event Event { get; set; }
    }
}