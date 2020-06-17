using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MultiUr
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }


        private void dagsDato(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            this.TidNu.Text = time.ToString();
        }

        private void TidNu_Click(object sender, EventArgs e)
        {

        }

        Stopwatch StopWatch = new Stopwatch();
        private void stopWatch(object sender, EventArgs e)
        {
            
            TimeSpan elapsed = this.StopWatch.Elapsed;
            label3.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds);


        }

        private void startStopUr(Object sender, EventArgs e)
        {
            
            timer2.Start();
            StopWatch.Start();
        }

        private void stopStopUr(Object sender, EventArgs e)
        {
            timer2.Stop();
            StopWatch.Stop();
        }

        private void resetStopUr(Object sender, EventArgs e)
        {
            StopWatch.Reset();
            label3.Text = "00:00:00:000";
            listView1.Items.Clear();
        }

        private void markerStopUr(Object sender, EventArgs e)
        {           
            listView1.Items.Add(label3.Text);            
            
        }
       
        private void stopUr_Click(object sender, EventArgs e)
        {
            // Intet at se her
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Intet at se her heller :/
        }

        private void startTimerKnap(object sender, EventArgs e)
        {
           

            if(textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }

            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }

            timer = new Timer(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));

            timer3.Start();
            timer.stopwatch.Start();


        }

        private void stopTimerKnap(object sender, EventArgs e)
        {
            timer3.Stop();
            timer.stopwatch.Stop();
        }

        Timer timer;
        
        private void timer3_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = timer.ts - timer.stopwatch.Elapsed;

            if (timer.ts < timer.stopwatch.Elapsed)
            {
                timer3.Stop();
                timer.stopwatch.Reset();
                MessageBox.Show("Tiden er gået");
            }
            
            label4.Text = ts.Hours.ToString();
            label5.Text = ts.Minutes.ToString();
            label6.Text = ts.Seconds.ToString();


        }
    }
}
