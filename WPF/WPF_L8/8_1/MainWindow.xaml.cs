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

namespace Wpf_L8_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SliderColorRed.ValueChanged += ColorSlider_ValueChanged;
            SliderColorGreen.ValueChanged += ColorSlider_ValueChanged;
            SliderColorBlue.ValueChanged += ColorSlider_ValueChanged;


        }

        private void ColorSlider_ValueChanged (object sender, RoutedEventArgs e)
        {
            Color color = Color.FromRgb(
                    (byte) SliderColorRed.Value,
                    (byte) SliderColorGreen.Value,
                    (byte) SliderColorBlue.Value
                );
            this.Background = new SolidColorBrush(color);

        }
    }
}
