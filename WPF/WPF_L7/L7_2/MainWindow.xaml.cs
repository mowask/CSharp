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

namespace Wpf_L7_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            buttonCalculate.Click += ButtonCalculate_Click;
        }
        

        private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
        {           
            progressBar.Value += 1;


            //try
            //{
            //    long number = int.Parse(textBoxNuber.Text);
            //    int sum = 0;
            //    for (int i = 0; i < number; i++)
            //    {
            //        sum += i;
            //        Dispatcher.Invoke(() => progressBar.Value = i / number * 100);                   
            //    }
            //    textBoxResult.Text = sum.ToString();
            //}
            //catch (Exception ex) 
            //{
            //    MessageBox.Show(ex.Message); 
            //}
        }
    }
}
