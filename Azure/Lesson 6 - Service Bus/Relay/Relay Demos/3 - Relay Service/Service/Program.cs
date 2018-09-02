using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading.Tasks;
using CommonContract;
using Microsoft.ServiceBus;

namespace RelayExample
{
    // This is an all-in-one Relay service that can be hosted through the 
    // Service Bus Relay. 
    
    class Program
    {
        public static void Main()
        {
            string listenAddress = "sb://relaydemo64.servicebus.windows.net/";
            string listenToken = "VhODsE8Q2/hfXvOttlQB/j2B77emtxeeTgGzOCt2/Jc=";

            ServiceBusEnvironment.SystemConnectivity.Mode = ConnectivityMode.AutoDetect; // Auto-detect, default
            //ServiceBusEnvironment.SystemConnectivity.Mode = ConnectivityMode.Https; // HTTPS WebSockets

            using (ServiceHost host = new ServiceHost(typeof(WcfService)))
            {
                ServiceEndpoint endpoint = host.AddServiceEndpoint(
                    typeof(IContract),
                    new NetTcpRelayBinding(),
                    listenAddress);

                endpoint.EndpointBehaviors.Add(new TransportClientEndpointBehavior
                {
                    TokenProvider = TokenProvider.CreateSharedAccessSignatureTokenProvider("RootManageSharedAccessKey", listenToken)
                });

                host.Open();
                Console.WriteLine($"Service listening at address {listenAddress}");
                Console.WriteLine("Press Enter to close the listener and exit.");
                Console.ReadLine();
                host.Close();
            }
        }        
    }
}