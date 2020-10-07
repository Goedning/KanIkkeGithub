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
using ABCLibrary;

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for Monster.xaml
    /// </summary>
    public partial class Monster : Window
    {
        public Monster(Menu menu)
        {
            InitializeComponent();
            this.Menu = menu;
        }

        public Menu Menu;

        private void Button_Back1(object sender, RoutedEventArgs e)
        {
            Menu.Show();
            Close();
        }

        private void Button_Doppler(object sender, RoutedEventArgs e)
        {
            this.Menu.mons.list.Add(new ABCLibrary.Monster("Doppler", "KENDETEGN: Ingenting ", "ANTAL: 1"));
        }

        private void Button_Ghoul(object sender, RoutedEventArgs e)
        {
            this.Menu.mons.list.Add(new ABCLibrary.Monster("Ghoul", "KENDETEGN: Uintelligent. Jagter i flok. Spiser de døde. Hænger ofte omkring slagsmarker", "ANTAL: 5-100"));
        }

        private void Button_Bruxa(object sender, RoutedEventArgs e)
        {
            this.Menu.mons.list.Add(new ABCLibrary.Monster("Bruxa", "KENDETEGN:  Smuk kvinde ligende. Blod tørstig. Hader lugten af løg. Vampyr", "ANTAL 1-5, de kan gå både alene og i små grupper"));
        }

        private void Button_Kikimora(object sender, RoutedEventArgs e)
        {
            this.Menu.mons.list.Add(new ABCLibrary.Monster("Kikimora", "KENDETEGN: Svampe & Skov boende. Vil angribe alt der kommer nær. Flere typer, arbejde, soldat og dronning", "ANTAL: 10-500"));
        }

        private void Button_Drage(object sender, RoutedEventArgs e)
        {
            this.Menu.mons.list.Add(new ABCLibrary.Monster("Drage", "KENDETEGN: ...Det er en drage...", "ANTAL: 1-3"));
        }
    }
}
