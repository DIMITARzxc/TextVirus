using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusServer
{
    public partial class SendMenu : Form
    {
        public string Action;
        public bool moreThanOneParametr;
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
                    moreThanOneParametr = true;
                    break;
                default:
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
