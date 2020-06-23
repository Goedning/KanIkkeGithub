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
        Form1 f1;
        int index;
        public AlarmForm(Form1 f1, int index)
        {
            this.f1 = f1;
            this.index = index;
            InitializeComponent();
            timer1.Start();
            for (int i = 0; i < 24; i++) { comboBox1.Items.Add(string.Format("{0:0#:##}", i * 100)); }
            for (int i = 0; i < 60; i++) { comboBox2.Items.Add(string.Format("{0:0#}", i)); }
        }

        private void Done()
        {
            f1.listBox1.Items[index] = index;
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
    }
}
