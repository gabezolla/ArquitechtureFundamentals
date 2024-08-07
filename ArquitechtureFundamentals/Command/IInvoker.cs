namespace ArchitectureStudies.Command
{
    public interface IInvoker
    {
        public void SetOnStart(ICommand command);

        public void SetOnFinish(ICommand command);

        public List<string> DoSomethingImportant();
    }
}
