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
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Data;

namespace _11_15_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public DataSet DataSet { get; set; }   
        public SqlDataAdapter SqlDataAdapter { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            DataSet = new DataSet();

            SqlConnection connection = null;
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;

            try
            {                
                connection = new SqlConnection(connectionString);
                SqlDataAdapter = GetAuthorsAdapter(connection);
                UpdateGridDataSource();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }

        public void UpdateGridDataSource()
        {
            //  очищаем ДатаСет перед повторным заполнением
            DataSet.Clear();

            //  заполняем ДатаСет новыми данными из таблицы Афторс
            SqlDataAdapter.Fill(DataSet, "Authors");

            //  Устанавливаем источние данных для грида
            grid.ItemsSource = DataSet.Tables["Authors"].DefaultView;
        }

        public static SqlDataAdapter GetAuthorsAdapter(SqlConnection connection)
        {
            string selectCommand = @"SELECT * FROM Authors";

            SqlDataAdapter authorsAdapter = new SqlDataAdapter(selectCommand, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(authorsAdapter);

            return authorsAdapter;
        }


    }
}
