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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.findust = new System.Windows.Forms.Label();
            this.uv = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(250, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "센서 정보 가져오기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // findust
            // 
            this.findust.AutoSize = true;
            this.findust.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.findust.Location = new System.Drawing.Point(42, 132);
            this.findust.Name = "findust";
            this.findust.Size = new System.Drawing.Size(111, 32);
            this.findust.TabIndex = 1;
            this.findust.Text = "미세먼지";
            // 
            // uv
            // 
            this.uv.AutoSize = true;
            this.uv.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uv.Location = new System.Drawing.Point(244, 132);
            this.uv.Name = "uv";
            this.uv.Size = new System.Drawing.Size(87, 32);
            this.uv.TabIndex = 2;
            this.uv.Text = "자외선";
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.temperature.Location = new System.Drawing.Point(480, 132);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(63, 32);
            this.temperature.TabIndex = 3;
            this.temperature.Text = "온도";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(690, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "습도";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.uv);
            this.Controls.Add(this.findust);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label findust;
        private System.Windows.Forms.Label uv;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.Label label1;
    }
}

