using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Singleton
{
    public class WorkerThread
    {
        public static void PostRequest()
        {
            LoadBalancer loadBalancer = LoadBalancer.Instance;
            Server selectedServer = loadBalancer.GetRandomServer();

            loadBalancer.ProcessRequest(selectedServer);

            Console.WriteLine($"Request processed by {selectedServer.Name} in {selectedServer.NumRequests} milliseconds");
        }
    }

}
