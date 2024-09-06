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

namespace Wpf_L2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rand = new Random();

        private Button myButton3= new Button();
        private Button myButton4= new Button();
        int x =0;
        int y =0;

        public MainWindow()
        {
            InitializeComponent();

            myButton3 = new Button()
            {
                Content = "myButton3",
                VerticalAlignment = VerticalAlignment.Top,
                HorizontalAlignment = HorizontalAlignment.Right,
                FontSize = 28
            };
            myButton4 = new Button()
            {
                Content = "myButton4",
                VerticalAlignment = VerticalAlignment.Bottom,
                HorizontalAlignment = HorizontalAlignment.Right,
                FontSize = 28
            };

            Grid.SetRow(myButton3, 0);
            Grid.SetRow(myButton4, 1);

            grid1.Children.Add(myButton3);
            grid1.Children.Add(myButton4);

            myButton1.Click += Button1_Click;
            myButton2.Click += Button2_Click;
            myButton3.Click += Button3_Click;
            myButton4.Click += Button4_Click;


        }

        private void Button1_Click (object sender, RoutedEventArgs e)
        {
            myButton1.Margin = new Thickness(rand.Next(10, 50));
        }
        private void Button2_Click (object sender, RoutedEventArgs e)
        {
            myButton1.Padding = new Thickness(rand.Next(10, 50));
        }

         private void Button3_Click (object sender, RoutedEventArgs e)
        {
            myButton3.Margin = new Thickness(x);
            x++;
        }
        private void Button4_Click (object sender, RoutedEventArgs e)
        {
            myButton4.Padding = new Thickness(y);
            y++;

        }

    }
}
