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
        string message;

        public VækkeUr(AlarmForm f, string message)
        {
            InitializeComponent();
            form = f;
            this.message = message;
        }

        private void snoozeKnap(object sender, EventArgs e)
        {
            form.Snooze();
            this.Close();
        }

        private void OkKnap(object sender, EventArgs e)
        {
            this.Close();
            form.Resume();
        }

        public void VækkeUr_Shown(object sender, EventArgs e)
        {
            richTextBox1.Text = message;
        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
