using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_Singleton
{
    public sealed class LoadBalancer
    {
        private static LoadBalancer instance = null;
        private static readonly object lockObject = new object();
        private readonly List<Server> servers;

        private LoadBalancer()
        {
            servers = new List<Server>
        {
            new Server { Name = "Server", IpAddress = "192.168.3.1" },
        };
        }

        public static LoadBalancer Instance
        {
            get
            {
                lock (lockObject)
                {
                    return instance ?? (instance = new LoadBalancer());
                }
            }
        }

        public Server GetRandomServer()
        {
            Random random = new Random();
            return servers[random.Next(servers.Count)];
        }

        public Server GetServerWithMinRequests()
        {
            return servers.OrderBy(s => s.NumRequests).First();
        }

        public void ProcessRequest(Server server)
        {
            int processingTime = new Random().Next(500, 1001);
            Thread.Sleep(processingTime);
            server.NumRequests++;
        }
        public List<Server> GetServers()
        {
            return servers;
        }
    }


}
