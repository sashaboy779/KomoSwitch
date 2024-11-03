using System.Collections.Generic;
using System.Linq;
using KomoSwitch.Models.Notifications;

namespace KomoSwitch.Models.EventArgs
{
    public class ConnectionEstablishedEventArgs : System.EventArgs
    {
        public List<Workspace> Workspaces { get; }

        public ConnectionEstablishedEventArgs(MonitorElement monitor)
        {
            Workspaces = monitor.Workspaces.Elements
                .Select((x, i) => new Workspace
                {
                    Name = x.Name,
                    Index = i,
                    IsFocused = monitor.Workspaces.Focused == i
                }).ToList();
        }
    }
}