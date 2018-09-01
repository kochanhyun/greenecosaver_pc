using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{


    static class Program
    {
        // 변수 선언
        static public string fds;
        static public int fdi;

        /// <summary>
        /// The main entry point for thes application.
        /// </summary>
        static void Main()
        {
            // Form 실행하기
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
