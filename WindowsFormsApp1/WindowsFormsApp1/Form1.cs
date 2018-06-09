using System;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Threading;


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
            this.findusts.Text = Convert.ToString(Program.fds);
            this.uvs.Text = Convert.ToString(Program.uvs);
            this.temps.Text = Convert.ToString(Program.temps);
            this.hums.Text = Convert.ToString(Program.hums);

            if (Program.fds < 30)
                this.fdc.BackColor = Color.Blue;
            else if (Program.fds < 80)
                this.fdc.BackColor = Color.Green;
            else if (Program.fds < 150)
                this.fdc.BackColor = Color.Orange;
            else if (Program.fds > 151)
                this.fdc.BackColor = Color.Red;


        }
        static public void udpsockets()
        {
            Console.WriteLine("Hello winform");
            //UdpClient 객체 성성
            UdpClient background = new UdpClient();
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);

            Console.WriteLine("콘솔 및 UDP 클라이언트 객체 생성 완료.");

            bugcatch:
            while (true)
            {
                try
                {
                    byte[] dgram = background.Receive(ref remoteEP);
                    Console.WriteLine("[Receive] {0} 로부터 {1} 바이트 수신", remoteEP.ToString(), dgram.Length);

                    Program.temps = dgram[0];
                    Program.hums = dgram[1];
                    Program.uvs = dgram[2];
                    Program.fds = dgram[3];


                    background.Send(dgram, dgram.Length, remoteEP);
                    Console.WriteLine("[Send] {0} 로 {1} 바이트 송신", remoteEP.ToString(), dgram.Length);
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
    }
}
