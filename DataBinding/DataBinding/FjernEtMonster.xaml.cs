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
    /// Interaction logic for FjernEtMonster.xaml
    /// </summary>
    public partial class FjernEtMonster : Window
    {
        public FjernEtMonster(MonsterController monster, Menu menu)
        {
            InitializeComponent();
            FjernListe.ItemsSource = monster.list.Getmonster();
            this.Menu = menu;
            this.Monster = monster;
        }

        public MonsterController Monster;
        public Menu Menu;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Monster.list.Remove(Monster.list[FjernListe.SelectedIndex]);

        }

    }
}
