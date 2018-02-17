using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Communicator.Model.Client;
using Newtonsoft.Json.Linq;

namespace Komunikator
{
    public partial class Chat : Form
    {
        public Client Client { get; private set; }
        public string ChatId { get; private set; }

        public Chat(Client client, string chatId)
        {
            Client = client;
            ChatId = chatId;
            InitializeComponent();
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            textBox2.Text = textBox2.Text + "From me:\r\n" ;
            textBox2.Text = textBox2.Text + textBox1.Text;
            textBox1.ResetText();

            Dictionary<string, object> sendMessageData = new Dictionary<string, object>();
            sendMessageData.Add("action", "send-message");
            sendMessageData.Add("message", message);
            sendMessageData.Add("chatId", ChatId);   

            Request sendMessRequest = new Request(Request.RequestType.SendMessage, sendMessageData);
            Response sendMessResponse = Client.SendRequest(sendMessRequest);

            if (sendMessResponse.Error != true)
            {
                textBox2.Text = textBox2.Text + "\r\nWysłano.";
            }
            else
            {
                MessageBox.Show(sendMessResponse.ErrorMessage);
            }
     
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> getMessageData = new Dictionary<string, object>();
            getMessageData.Add("action", "get-messages");
            getMessageData.Add("chatId", ChatId);
            getMessageData.Add("lastKnownMessageId", 1034);

            Request getMessRequest = new Request(Request.RequestType.GetNewMessage, getMessageData);
            Response getMessResponse = Client.SendRequest(getMessRequest);

            if (getMessResponse.Error != true)
            {
                object data = getMessResponse.Data["Data"];
                textBox2.Text = textBox2.Text + getMessResponse.Data.First();
            }
            else
            {
                MessageBox.Show(getMessResponse.ErrorMessage);
            }
        }
    }
}
