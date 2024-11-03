using Newtonsoft.Json;

namespace KomoSwitch.Models.Notifications
{
    public class MonitorElement
    {
        [JsonProperty("workspaces")]
        public Workspace Workspaces { get; set; }
    }
}