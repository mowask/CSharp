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
using static System.Net.Mime.MediaTypeNames;

namespace Wpf_L4_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TextBox textBox;
        private TextBlock textBlock1;
        private TextBlock textBlock2;
        private TextBlock textBlock3;
        private TextBox txtStatus;
        private PasswordBox passwordBox;

        private Grid grid;

        public MainWindow()
        {
            InitializeComponent();
            CreateWindowContent();
        }

        private void text_TextChanged (object sender, EventArgs e)
        {
            textBlock1.Text = "Changed Text: " + textBox.Text;
        }         

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
           textBlock3.Text = passwordBox.Password;
        }

        private void TextBox_SelectionChanged(object sender, EventArgs e)
        {
            TextBox textBox2 = sender as TextBox;
            txtStatus.Text = "Selection starts at character #" +
                textBox2.SelectionStart + Environment.NewLine;
            txtStatus.Text += "Seletion is " + textBox2.SelectionLength +
                " character(s) long" + Environment.NewLine;
            txtStatus.Text += "Selected text: '" + textBox2.SelectedText + "'";

           // textBlock1.Text = "Selected Text: " + textBox.SelectedText;
        }
        private void CreateWindowContent()
        {
            textBox = new TextBox()
            {
                CharacterCasing = CharacterCasing.Upper,
                FontSize = 28,
                TextWrapping = TextWrapping.Wrap
            };
            txtStatus = new TextBox()
            {
                FontSize = 28,
                IsReadOnly = true,
            };
            textBlock1 = new TextBlock()
            {
                Text = "Changed Text:",
                       FontSize = 28
            };
            textBlock2 = new TextBlock()
            {
                Text= "Selected Text:",
                       FontSize = 28
            };

            textBlock3 = new TextBlock()
            {                
                       FontSize = 28
            };
            passwordBox = new PasswordBox()
            {
                PasswordChar = '*',
                FontSize = 28
            };


            StackPanel stackPanel = new StackPanel();
            stackPanel.Children.Add(textBox);
            stackPanel.Children.Add(textBlock1);
            stackPanel.Children.Add(textBlock2);
            stackPanel.Children.Add(txtStatus);
            stackPanel.Children.Add(passwordBox);
            stackPanel.Children.Add(textBlock3);


            grid = new Grid();
            grid.Children.Add(stackPanel);

            this.Content= grid;

            textBox.SelectionChanged += TextBox_SelectionChanged;
            textBox.TextChanged += text_TextChanged;

            passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
        }

    }
}
