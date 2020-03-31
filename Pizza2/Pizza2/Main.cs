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
    public partial class Main : Form
    {
        decimal Pris;
        decimal Størrelse;
        decimal Total;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Størrelse = -10;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Størrelse = 10;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Størrelse = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main NewForm = new Main();
            NewForm.Show();  // Starter forms op som ny.
            this.Dispose(false); 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
             Pris = 50; 
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Pris = 50; 
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Pris = 50; // Priserne kan ændres senere
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                radioButton1.Text.ToString();
                textBox2.Text = radioButton1.Text;
                if (checkBox1.Checked)
                {
                    Total = Pris + Størrelse;
                    Total.ToString();
                    textBox1.Text = Total.ToString();
                }
                else if (checkBox2.Checked)
                {
                    Total = Pris + Størrelse;
                    Total.ToString();
                    textBox1.Text = Total.ToString();
                }
                else if (checkBox3.Checked)
                {
                    Total = Pris + Størrelse;
                    Total.ToString();
                    textBox1.Text = Total.ToString();
                }
            }
            else if (radioButton2.Checked == true)
            {
                radioButton2.Text.ToString();
                textBox2.Text = radioButton2.Text;
                if (checkBox1.Checked)
                {
                    Total = Pris + Størrelse;
                    Total.ToString();
                    textBox1.Text = Total.ToString();
                }
                else if (checkBox2.Checked)
                {
                    Total = Pris + Størrelse;
                    Total.ToString();
                    textBox1.Text = Total.ToString();
                }
                else if (checkBox3.Checked)
                {
                    Total = Pris + Størrelse;
                    Total.ToString();
                    textBox1.Text = Total.ToString();
                }
            }
            else if (radioButton3.Checked == true)
            {
                radioButton3.Text.ToString();
                textBox2.Text = radioButton3.Text;
                if (checkBox1.Checked)
                {
                    Total = Pris + Størrelse;
                    Total.ToString();
                    textBox1.Text = Total.ToString();
                }
                else if (checkBox2.Checked)
                {
                    Total = Pris + Størrelse;
                    Total.ToString();
                    textBox1.Text = Total.ToString();
                }
                else if (checkBox3.Checked)
                {
                    Total = Pris + Størrelse;
                    Total.ToString();
                    textBox1.Text = Total.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Tilføj if så den kun giver denne besked hvis, din ordrer box er fyldt ud.
            MessageBox.Show("Din Ordre er på vej og vil være ved dig hurtigst muligt!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
