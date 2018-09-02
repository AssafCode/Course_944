using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WcfApplication;

namespace HosterConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string listenAddress = "http://localhost:6488";

            using (ServiceHost host = new ServiceHost(typeof(Service1)))
            {
                host.AddServiceEndpoint(
                    typeof(IService1),
                    new BasicHttpBinding(),
                    listenAddress);

                //Add this part to add wsdl to the service, so add service reference will work
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.HttpGetUrl = new Uri(listenAddress);
                host.Description.Behaviors.Add(smb);

                host.Open();
                Console.WriteLine("Service listening at address {0}", listenAddress);
                Console.WriteLine("Press [Enter] to close the listener and exit.");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
