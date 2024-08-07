namespace ArchitectureStudies.Adapter
{
    public class ClientService : IClientService
    {
        private readonly ILoggerCustomized _logger;
        public ClientService(ILoggerCustomized logger)
        {
            _logger = logger;
        }

        public List<string> Execute()
        {
            var adapter = new LoggerAdapter(_logger);

            return new List<string> { adapter.Log("succesfully adapted"), adapter.LogError("sucessfully adapted error") };
        }
    }
}
