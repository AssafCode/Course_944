using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceReferenceClient.RemoteServerFullService;
using ServiceReferenceClient.RemoteServerMinimizedService;

namespace ServiceReferenceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteServerFullService.FullServiceClient serverConnectorFull = new RemoteServerFullService.FullServiceClient();
            string resultFull = serverConnectorFull.GetData(6);
            Console.WriteLine(resultFull);

            RemoteServerMinimizedService.ServiceMinimizedClient serverConnectorMinimized = new RemoteServerMinimizedService.ServiceMinimizedClient();
            string resultMini = serverConnectorMinimized.GetDataMinimized(6);
            Console.WriteLine(resultMini);
        }
    }
}
