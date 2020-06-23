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
    public partial class VækkeUr : Form
    {

        static AlarmForm form;
        string _message;

        public VækkeUr(AlarmForm f)
        {
            InitializeComponent();
            form = f;
        }

        public void message(string message)
        {
            _message = message;
        }

        private void snoozeKnap(object sender, EventArgs e)
        {
            form.Snooze();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Resume();
        }

        public void VækkeUr_Shown(object sender, EventArgs e)
        {
            richTextBox1.Text = _message;
        }
    }
}
