namespace KomoSwitch.Models
{
    public class Workspace
    {
        public string Name { get; set; }
        public int Index { get; set; }
        public bool IsFocused { get; set; }

        public Workspace()
        {
        }

        public Workspace(string name, int index, bool isFocused)
        {
            Name = name;
            Index = index;
            IsFocused = isFocused;
        }
    }
}