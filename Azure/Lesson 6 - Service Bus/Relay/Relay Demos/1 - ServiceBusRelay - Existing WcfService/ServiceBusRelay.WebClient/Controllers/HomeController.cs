using Microsoft.ServiceBus;
using ServiceBusRelay.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;

namespace ServiceBusRelay.WebClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult Write(string text)
        {
            //Dolev Changed    NetTcpBinding -> NetTcpRelayBinding
            ChannelFactory<IConsoleService> factory = new ChannelFactory<IConsoleService>(new NetTcpRelayBinding(),
                                                              //Dolev Changed from net.tcp://127.0.0.1:747/console -> sb://ServiceBusDemos07.servicebus.windows.net/console
                                                              new EndpointAddress("sb://ServiceBusDemos07.servicebus.windows.net/console"));
            factory.Endpoint.EndpointBehaviors.Add(new TransportClientEndpointBehavior { TokenProvider = TokenProvider.CreateSharedAccessSignatureTokenProvider("RootManageSharedAccessKey", "qPaPMizJYttwRJvwUVjmKEQqbQWahElj2iQCUTpQPxU=") });// Dolev New Code
            IConsoleService proxy = factory.CreateChannel();
            try
            {
                proxy.Write(text);
            }
            catch (Exception)
            {

                throw;
            }


            (proxy as IClientChannel).Close();
            return Redirect(Request.ApplicationPath);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
