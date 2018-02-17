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
    public partial class Login : Form
    {
        public Client Client { get; private set; } 

        public Login(Client client)
        {
            Client = client;
            InitializeComponent();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dictionary<string, object> loginData = new Dictionary<string, object>();
            loginData.Add("action", "login");
            loginData.Add("login", user_login.Text);
            loginData.Add("password", user_password.Text);
            
            Request loginRequest = new Request(Request.RequestType.Login, loginData);
            Response loginResponse = Client.SendRequest(loginRequest);

            var responseData = loginResponse.Data;

            if (loginResponse.Error != true)
            {
                this.Hide();
                MainApplication frm2 = new MainApplication(Client);
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show(loginResponse.ErrorMessage);
                this.Hide();
                Login frm1 = new Login(Client);
                frm1.ShowDialog();
                user_password.ResetText();
                user_login.ResetText();
            }
            
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
