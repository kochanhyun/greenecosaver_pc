using System;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;
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
            
            // (1) UdpClient 객체 성성. 포트 7777 에서 Listening
            UdpClient background = new UdpClient(8888);

            // 클라이언트 IP를 담을 변수
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 0);

            while (true)
            {
                bugcatch:
                try
                {
                    byte[] dgram = background.Receive(ref remoteEP);
                    Console.WriteLine("[Receive] {0} 로부터 {1} 바이트 수신", remoteEP.ToString(), dgram.Length);

                    // 이거만 하면 끝이당
                    Program.sgram = Encoding.UTF8.GetString(dgram);
                    Program.fds = Int32.Parse(Program.sgram.Substring(0, 2));
                    Program.uvs = Int32.Parse(Program.sgram.Substring(2, 2));
                    Program.temps = Int32.Parse(Program.sgram.Substring(4, 2));
                    Program.hums = Int32.Parse(Program.sgram.Substring(6, 2));

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
