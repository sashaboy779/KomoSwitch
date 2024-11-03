using Newtonsoft.Json;

namespace KomoSwitch.Models.Notifications
{
    public class WorkspaceElement
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}