using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiUr
{
    public partial class AlarmForm : Form
    {
        bool alarmSet = false;

        public string selectedTime;
        string selectedSnooze;
        string snoozeTime;
        string txtTime;
        string selectedMessage;

        bool snoozeSet = false;


        Form1 f1;
        int index;
        public AlarmForm(Form1 f1, int index)
        {
            this.f1 = f1;
            this.index = index;

            InitializeComponent();
            timer1.Start();
            
            UpdateData();
        }

        private void AlarmForm_Shown(object sender, EventArgs e)
        {
            txtTime = comboBox1.Text + ":" + comboBox2.Text;
            txtTime = DateTime.Now.ToString(@"h:mm");

            if (alarmSet)
            {
                if(txtTime == selectedTime)
                {
                    alarmSet = false;
                    
                }
            }
            else if(snoozeSet)
            {
                if(txtTime == snoozeTime)
                {
                    snoozeSet = false;
                }
            }
            else if (snoozeSet)
            {
                if(txtTime != snoozeTime)
                {
                    snoozeSet = true;
                }
            }

        }

        private void Done()
        {
            f1.listBox1.Items[index] = index;
        }

        private void UpdateData()
        {
            // For time combobox
            for (int i = 0; i < 24; i++) { comboBox1.Items.Add(string.Format("{0:#:##}", i * 100)); }
            // For minutter combobox
            for (int i = 0; i < 60; i++) { comboBox2.Items.Add(string.Format("{0:0#}", i)); }

            comboBox3.Items.Add("1M");
            comboBox3.Items.Add("5M");
            comboBox3.Items.Add("10M");
            comboBox3.Items.Add("15M");
        }

        private void tidNuForm2(object sender, EventArgs e)
        {            
            // Jeg var et uheld.
        }

        private void dagsDatoForm2(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            tidNuForms2.Text = time.ToString();
        }
        
        private void timerICombobox(object sender, EventArgs e)
        {
            
        }

        private void minutterICombobox(object sender, EventArgs e)
        {

        }

        Form1 form1 = new Form1();
        public void lavAlarmKnap(object sender, EventArgs e)
        {
            selectedTime = comboBox1.Text + ":" + comboBox2.Text;
            selectedSnooze = comboBox3.Text;
            selectedMessage = textBox1.Text;

            if(form1.listBox1.SelectedIndex > -1)
                try
                {
                    int index = form1.listBox1.SelectedIndex;
                    form1.listBox1.Items.RemoveAt(index);
                    form1.listBox1.Items.Insert(index, selectedTime);
                }
                catch
                {

                }
            
        }

        private void beskedTilMigSelv(object sender, EventArgs e)
        {

        }



        public void Snooze()
        {
            DateTime dateTime = DateTime.Now;
            TimeSpan timeSpan = new TimeSpan(0, Convert.ToInt32(selectedSnooze), 0);
            snoozeTime = dateTime.Add(timeSpan).ToString("h:mm");

            snoozeSet = true;
        }


        public void Resume()
        {
            this.Close();
        }

    }
}
