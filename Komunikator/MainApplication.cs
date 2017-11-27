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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Communicator
{
    public partial class MainApplication : Form
    {
        public Client Client { get; private set; }

        public MainApplication(Client client)
        {
            Client = client;
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //textBox2.Text = "From me:";
            //textBox2.Text = textBox2.Text + textBox1.Text;
            //textBox2.Text = textBox2.Text + "Sending";
            //textBox1.ResetText();

            Dictionary<string, object> messageData = new Dictionary<string, object>();
            messageData.Add("message", textBox2.Text);

            Request sendMessageRequest = new Request(Request.RequestType.SendMessage, messageData);
            Response sendMessageResponse = Client.SendRequest(sendMessageRequest);

            if (sendMessageResponse.Error != true)
            {
                textBox2.Text = "From me:";
                textBox2.Text = textBox2.Text + textBox1.Text;
                textBox2.Text = textBox2.Text + "Sending";
                textBox1.ResetText();

                Dictionary<string, object> receiveMessageData = new Dictionary<string, object>();
                receiveMessageData.Add("ChatId", 2);

                Request getMessageRequest = new Request(Request.RequestType.GetMessage, receiveMessageData);
                Response getMessageResponse = Client.SendRequest(getMessageRequest);

                if (getMessageResponse.Error != true) {
                    //JToken data = JsonConvert.DeserializeObject<JObject>(getMessageResponse.Data);
                    textBox2.Text = textBox2.Text + "From responder:";
                    textBox2.Text = textBox2.Text + "MESSAGE";
                    textBox2.Text = textBox2.Text + "Received";
                }

            }
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //@SAJMON czy na logout też wysyłam ci request?
            MessageBox.Show("Logout.");
            this.Hide();
            Choose frm1 = new Choose(Client);
            frm1.ShowDialog();
        }
    }
}
