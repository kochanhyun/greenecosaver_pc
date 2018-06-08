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

        public static void udp()
        {
            int[] vars = new int[4];
            // UdpClient 객체 성성
            UdpClient background = new UdpClient();
            Console.WriteLine("콘솔 및 UDP 클라이언트 객체 생성 완료.");

            udploof:
            try
            {
                // 데이타 수신
                IPEndPoint epRemote = new IPEndPoint(IPAddress.Any, 8888);

                vars[3] = Convert.ToChar(background.Receive(ref epRemote));
                Console.WriteLine("[Receive] {0} 로부터 {1} 수신", epRemote.ToString(), vars);
            }
            catch
            {
                goto udploof;
            }
            finally
            {
                background.Close();
                Program.temps = vars[0];
                Program.hums = vars[1];
                Program.uvs = vars[2];
                Program.fds = vars[3];
            }

        }
     }
}
