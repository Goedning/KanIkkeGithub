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
        bool alarmSet = true;

        public string selectedTime;
        string selectedSnooze;
        string snoozeTime;
        string txtTime;
        string selectedMessage;

        bool snoozeSet = false;

        
        TabSider f1;
        int index;
        ListBox lb;
        public AlarmForm(TabSider f1, ListBox lb, int index)
        {
            this.f1 = f1;
            this.index = index;
            this.lb = lb;

            InitializeComponent();
            timer1.Start();
            
            UpdateData();
        }



        string message;

        TabSider form1 = new TabSider();
        public void lavAlarmKnap(object sender, EventArgs e)
        {
            selectedTime = comboBox1.Text + ":" + comboBox2.Text; //Her sætter vi de mange forskellige værdier og sætter vores alarm
            selectedSnooze = comboBox3.Text;
            selectedMessage = textBox1.Text;

            alarmSet = true;

            message = textBox1.Text;
            lb.Items[index] = selectedTime;


        }

        private void AlarmForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void AlarmForm_Shown(object sender, EventArgs e)
        {            
            

        }

        private void Done()
        {
            f1.listBox1.Items[index] = index;
        }

        public void UpdateData()
        {
            // For time combobox
            for (int i = 0; i < 24; i++) { comboBox1.Items.Add(string.Format("{0:#}", i )); }
            // For minutter combobox
            for (int i = 0; i < 60; i++) { comboBox2.Items.Add(string.Format("{0:0#}", i)); }

            comboBox3.Items.Add("1");
            comboBox3.Items.Add("5");
            comboBox3.Items.Add("10");
            comboBox3.Items.Add("15");
        }

        public void TidNuForm2(object sender, EventArgs e)
        {            
            // Jeg er et label
        }

        public void timerIForms2(object sender, EventArgs e)        
        {
            DateTime time = DateTime.Now;
            tidNuForms2.Text = time.ToString();
            txtTime = DateTime.Now.ToString("h:mm");

            if (alarmSet)
            {
                if (txtTime == selectedTime)
                {
                    VækkeUr vækkeur = new VækkeUr(this, message); //Vækkeur pop up, når tiden vi har valgt er = DateTime.Now, eller txtTime som jeg har valgt at bruge
                    vækkeur.Show();
                    alarmSet = false;
                }
            }
            else if (snoozeSet)
            {
                if (txtTime == snoozeTime)
                {
                    VækkeUr vækkeur = new VækkeUr(this, message);
                    vækkeur.Show();
                    snoozeSet = false;
                }
            }

        }
        
        private void timerICombobox(object sender, EventArgs e)
        {
            
        }

        private void minutterICombobox(object sender, EventArgs e)
        {

        }

        private void beskedTilMigSelv(object sender, EventArgs e)
        {
            
        }



        public void Snooze()
        { //I Snooze laver vi en ny timespan hvor vi lægger mere tid i vores alarm (Jeg skal arbejde på mine beskrivelser)
            DateTime dateTime = DateTime.Now;
            TimeSpan timeSpan = new TimeSpan(0, Convert.ToInt32(selectedSnooze), 0);
            snoozeTime = dateTime.Add(timeSpan).ToString("h:mm");

            snoozeSet = true;
        }        
        public void Resume()
        {

        }


        
    }
}
