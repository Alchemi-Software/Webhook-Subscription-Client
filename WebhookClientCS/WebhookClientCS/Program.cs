using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;

namespace WebhookClientCS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            
            Application.Run(toolbox.form);
        }
    }

    public static class toolbox
    {
        public static Form1 form = new Form1();
        public static string subscribedWebhook;
        public static int latestMessageNumber = 0;



        public static async void WebHook()
        {
            if(subscribedWebhook != null && subscribedWebhook != "")
            {
                int receivedNumber;
                var getNumberResp = await (subscribedWebhook + "/latest/").GetAsync();
                Int32.TryParse(getNumberResp.Content.ReadAsStringAsync().Result, out receivedNumber);
                Console.WriteLine(receivedNumber);
                Console.WriteLine(latestMessageNumber);
                
                if(receivedNumber > latestMessageNumber)
                {
                    var getMsgResp = await (subscribedWebhook + "/message/").GetAsync();
                    Console.WriteLine(getMsgResp.Content.ReadAsStringAsync().Result);
                    ReceivedMessage msg = new ReceivedMessage(subscribedWebhook, getMsgResp.Content.ReadAsStringAsync().Result, receivedNumber);
                    form.addMessageToConsole(msg);
                    latestMessageNumber = receivedNumber;
                }

                
            }
            
            
        }

        

    }
}
