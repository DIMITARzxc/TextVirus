using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
namespace VirusServer
{
    public partial class Form1 : Form
    {
        public Thread refreshThread;
        public static Socket socket;
        public static List<Socket> ClientList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPHostEntry iPHostEntry =  Dns.Resolve(Dns.GetHostName());
            IPAddress adress =  iPHostEntry.AddressList[0];
            int port = 19132;
            IPEndPoint endPoint = new IPEndPoint(adress, port);
            socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(endPoint);
            refreshThread = new Thread(WaitForConnect);
            refreshThread.Start();
        }
        public  void WaitForConnect()
        {
            Socket client = socket.Accept();
            ClientList.Add(client);
            ClientTable.DataSource = ClientList;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            refreshThread.Abort();
        }

        private void ClientTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Socket current = ClientList[e.RowIndex];
        }
    }
}
