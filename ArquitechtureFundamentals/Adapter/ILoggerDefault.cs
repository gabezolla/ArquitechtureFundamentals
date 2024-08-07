namespace AbstractFactory.Adapter
{
    public interface ILoggerDefault
    {
        public string Log(string message);

        public string LogError(string message);
    }
}
