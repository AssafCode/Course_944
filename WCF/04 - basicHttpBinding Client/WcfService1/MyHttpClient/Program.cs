using mini = ServiceReferenceClient.RemoteServerMinimizedService;
using full = ServiceReferenceClient.RemoteServerFullService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyHttpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // This code is written by an application developer.
            // Create a channel factory.
            BasicHttpBinding myBinding = new BasicHttpBinding();

            EndpointAddress myEndpointFull = new EndpointAddress("http://localhost:58151/Service1.svc/Regular");

            ChannelFactory<full.IFullService> myChannelFactory = new ChannelFactory<full.IFullService>(myBinding, myEndpointFull);

            // Create a channel.
            full.IFullService channelFull = myChannelFactory.CreateChannel();
            string s = channelFull.GetData(5);
            Console.WriteLine(s.ToString());
            ((IClientChannel)channelFull).Close();

            

            

            EndpointAddress myEndpointMini = new EndpointAddress("http://localhost:58151/Service1.svc/Minimized");

            ChannelFactory<mini.IServiceMinimized> myChannelFactoryMini = new ChannelFactory<mini.IServiceMinimized>(myBinding, myEndpointMini);

            // Create a channel.
            mini.IServiceMinimized channelMini = myChannelFactoryMini.CreateChannel();
            string sMini = channelMini.GetDataMinimized(7);
            Console.WriteLine(sMini.ToString());
            ((IClientChannel)channelMini).Close();
        }
    }
}
