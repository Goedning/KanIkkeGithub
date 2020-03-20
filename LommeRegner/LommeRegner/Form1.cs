using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LommeRegner
{
    public partial class Form1 : Form
    {
        string input = string.Empty;      //Her bliver det registeret hvad vi trykker  
        String tal1 = string.Empty;       //Vælg det første tal
        String tal2 = string.Empty;       // Vælger det andet tal  
        char operation;                   //Her vælger hvilken funktion vi vil benytte for at opnå vores resultat 
        double result = 0.0;              // Her skriver den resultatet ud.  

        class circle
        {
            public double circ(double r) // Her giver vi vores variabler værdier, der vil blive brugt nede i vores metode for at finde arealet på en cirkel
            {
                double s;
                double pi = 3.14;
                s = r * r * pi;
                return (s);
            }
        }

        class trapez
        {

            // Funktion for at finde arealet af en trepez
            public double Trapez(int b1, int b2, int h)
            {
                double j;
                j = ((b1 + b2) / 2) * h;
                return (j);
            }
        }

        class cone
        {
            public double Cone(int r, int h) // Formlen til at skabe arealet af en cone

            {
                double y;
                y = Math.PI * r * r + Math.PI * r * h;
                return (y);
            }

        }

        class firkant
        {
            public double kant(int n, int m)
            {
                double t;
                t = n * m;
                return (t);
            }
        }




            public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)   
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            input += ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tal1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tal1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tal1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tal1 = input;                 
            operation = '+';
            input = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e) //Her klarer vi vores, *, /, - & + hvor de blive lagt sammen
        {
            tal2 = input;
            double num1, num2;
            double.TryParse(tal1, out num1);
            double.TryParse(tal2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "FEJL DIV MED NUL";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.tal1 = string.Empty;
            this.tal2 = string.Empty;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            circle c = new circle();
            double d;
            d = c.circ(Convert.ToInt32(textBox1.Text));
            textBox1.Text = Convert.ToString(d);

        }

        private void button21_Click(object sender, EventArgs e) 
        {
            trapez z = new trapez();
            double w;
            w = z.Trapez(Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox1.Text));
            textBox1.Text = Convert.ToString(w);


        }

        private void button22_Click(object sender, EventArgs e)
        {
           
        }

        private void button20_Click(object sender, EventArgs e)
        {
            cone l = new cone();
            double p;
            p = l.Cone(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text));
            textBox1.Text = Convert.ToString(p);

        }

        private void button19_Click(object sender, EventArgs e)
        {
            firkant k = new firkant();
            double q;
            q = k.kant(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text));
            textBox1.Text = Convert.ToString(q);
        }
    }
}

