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

namespace _3._12.Програмне_керування_Canvas
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Canvas canvasPanel;
              public MainWindow()
        {
            InitializeComponent();

            canvasPanel = new Canvas();
            canvasPanel.Background = new SolidColorBrush(Colors.RosyBrown);
            
    //Create orange Rectangle
            Rectangle orangeRectangle = new Rectangle();//obj
            //Properties sets
            orangeRectangle.Width = 150;
            orangeRectangle.Height = 150;      
            orangeRectangle.Fill = new SolidColorBrush(Colors.Orange);
            Canvas.SetLeft(orangeRectangle, 30);
            Canvas.SetTop(orangeRectangle, 30);
            canvasPanel.Children.Add(orangeRectangle); //Add it

    //Create pink Rectangle
            Rectangle pinkRectangle = new Rectangle();
            pinkRectangle.Width = 250;
            pinkRectangle.Height = 250;
            // Створюємо ImageBrush та задаємо шлях до зображення
            ImageBrush imageBrush = new ImageBrush();
            imageBrush.ImageSource = new BitmapImage(new Uri("C:\\Users\\yu_ta\\source\\repos\\DPGI-2025\\3.11.Програмне керування Canvas\\Photo\\photo1.jpg"));
            // Заповнюємо Rectangle зображенням
            pinkRectangle.Fill = imageBrush;            
            Canvas.SetLeft(pinkRectangle, 70);
            Canvas.SetTop(orangeRectangle, 70);
            canvasPanel.Children.Add(pinkRectangle);

            // Set content of the Window
            this.Content = canvasPanel;

            canvasPanel.MouseLeftButtonDown += RemoveRectangle;
        }

        private void RemoveRectangle(object sender, MouseButtonEventArgs e)
        {
            if (e.OriginalSource is Rectangle)
            {
                Rectangle activeRectangle = (Rectangle)e.OriginalSource;
                canvasPanel.Children.Remove(activeRectangle); //remove canvas
            }
        }
    }
}
