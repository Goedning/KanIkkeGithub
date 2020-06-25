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
using System.Security.Cryptography.X509Certificates;

namespace MultiUr
{
    
    public partial class TabSider : Form
    {
        public string tidTilMineTimer;


        public TabSider()
        {
            
            InitializeComponent();
            timer1.Start();

            Opdatering();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void DagsDato(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            this.TidNu.Text = time.ToString();
        }

        private void TidNu_Click(object sender, EventArgs e)
        {
            // De lukkede er tomme, nogle var skabt ved et uheld.
        }

        Stopwatch StopWatch = new Stopwatch();
        private void stopWatch(object sender, EventArgs e)
        {
            
            TimeSpan elapsed = this.StopWatch.Elapsed;
            label3.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds);


        }

        private void StartStopUr(Object sender, EventArgs e)
        {
            
            timer2.Start();
            StopWatch.Start();
        }

        private void StopStopUr(Object sender, EventArgs e)
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
        private int index;

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

        private void tilføjAlarmKnap(object sender, EventArgs e)
        {
            
            listBox1.Items.Add("Alarm");
        }

        private void sletAlarmKnap(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex > -1)
            listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
            else
            {
                MessageBox.Show("Ingen alarmer valgt til at slette :/ ");
            }
        }

        private void sletAlleAlarmerKnap(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
                listBox1.Items.Clear();
            else
            {
                MessageBox.Show("Der er ingen alarmer at slette :/ ");
            }
        }

        private void redigerAlarmKnap(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex > -1)
            {
                AlarmForm frm = new AlarmForm(this, listBox1, listBox1.SelectedIndex);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Vælg venligst en alarm :)");
            }
            
        }

        public void Opdatering()
        {
            for (int i = 0; i < 24; i++) { comboBox1.Items.Add(string.Format("{0:#}", i)); }

            for (int i = 0; i < 60; i++) { comboBox2.Items.Add(string.Format("{0:#}", i)); }

            for (int i = 0; i < 60; i++) { comboBox3.Items.Add(string.Format("{0:#}", i)); }

            if (comboBox1.Text == "")
            {
                comboBox1.Text = "00";
            }

            if (comboBox2.Text == "")
            {
                comboBox2.Text = "00";
            }

            if (comboBox3.Text == "")
            {
                comboBox3.Text = "00";
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Timer");
        }

        private void SletTimer(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
                listBox2.Items.Remove(listBox2.Items[listBox2.SelectedIndex]);
            else
            {
                MessageBox.Show("Ingen Timer valgt at slette ");
            }

        }

        private void SætEnTimer(object sender, EventArgs e)
        {

            if (listBox2.SelectedIndex > -1)
            {


                tidTilMineTimer = comboBox1.Text + ":" + comboBox2.Text + ":" + comboBox3.Text;
                listBox2.Items[index] = tidTilMineTimer;
                int selectedItem = listBox2.SelectedIndex;
                listBox2.Items.RemoveAt(index);
                listBox2.Items.Insert(index, tidTilMineTimer);
            }
            else
            {
                MessageBox.Show("Lele");
            }

            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabSider_Shown(object sender, EventArgs e)
        {
           
        }
       
        private void timer4_Tick(object sender, EventArgs e)
        {
            RomerTal romer = new RomerTal();

            DateTime time = DateTime.Now;
            label14.Text = time.ToString();

            romer.NumberToRoman(Convert.ToInt32(label15.Text));
                        
        }
    }
}
