using System;

namespace KomoSwitch.Models
{
    public class WorkspaceFocusedEventArgs : EventArgs
    {
        public int Index { get; }

        public WorkspaceFocusedEventArgs(int index)
        {
            Index = index;
        }
    }
}