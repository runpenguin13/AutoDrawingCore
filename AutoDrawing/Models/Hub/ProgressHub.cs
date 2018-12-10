using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace AutoDrawing.Hubs
{
    public class ProgressHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        //public static void NotifyStart(string taskId)
        //{
        //    var hubContext = GlobalHost.ConnectionManager.GetHubContext<ProgressHub>();
        //    hubContext.Clients.Client(taskId).initProgressBar(taskId);
        //}
        //public static void NotifyProgress(string taskId, int percentage)
        //{
        //    var hubContext = GlobalHost.ConnectionManager.GetHubContext<ProgressHub>();
        //    hubContext.Clients.Client(taskId).updateProgressBar(taskId, percentage);
        //}
        //public static void NotifyProduce(string taskId, bool success, string name, string uri)
        //{
        //    var hubContext = GlobalHost.ConnectionManager.GetHubContext<ProgressHub>();
        //    hubContext.Clients.Client(taskId).notifyProduce(taskId, success, name, uri);
        //}
        //public static void NotifyEnd(string taskId)
        //{
        //    var hubContext = GlobalHost.ConnectionManager.GetHubContext<ProgressHub>();
        //    hubContext.Clients.Client(taskId).clearProgressBar(taskId);
        //}
    }
}