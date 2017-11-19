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
            if (true)
            {
                MessageBox.Show("Rejestracja zakończona powodzeniem. Zaloguj się.");
                Login frm1 = new Login(Client);
                frm1.ShowDialog();
            }
            else {
                MessageBox.Show("Nieunikalny login, lub błąd przetwarzania na serwerze. Spróbuj ponownie.");
                register_login.ResetText();
                register_password.ResetText();
            }
        }
    }
}
