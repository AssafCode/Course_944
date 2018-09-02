using System;
using System.ServiceModel;
using System.Threading.Tasks;
using CommonContract;
using Microsoft.ServiceBus;

namespace RelayExample
{
    class Program
    {
        public static void Main()
        {
            string sendAddress = "sb://relaydemo64.servicebus.windows.net/";
            string sendToken = "VhODsE8Q2/hfXvOttlQB/j2B77emtxeeTgGzOCt2/Jc=";

            ServiceBusEnvironment.SystemConnectivity.Mode = ConnectivityMode.AutoDetect; // Auto-detect, default
            //ServiceBusEnvironment.SystemConnectivity.Mode = ConnectivityMode.Https; // HTTPS WebSockets

            var cf = new ChannelFactory<IContract>(new NetTcpRelayBinding { IsDynamic = false }, sendAddress);

            cf.Endpoint.EndpointBehaviors.Add(new TransportClientEndpointBehavior
            {
                TokenProvider = TokenProvider.CreateSharedAccessSignatureTokenProvider("RootManageSharedAccessKey", sendToken)
            });

            ICommunicationObject channel = (ICommunicationObject)cf.CreateChannel();

            IContract client = (IContract)channel;
            for (int i = 1; i <= 25; i++)
            {
                var result = client.Echo(DateTime.UtcNow.ToString());
                Console.WriteLine("Round {0}, Echo: {1}", i, result);
            }
            channel.Close();

            Console.WriteLine("Press [Enter] to exit.");
            Console.ReadLine();
        }
    }
}