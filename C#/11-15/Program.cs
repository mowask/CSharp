using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace _11_15
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ////создаем пустую таблицу
            //DataTable authorsTable = new DataTable("Authors");

            //authorsTable.Columns.Add("Id", typeof(int));                // создана новая колонка Ид
            //authorsTable.Columns.Add("FirstName", typeof(string));
            //authorsTable.Columns.Add("LastName", typeof(string));

            ////  теперь можно заносить в таблицу строки
            ////  каждая стока это объект типа датаРоу
            //DataRow newRow = authorsTable.NewRow();

            //newRow[0] = 1;
            //newRow[1] = "Francis";
            //newRow[2] = "Bacon";
            //authorsTable.Rows.Add(newRow);

            //foreach (DataRow row in authorsTable.Rows)  // в таблицу добавлена новая сткрока
            //    Console.WriteLine($"{row["Id"]} {row["FirstName"]} {row["LastName"]}");




            //DataTable booksTable = new DataTable("Books");

            //booksTable.Columns.Add("Id", typeof(int));
            //booksTable.Columns.Add("AuthorId", typeof(int));
            //booksTable.Columns.Add("Title", typeof(string));
            //booksTable.Columns.Add("Price", typeof(int));
            //booksTable.Columns.Add("Pages", typeof(int));

            //DataRow newRow2 = booksTable.NewRow();

            //newRow2[0] = 1;
            //newRow2[1] = 1;
            //newRow2[2] = "Idiot";
            //newRow2[3] = 99;
            //newRow2[4] = 150;
            //booksTable.Rows.Add(newRow2);

            //foreach (DataRow row in booksTable.Rows)
            //    Console.WriteLine($"{row["Id"]} {row["AuthorId"]} {row["Title"]} {row["Price"]} {row["Pages"]}");

            /////////////////////////////////////

            //Console.WriteLine();


            //DataSet dataset = new DataSet("Library");
            //dataset.Tables.Add(authorsTable);
            //dataset.Tables.Add(booksTable);

            //foreach (DataRow row in dataset.Tables["Authors"].Rows)
            //{
            //    Console.WriteLine($"{row["Id"]} {row["FirstName"]} {row["LastName"]}");
            //}
            //foreach (DataRow row in dataset.Tables["Books"].Rows)
            //    Console.WriteLine($"{row["Id"]} {row["AuthorId"]} {row["Title"]} {row["Price"]} {row["Pages"]}");

            //Console.WriteLine();

            //////////////////////////////////////////////////////////////////////

            SqlConnection _connection = null;

            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
                _connection = new SqlConnection(ConnectionString);

                DataSet dataSet = new DataSet();

                //string selectstring = @"SELECT * FROM Authors";
                //SqlDataAdapter authorsAdapter = new SqlDataAdapter(selectstring, _connection);
                var authorsAdapter = GetAuthorsAdapter(_connection);

                //  заполняем ДатаСет данными из таблицы Афторс
                authorsAdapter.Fill(dataSet, "Authors");

                //  выводим информация о всех авторах
                foreach (DataRow row in dataSet.Tables["Authors"].Rows)
                    Console.WriteLine($"{row["Id"]} {row["FirstName"]} {row["LastName"]}");
                
                Console.WriteLine();

                ////  добавляем нового автора
                //DataRow newAuthor = dataSet.Tables["Authors"].NewRow();
                //newAuthor["FirstName"] = "Douglas";
                //newAuthor["LastName"] = "Adams";
                //dataSet.Tables["Authors"].Rows.Add(newAuthor);

                //foreach (DataRow row in dataSet.Tables["Authors"].Rows)
                //    Console.WriteLine($"{row["Id"]} {row["FirstName"]} {row["LastName"]}");

                ////  удаляем первую строку
                //dataSet.Tables["Authors"].Rows[2].Delete();
                ////  Обнорвляем вторую строку
                //dataSet.Tables["Authors"].Rows[1]["FirstName"] = "UpdateName";


                Console.WriteLine();

                // вносим изменения в бд
                authorsAdapter.Update(dataSet, "Authors");

                foreach (DataRow row in dataSet.Tables["Authors"].Rows)
                    Console.WriteLine($"{row["Id"]} {row["FirstName"]} {row["LastName"]}");

                Console.WriteLine("\n////////////////////////////\n");


                var booksAdapter = GetBooksAdapter(_connection);
                booksAdapter.Fill(dataSet, "Books");

                foreach (DataRow row in dataSet.Tables["Books"].Rows)
                        Console.WriteLine($"{row["Id"]} {row["AuthorId"]} {row["Title"]} {row["Price"]} {row["Pages"]}");

                Console.WriteLine();

                DataRow bookToUpdate = dataSet.Tables["Books"].Rows[0];
                bookToUpdate["Title"] = "Update Title";
                bookToUpdate["Price"] = 49.99;

                booksAdapter.Update(dataSet, "Books");

                foreach (DataRow row in dataSet.Tables["Books"].Rows)
                    Console.WriteLine($"{row["Id"]} {row["AuthorId"]} {row["Title"]} {row["Price"]} {row["Pages"]}");





                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                if (_connection != null)
                    _connection.Close();
            }                     

        }

        ////////////////////////////////////////////////////////////////////////////////////////////
        ///

        public static SqlDataAdapter GetAuthorsAdapter (SqlConnection connection)
        {
            //  строки SQL-запроса для выборки, добавления, обновления и удаления записей
            string selectString = @"SELECT * FROM Authors";
            string insertString = @"INSERT INTO Authors (FirstName, LastName) VALUES (@FirstName, @LastName)";
            string updateString = @"UPDATE Authors SET FirstName = @FirstName, LastName = @LastName WHERE Id = @Id";
            string deleteString = @"DELETE FROM Authors WHERE Id = @Id";

            //  создаем объект SqlDataAdapter для выборки данных из таблицы Афторс
            SqlDataAdapter authorsAdapter = new SqlDataAdapter(selectString, connection);

            SqlCommand insertCommand = new SqlCommand(insertString, connection);
            insertCommand.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@FirstName",
                SqlDbType = SqlDbType.NVarChar,
                SourceColumn = "FirstName"
            });
            insertCommand.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@LastName",
                SqlDbType = SqlDbType.NVarChar,
                SourceColumn = "LastName"
            });

            
            SqlCommand updateCommand = new SqlCommand(updateString, connection);
            updateCommand.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@Id",
                SqlDbType = SqlDbType.Int,
                SourceColumn = "Id",
                SourceVersion = DataRowVersion.Original
            });
            updateCommand.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@FirstName",
                SqlDbType = SqlDbType.NVarChar,
                SourceColumn = "FirstName",
                SourceVersion = DataRowVersion.Original
            });
            updateCommand.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@LastName",
                SqlDbType = SqlDbType.NVarChar,
                SourceColumn = "LastName",
                SourceVersion = DataRowVersion.Original
            });

            
            SqlCommand deleteCommand = new SqlCommand(deleteString, connection);
            deleteCommand.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@Id",
                SqlDbType = SqlDbType.Int,
                SourceColumn = "Id",
                SourceVersion = DataRowVersion.Original
            });

            // назначение команды для операций
            authorsAdapter.InsertCommand = insertCommand;
            authorsAdapter.UpdateCommand = updateCommand;
            authorsAdapter.DeleteCommand = deleteCommand;

            return authorsAdapter;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////


        public static SqlDataAdapter GetBooksAdapter(SqlConnection connection)
        {
            string selectCommand = @"SELECT * FROM Books";

            SqlDataAdapter booksAdapter = new SqlDataAdapter(selectCommand, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(booksAdapter);

            return booksAdapter;
        }

    }
}
    
    
 
