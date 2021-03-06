﻿using System;
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
    public partial class Choose : Form
    {
        public Client Client { get; private set; }

        public Choose(Client client)
        {
            Client = client;
            InitializeComponent();
            if (Client.IsConnect != true)
            {
                MessageBox.Show("Can't connect to serwer. Rebbot aplication or contact with admin.");
                Login.Enabled = false;
                SignUp.Enabled = false;
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm1 = new Login(Client);
            frm1.ShowDialog();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register frm4 = new Register(Client);
            frm4.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application will be close");
            closeAll();
        }

        private void closeAll() {    
            Client.Close();
            Application.Exit();
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Application will be close");
            closeAll();
        }
    }
}
