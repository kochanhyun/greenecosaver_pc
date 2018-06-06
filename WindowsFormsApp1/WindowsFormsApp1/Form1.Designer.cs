using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        
        private Label findust;
        private Label temperature;
        private Label humidity;
        public Label findusts;
        private Button button1;
        public Label uv;
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.findust = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.findusts = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.uv = new System.Windows.Forms.Label();
            this.uvs = new System.Windows.Forms.Label();
            this.temps = new System.Windows.Forms.Label();
            this.hums = new System.Windows.Forms.Label();
            this.fdc = new System.Windows.Forms.Label();
            this.uvc = new System.Windows.Forms.Label();
            this.tpc = new System.Windows.Forms.Label();
            this.hmc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // findust
            // 
            this.findust.AutoSize = true;
            this.findust.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.findust.Location = new System.Drawing.Point(55, 45);
            this.findust.Name = "findust";
            this.findust.Size = new System.Drawing.Size(111, 32);
            this.findust.TabIndex = 1;
            this.findust.Text = "미세먼지";
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.temperature.Location = new System.Drawing.Point(55, 163);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(63, 32);
            this.temperature.TabIndex = 3;
            this.temperature.Text = "온도";
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.humidity.Location = new System.Drawing.Point(55, 223);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(63, 32);
            this.humidity.TabIndex = 4;
            this.humidity.Text = "습도";
            // 
            // findusts
            // 
            this.findusts.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.findusts.Location = new System.Drawing.Point(178, 45);
            this.findusts.Name = "findusts";
            this.findusts.Size = new System.Drawing.Size(111, 32);
            this.findusts.TabIndex = 5;
            this.findusts.Text = "0";
            this.findusts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(64, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "값 갱신";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uv
            // 
            this.uv.AutoSize = true;
            this.uv.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uv.Location = new System.Drawing.Point(55, 103);
            this.uv.Name = "uv";
            this.uv.Size = new System.Drawing.Size(87, 32);
            this.uv.TabIndex = 2;
            this.uv.Text = "자외선";
            // 
            // uvs
            // 
            this.uvs.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uvs.Location = new System.Drawing.Point(178, 103);
            this.uvs.Name = "uvs";
            this.uvs.Size = new System.Drawing.Size(111, 32);
            this.uvs.TabIndex = 5;
            this.uvs.Text = "0";
            this.uvs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temps
            // 
            this.temps.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.temps.Location = new System.Drawing.Point(178, 163);
            this.temps.Name = "temps";
            this.temps.Size = new System.Drawing.Size(111, 32);
            this.temps.TabIndex = 5;
            this.temps.Text = "0";
            this.temps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hums
            // 
            this.hums.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hums.Location = new System.Drawing.Point(178, 223);
            this.hums.Name = "hums";
            this.hums.Size = new System.Drawing.Size(111, 32);
            this.hums.TabIndex = 5;
            this.hums.Text = "0";
            this.hums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fdc
            // 
            this.fdc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fdc.Location = new System.Drawing.Point(23, 52);
            this.fdc.Name = "fdc";
            this.fdc.Size = new System.Drawing.Size(16, 16);
            this.fdc.TabIndex = 14;
            // 
            // uvc
            // 
            this.uvc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.uvc.Location = new System.Drawing.Point(23, 110);
            this.uvc.Name = "uvc";
            this.uvc.Size = new System.Drawing.Size(16, 16);
            this.uvc.TabIndex = 14;
            // 
            // tpc
            // 
            this.tpc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tpc.Location = new System.Drawing.Point(23, 171);
            this.tpc.Name = "tpc";
            this.tpc.Size = new System.Drawing.Size(16, 16);
            this.tpc.TabIndex = 14;
            // 
            // hmc
            // 
            this.hmc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hmc.Location = new System.Drawing.Point(23, 232);
            this.hmc.Name = "hmc";
            this.hmc.Size = new System.Drawing.Size(16, 16);
            this.hmc.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 340);
            this.Controls.Add(this.hmc);
            this.Controls.Add(this.tpc);
            this.Controls.Add(this.uvc);
            this.Controls.Add(this.fdc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hums);
            this.Controls.Add(this.temps);
            this.Controls.Add(this.uvs);
            this.Controls.Add(this.findusts);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.uv);
            this.Controls.Add(this.findust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GreenEcoSaver_PC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Label uvs;
        public Label temps;
        public Label hums;
        private Label fdc;
        private Label uvc;
        private Label tpc;
        private Label hmc;
    }
}

