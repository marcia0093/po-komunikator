using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komunikator
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Komunikator.Properties.Request.register(register_login.Text, email.Text, register_password.Text))
            {
                MessageBox.Show("Rejestracja zakończona powodzeniem. Zaloguj się.");
                Login frm1 = new Login();
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
