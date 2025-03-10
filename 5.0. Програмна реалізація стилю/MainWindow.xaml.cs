using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _5._0._Програмна_реалізація_стилю
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Створюємо стиль програмно

            Style myButtonStyle = new Style(typeof(Button));
            myButtonStyle.Setters.Add(new Setter(Button.BackgroundProperty, Brushes.BlanchedAlmond));
            myButtonStyle.Setters.Add(new Setter(Button.FontFamilyProperty, new FontFamily("Arial")));
            myButtonStyle.Setters.Add(new Setter(Button.FontWeightProperty, FontWeights.Bold));
            myButtonStyle.Setters.Add(new Setter(Button.FontSizeProperty, 24.0));
            myButtonStyle.Setters.Add(new Setter(Button.PaddingProperty, new Thickness(50, 20, 50, 20)));

            // Застосовуємо стиль до кнопки
            myButton.Style = myButtonStyle;
        }
        
    }
}