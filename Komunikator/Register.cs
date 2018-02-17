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
    public partial class Register : Form
    {
        public Client Client { get; private set; }

        public Register(Client client)
        {
            Client = client;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Password.Text == RepeatPassword.Text) {

                Dictionary<string, object> registerData = new Dictionary<string, object>();
                registerData.Add("action", "register");
                registerData.Add("login", Login.Text);
                registerData.Add("password", Password.Text);
                registerData.Add("password2", RepeatPassword.Text);

                Request registerRequest = new Request(Request.RequestType.Register, registerData);
                Response registerResponse = Client.SendRequest(registerRequest);

                if (registerResponse.Error != true)
                {
                    MessageBox.Show("Register ok. Log in.");
                    this.Hide();
                    Login frm1 = new Login(Client);
                    frm1.ShowDialog();
                }
                else {
                    MessageBox.Show(registerResponse.ErrorMessage);
                    Login.ResetText();
                    Password.ResetText();
                    RepeatPassword.ResetText();
                }
            }
            else {
                MessageBox.Show("Password aren't equal. Try again.");
                Password.ResetText();
                RepeatPassword.ResetText();
            }
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
