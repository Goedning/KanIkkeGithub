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
            Load();
        }
        BindingList<string> temp = new BindingList<string>();


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnSeries_Tilføj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Series.Text))
            {
                temp.Add(textBox_Series.Text);
                textBox_Series.Focus();
            }
        }

        private void btnSeries_Save_Click(object sender, EventArgs e)
        {
            const string sPath = "save.txt";

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var item in temp)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();

            MessageBox.Show("Programs saved!");
        }

        private void btn_SeriesFjern_Click(object sender, EventArgs e)
        {
            temp.Remove(listBox_Serier.SelectedItem.ToString());
        }



        private void Load()

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

        private void listBox_Serier_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string temp = "https://www.google.com/search?q=" + listBox_Serier.SelectedItem.ToString().Replace(" ", "%20");
            System.Diagnostics.Process.Start(temp);
            Console.WriteLine(temp);
        }


    }
}
