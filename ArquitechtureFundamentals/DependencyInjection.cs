using AbstractFactory.Adapter;
using ArchitectureStudies.Adapter;
using ArchitectureStudies.Command;
using ArchitectureStudies.Strategy;
using System.Runtime.CompilerServices;

namespace ArchitectureStudies
{
    public static class DependencyInjection
    {
        public static IServiceCollection InjectDependencies(this IServiceCollection service)
        {
            service.AddScoped<ILoggerDefault, LoggerDefault>();
            service.AddScoped<ILoggerCustomized, LoggerCustomized>();
            service.AddScoped<IClientService, ClientService>();
            service.AddScoped<IReceiver, Receiver>();
            service.AddScoped<IInvoker, Invoker>();
            service.AddScoped<IOrderingService, OrderingService>();
            service.AddScoped<IPayment, CreditCardStrategy>();
            service.AddScoped<IPayment, DebitCardStrategy>();
            service.AddScoped<IOrderingStrategyFactory, OrderingStrategyFactory>();

            return service;
        }
    }
}
