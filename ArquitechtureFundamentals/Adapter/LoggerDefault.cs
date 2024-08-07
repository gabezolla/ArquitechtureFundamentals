namespace AbstractFactory.Adapter
{
    public class LoggerDefault : ILoggerDefault
    {
        public string Log(string message)
        {
            return $"Default log message {message}";
        }

        public string LogError(string message)
        {
            return $"Default log error {message}";
        }
    }
}
