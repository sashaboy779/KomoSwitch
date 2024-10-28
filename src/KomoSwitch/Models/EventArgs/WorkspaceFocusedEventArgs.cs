namespace KomoSwitch.Models.EventArgs
{
    public class WorkspaceFocusedEventArgs : System.EventArgs
    {
        public int Index { get; }

        public WorkspaceFocusedEventArgs(int index)
        {
            Index = index;
        }
    }
}