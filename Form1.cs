using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using ThreadSafe.CrossThreading;

namespace SpeakTimer
{
    public partial class Form1 : Form
    {
        int Point1 = 0;
        int Point2 = 0;
        public System.Windows.Forms.Timer _SpeakCounter = new System.Windows.Forms.Timer();
        public Stopwatch _SpeakStopWatch = new Stopwatch();
        public TimeSpan _SpeakTimeSpan;
        public BackgroundWorker backgroundWorker1 = new BackgroundWorker();
         public Form1()

        {
            InitializeComponent();
            _SpeakCounter.Tick += new EventHandler(_SpeakCounter_Tick);
            this.Icon = SpeakTimer.Properties.Resources.flat_clock;
            this.textBox1.BackColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
            this.textBox1.ForeColor = Color.FromKnownColor(KnownColor.ControlLightLight);
            this.textBox1.BorderStyle = BorderStyle.FixedSingle;
            this.textBox1.TextAlign = HorizontalAlignment.Center;
            this.textBox1.MouseDown += new MouseEventHandler(textBox1_MouseDown);
            this.textBox1.MouseLeave += new EventHandler(textBox1_MouseLeave);
             //
            this.textBox2.BackColor = Color.FromKnownColor(KnownColor.ControlDarkDark);
            this.textBox2.ForeColor = Color.FromKnownColor(KnownColor.ControlLightLight);
            this.textBox2.BorderStyle = BorderStyle.FixedSingle;
            this.textBox2.TextAlign = HorizontalAlignment.Center;
            this.textBox2.MouseDown += new MouseEventHandler(textBox2_MouseDown);
            this.textBox2.MouseLeave += new EventHandler(textBox2_MouseLeave);
            //
            person1point.Text = Convert.ToString(Point1);
            //
            person2count.Text = Convert.ToString(Point2);
            //
            this.Text = "Live Talk Counter - Speak Timer";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimizeBox = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.FromKnownColor(KnownColor.ControlLightLight);
            this.timeCounter.TabIndex = 0;
            this.person1point.TabIndex = 1;
            this.person2count.TabIndex = 2;
            this.textBox1.TabIndex = 3;
            this.textBox2.TabIndex = 4;
            this.button1.TabIndex = 5;
            this.button2.TabIndex = 6;
            this.startTimeBTN.TabIndex = 7;
            this.textBox1.Text = "Enter Debator 1 Name...";
            this.textBox2.Text = "Enter Debator 2 Name...";
            this.timeCounter.Text = _SpeakStopWatch.Elapsed.TotalMilliseconds.ToString();
            this.maxtime.Text = "00:02:00.00";
             //
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted); //Tell the user how the process went
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true; //Allow for the process to be cancelled
            backgroundWorker1.Disposed += new EventHandler(backgroundWorker1_Disposed);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
             //


            }

         void textBox2_MouseLeave(object sender, EventArgs e)
         {
             if (textBox2.Text == "")
             {
                 this.textBox2.Text = "Enter Debator 2 Name...";
             }
         }

         void textBox1_MouseLeave(object sender, EventArgs e)
         {
             if (textBox1.Text == "")
             {
                 this.textBox1.Text = "Enter Debator 1 Name...";
             }
         }

         void textBox2_MouseDown(object sender, MouseEventArgs e)
         {
             textBox2.Clear();
         }

         void textBox1_MouseDown(object sender, MouseEventArgs e)
         {
             textBox1.Clear();
         }

         void backgroundWorker1_Disposed(object sender, EventArgs e)
         {
             _SpeakStopWatch.Stop();
         }

         void Form1_FormClosing(object sender, FormClosingEventArgs e)
         {
             Application.Exit();
         }

         void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
         {
             if (e.Cancelled)
             {
                 //MessageBox.Show("Process was cancelled");
                 _SpeakStopWatch.Reset();
                 UpdateScreen("00:00:00.00", _SpeakStopWatch);
                 
             }
             else if (e.Error != null)
             {
                 MessageBox.Show("There was an error running the process. The thread aborted");
             }
             else
             {
                 //MessageBox.Show("Process was completed");
             }
         }

         void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
         {
             //throw new NotImplementedException();
         }

         void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
         {
             for (int i = 0; i < 100; i++)
             {
                 // put program here...
                 //Thread.Sleep(1000);
                 while (true)
                 {
                     StartCounting(_SpeakStopWatch);

                     backgroundWorker1.ReportProgress(i);


                     //Check if there is a request to cancel the process
                     if (backgroundWorker1.CancellationPending)
                     {
                         e.Cancel = true;
                         backgroundWorker1.ReportProgress(0);
                         return;
                     }
                 }
             }
             //If the process exits the loop, ensure that progress is set to 100%
             //Remember in the loop we set i < 100 so in theory the process will complete at 99%
             backgroundWorker1.ReportProgress(100);
         }

         void _SpeakCounter_Tick(object sender, EventArgs e)
         {
             // after 120s stop and show message.

            

         }

        private void button1_Click(object sender, EventArgs e)
        {
            // add point to person 1
            Point1++;
            person1point.Text = Convert.ToString(Point1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point2++;
            person2count.Text = Convert.ToString(Point2);
        }
        
        private void StartCounting(Stopwatch _SW)
        {

            _SW.Start();



            if (_SW.IsRunning)
            {
                _SpeakTimeSpan = _SW.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", _SpeakTimeSpan.Hours, _SpeakTimeSpan.Minutes, _SpeakTimeSpan.Seconds, _SpeakTimeSpan.Milliseconds / 10);
                
                UpdateScreen(elapsedTime, _SW);

 
                             
                        
                
            }
           

        }
        
        private void UpdateScreen(string _updateString, Stopwatch _SSW)        
        {

            // auto reset text.
            if (timeCounter.Text.Contains("00:02:00.00"))
            {
                backgroundWorker1.CancelAsync();
                _SpeakStopWatch.Stop();
                string _updateString1 = "00:00:00.00";
                CrossThreadText.SetText(this, timeCounter, _updateString1);
                //MessageBox.Show("Timer Finished: Next Speaker.");
                
                
            }
            CrossThreadText.SetText(this, timeCounter, _updateString);
           
            
           //timeCounter.Text = _updateString;
            
        }   

        private void startTimeBTN_Click(object sender, EventArgs e)
        {
            // start counting and updating ms.

            
            backgroundWorker1.RunWorkerAsync();




            //UpdateScreen(10, _SpeakStopWatch.Elapsed.Hours,  _SpeakStopWatch.Elapsed.Minutes, _SpeakStopWatch.Elapsed.Seconds, _SpeakStopWatch.Elapsed.Milliseconds);
            //_SpeakStopWatch.Start();

            //if (_SpeakStopWatch.IsRunning)
            //{
            //    while (true)
            //    {
                    //timeCounter.Text = Convert.ToString(_SpeakStopWatch.ElapsedTicks);
            //    }
            //}
        }

        private void stopTimeBTN_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                backgroundWorker1.Dispose();
            }


        }
    }
}
