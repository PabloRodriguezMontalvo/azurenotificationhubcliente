using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.NotificationHubs;

namespace TestNot
{
    class Program
    {
        static void Main(string[] args)
        {
            SendNotificationAsync();
            Console.ReadLine();
        }

        private static async void SendNotificationAsync()
        {
            var t = new List<String>() { "Usuario:" + 77 };
            NotificationHubClient hub = NotificationHubClient
                .CreateClientFromConnectionString("Endpoint=sb://testnh2-ns.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=5Sot8Cy4PRmSzjYR4BBxAded6FALlJN0sDc+Nl62nXQ=", "testnh");
            var toast = @"<toast><visual><binding template=""ToastText01""><text id=""1"">Hello from a .NET App!</text></binding></visual></toast>";
          var r=  await hub.SendWindowsNativeNotificationAsync(toast,t);

            var x = r.Results;
        }
    }
}
