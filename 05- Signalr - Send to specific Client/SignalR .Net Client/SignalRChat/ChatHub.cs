using System;
using System.Collections.Generic;
using System.Web;
using Microsoft.AspNet.SignalR;
namespace SignalRChat
{
    public class ChatHub : Hub
    {

        static Dictionary<string, string> userConnections = new Dictionary<string, string>();
        static Dictionary<string, string> userNames = new Dictionary<string, string>();


        public void SignIn(string name)
        {
            userConnections.Add(Context.ConnectionId, name);
            userNames.Add(name, Context.ConnectionId);
        }

        public void SendToAll(string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(userConnections[Context.ConnectionId], message);
        }

        public void SendTo(string message, string toClient)
        {
            // Call the broadcastMessage method to update clients.
            Clients.Client(userNames[toClient]).broadcastMessage(toClient, message);
        }
    }
}