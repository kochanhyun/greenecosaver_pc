﻿namespace WindowsFormsApp1
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
            this.humidity = new System.Windows.Forms.Label();
            this.findusts = new System.Windows.Forms.Label();
            this.uvs = new System.Windows.Forms.Label();
            this.temps = new System.Windows.Forms.Label();
            this.hums = new System.Windows.Forms.Label();
            this.Findustb = new System.Windows.Forms.Label();
            this.uvb = new System.Windows.Forms.Label();
            this.tempb = new System.Windows.Forms.Label();
            this.humb = new System.Windows.Forms.Label();
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
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.humidity.Location = new System.Drawing.Point(690, 132);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(63, 32);
            this.humidity.TabIndex = 4;
            this.humidity.Text = "습도";
            // 
            // findusts
            // 
            this.findusts.AutoSize = true;
            this.findusts.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.findusts.Location = new System.Drawing.Point(42, 229);
            this.findusts.Name = "findusts";
            this.findusts.Size = new System.Drawing.Size(111, 32);
            this.findusts.TabIndex = 5;
            this.findusts.Text = "미세먼지";
            // 
            // uvs
            // 
            this.uvs.AutoSize = true;
            this.uvs.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uvs.Location = new System.Drawing.Point(244, 229);
            this.uvs.Name = "uvs";
            this.uvs.Size = new System.Drawing.Size(87, 32);
            this.uvs.TabIndex = 6;
            this.uvs.Text = "자외선";
            // 
            // temps
            // 
            this.temps.AutoSize = true;
            this.temps.Font = new System.Drawing.Font("Malgun Gothic", 18F);
            this.temps.Location = new System.Drawing.Point(480, 229);
            this.temps.Name = "temps";
            this.temps.Size = new System.Drawing.Size(63, 32);
            this.temps.TabIndex = 7;
            this.temps.Text = "온도";
            // 
            // hums
            // 
            this.hums.AutoSize = true;
            this.hums.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hums.Location = new System.Drawing.Point(690, 229);
            this.hums.Name = "hums";
            this.hums.Size = new System.Drawing.Size(63, 32);
            this.hums.TabIndex = 8;
            this.hums.Text = "습도";
            // 
            // Findustb
            // 
            this.Findustb.AutoSize = true;
            this.Findustb.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Findustb.Location = new System.Drawing.Point(61, 330);
            this.Findustb.Name = "Findustb";
            this.Findustb.Size = new System.Drawing.Size(63, 32);
            this.Findustb.TabIndex = 9;
            this.Findustb.Text = "좋음";
            // 
            // uvb
            // 
            this.uvb.AutoSize = true;
            this.uvb.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uvb.Location = new System.Drawing.Point(254, 330);
            this.uvb.Name = "uvb";
            this.uvb.Size = new System.Drawing.Size(63, 32);
            this.uvb.TabIndex = 10;
            this.uvb.Text = "좋음";
            // 
            // tempb
            // 
            this.tempb.AutoSize = true;
            this.tempb.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tempb.Location = new System.Drawing.Point(480, 330);
            this.tempb.Name = "tempb";
            this.tempb.Size = new System.Drawing.Size(63, 32);
            this.tempb.TabIndex = 11;
            this.tempb.Text = "좋음";
            // 
            // humb
            // 
            this.humb.AutoSize = true;
            this.humb.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.humb.Location = new System.Drawing.Point(690, 330);
            this.humb.Name = "humb";
            this.humb.Size = new System.Drawing.Size(63, 32);
            this.humb.TabIndex = 12;
            this.humb.Text = "좋음";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.humb);
            this.Controls.Add(this.tempb);
            this.Controls.Add(this.uvb);
            this.Controls.Add(this.Findustb);
            this.Controls.Add(this.hums);
            this.Controls.Add(this.temps);
            this.Controls.Add(this.uvs);
            this.Controls.Add(this.findusts);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.uv);
            this.Controls.Add(this.findust);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "  ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label findust;
        private System.Windows.Forms.Label uv;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label findusts;
        private System.Windows.Forms.Label uvs;
        private System.Windows.Forms.Label temps;
        private System.Windows.Forms.Label hums;
        private System.Windows.Forms.Label Findustb;
        private System.Windows.Forms.Label uvb;
        private System.Windows.Forms.Label tempb;
        private System.Windows.Forms.Label humb;
    }
}

