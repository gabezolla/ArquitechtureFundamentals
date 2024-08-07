namespace ArchitectureStudies.Command
{
    public class Receiver : IReceiver
    {
        public string DoSomething(string payload)
        {
            return $"Receiver: Working on ({payload}.)";
        }

        public string DoSomethingElse(string payload)
        {
            return $"Receiver: Also working on ({payload}.)";
        }
    }
}
