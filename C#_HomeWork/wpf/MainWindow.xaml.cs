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

namespace Wpf_hw_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int count = 1;
        Random random = new Random();
        List<Random> numbers = new List<Random>();

        public MainWindow()
        {
            InitializeComponent();
            button.Click += ButtonClick;

        }        

        private void ButtonClick(object sender, RoutedEventArgs e)
        {            
            {                
                int guessNumber = random.Next(1, 11);
                MessageBoxResult result = MessageBox.Show($"Ваше число {random.Next()}?", "My Title",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);
                while (result != MessageBoxResult.Yes)
                {
                    if (result == MessageBoxResult.Yes)
                    {
                        myTextBlock.Text = $"Угадал с {count} попытки! Ваше число {random.Next()}";
                        count = 1;
                    }
                    else
                    {
                        numbers.Add(random);
                        count++;
                    }
                }
            }
        }


    }
}
