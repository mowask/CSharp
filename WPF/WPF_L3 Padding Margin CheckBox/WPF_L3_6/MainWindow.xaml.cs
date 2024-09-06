using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace Wpf_L3_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> people;
        public MainWindow()
        {
            InitializeComponent();
            people = new List<Person>();
            buttonSubmit.Click += ButtonSubmit_Click;
            buttonStats.Click += ButtonStats_Click;
            
        }

        private void ButtonStats_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (people.Count == 0)
                {
                    throw new Exception("There no people in the list");
                }
                int countFemale = people.Count(p => p.Gender == 'f');
                int countMale = people.Count(p => p.Gender == 'm');
                TextBoxStats.Text = $"Females = {countFemale}\n";
                TextBoxStats.Text += $"Males = {countMale}\n";

                double avgAge = people.Average(p => p.Age);
                TextBoxStats.Text += $"Average age = {avgAge:0.00}\n";
            }
            catch(Exception ex)
            {
                MessageBox.Show (ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        void ButtonSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = NameBox.Text;
                int age = Convert.ToInt32(AgeBox.Text);
                if (age<1||age>120) 
                {
                    throw new Exception("Age must be between 1 and 120");
                }
                char gender = 'm';
                if (RadioButtonFemale.IsChecked == true)
                {
                    gender = 'f';
                }
                bool isMarried = (bool)RadioButtonFemale.IsChecked;
                                
                    Person person = new Person()
                    {
                        Name = name,
                        Age = age,
                        Gender = gender,
                        IsMarried = isMarried
                    };
                    people.Add(person);
                    TextBoxResult.Text = string.Empty;
                foreach (var p in people)
                {
                    TextBoxResult.Text += p.ToString()+"\n";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }





    }
}
