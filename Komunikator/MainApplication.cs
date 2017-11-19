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
    public partial class MainApplication : Form
    {
        Komunikator.Entities.User user;

        public MainApplication(string login, string pass)
        {
            InitializeComponent();
            user = new Komunikator.Entities.User(Komunikator.Properties.Request.getUserIdByName(login), login, pass);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Komunikator.Entities.Message message = new Komunikator.Entities.Message(user);
            message.setContent(textBox1.Text);

            textBox2.Text = "From me:";
            textBox2.Text = textBox2.Text + message.getContent();
            textBox2.Text = textBox2.Text + "Sending";
            textBox1.ResetText();
        }
    }
}
