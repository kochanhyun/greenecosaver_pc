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
        static public int fds, uvs, temps, hums;
        static public bool started;

        static void Main()
        {
            Udpsockets.main();
        }
    }
    public class Udpsockets
    {
        static char[] vars;

        public static void main()
        {

            // UdpClient 객체 성성
            UdpClient background = new UdpClient();


            // 데이타 수신
            IPEndPoint epRemote = new IPEndPoint(IPAddress.Any, 8888);

            vars[10] = Convert.ToChar(background.Receive(ref epRemote));

            background.Close();

            After();
        }

        static void After()
        {
            vrbl.temps = vars[0] + vars[1];
            vrbl.hums = vars[2] + vars[3];
            vrbl.uvs = vars[4] + vars[5];
            vrbl.fds = vars[6] + vars[7];

            //Form1.Text\(Convert.ToString(vrbl.fds));
            main();
        }
     }
}
