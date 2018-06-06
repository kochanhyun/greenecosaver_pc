using System;
using System.Windows.Forms;
using System.Drawing;

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

            if (Program.fds < 30)
                this.fdc.BackColor = Color.Blue;
            else if(Program.fds < 80)
                this.fdc.BackColor = Color.Green;
            else if (Program.fds < 150)
                this.fdc.BackColor = Color.Orange;
            else if (Program.fds > 151)
                this.fdc.BackColor = Color.Red;


        }
    }
}
