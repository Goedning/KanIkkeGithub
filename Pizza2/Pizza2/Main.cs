using System;
using System.Windows.Forms;

namespace Pizza2
{
    public partial class Main : Form
    {
        public decimal Pris;
        public decimal Størrelse;
        public decimal Total;
        public decimal Antal;
        public decimal NytAntal;


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
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Størrelse = 10;
            checkBox1.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Størrelse = 0;
            checkBox2.Checked = false;
            checkBox1.Checked = false;
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
            if (button2.Enabled)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                Total = (Pris + Størrelse) * Antal;
                Total.ToString();
                textBox1.Text = Total.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Ant = Convert.ToInt32(textBox3.Text);
            Antal = Ant;
            if (radioButton1.Checked == true)
            {
                radioButton1.Text.ToString();
                textBox2.Text = radioButton1.Text + $" * {Antal}";
                if (checkBox1.Checked)
                {

                }
                else if (checkBox2.Checked)
                {

                }
                else if (checkBox3.Checked)
                {

                }
            }
            else if (radioButton2.Checked == true)
            {
                radioButton2.Text.ToString();
                textBox2.Text = radioButton2.Text + $" * {Antal}";
                if (checkBox1.Checked)
                {

                }
                else if (checkBox2.Checked)
                {

                }
                else if (checkBox3.Checked)
                {

                }
            }
            else if (radioButton3.Checked == true)
            {
                radioButton3.Text.ToString();
                textBox2.Text = radioButton3.Text + $" * {Antal}";
                if (checkBox1.Checked)
                {

                }
                else if (checkBox2.Checked)
                {

                }
                else if (checkBox3.Checked)
                {

                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Antal == 1)
            {
                MessageBox.Show("Din Ordre er på vej og vil være ved dig hurtigst muligt!");
            }
            else if(Antal >= 2)
            {
                NytAntal = Total / 2;
                MessageBox.Show("Tak for din store bestilling som Tak, Halver vi din pris!" + $" {NytAntal}");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }
    }
}
