using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApp1
{


    static class Program
    {
        // 변수 선언
        static public int fds, uvs, temps, hums;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            // Form 실행하기
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Udpsockets
    {
        static char[] vars;

        public static void udp()
        {

            // UdpClient 객체 성성
            UdpClient background = new UdpClient();

            try
            {
                // 데이타 수신
                IPEndPoint epRemote = new IPEndPoint(IPAddress.Any, 8888);

                vars[10] = Convert.ToChar(background.Receive(ref epRemote));
            }
            finally
            {
                background.Close();
                After();
            }

        }

        static void After()
        {
            WindowsFormsApp1.Program.temps = vars[0] + vars[1];
            WindowsFormsApp1.Program.hums = vars[2] + vars[3];
            WindowsFormsApp1.Program.uvs = vars[4] + vars[5];
            WindowsFormsApp1.Program.fds = vars[6] + vars[7];

            udp();
        }
     }
}
