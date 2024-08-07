namespace ArchitectureStudies.Adapter
{
    public class LoggerCustomized : ILoggerCustomized
    {
        public string LogCustomized(string message)
        {
            return $"Customized log message {message}";
        }

        public string LogErrorCustomized(string message)
        {
            return $"Customized log error message {message}";
        }
    }
}
