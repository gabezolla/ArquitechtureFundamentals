using AbstractFactory.Adapter;

namespace ArchitectureStudies.Adapter
{
    public class LoggerAdapter : ILoggerDefault
    {
        private readonly ILoggerCustomized _logger;

        public LoggerAdapter(ILoggerCustomized logger)
        {
            _logger = logger;
        }

        public string Log(string message)
        {
            return _logger.LogCustomized(message);
        }

        public string LogError(string message)
        {
            return _logger.LogErrorCustomized(message);
        }
    }
}
