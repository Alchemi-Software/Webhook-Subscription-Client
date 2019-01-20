using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebhookClientCS
{
    public partial class Form1 : Form
    {
        private Timer timer1 = new Timer()
        {
            Enabled = true,
            Interval = 1000
        };
        int Counter = 0;
        
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += new System.EventHandler(Ticks);
            subLabel.Text = "Unsubscribed";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void URLButton_Click(object sender, EventArgs e)
        {
            toolbox.subscribedWebhook = textBox1.Text;
            if(textBox1.Text != null && textBox1.Text != "")
            {
                subLabel.Text = "Subscribed";
                ConsoleBox.AppendText("Subscribed to " + toolbox.subscribedWebhook + Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Enter a Webhook URL", "User Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void Ticks(object sender, EventArgs e)
        {
            //Counter++;
            if(subLabel.Text == "Subscribed")
            {
                Console.WriteLine("BigLol");
                toolbox.WebHook();
            }
            

        }

        public void addMessageToConsole(ReceivedMessage item)
        {
            ConsoleBox.AppendText(item.ToString() + Environment.NewLine);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CLSButton_Click(object sender, EventArgs e)
        {
            ConsoleBox.Clear();
        }

        private void unsubButton_Click(object sender, EventArgs e)
        {
            ConsoleBox.AppendText(Environment.NewLine + "Unsubscribed" + Environment.NewLine);
            toolbox.subscribedWebhook = "";
            subLabel.Text = "Unsubscribed";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
