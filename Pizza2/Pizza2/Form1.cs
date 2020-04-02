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

        private void checkBox1_CheckChanged(object sender, EventArgs e)
        {
            Størrelse = 40;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            if (checkBox1.Checked)
            {
                Total = Størrelse + Dej + Sovs + Kryderi + Andet;
                Total.ToString();
                textBox1.Text = Total.ToString();
            }
        }

        private void checkBox2_CheckChanged(object sender, EventArgs e)
        {
            Størrelse = 50;
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            if (checkBox2.Checked)
            {
                Total = Størrelse + Dej + Sovs + Kryderi + Andet;
                Total.ToString();
                textBox1.Text = Total.ToString();
            }
        }

        private void checkBox3_CheckChanged(object sender, EventArgs e)
        {
            Størrelse = 60;
            checkBox2.Checked = false;
            checkBox1.Checked = false; // Når vi skifter kræve det et dobbeltklik, find fejlen senere!
            if (checkBox3.Checked)
            {
                Total = Størrelse + Dej + Sovs + Kryderi + Andet;
                Total.ToString();
                textBox1.Text = Total.ToString();
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            Dej = 0;
            if (checkBox16.Checked)
            {
                Total = Størrelse + Dej + Sovs + Kryderi + Andet;
                Total.ToString();
                textBox1.Text = Total.ToString();
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            Dej = - 5;
            if (checkBox17.Checked)
            {
                Total = Størrelse + Dej + Sovs + Kryderi + Andet;
                Total.ToString();
                textBox1.Text = Total.ToString();
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            Dej =  - 8;
            if (checkBox18.Checked)
            {
                Total = Størrelse + Dej + Sovs + Kryderi + Andet;
                Total.ToString();
                textBox1.Text = Total.ToString();
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            Sovs = 0;
            if (checkBox8.Checked)
            {
                Total = Størrelse + Dej + Sovs + Kryderi + Andet;
                Total.ToString();
                textBox1.Text = Total.ToString();
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            Sovs = 15;
            if (checkBox9.Checked)
            {
                Total = Størrelse + Dej + Sovs + Kryderi + Andet;
                Total.ToString();
                textBox1.Text = Total.ToString();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Sovs = -5;
            if (checkBox7.Checked)
            {
                Total = Størrelse + Dej + Sovs + Kryderi + Andet;
                Total.ToString();
                textBox1.Text = Total.ToString();
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            Kryderi = 5;
            if (checkBox11.Checked)
            {
                Total = Størrelse + Dej + Sovs + Kryderi + Andet;
                Total.ToString();
                textBox1.Text = Total.ToString();
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            Kryderi = 11;
            if (checkBox12.Checked)
            {
                Total = Størrelse + Dej + Sovs + Kryderi + Andet;
                Total.ToString();
                textBox1.Text = Total.ToString();
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            Kryderi = -4;
            if (checkBox10.Checked)
            {
                Total = Størrelse + Dej + Sovs + Kryderi + Andet;
                Total.ToString();
                textBox1.Text = Total.ToString();
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            Andet = 10;
            if (checkBox14.Checked)
            {
                Total = Størrelse + Dej + Sovs + Kryderi + Andet;
                Total.ToString();
                textBox1.Text = Total.ToString();
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            Andet = - 10;
            if (checkBox15.Checked)
            {
                Total = Størrelse + Dej + Sovs + Kryderi + Andet;
                Total.ToString();
                textBox1.Text = Total.ToString();
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            Andet = 3;
            if (checkBox13.Checked)
            {
                Total = Størrelse + Dej + Sovs + Kryderi + Andet;
                Total.ToString();
                textBox1.Text = Total.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f1 = new Main();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();  // Starter forms op som ny.
            this.Dispose(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }
    }
}
