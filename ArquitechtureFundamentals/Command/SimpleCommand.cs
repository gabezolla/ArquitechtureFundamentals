namespace ArchitectureStudies.Command
{
    public class SimpleCommand : ICommand
    {
        public SimpleCommand(string payload)
        {
            Payload = payload;
        }

        public string Payload { get; set; }

        public string Execute()
        {
            return $"Returning {Payload}";
        }
    }
}
