namespace KomoSwitch.CommandPrompt
{
    public class CommandResult
    {
        public string Output { get; set; }
        
        public string Error { get; set; }

        public bool IsSuccess => string.IsNullOrEmpty(Error) && string.IsNullOrEmpty(Output);

        public CommandResult(string output, string error)
        {
            Output = output;
            Error = error;
        }
    }
}