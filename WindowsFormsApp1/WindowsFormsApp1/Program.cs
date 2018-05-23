using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Timers;


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
            // Form 실행하기
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class vrbl
    {
        // 변수 선언 클래스
        static public int fds, uvs, temps, hums, count;
        static public bool started;
    }
    public class udpsockets
    {
          static void Main()
          {
            string fds, uvs, temps, hums;

            count:

            if (vrbl.count != 4)
            {
                // UdpClient 객체 성성
                UdpClient background = new UdpClient();


                // 데이타 수신
                IPEndPoint epRemote = new IPEndPoint(IPAddress.Any, 0);
                fds = Convert.ToString(background.Receive(ref epRemote)); // byte to string
                
                // UdpClient 닫기
                background.Close();
                vrbl.count++;
                goto count;
            }
            

        }
    }
}
