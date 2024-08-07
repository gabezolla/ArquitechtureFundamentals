using Microsoft.AspNetCore.Hosting.Server;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AbstractFactory.Singleton
{
    internal sealed class LoadBalancer
    {
        private static readonly LoadBalancer Instance = new LoadBalancer();

        private readonly List<Server> _servers;
        private readonly Random random = new();

        private LoadBalancer()
        {
            _servers = [
                new Server(Guid.NewGuid().ToString(), "ServerI", "120.14.220.18"),
                new Server(Guid.NewGuid().ToString(), "ServerII", "120.14.220.19"),
                new Server(Guid.NewGuid().ToString(), "ServerIII", "120.14.220.20"),
                new Server(Guid.NewGuid().ToString(), "ServerIV", "120.14.220.21"),
                new Server(Guid.NewGuid().ToString(), "ServerV", "120.14.220.22")
            ];
        }
        public static LoadBalancer GetInstance()
        {
            return Instance;
        }

        public Server NextServer
        {
            get => _servers[random.Next(_servers.Count)];
        }

    }
}
