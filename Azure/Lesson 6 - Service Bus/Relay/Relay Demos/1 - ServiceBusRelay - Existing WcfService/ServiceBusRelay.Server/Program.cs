using ServiceBusRelay.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ServiceBus;
using RelayWcfService;

namespace ServiceBusRelay.Server
{
    class Program
    {
        static void Main(string[] args)
        {//    sb://ServiceBusDemos07.servicebus.windows.net/console

            //Dolev Changed from net.tcp://127.0.0.1:747/console -> sb://ServiceBusDemo07*YourInitials*.servicebus.windows.net/console
            ServiceHost host = new ServiceHost(typeof(Service1), new Uri("sb://ServiceBusDemos07.servicebus.windows.net"));
            
            //Dolev NetTcpBinding -> NetTcpRelayBinding
            ServiceEndpoint endpoint = host.AddServiceEndpoint(typeof(IConsoleService), new NetTcpRelayBinding(), "console");
            endpoint.EndpointBehaviors.Add(new TransportClientEndpointBehavior//Dolev New Code
            {
                TokenProvider = TokenProvider.CreateSharedAccessSignatureTokenProvider("RootManageSharedAccessKey", "qPaPMizJYttwRJvwUVjmKEQqbQWahElj2iQCUTpQPxU=")
            });

            host.Open();

            Console.WriteLine("The server is running");
            Console.ReadKey();
            host.Close();
        }
    }
}
