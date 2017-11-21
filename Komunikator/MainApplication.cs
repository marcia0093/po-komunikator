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
            }
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
