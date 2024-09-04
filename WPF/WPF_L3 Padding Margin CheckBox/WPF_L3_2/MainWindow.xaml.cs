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

namespace Wpf_L2_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Button button = new Button();

        public MainWindow()
        {
            InitializeComponent();
            CreateWindowContent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Title = $"Button cliced at {DateTime.Now}";
        }
        private void CreateWindowContent ()
        {
            var button = new Button
            {
                Content = "Button",
                Height = 23.0,
                Width = 75.0,
            };
            button.Click += Button_Click;
            Content= button;
        }
    }
}
