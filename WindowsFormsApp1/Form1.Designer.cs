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
        public Label findusts;
        private Button button1;
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.findust = new System.Windows.Forms.Label();
            this.findusts = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.findustcolor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // findust
            // 
            this.findust.AutoSize = true;
            this.findust.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.findust.Location = new System.Drawing.Point(45, 52);
            this.findust.Name = "findust";
            this.findust.Size = new System.Drawing.Size(111, 32);
            this.findust.TabIndex = 1;
            this.findust.Text = "미세먼지";
            // 
            // findusts
            // 
            this.findusts.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.findusts.Location = new System.Drawing.Point(177, 52);
            this.findusts.Name = "findusts";
            this.findusts.Size = new System.Drawing.Size(91, 32);
            this.findusts.TabIndex = 5;
            this.findusts.Text = "0";
            this.findusts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(291, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "갱신";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // findustcolor
            // 
            this.findustcolor.Location = new System.Drawing.Point(16, 58);
            this.findustcolor.Name = "findustcolor";
            this.findustcolor.Size = new System.Drawing.Size(23, 21);
            this.findustcolor.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 136);
            this.Controls.Add(this.findustcolor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.findusts);
            this.Controls.Add(this.findust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GreenEcoSaver_PC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox findustcolor;
    }
}

