using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }


        private void TextBrugernavn_MouseClick(object sender, MouseEventArgs e)
        {
            if(textBrugernavn.Text == "Brugernavn")
            {
                textBrugernavn.Clear();
            }
        }

        private void TextKode_MouseClick(object sender, MouseEventArgs e)
        {
            if (textKode.Text == "Kode")
            {
                textKode.Clear();
                textKode.PasswordChar = '*';
            }
        }

        private void Lbl_Clear_Click(object sender, EventArgs e)
        {
            textKode.Clear();
            textBrugernavn.Clear();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (textBrugernavn.Text == "123" && textKode.Text == "123")
            {
                new Form2().Show();
                this.Hide();
            }
            else if (textBrugernavn.Text == "Heinrich Himler" && textKode.Text == "DuBistEinJude")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ja, så dit brugernavn eller password, eller måske begge er forkert, prøv igen noob.");
                textBrugernavn.Clear();
                textKode.Clear();
                textBrugernavn.Focus();
            }
        }
    }
}
