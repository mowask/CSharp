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
        public SqlDataAdapter SqlBooksDataAdapter { get; set; }

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


                SqlBooksDataAdapter = GetBooksAdapter(connection);
                UpdateGridBooksDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           

            buttonFill.Click += ButtonFill_Click;
            buttonUpdate.Click += ButtonUpdate_Click;
            buttonDelete.Click += ButtonDelete_Click;
            btnFill.Click += BtnFill_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;



        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (grid2.SelectedItems != null)
                {
                    for (int i = 0; i < grid2.SelectedItems.Count; i++)
                    {
                        DataRow dataRow = (grid2.SelectedItems[i] as DataRowView).Row;
                        if (dataRow != null)
                        {
                            dataRow.Delete();
                        }
                    }
                }
                SqlBooksDataAdapter.Update(DataSet, "Books");
                UpdateGridBooksDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlBooksDataAdapter.Update(DataSet, "Books");
                UpdateGridBooksDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnFill_Click(object sender, RoutedEventArgs e)
        {
            try
            {                
                UpdateGridBooksDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonFill_Click(object sender, RoutedEventArgs e)
        {
            try
            {               
                UpdateGridDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (grid.SelectedItems != null)
                {
                    for (int i = 0; i < grid.SelectedItems.Count; i++)
                    {
                        DataRow dataRow = (grid.SelectedItems[i] as DataRowView).Row;
                        if (dataRow != null)
                        {
                            dataRow.Delete();
                        }
                    }
                }
                SqlDataAdapter.Update(DataSet, "Authors");
                UpdateGridDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlDataAdapter.Update(DataSet, "Authors");
                UpdateGridDataSource();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        ///

        public void UpdateGridDataSource()
        {
            //  очищаем ДатаСет перед повторным заполнением
            //DataSet.Clear();

            if (DataSet.Tables.Contains("Authors"))
                DataSet.Tables["Authors"].Clear();

            //  заполняем ДатаСет новыми данными из таблицы Афторс
            SqlDataAdapter.Fill(DataSet, "Authors");

            //  Устанавливаем источние данных для грида
            grid.ItemsSource = DataSet.Tables["Authors"].DefaultView;
        }

        public void UpdateGridBooksDataSource()
        {
           // DataSet.Clear();

            if (DataSet.Tables.Contains("Books"))
                DataSet.Tables["Books"].Clear();

            SqlBooksDataAdapter.Fill(DataSet, "Books");
            
            grid2.ItemsSource = DataSet.Tables["Books"].DefaultView;
        }

        ///

        public static SqlDataAdapter GetAuthorsAdapter(SqlConnection connection)
        {
            string selectCommand = @"SELECT * FROM Authors";

            SqlDataAdapter authorsAdapter = new SqlDataAdapter(selectCommand, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(authorsAdapter);

            return authorsAdapter;
        }

        public static SqlDataAdapter GetBooksAdapter(SqlConnection connection)
        {
            string selectCommand = @"SELECT * FROM Books";

            SqlDataAdapter booksAdapter = new SqlDataAdapter(selectCommand, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(booksAdapter);

            return booksAdapter;
        }



    }
}
