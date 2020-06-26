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
            TimeSpan otherElapsed = this.StopWatch.Elapsed;
            listBox2.SelectedItem = string.Format("{00:00:00}", Math.Floor(otherElapsed.TotalSeconds));

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

        private void ResetStopUr(Object sender, EventArgs e)
        {
            StopWatch.Reset();
            label3.Text = "00:00:00:000";
            listView1.Items.Clear();
        }

        private void MarkerStopUr(Object sender, EventArgs e)
        {
            listView1.Items.Add(label3.Text);

        }

        private void StopUr_Click(object sender, EventArgs e)
        {
            // Intet at se her
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            // Intet at se her heller :/
        }

        private void StartTimerKnap(object sender, EventArgs e)
        {


            if (textBox1.Text == "")
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

            timer = new MyTimer(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));

            timer3.Start();
            timer.stopwatch.Start();


        }

        private void StopTimerKnap(object sender, EventArgs e)
        {
            timer3.Stop();
            timer.stopwatch.Stop();
        }

        MyTimer timer;
        private int index;

        private void Timer3_Tick(object sender, EventArgs e)
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

        private void TilføjAlarmKnap(object sender, EventArgs e)
        {

            listBox1.Items.Add("Alarm");

        }

        private void SletAlarmKnap(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
                listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
            else
            {
                MessageBox.Show("Ingen alarmer valgt til at slette :/ ");
            }
        }

        private void SletAlleAlarmerKnap(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
                listBox1.Items.Clear();
            else
            {
                MessageBox.Show("Der er ingen alarmer at slette :/ ");
            }
        }

        private void RedigerAlarmKnap(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
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
        { // Sætter alle vores værdier til vores combobox
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

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ViTilføjerTilVoresListeKnap(object sender, EventArgs e)
        {

            tidTilMineTimer = string.Format("{0:00}:{1:00}:{2:00}", Convert.ToInt32(comboBox1.Text), Convert.ToInt32(comboBox2.Text), Convert.ToInt32(comboBox3.Text));
            listBox2.Items.Add(tidTilMineTimer);
            MyTimer timer = new MyTimer(Convert.ToInt32(comboBox1.Text), Convert.ToInt32(comboBox2.Text), Convert.ToInt32(comboBox3.Text));
            myTimers.Add(timer);
        }

        private void SletTimer(object sender, EventArgs e) //sletter timer
        {
            if (listBox2.SelectedIndex > -1)
            {
                myTimers.RemoveAt(listBox2.SelectedIndex);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Ingen Timer valgt at slette ");
            }

        }

        List<MyTimer> myTimers = new List<MyTimer>();

        private void SætEnTimer(object sender, EventArgs e)
        {

            if (listBox2.SelectedIndex > -1)
            {
                // Giv en af timerne fra listbox2 en værdi

                tidTilMineTimer = string.Format("{0:00}:{1:00}:{2:00}", Convert.ToInt32(comboBox1.Text), Convert.ToInt32(comboBox2.Text), Convert.ToInt32(comboBox3.Text));
                listBox2.Items[listBox2.SelectedIndex] = tidTilMineTimer;
                MyTimer timer = new MyTimer(Convert.ToInt32(comboBox1.Text), Convert.ToInt32(comboBox2.Text), Convert.ToInt32(comboBox3.Text));
                myTimers[listBox2.SelectedIndex] = timer;
            }
            else
            {
                MessageBox.Show("Oh well :( ");
            }


        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabSider_Shown(object sender, EventArgs e)
        {

        }

        private void Timer4_Tick(object sender, EventArgs e)
        {



            RomerTal romer = new RomerTal();

            DateTime time = DateTime.Now;
            label14.Text = time.ToString();
            // Konvert vores sekunder, minutter og timer om til romer tal.
            label15.Text = $"{romer.NumberToRoman(DateTime.Now.Hour)}:{romer.NumberToRoman(DateTime.Now.Minute)}:{romer.NumberToRoman(DateTime.Now.Second)}";

        }

        private void StartTimerFraListeKnap(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                //MyTimer timer = new MyTimer(Convert.ToInt32(comboBox1.Text), Convert.ToInt32(comboBox2.Text), Convert.ToInt32(comboBox3.Text));
                //myTimers[listBox2.SelectedIndex] = timer;

                timer5.Start();
                myTimers[listBox2.SelectedIndex].stopwatch.Start();
            }

        }

        private void Timer5_Tick(object sender, EventArgs e)
        { //Hvordan vores Timer5 virker inde i vores listebox2
            for (int i = 0; i < myTimers.Count; i++)
            {
                listBox2.Items[i] = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", myTimers[i].Remaining.Hours, myTimers[i].Remaining.Minutes, myTimers[i].Remaining.Seconds, myTimers[i].Remaining.Milliseconds / 10);
                if (myTimers[i].ts < myTimers[i].stopwatch.Elapsed)
                {
                    //timer5.Stop();
                    timer.stopwatch.Reset();
                    MessageBox.Show("Tiden er gået");
                }

            }

        }
    }
}
