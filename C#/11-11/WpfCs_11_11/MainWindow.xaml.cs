using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
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
using System.Data;
using System.Configuration;
using WpfCs_11_11.Models;
using WpfCs_11_11.Repositories;


namespace WpfCs_11_11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private SqlConnection _connection;
        private EmployeesRepository _employeesRepository;

        public ObservableCollection<Employee> Employees { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                _connection = new SqlConnection(ConnectionString);
                _connection.Open();
                _employeesRepository = new EmployeesRepository(_connection);


                Employees = _employeesRepository.getAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            dataGridEmployees.ItemsSource = Employees;

            this.Closing += MainWindow_Closing;

            buttonAddEmployee.Click += ButtonAddEmployee_Click;

            buttonLoadEmployees.Click += ButtonLoadEmployees_Click;

        }

        private void ButtonLoadEmployees_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Employees.Clear();
                Employees = _employeesRepository.getAll();
                dataGridEmployees.ItemsSource = Employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonAddEmployee_Click(object sender, RoutedEventArgs e)
        {
           try
            {
                _employeesRepository.Insert(new Employee()
                {
                    FirstName = textBoxFirtName.Text,
                    LastName = textBoxLastName.Text
                    
                });
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());         
            }
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_connection != null)
                _connection.Close();
        }
    }
}
