using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Configuration;


namespace _11_08
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private SqlConnection _connection;
        readonly private string _connectionString;

        public MainWindow()
        {
            InitializeComponent();
            button.Click += Execute; 
            

            _connectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            _connection = new SqlConnection(_connectionString);

        }

        public void Execute(object sender, RoutedEventArgs e)
        {
           string query = textBox.Text;
            try
            {
                _connection.Open();
                SqlCommand command = new SqlCommand(query, _connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    string result = "";
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            result += reader[i] + " ";
                        }
                        result += "\n";
                    }
                    textBlock.Text = result;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
