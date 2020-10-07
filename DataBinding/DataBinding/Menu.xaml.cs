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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Monster monster = new Monster(this);
            monster.Show();
            Hide();
        }

        public MonsterController mons = new ABCLibrary.MonsterController();

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Liste liste = new Liste(mons, this);
            liste.Show();
            Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Fjender fjender = new Fjender(this);
            fjender.Show();
            Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            FjernEtMonster fjernEtMonster = new FjernEtMonster(mons, this);
            fjernEtMonster.Show();
            Hide();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            OpdaterKendtegn opdaterKendtegn = new OpdaterKendtegn(mons, this);
            opdaterKendtegn.Show();
            Hide();
        }
    }
}
