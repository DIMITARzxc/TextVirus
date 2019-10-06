using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace VirusServer
{
    public partial class SendMenu : Form
    {
        public string Action;
        public bool moreThanOneParametr;
        public Socket socket;
        public SendMenu()
        {
            InitializeComponent();
        }

        private void SendMenu_Load(object sender, EventArgs e)
        {
            switch (Action)
            {
                case "Create":
                    FirstParametrLabel.Text = "Path";
                    moreThanOneParametr = false;
                    break;
                case "Delete":
                    FirstParametrLabel.Text = "Path";
                    moreThanOneParametr = false;
                    break;
                case "Rename":
                    FirstParametrLabel.Text = "Path";
                    SecondParametrLabel.Text = "Name";
                    moreThanOneParametr = true;
                    break;
                default:
                    break;
            }
            if (!moreThanOneParametr)
            {
                SecondParametrLabel.Hide();
                SecondParametrTextBox.Hide();
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string command = Action.ToLower();
            string request = command + "|"+FirstParametrTextBox.Text+"|"+ SecondParametrTextBox.Text;
            byte[] buffer = Encoding.UTF8.GetBytes(request);
            socket.Send(buffer);
        }
    }
}
