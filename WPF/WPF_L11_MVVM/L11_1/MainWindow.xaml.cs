using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

namespace Wpf_L11_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


    public class PersonContex : INotifyPropertyChanged
    {
        public Person Person { get; set; }
        public ICommand ChangePerson { get; set; }

        public PersonContex ()
        {
            Person = new Person()
            {
                Age = 30,
                Name = "John"
            };

            ChangePerson = new DelegateCommand(ChangePersonToJane);
        }

        public void ChangePersonToJane(object obj)
        {
            Person = new Person()
            {
                Age = 24,
                Name = "Jane"
            };
            OnPropertyChanged("Person");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop) 
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
            
    }


    ///////////////////////


    public partial class MainWindow : Window
    {
        public int Number { get; set; }

        public ICommand MyCommand { get; set; }

        public MainWindow()
        {            
            PersonContex contex = new PersonContex();
            InitializeComponent();
            this.DataContext = contex ;

            MyCommand = new DelegateCommand(ShowMessage);            
            //this.DataContext = this ;
        }


    ////////////////////////


        public void ShowMessage (Object obj)
        {
            if (obj is string )
                MessageBox.Show(obj as string );
        }

    }
}
