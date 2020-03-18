namespace SpeakTimer
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
            this.maxtime = new System.Windows.Forms.Label();
            this.timeCounter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.person1point = new System.Windows.Forms.Label();
            this.person2count = new System.Windows.Forms.Label();
            this.startTimeBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maxtime
            // 
            this.maxtime.BackColor = System.Drawing.SystemColors.ControlDark;
            this.maxtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxtime.Font = new System.Drawing.Font("Arial", 20F);
            this.maxtime.Location = new System.Drawing.Point(11, 9);
            this.maxtime.Name = "maxtime";
            this.maxtime.Size = new System.Drawing.Size(372, 53);
            this.maxtime.TabIndex = 0;
            this.maxtime.Text = "00:00:02:00";
            this.maxtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeCounter
            // 
            this.timeCounter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.timeCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeCounter.Font = new System.Drawing.Font("Arial", 20F);
            this.timeCounter.Location = new System.Drawing.Point(12, 157);
            this.timeCounter.Name = "timeCounter";
            this.timeCounter.Size = new System.Drawing.Size(371, 46);
            this.timeCounter.TabIndex = 0;
            this.timeCounter.Text = "00:00";
            this.timeCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Point";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Point";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // person1point
            // 
            this.person1point.BackColor = System.Drawing.SystemColors.ControlDark;
            this.person1point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.person1point.Font = new System.Drawing.Font("Arial", 20F);
            this.person1point.Location = new System.Drawing.Point(12, 89);
            this.person1point.Name = "person1point";
            this.person1point.Size = new System.Drawing.Size(183, 39);
            this.person1point.TabIndex = 0;
            this.person1point.Text = "0";
            this.person1point.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // person2count
            // 
            this.person2count.BackColor = System.Drawing.SystemColors.ControlDark;
            this.person2count.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.person2count.Font = new System.Drawing.Font("Arial", 20F);
            this.person2count.Location = new System.Drawing.Point(201, 89);
            this.person2count.Name = "person2count";
            this.person2count.Size = new System.Drawing.Size(183, 39);
            this.person2count.TabIndex = 0;
            this.person2count.Text = "0";
            this.person2count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startTimeBTN
            // 
            this.startTimeBTN.Location = new System.Drawing.Point(11, 206);
            this.startTimeBTN.Name = "startTimeBTN";
            this.startTimeBTN.Size = new System.Drawing.Size(184, 36);
            this.startTimeBTN.TabIndex = 2;
            this.startTimeBTN.Text = "Start Speaking Time!";
            this.startTimeBTN.UseVisualStyleBackColor = true;
            this.startTimeBTN.Click += new System.EventHandler(this.startTimeBTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(201, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(199, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Stop Time!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.stopTimeBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 253);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.startTimeBTN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.person2count);
            this.Controls.Add(this.person1point);
            this.Controls.Add(this.timeCounter);
            this.Controls.Add(this.maxtime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label maxtime;
        private System.Windows.Forms.Label timeCounter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label person1point;
        private System.Windows.Forms.Label person2count;
        private System.Windows.Forms.Button startTimeBTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
    }
}

