using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.findusts.Text = Convert.ToString(Program.fds);
            this.uvs.Text = Convert.ToString(Program.uvs);
            this.temps.Text = Convert.ToString(Program.temps);
            this.hums.Text = Convert.ToString(Program.hums);
        }
    }
}
