namespace ArchitectureStudies.Command
{
    public interface IReceiver
    {
        public string DoSomething(string payload);

        public string DoSomethingElse(string payload);
    }
}
