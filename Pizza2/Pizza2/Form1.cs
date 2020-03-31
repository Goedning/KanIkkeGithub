using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza2
{
    public partial class Form1 : Form
    {
        decimal Pris;
        decimal Størrelse;
        decimal Total;
        decimal Sovs;
        decimal Dej;
        decimal Kryderi;
        decimal Andet;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Størrelse = - 10;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Størrelse = 0;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Størrelse = 15;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            Dej = 0;
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            Dej = - 7;
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            Dej =  - 10;
        }

    }
}
