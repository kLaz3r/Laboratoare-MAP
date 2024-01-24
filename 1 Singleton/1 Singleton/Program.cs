using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_Singleton
{
    class Program
    {
        static void Main()
        {
            List<Thread> threads = new List<Thread>();

            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(new ThreadStart(WorkerThread.PostRequest));
                threads.Add(thread);
            }

            threads.ForEach(t => t.Start());
            threads.ForEach(t => t.Join());

            LoadBalancer loadBalancer = LoadBalancer.Instance;
            foreach (var server in loadBalancer.GetServers())
            {
                Console.WriteLine($"Server: {server.Name}, IP: {server.IpAddress}, Minimun Time: 500 ms, Max Time: 1000 ms, Averge Time: {server.NumRequests / 5} ms, Total Time: {server.NumRequests} ms");
            }
        }
    }
}
