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

namespace Wpf_L8_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            

            buttonIncrease.Click += ButtonIncrease_Click;
            buttonDecrease.Click += ButtonDecrease_Click;

            List <ToDoItem> items = new List <ToDoItem>();
            items.Add(new ToDoItem() { Title = "Learn C#", Completion = 80 });
            items.Add(new ToDoItem() { Title = "Wash the car", Completion = 0 });
            items.Add(new ToDoItem() { Title = "Clean the dishes", Completion = 25 });
            items.Add(new ToDoItem() { Title = "Walk the dog", Completion = 50 });

            listBoxToDoList.ItemsSource = items;

            //////////////////////////////////
            
            List <Animals> animals = new List <Animals>();
            animals.Add(new Animals () { Name = "Tom", Age = 2 });
            animals.Add(new Animals () { Name = "Bolt", Age = 5 });
            animals.Add(new Animals () { Name = "Lacy", Age = 8 });

            ListBoxAmimals.ItemsSource = animals;

            comboBox.SelectionChanged += ComboBox_SelectionChanged;
        }

        public void ButtonIncrease_Click (object sender, RoutedEventArgs e)
        {
            foreach (object o in listBoxToDoList.SelectedItems)
            {
                var todoItem = (o as ToDoItem);


              //  todoItem.Completion = Math.Min(100, todoItem.Completion + 10);
                
                
                todoItem.onPropertyChanged("Completion");
            }
        }
        public void ButtonDecrease_Click (object sender, RoutedEventArgs e)
        {
            foreach (object o in listBoxToDoList.SelectedItems)
            {
                var todoItem = (o as ToDoItem);

               // todoItem.Completion = Math.Max(0, todoItem.Completion - 10);
                todoItem.onPropertyChanged("Completion");
            }
        }

        private void ComboBox_SelectionChanged (object sender, SelectionChangedEventArgs e)
        {
            Color[] colors = {Colors.Red, Colors.Green, Colors.Blue};  
                this.Background = new SolidColorBrush(colors[comboBox.SelectedIndex]);
            
        }



    }
}
