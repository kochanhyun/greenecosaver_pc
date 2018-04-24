using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;


namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class vrbl
    {
        static
        public int fds, uvs, temps, hums;
    }
    public class sockets
    {
        static void main()
        {
            string IP = "211.187.75.188";
            int PORT = 9999;
            NetworkStream NS = null;

            StreamReader SR = null;

            TcpClient client = null;


                client = new TcpClient(IP, PORT); //client 연결

                SR = new StreamReader(NS, Encoding.UTF8); // Get message

                string GetMessage = string.Empty;

                if (SR != null) SR.Close();

                if (client != null) client.Close();

        }
    }
}
