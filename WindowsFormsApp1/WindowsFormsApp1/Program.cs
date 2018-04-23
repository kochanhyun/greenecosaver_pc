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
            int PORT = 9999;

            string IP = "211.187.75.188";

            NetworkStream ns = null;
            StreamReader sr = null;
            TcpClient client = null;
        }
    }
}
