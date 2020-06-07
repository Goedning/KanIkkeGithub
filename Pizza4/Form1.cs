using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // I modsætning til sidste gang, hvor alting havde deres egen effekt, har jeg fået at vide det er lettere at kører det hele igennem en knap.

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Pizza Type Selection Fn1353

            if (radioButton1.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Lille Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("25");
                    listView1.Items.Add(item);

                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Lille Kød Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("25");
                    listView1.Items.Add(item);

                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Lille Vegatar Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("25");
                    listView1.Items.Add(item);

                }

            }

            else if (radioButton2.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("35");
                    listView1.Items.Add(item);

                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Kød Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("35");
                    listView1.Items.Add(item);

                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Vegatar Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("35");
                    listView1.Items.Add(item);

                }
            }

            else if (radioButton3.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Stor Normal Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("45");
                    listView1.Items.Add(item);

                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Stor Kød Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("45");
                    listView1.Items.Add(item);

                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Stor Vegetar Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("45");
                    listView1.Items.Add(item);

                }
            }

            else if (radioButton4.Checked == true)
            {
                if (radioButton5.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Extra Stor Normal Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("50");
                    listView1.Items.Add(item);

                }
                else if (radioButton6.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Ekstra Stor Kød Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("50");
                    listView1.Items.Add(item);

                }
                else if (radioButton7.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Exsta Stor Vegetar Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("50");
                    listView1.Items.Add(item);

                }
            }

            // Mine foreskellige ingredienser

            if (checkBox1.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Ekstra Salt");
                item.SubItems.Add("");
                item.SubItems.Add("5");
                listView1.Items.Add(item);

            }

            if (checkBox2.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Extra Peber");
                item.SubItems.Add("");
                item.SubItems.Add("5");
                listView1.Items.Add(item);

            }

            if (checkBox3.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Pepparoni");
                item.SubItems.Add("");
                item.SubItems.Add("5");
                listView1.Items.Add(item);

            }

            if (checkBox4.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Ananas");
                item.SubItems.Add("");
                item.SubItems.Add("5");
                listView1.Items.Add(item);

            }

            if (checkBox5.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Agurk");
                item.SubItems.Add("");
                item.SubItems.Add("5");
                listView1.Items.Add(item);

            }

            if (checkBox6.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Tomat");
                item.SubItems.Add("");
                item.SubItems.Add("5");
                listView1.Items.Add(item);

            }

            if (checkBox7.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Bacon");
                item.SubItems.Add("");
                item.SubItems.Add("5");
                listView1.Items.Add(item);

            }

            if (checkBox8.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Skinke");
                item.SubItems.Add("");
                item.SubItems.Add("5");
                listView1.Items.Add(item);

            }

            if (checkBox9.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Løg");
                item.SubItems.Add("");
                item.SubItems.Add("5");
                listView1.Items.Add(item);

            }

            if (checkBox10.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Svampe");
                item.SubItems.Add("");
                item.SubItems.Add("5");
                listView1.Items.Add(item);

            }

            if (checkBox11.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Jalapeno");
                item.SubItems.Add("");
                item.SubItems.Add("5");
                listView1.Items.Add(item);

            }

            if (checkBox12.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Chili");
                item.SubItems.Add("");
                item.SubItems.Add("5");
                listView1.Items.Add(item);

            }

            // Drikkevarer

            if (checkBox13.Checked == true)
            {
                ListViewItem item = new ListViewItem("Cola - Flaske");
                item.SubItems.Add(textBox1.Text);
                int qty = Convert.ToInt32(textBox1.Text);
                double cost = qty * 15;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox1.Text = "";
            }

            if (checkBox14.Checked == true)
            {
                ListViewItem item = new ListViewItem("Cola Light - Flaske");
                item.SubItems.Add(textBox2.Text);
                int qty = Convert.ToInt32(textBox2.Text);
                double cost = qty * 10;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox2.Text = "";
            }

            if (checkBox15.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sprite - Flaske");
                item.SubItems.Add(textBox3.Text);
                int qty = Convert.ToInt32(textBox3.Text);
                double cost = qty * 10;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);

            }

            else
            {
                textBox3.Text = "";
            }

            if (checkBox16.Checked == true)
            {
                ListViewItem item = new ListViewItem("Squash - Flaske");
                item.SubItems.Add(textBox4.Text);
                int qty = Convert.ToInt32(textBox4.Text);
                double cost = qty * 10;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox4.Text = "";
            }

            if (checkBox17.Checked == true)
            {
                ListViewItem item = new ListViewItem("Bajer - Dåse");
                item.SubItems.Add(textBox5.Text);
                int qty = Convert.ToInt32(textBox5.Text);
                double cost = qty * 20;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox5.Text = "";
            }

            if (checkBox18.Checked == true)
            {
                ListViewItem item = new ListViewItem("Vand - Flaske");
                item.SubItems.Add(textBox6.Text);
                int qty = Convert.ToInt32(textBox6.Text);
                double cost = qty * 10;
                string dCost = cost.ToString();
                item.SubItems.Add(dCost);
                listView1.Items.Add(item);
            }

            else
            {
                textBox6.Text = "";
            }

            double total = 0;
            


            foreach (ListViewItem item in listView1.Items)
            {
                total += Convert.ToDouble(item.SubItems[2].Text);
            }
            

            textBox7.Text = Convert.ToString(total);

            tabControl1.SelectTab("tabPage2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage3");
            textBox12.Text = textBox7.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            tabControl1.SelectTab("tabPage2");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {


            if (textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("Udfyld venligst de nødvendige felter!");
            }

            else
            {
                string money = textBox12.Text;
                char[] kroner = { 'K' };
                string paymoney = money.TrimStart(kroner);
                double paymentDue = Convert.ToDouble(paymoney);
                double amountPaid = Convert.ToDouble(textBox13.Text);
                double change = 0;
                change = amountPaid - paymentDue;
                textBox14.Text = change.ToString("c2");

                if (change < 0)
                {
                    MessageBox.Show("Betal venligst det rigtige beløb");

                }

                else
                {
                    DialogResult dialog = MessageBox.Show("Mange tak for din bestilling, vi har din ordrer klar hurtigest muligt, i mellem tiden er der eller andet vi kan hjlpe med?", "Exit", MessageBoxButtons.YesNo);

                    if (dialog == DialogResult.Yes)
                    {

                        
                        checkBox1.Checked = false;    //Vi begynder forfra
                        checkBox2.Checked = false;   
                        checkBox3.Checked = false;
                        checkBox4.Checked = false;
                        checkBox5.Checked = false;
                        checkBox6.Checked = false;
                        checkBox7.Checked = false;
                        checkBox8.Checked = false;
                        checkBox9.Checked = false;
                        checkBox10.Checked = false;
                        checkBox11.Checked = false;
                        checkBox12.Checked = false;
                        checkBox13.Checked = false;
                        checkBox14.Checked = false;
                        checkBox15.Checked = false;
                        checkBox16.Checked = false;
                        checkBox17.Checked = false;
                        checkBox18.Checked = false;


                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";

                        listView1.Items.Clear();
                        textBox8.Text = "";
                        textBox9.Text = "";
                        textBox10.Text = "";

                        textBox11.Text = "";
                        textBox12.Text = "";
                        textBox13.Text = "";
                        textBox14.Text = "";


                        tabControl1.SelectTab("tabPage1");
                    }

                    else if (dialog == DialogResult.No)
                    {
                        this.Close();
                    }


                }
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox7.Text = "";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}


