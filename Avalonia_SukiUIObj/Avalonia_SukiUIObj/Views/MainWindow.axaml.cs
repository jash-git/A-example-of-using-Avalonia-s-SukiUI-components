using Avalonia.Controls;
using Avalonia.Media;
using System.Security.Cryptography;

namespace Avalonia_SukiUIObj.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void B1_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            IBrush[] ColorBuf = new IBrush[4];
            ColorBuf[0] = new SolidColorBrush(Color.FromRgb(92, 171, 125));//G
            ColorBuf[1] = new SolidColorBrush(Color.FromRgb(28, 74, 110));//B
            ColorBuf[2] = new SolidColorBrush(Color.FromRgb(178, 34, 34));//R
            ColorBuf[3] = new SolidColorBrush(Color.FromRgb(253, 95, 0));//O
            B1.Background = ColorBuf[0];
            B1.BorderBrush = ColorBuf[0];
            B1.Foreground = ColorBuf[2];
        }

        private void B2_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
        }

        private void B3_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
        }
    }
}