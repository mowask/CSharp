using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Wpf_L9_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string _currentFilePath;
        public MainWindow()
        {
            InitializeComponent();

            menuItemExit.Click += MenuItemExit_Click;

            menuItemNew.Click += MenuItemNew_Click;
            menuItemOpen.Click += MenuItemOpen_Click;
            menuItemSave.Click += MenuItemSave_Click;
            menuItemSaveAs.Click += MenuItemSaveAs_Click;

            textBox.TextChanged += TextBox_TextChanged;

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBlockLines.Text = "Lines " + (textBox.Text.Count(x => x == '\n') + 1);
            textBlockChars.Text = "Chars " + textBox.Text.Count(x => x != '\n' && x != '\r');
        }

        private void MenuItemSaveAs_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == true)
            {
                _currentFilePath = saveFileDialog.FileName;

                using (StreamWriter writer = new StreamWriter(_currentFilePath))
                {
                    writer.Write(textBox.Text);
                }
                Title = _currentFilePath;
            }
        }

        private void MenuItemSave_Click(object sender, RoutedEventArgs e)
        {          
            if (_currentFilePath != null)
            {
                using (StreamWriter writer = new StreamWriter(_currentFilePath))
                {
                    writer.Write(textBox.Text);
                }
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == true)
                {
                    _currentFilePath = saveFileDialog.FileName;

                    using (StreamWriter writer = new StreamWriter(_currentFilePath))
                    {
                        writer.Write(textBox.Text);
                    }
                    Title = _currentFilePath;
                }
            }

          
        }

        private void MenuItemOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                _currentFilePath= openFileDialog.FileName;

                try
                {
                    using (StreamReader reader = new StreamReader(_currentFilePath))
                    {
                        textBox.Text = reader.ReadToEnd();
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Error open file:" + ex.Message);
                }
                Title = _currentFilePath;
            }


        }

        private void MenuItemNew_Click(object sender, RoutedEventArgs e)
        {
            //
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            //
            saveFileDialog.Filter = "text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            //
            if (saveFileDialog.ShowDialog() ==true)
            {
                //
                _currentFilePath = saveFileDialog.FileName;

                //
                textBox.Text = string.Empty;

                //
                Title = _currentFilePath;

            }

        }

        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
