using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChattingAppAsp.NetCoreSignalR.HubConfig
{
    public class MyHub : Hub
    {
        public async Task askServer(string somethingTextFromClient)
        {
            string tempString = "";
            if (somethingTextFromClient == "hey")
            {
                tempString = "message was 'hey'";
            }
            else
            {
                tempString = "message was something else";
            }
            await Clients.Client(this.Context.ConnectionId).SendAsync("askServerResponse", tempString);
        }
    }
}
