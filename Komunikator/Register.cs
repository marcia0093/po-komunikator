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
            Dictionary<string, object> registerData = new Dictionary<string, object>();
            registerData.Add("login", register_login.Text);
            registerData.Add("password", register_password.Text);

            Request registerRequest = new Request(Request.RequestType.Register, registerData);
            Response registerResponse = Client.SendRequest(registerRequest);

            // Dictionary<string, object> responseData = loginResponse.Data; Odkomentowac po zmianie JToken na Dictionary w klasie Client
            var responseData = registerResponse.Data;

            if (registerResponse.Error != true)
            {
                MessageBox.Show("Rejestracja zakończona powodzeniem. Zaloguj się.");
                this.Hide();
                Login frm1 = new Login(Client);
                frm1.ShowDialog();
            }
            else {
                MessageBox.Show(registerResponse.ErrorMessage);
                register_login.ResetText();
                register_password.ResetText();
            }
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
