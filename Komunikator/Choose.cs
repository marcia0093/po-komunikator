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
    public partial class Choose : Form
    {
        public Client Client { get; private set; }

        public Choose(Client client)
        {
            Client = client;
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Login frm1 = new Login(Client);
            frm1.ShowDialog();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            Register frm4 = new Register(Client);
            frm4.ShowDialog();
        }
    }
}
