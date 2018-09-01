using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new Thread(new ThreadStart(udpsockets)).Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            findusts.Text = Program.fds + ("㎍");
            if (Program.fds == null)
                findusts.Text = "0";
            Int32.TryParse(Program.fds, out Program.fdi);
            if (Program.fdi <= 30)
            {
                findustcolor.BackColor = Color.Blue;
            } else if (Program.fdi <= 80) {
                findustcolor.BackColor = Color.Green;
            } else if (Program.fdi <= 150) {
                findustcolor.BackColor = Color.Orange;
            } else {
                findustcolor.BackColor = Color.Red;
            }
        }
        static public void udpsockets()
        {
            UdpClient background = new UdpClient(8888);

            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                bugcatch:
                try
                {
                    byte[] dgram = background.Receive(ref remoteEP);

                    Program.fds = Encoding.UTF8.GetString(dgram);

                    background.Send(dgram, dgram.Length, remoteEP);
                }
                catch 
                {
                    goto bugcatch;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
