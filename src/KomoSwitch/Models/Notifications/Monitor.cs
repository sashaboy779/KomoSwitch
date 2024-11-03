using System.Collections.Generic;
using Newtonsoft.Json;

namespace KomoSwitch.Models.Notifications
{
    public class Monitor
    {
        [JsonProperty("elements")]
        public List<MonitorElement> Elements { get; set; }
    }
}