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

namespace Wpf_L3_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SubmitButton.Click += Submit;

        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            if (RadioButton1.IsChecked == true)
            {
                ResultTextBlock.Text = $"{RadioButton1.Content} selected RadioBatton 1";
            }
            else if (RadioButton2.IsChecked == true)
            {
                ResultTextBlock.Text = $"{RadioButton2.Content} selected RadioBatton 2";
            }
            else if (RadioButton3.IsChecked == true)
            {
                ResultTextBlock.Text = $"{RadioButton3.Content} selected RadioBatton 3";
            }
            else { ResultTextBlock.Text = $"Nothing selected"; }
        }

    }
}
