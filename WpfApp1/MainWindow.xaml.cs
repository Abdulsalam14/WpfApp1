using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            SolidColorBrush brush = new SolidColorBrush(Color.FromArgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 255)));
            string messageBoxText = "";
            if (sender is Button a)
            {
                a.Background = brush;
                messageBoxText = $"Button{a.Content}={a.Background}";
                ;
                MessageBoxButton button = MessageBoxButton.OK;
                MessageBoxImage icon = MessageBoxImage.Information;
                MessageBox.Show(messageBoxText, "Information", button, icon);
            }

        }
        private void Button_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button b)
            {
                gr.Children.Remove(b);
                Title = b.Content.ToString();
            }
        }
    }
}
