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

namespace Wpf_L1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int count = 0;

        public MainWindow()
        {
            InitializeComponent();
            myButton.Click+=ButtonClic;
            myButton2.MouseRightButtonDown += resetCount;
            myButton3.MouseEnter += ButtonClic;
            myButton4.Click += addCount;
        }

        private void addCount(object sender, RoutedEventArgs e)
        {            
            count ++;
            myTextBlock.Text = $"count {count}";
        }
        private void ButtonClic(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You click me button", "My Title",
                MessageBoxButton.YesNo, MessageBoxImage.Question);
        }
        private void resetCount(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
                "Are you sure wont to reset", 
                "My Title",
                MessageBoxButton.YesNo, 
                MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                count = 0;
                myTextBlock.Text = $"counter reseted";
            }            
        }
        private void ButtonClic3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You click me button", 
                "My Title", 
                MessageBoxButton.YesNo, 
                MessageBoxImage.Error);
        }

    }
}
