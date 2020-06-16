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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Stop Ur")
            {
                groupBox2.Hide();
                groupBox1.Show();
            }
            else if (comboBox1.SelectedItem.ToString() == "Ned Tælling")
            { 
                groupBox1.Hide();
                groupBox2.Show();
                textBox1.Text = "00:00:00:000";
            }
                
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Start();
            label3.Text = textBox1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(label3.Text);
        }

        private void stopUr_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
