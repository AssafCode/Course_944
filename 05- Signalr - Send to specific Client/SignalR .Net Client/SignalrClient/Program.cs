using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalrClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var hubConnection = new HubConnection("http://localhost:52527/");
            IHubProxy chatHubProxy = hubConnection.CreateHubProxy("ChatHub");
            chatHubProxy.On("broadcastMessage", (string name, string message) => 
            {
                Console.WriteLine($"{name}: {message}");
            });
            hubConnection.Start().Wait();
            
            Console.WriteLine("Write down the user name");
            string clientName = Console.ReadLine();
            chatHubProxy.Invoke("SignIn", clientName);

            string targetUserName = null;
            Console.WriteLine("Write down to who to send");
            targetUserName = Console.ReadLine();

            string sendMessage = null;
            Console.WriteLine("Write down a message");
            sendMessage = Console.ReadLine();

            chatHubProxy.Invoke("SendTo", sendMessage, targetUserName);
            Console.ReadLine();
        }
    }
}
