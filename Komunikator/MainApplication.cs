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
using Komunikator;
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
            GetMessages();
        }

        public void GetMessages()
        {
            Dictionary<string, object> getChatsData = new Dictionary<string, object>();
            getChatsData.Add("action", "get-chats");

            Request getChatsRequest = new Request(Request.RequestType.GetChats, getChatsData);
            Response getChatsResponse = Client.SendRequest(getChatsRequest);

            string chats = JsonConvert.SerializeObject(getChatsResponse.Data["Data"]);
            textBox2.Text = chats;
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> logoutData = new Dictionary<string, object>();
            logoutData.Add("action", "logout");

            Request logoutRequest = new Request(Request.RequestType.Logout, logoutData);
            Response logoutResponse = Client.SendRequest(logoutRequest);

            if (logoutResponse.Error != true)
            {
                MessageBox.Show("Logout.");
                this.Hide();
                Choose frm1 = new Choose(Client);
                frm1.ShowDialog();
            }
            else
            {
                MessageBox.Show(logoutResponse.ErrorMessage);
            }
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newChat_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox("Name",
                       "New chat",
                       "Default",
                       0,
                       0);
            string users = Microsoft.VisualBasic.Interaction.InputBox("Users",
                       "New chat",
                       "Default",
                       0,
                       0);

            Dictionary<string, object> newChatData = new Dictionary<string, object>();
            newChatData.Add("action", "create-chat");
            newChatData.Add("name", name);
            newChatData.Add("recipients", users.Split(' '));

            Request newChatRequest = new Request(Request.RequestType.NewChat, newChatData);
            Response newChatResponse = Client.SendRequest(newChatRequest);

            if (newChatResponse.Error != true)
            {
                MessageBox.Show("New chat created");
                GetMessages();
            }
            else
            {
                MessageBox.Show(newChatResponse.ErrorMessage);   
            }
        }

        private void Chat_Click(object sender, EventArgs e)
        {
            string chatId = Microsoft.VisualBasic.Interaction.InputBox("Chat id",
                       "Open chat",
                       "Default",
                       0,
                       0);
            Chat frm1 = new Chat(Client, chatId);
            frm1.ShowDialog();
        }

    }
}
