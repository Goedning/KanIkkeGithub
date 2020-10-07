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
using System.IO;
using ABCLibrary;
using Microsoft.Win32;

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for Liste.xaml
    /// </summary>
    public partial class Liste : Window
    {
        public Liste(MonsterController monster, Menu menu)
        {
            InitializeComponent();
            DræbsListe.ItemsSource = monster.list.Getmonster();
            this.Menu = menu;


        }

        public Menu Menu;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu.Show();
            Close();
        }

       

        
    }
}
