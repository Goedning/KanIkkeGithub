using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Library
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            listBox_Serier.DataSource = temp;
            LoadTxt();
            /*
            foreach (var item in temp)
            {
                temp2.Add(item);
            }
            listBox_Serier.DataSource = temp2;
            */
        }
        BindingList<string> temp = new BindingList<string>();
        //List<string> temp = new List<string>();
        //BindingList<string> temp2 = new BindingList<string>();




        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void BtnSeries_Tilføj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Series.Text))
            {
                temp.Add(textBox_Series.Text);
                textBox_Series.Focus();
            }
        }

        private void BtnSeries_Save_Click(object sender, EventArgs e)
        {
            const string sPath = "save.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in temp)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();

            MessageBox.Show("Listen er blevet gemt!");
        }

        private void Btn_SeriesFjern_Click(object sender, EventArgs e)
        {
            temp.Remove(listBox_Serier.SelectedItem.ToString());
        }



        private void LoadTxt()
        {
            using (StreamReader sr = new StreamReader("../Debug/save.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    temp.Add(line);

                }
                sr.Close();

            }

        }

        private void ListBox_Serier_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string temp = "https://www.google.com/search?q=" + listBox_Serier.SelectedItem.ToString().Replace(" ", "%20");
            System.Diagnostics.Process.Start(temp);
            Console.WriteLine(temp);
        }

        private void TextBox_Search_TextChanged(object sender, EventArgs e)
        {
            /*
            temp2.Clear();
            foreach (var item in temp.Where(x => x.ToLower().Contains(textBox_Search.Text.ToLower())))
            {
                temp2.Add(item);
            };
            */
            
            for (int i = 0; i < listBox_Serier.Items.Count; i++)
            {
                string s = listBox_Serier.Items[i].ToString();
                if (!s.Contains(textBox_Search.Text))
                {
                    listBox_Serier.Items.RemoveAt(i);
                }
                else
                {
                    if (!listBox_Serier.Items.Contains(temp[i]))
                    {
                        listBox_Serier.Items.Add(temp[i]);
                    }
                }
            }
            
        }
    }
}
