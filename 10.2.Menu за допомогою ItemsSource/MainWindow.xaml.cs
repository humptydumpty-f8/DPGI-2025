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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _10._2.Menu_за_допомогою_ItemsSource
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Створення списку елементів 
            List<MenuItem> items = new List<MenuItem>()
            {
                new MenuItem {Header= "_File"},
                new MenuItem {Header= "_Edit" },
                new MenuItem {Header= "_View" },
                new MenuItem {Header= "_Window" },
                new MenuItem {Header= "_Help" },
            };
            

            //Заповнити меню зі списку елементів 
            menu.ItemsSource = items;

        }
    }
}
