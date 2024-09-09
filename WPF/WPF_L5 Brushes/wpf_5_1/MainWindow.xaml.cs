using Microsoft.Win32;
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
using System.IO;


namespace Wpf_L5_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnLoadFromFile.Click += btnLoadFromFile_click;
            btnLoadFromResource.Click += btnLoadFromResource_click;
            btn_Stretch.Click += Btn_Stretch_Click;


            // button.Click += button_Click;


            //Uri uri = new Uri("/Images/Hamster.jpg", UriKind.Relative);
            //Uri uri1 = new Uri("/Images/Kot.png", UriKind.Relative);
            //image.Source = new BitmapImage(uri1);


        }

        private void Btn_Stretch_Click(object sender, RoutedEventArgs e)
        {
            if (uniform.IsChecked == true)
                image.Stretch = Stretch.Uniform;
            else if (uniformToFill.IsChecked == true)
                image.Stretch = Stretch.UniformToFill;
            else if (fill.IsChecked == true)
                image.Stretch = Stretch.Fill;
            else if (none.IsChecked == true)
                image.Stretch = Stretch.None;

        }

        private void btnLoadFromFile_click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                image.Source = new BitmapImage(fileUri);
            }
        }

        private void btnLoadFromResource_click(object sender, RoutedEventArgs e)
        {
            Uri resourceUri = new Uri("/Images/kot.png", UriKind.Relative);
            image.Source = new BitmapImage(resourceUri);
        }


        //private void button_Click(object sender, RoutedEventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
        //    if (openFileDialog.ShowDialog() == true)
        //    {
        //        txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
        //    }
        //}

    }
}
