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

namespace _42_RAdioButton_in_code
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            RadioButton rb = new RadioButton { IsChecked = true,  Content = "WPF" };
            RadioButton rb1 = new RadioButton { IsChecked = false, Content = "WinForms" };
            RadioButton rb2 = new RadioButton { IsChecked = false,  Content = "ASP.NET" };
            rb.Checked += Rb_Checked;

            StackPanel stackPanel = new StackPanel();
            stackPanel.Margin = new Thickness(10,5,5,5);

            stackPanel.Children.Add(rb);
            stackPanel.Children.Add(rb1);
            stackPanel.Children.Add(rb2);

            grid.Children.Add(stackPanel);
        }

        private void Rb_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            MessageBox.Show(pressed.Content.ToString());
        }
    }
}
