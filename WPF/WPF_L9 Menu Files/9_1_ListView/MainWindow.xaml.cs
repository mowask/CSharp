using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Xml.Serialization;

namespace Wpf_L9_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string FILE_NAME = "people.xml";

        ObservableCollection<Person> peopleList;

        public MainWindow()
        {
            InitializeComponent();
            LoadPeapleFromFile();

            //peopleList = new ObservableCollection<Person>()
            //{ new Person ()
            //    {
            //    Name = "John",
            //    Age = 19,
            //    Email = "john@mail.ru"
            //    },
            //    new Person()
            //    {
            //        Name = "Jane",
            //        Age = 18,
            //        Email = "jane@mail.ru"
            //    },
            //    new Person()
            //    {
            //        Name = "Tom",
            //        Age = 29,
            //        Email = "tom@mail.ru"
            //    }
            //};

            peopleListView.ItemsSource = peopleList;

            btnAdd.Click += BtnAdd_Click;

        }


        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = textBoxName.Text;
                if (name == string.Empty)
                    throw new Exception("Name is empty");
                int age = int.Parse(textBoxAge.Text);
                string email = textBoxEmail.Text;
                if (email == string.Empty)
                    throw new Exception("Email is empty");

                peopleList.Add(new Person()
                {
                    Name = name,
                    Age = age,
                    Email = email
                });

                SavePeapleToFile();

                textBoxName.Text = string.Empty;
                textBoxAge.Text = string.Empty;
                textBoxEmail.Text = string.Empty;

                //peopleListView.ItemsSource = peopleList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void SavePeapleToFile()
        {
            try
            {
                using (FileStream fs = new FileStream(FILE_NAME, FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Person>));

                    serializer.Serialize(fs, peopleList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void LoadPeapleFromFile()
        {
            if (!File.Exists(FILE_NAME)) return;
            try
            {
                using (FileStream fs = new FileStream(FILE_NAME, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Person>));

                    peopleList= (ObservableCollection<Person>)serializer.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
