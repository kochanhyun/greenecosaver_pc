using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

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
            findusts.Text = Convert.ToString(Program.fds);
            temps.Text = Convert.ToString(Program.temps);
            hums.Text = Convert.ToString(Program.hums);
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

                    Program.sgram = Encoding.UTF8.GetString(dgram);
                    Program.temps = Int32.Parse(Program.sgram.Substring(0, 2));
                    Program.hums = Int32.Parse(Program.sgram.Substring(2, 2));
                    Program.fds = Int32.Parse(Program.sgram.Substring(4, 3));

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
