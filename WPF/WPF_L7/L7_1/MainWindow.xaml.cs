using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Wpf_L7

{
    class Dog : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Dog() { }

        public event PropertyChangedEventHandler PropertyChanged;
        public void onPropertyChanged (string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged (this, new PropertyChangedEventArgs (prop));
            }
        }
    }

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int titleNumber = 0; 


        public MainWindow()
        {
            InitializeComponent();

            buttonChangeName.Click += ButtonChangeName_Click;

            Binding binding= new Binding();

            //Элемент-источник
            binding.ElementName = "myTextBox";

            //свойство элемента-источника
            binding.Path = new PropertyPath("Text");

            // установка ривязки для элемента-приемнкиа
            myTextBlock2.SetBinding(TextBlock.TextProperty, binding);


            removeBinding.Click += RemoveBinding_Click;


            buttonChangeTitle.Click += ButtonChangeTitle_Click;


            

        }

        private void ButtonChangeName_Click(object sender, RoutedEventArgs e)
        {
            Dog myDog = (Dog)this.Resources["myDog"];
            myDog.Name = "Bolt";
            myDog.onPropertyChanged("Name");
        }

        private void ButtonChangeTitle_Click(object sender, RoutedEventArgs e)
        {
           titleNumber++;
            Title = $"Title {titleNumber}";
        }

        private void RemoveBinding_Click(object sender, RoutedEventArgs e)
        {
           // BindingOperations.ClearBinding(myTextBlock2, TextBlock.Text    )
            BindingOperations.ClearAllBindings(myTextBlock2);
        }
    }
}
