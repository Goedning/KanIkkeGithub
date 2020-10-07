using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for Fjender.xaml
    /// </summary>
    public partial class Fjender : Window
    {
        public Fjender(Menu menu)
        {
            InitializeComponent();
            this.Menu = menu;
        }

        public Menu Menu;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Menu.mons.list.Add(new ABCLibrary.Fjender("The Common Bandit", "GRIM: Meget ", "Forbrydelse: Han prøvede at stjæle mine lommepenge!"));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Menu.mons.list.Add(new ABCLibrary.Fjender("Poul Præmiephysco", "GRIM: 7.43", "Forbrydelse: Han satte ild til den lokale kirke og sparkede en drenge spejder"));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Menu.mons.list.Add(new ABCLibrary.Fjender("Emil", "GRIM: 22%", "Forbrydelse: Han snakkede grimt om min kode"));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Menu.mons.list.Add(new ABCLibrary.Fjender("Kim Jong Un", "GRIM: Ca. Meget", "Forbrydelse: Ond diktator, kan lide at true med farlige våben"));
        }
    }
}
