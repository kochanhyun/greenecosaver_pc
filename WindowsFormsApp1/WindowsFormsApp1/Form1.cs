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
            
            findusts.Text = Convert.ToString(vrbl.fds);
            uvs.Text = Convert.ToString(vrbl.uvs);
            temps.Text = Convert.ToString(vrbl.temps);
            hums.Text = Convert.ToString(vrbl.hums);
        }
    }
}
