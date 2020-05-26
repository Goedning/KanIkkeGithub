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
    
    public partial class Form2 : Form
    {
        decimal Størrelse;
        decimal Pepsi;
        decimal Total;
        decimal Antal;
        decimal NytAntal;

        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Størrelse = 25;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Størrelse = 33;
            checkBox1.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Størrelse = 40;
            checkBox2.Checked = false;
            checkBox1.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Pepsi = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Pepsi = 3;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Pepsi = -5;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Pepsi = 0;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Pepsi = -2;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Pepsi = -8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f1 = new Main();
            f1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Ant = Convert.ToInt32(textBox2.Text);
            Antal = Ant;
            Total = (Pepsi + Størrelse) * Antal;
            Total.ToString();
            textBox1.Text = Total.ToString();

            if (radioButton1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                radioButton1.Text.ToString();
                textBox3.Text = "Stor " + radioButton1.Text + $" * {Antal}";
            }
            else if (radioButton1.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                radioButton1.Text.ToString();
                textBox3.Text = "Mellem " + radioButton1.Text + $" * {Antal}";
            }
            else if (radioButton1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                radioButton1.Text.ToString();
                textBox3.Text = "Lille " + radioButton1.Text + $" * {Antal}";
            }
            if (radioButton2.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                radioButton2.Text.ToString();
                textBox3.Text = "Stor " + radioButton2.Text + $" * {Antal}";
            }
            else if (radioButton2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                radioButton2.Text.ToString();
                textBox3.Text = "Mellem " + radioButton2.Text + $" * {Antal}";
            }
            else if (radioButton2.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                radioButton2.Text.ToString();
                textBox3.Text = "Lille " + radioButton2.Text + $" * {Antal}";
            }
            if (radioButton3.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                radioButton3.Text.ToString();
                textBox3.Text = "Stor " + radioButton3.Text + $" * {Antal}";
            }
            else if (radioButton3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                radioButton3.Text.ToString();
                textBox3.Text = "Mellem " + radioButton3.Text + $" * {Antal}";
            }
            else if (radioButton3.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                radioButton3.Text.ToString();
                textBox3.Text = "Lille " + radioButton3.Text + $" * {Antal}";
            }
            if (radioButton4.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                radioButton4.Text.ToString();
                textBox3.Text = "Stor " + radioButton4.Text + $" * {Antal}";
            }
            else if (radioButton4.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                radioButton4.Text.ToString();
                textBox3.Text = "Mellem " + radioButton4.Text + $" * {Antal}";
            }
            else if (radioButton4.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                radioButton4.Text.ToString();
                textBox3.Text = "Lille " + radioButton4.Text + $" * {Antal}";
            }
            if (radioButton5.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                radioButton5.Text.ToString();
                textBox3.Text = "Stor " + radioButton5.Text + $" * {Antal}";
            }
            else if (radioButton5.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                radioButton5.Text.ToString();
                textBox3.Text = "Mellem " + radioButton5.Text + $" * {Antal}";
            }
            else if (radioButton5.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                radioButton5.Text.ToString();
                textBox3.Text = "Lille " + radioButton5.Text + $" * {Antal}";
            }
            if (radioButton6.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                radioButton6.Text.ToString();
                textBox3.Text = "Stor " + radioButton6.Text + $" * {Antal}";
            }
            else if (radioButton6.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                radioButton6.Text.ToString();
                textBox3.Text = "Mellem " + radioButton6.Text + $" * {Antal}";
            }
            else if (radioButton6.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                radioButton6.Text.ToString();
                textBox3.Text = "Lille " + radioButton6.Text + $" * {Antal}";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Antal == 1)
            {
                MessageBox.Show("Din Ordre er på vej og vil være ved dig hurtigst muligt!");
            }
            else if (Antal >= 2)
            {
                NytAntal = Total / 2;
                MessageBox.Show("Tak for din store bestilling som Tak, Halver vi din pris til" + $" {NytAntal}");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
