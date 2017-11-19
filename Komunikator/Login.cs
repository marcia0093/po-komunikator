using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Komunikator.Model.Client;

namespace Komunikator
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
            loginData.Add("login", user_login.Text);
            loginData.Add("password", user_password.Text);

            Request loginRequest = new Request(Request.RequestType.Login, loginData);
            Response loginResponse = Client.SendRequest(loginRequest);

            Dictionary<string, object> responseData = loginResponse.Data;
           
            if ((bool) responseData["isValid"] == true)
            {
                MainApplication frm2 = new MainApplication(user_login.Text, user_password.Text);
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Niepoprawny login i/lub hasło!");
                user_password.ResetText();
                user_login.ResetText();
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
