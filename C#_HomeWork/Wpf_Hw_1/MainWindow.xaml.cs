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
        Random random = new Random();
        List<int> numbers = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
            button.Click += ButtonClick;
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            if (numbers.Count == 10)
            {
                MessageBox.Show("Ты врун! ", "Угадайка", MessageBoxButton.OK, MessageBoxImage.Warning);
                Close();
                return;
            }

            int guessNumber;
            do
            {
                guessNumber = random.Next(1, 11);
            }
            while (numbers.Contains(guessNumber));
            {
                numbers.Add(guessNumber);
                MessageBoxResult result = MessageBox.Show($"Ваше число {guessNumber}?", "Угадайка",
                                                MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)                   
                    {
                        myTextBlock.Text = $"Угадал с {numbers.Count} попытки! Ваше число {guessNumber}";
                        numbers.Clear();
                    }                
            }
        }
    }
}
    

