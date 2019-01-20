using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebhookClientCS
{
    public class ReceivedMessage
    {
        public string Sender;
        public string Msg;
        public int number;
        public ReceivedMessage(string s, string m,int n)
        {
            Sender = s;
            Msg = m;
            number = n;
        }

        public string ToString()
        {
            return Environment.NewLine + "--Received From " + Sender + ": " + Environment.NewLine + Msg + Environment.NewLine;
        }
    }
}
