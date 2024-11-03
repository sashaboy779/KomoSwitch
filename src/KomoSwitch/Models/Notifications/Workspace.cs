using System.Collections.Generic;
using Newtonsoft.Json;

namespace KomoSwitch.Models.Notifications
{
    public class Workspace
    {
        [JsonProperty("elements")]
        public List<WorkspaceElement> Elements { get; set; }
        
        [JsonProperty("focused")]
        public int Focused { get; set; }
    }
}