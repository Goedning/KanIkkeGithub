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


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            this.TidNu.Text = time.ToString();
        }

        private void TidNu_Click(object sender, EventArgs e)
        {

        }

        Stopwatch StopWatch = new Stopwatch();
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            
            TimeSpan elapsed = this.StopWatch.Elapsed;
            label3.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds);


        }

        private void button1_Click(Object sender, EventArgs e)
        {
            
            timer2.Start();
            StopWatch.Start();
        }

        private void button2_Click(Object sender, EventArgs e)
        {
            timer2.Stop();
            StopWatch.Stop();
        }

        private void button3_Click(Object sender, EventArgs e)
        {
            StopWatch.Reset();
            label3.Text = "00:00:00:000";
            listView1.Items.Clear();
        }

        private void button4_Click(Object sender, EventArgs e)
        {
            listView1.Items.Add(label3.Text);

        }


    }
}
