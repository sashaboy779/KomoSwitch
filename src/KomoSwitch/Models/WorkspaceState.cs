namespace KomoSwitch.Models
{
    public class WorkspaceState
    {
        public string Name { get; set; }
        public int Index { get; set; }
        public bool IsFocused { get; set; }

        public WorkspaceState(string name, int index, bool isFocused)
        {
            Name = name;
            Index = index;
            IsFocused = isFocused;
        }
    }
}