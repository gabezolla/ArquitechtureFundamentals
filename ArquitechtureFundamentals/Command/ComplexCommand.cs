namespace ArchitectureStudies.Command
{
    public class ComplexCommand : ICommand
    {
        public IReceiver Receiver;

        public string PayloadA;

        public string PayloadB;

        public ComplexCommand(IReceiver receiver, string payloadA, string payloadB)
        {
            Receiver = receiver;
            PayloadA = payloadA;
            PayloadB = payloadB;
        }

        public string Execute()
        {
            Console.WriteLine(Receiver.DoSomething("Doing first things"));

            return $"Returning {PayloadA} and {PayloadB}";
        }
    }
}
