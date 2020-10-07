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
    /// Interaction logic for OpdaterKendtegn.xaml
    /// </summary>
    public partial class OpdaterKendtegn : Window
    {
        public OpdaterKendtegn(MonsterController monster, Menu menu)
        {
            InitializeComponent();
            OpdaterList.ItemsSource = monster.list.Getmonster();
            this.Menu = menu;
            this.Monster = monster;
        }

        public Menu Menu;
        public MonsterController Monster;

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            Menu.Show();
            Close();
        }

        private void Button_Vælg(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = Monster.list[OpdaterList.SelectedIndex].Kendetegn;
        }

        private void Button_Opdater(object sender, RoutedEventArgs e)
        {
            Monster.list[OpdaterList.SelectedIndex].Kendetegn = TextBox1.Text;
        }
    }
}
