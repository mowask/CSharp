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

namespace Wpf_L3_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;

        private Grid grid1;

        public MainWindow()
        {
            InitializeComponent();
            CreateWindowContent();
            SetupEvents();

        }

        private void CreateWindowContent()
        {
            checkBox1 = new CheckBox()
            {
                Content= "Unchecked",
                HorizontalAlignment= HorizontalAlignment.Center,
                VerticalAlignment= VerticalAlignment.Center
            };
            checkBox2 = new CheckBox()
            {
                Content = "Checked",
                HorizontalAlignment = HorizontalAlignment.Center,
                IsChecked = true,
                VerticalAlignment = VerticalAlignment.Center
            };
            checkBox3 = new CheckBox()
            {
                Content = "Indeterminate",
                HorizontalAlignment = HorizontalAlignment.Center,
                IsChecked = null,
                IsThreeState= true,
                VerticalAlignment = VerticalAlignment.Center
            };

           var grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());
            grid.Children.Add(checkBox1);
            grid.Children.Add(checkBox2);
            grid.Children.Add(checkBox3);

            Grid.SetRow(checkBox1, 0);
            Grid.SetRow(checkBox2, 1);
            Grid.SetRow(checkBox3, 2);

            this.Content= grid;
        }

        private void SetupEvents()
        {
            checkBox1.Checked += CheckBox_Checked;
            checkBox1.Unchecked += CheckBox_Unchecked;

            checkBox2.Checked += CheckBox_Checked;
            checkBox2.Unchecked += CheckBox_Unchecked;

            checkBox3.Checked += CheckBox_Checked;
            checkBox3.Indeterminate += CheckBox_Indeterminate;
            checkBox3.Unchecked += CheckBox_Unchecked;
        }

        private void CheckBox_Indeterminate(object sender, RoutedEventArgs e)
        {
            this.Title = $"Checked at {DateTime.Now}";
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.Title = $"Indeterminate at {DateTime.Now}";
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Title = $"Uncheked at {DateTime.Now}";
        }

    }
}
