﻿using System;
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

namespace _4._0.Зафарбовування_геометричних_фігур
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            grid.Background=new SolidColorBrush(Colors.WhiteSmoke);
        }


        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Flag of Ukraine");
        }
    }
}
