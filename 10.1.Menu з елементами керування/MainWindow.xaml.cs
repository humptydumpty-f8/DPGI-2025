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

namespace _10._1.Menu_з_елементами_керування
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Створення прив'язки.
            CommandBinding binding = new CommandBinding(ApplicationCommands.Help);
            // Приєднання оброблювача подій,
            binding.Executed += HelpCommandBinding_Executed;
            // Реєстрація прив'язки.
            this.CommandBindings.Add(binding);
        }

        private void HelpCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("The Help command was invoked");
        }

        private void HelpCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void sendToDisk_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Send To Disk");
        }

        private void sendToFax_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Send To Fax");
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
