using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace SistemeTeShperndaraGR7.SignalR.Hubs
{
    public class Chat: Microsoft.AspNet.SignalR.Hub
    {
        public void Send(string name,string message)
        {
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}