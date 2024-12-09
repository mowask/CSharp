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
    public partial class MainWindow : Window
    {

        private SqlConnection _connection;
        private EmployeesRepository _employeesRepository;
        private ProductsRepository _productsRepository;
        private SalesRepository _salesRepository;

        public ObservableCollection<Employee> Employees { get; set; }
        public ObservableCollection<Products> ProductsList { get; set; }

        public ObservableCollection<Sale> Sales { get; set; }

        public List <TextBox> ProductInput { get; set; }

        TextBox textBoxCustomerInput;
        TextBox textBoxQuantity;
        ComboBox comboBoxProducts;
        ComboBox comboBoxEmployees;



        public MainWindow()
        {
            InitializeComponent();

            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                _connection = new SqlConnection(ConnectionString);
                _connection.Open();
                _employeesRepository = new EmployeesRepository(_connection);
                _productsRepository = new ProductsRepository(_connection);
                _salesRepository = new SalesRepository(_connection);


                Employees = _employeesRepository.getAll();
                ProductsList = _productsRepository.getAll();
                Sales = _salesRepository.getAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            dataGridEmployees.ItemsSource = Employees;
            dataGridProducts.ItemsSource = ProductsList;
            dataGridSales.ItemsSource = Sales;

            this.Closing += MainWindow_Closing;

            buttonAddEmployee.Click += ButtonAddEmployee_Click;
            buttonDeleteEmployee.Click += ButtonDeleteEmployee_Click;
           // buttonLoadEmployees.Click += ButtonLoadEmployees_Click;



            SetupProductInput();

            buttonAddProducts.Click += ButtonAddProducts_Click;
            buttonDeleteProducts.Click += ButtonDeleteProducts_Click; 
           // buttonLoadProducts.Click += ButtonLoadProducts_Click;

            SetupSaleInput();

            buttonAddSales.Click += ButtonAddSales_Click;
            buttonDeleteSales.Click += ButtonDeleteSales_Click;

        }

        private void ButtonDeleteSales_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonDeleteProducts_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonDeleteEmployee_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonAddSales_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(textBoxQuantity.Text);
                string customerName = textBoxCustomerInput.Text;
                int quantity = Convert.ToInt32(textBoxQuantity.Text);
                int productId = 0;
                int employeeId = 0;
                if (comboBoxProducts.SelectedItem is Products p) {
                        productId = p.Id;
                    }

                if (comboBoxEmployees.SelectedItem is Employee em) {
                    employeeId = em.Id;
                }

                _salesRepository.Insert(new Sale()
                {
                    CustomerName = customerName,
                    Quantity = quantity,
                    Product = new Products() { Id = productId },
                    Employee = new Employee() { Id = employeeId }
                });

                Sales = _salesRepository.getAll();
                dataGridSales.ItemsSource = Sales;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void ButtonLoadProducts_Click(object sender, RoutedEventArgs e)
        {
            try
            {                
                ProductsList = _productsRepository.getAll();
                dataGridProducts.ItemsSource = ProductsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void ButtonAddProducts_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _productsRepository.Insert(Products.FromString(
                    "0",
                    ProductInput[0].Text,
                    ProductInput[1].Text,
                    ProductInput[2].Text,
                    ProductInput[3].Text,
                    ProductInput[4].Text
                    ));

                ProductsList = _productsRepository.getAll();
                dataGridProducts.ItemsSource = ProductsList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

                Employees = _employeesRepository.getAll();
                dataGridEmployees.ItemsSource = Employees;
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


        private void SetupProductInput ()
        {
            ProductInput = new List<TextBox>();

            var temp = new Products();
           foreach (var prop in temp.GetType().GetProperties()) 
            {
                if (prop.Name == "Id") continue;
                var stackPanel = new StackPanel()
                {
                    Margin = new Thickness(2),
                    Orientation = Orientation.Horizontal,
                     HorizontalAlignment = HorizontalAlignment.Center
                };
                var textBlock = new TextBlock()
                {
                    Text = $"{prop.Name}",
                    Width = 100
                    
                };
                var textBox = new TextBox() { 
                    Margin = new Thickness(2),
                    Width = 100
                    
                };
                stackPanel.Children.Add(textBlock);
                stackPanel.Children.Add(textBox);

                stackPanelProducts.Children.Add(stackPanel);
                ProductInput.Add(textBox);
            }
        }


        private void SetupSaleInput()
        {
            var stackPanel1 = new StackPanel()
            {
                Margin = new Thickness(2),
                Orientation = Orientation.Horizontal,
                HorizontalAlignment = HorizontalAlignment.Center
            };
            var textBlock1 = new TextBlock()
            {
                Text = $"CustomerName",
                Width = 100
            };
            textBoxCustomerInput = new TextBox()
            {
                Margin = new Thickness(2),
                Width = 100
            };
            stackPanel1.Children.Add(textBlock1);
            stackPanel1.Children.Add(textBoxCustomerInput);


            var stackPanel2 = new StackPanel()
            {
                Margin = new Thickness(2),
                Orientation = Orientation.Horizontal,
                HorizontalAlignment = HorizontalAlignment.Center
            };
            var textBlock2 = new TextBlock()
            {
                Text = $"Quantity",
                Width = 100
            };
            textBoxQuantity = new TextBox()
            {
                Margin = new Thickness(2),
                Width = 100
            };
            stackPanel2.Children.Add(textBlock2);
            stackPanel2.Children.Add(textBoxQuantity);

            comboBoxProducts = new ComboBox()
            {
                Width = 200,
                Margin = new Thickness(2),
            };
            comboBoxProducts.ItemsSource = ProductsList;

            comboBoxEmployees = new ComboBox()
            {
                Width = 200,
                Margin = new Thickness(2),
            };
            comboBoxEmployees.ItemsSource = Employees;

            stackPanelSales.Children.Add(stackPanel1);
            stackPanelSales.Children.Add(stackPanel2);
            stackPanelSales.Children.Add(comboBoxProducts);
            stackPanelSales.Children.Add(comboBoxEmployees);            
        }


    }
}
