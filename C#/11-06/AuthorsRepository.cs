using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AuthorsRepository
    {
        private readonly SqlConnection conn;

        public AuthorsRepository(SqlConnection connection)
        {
            conn = connection;
        }


        public string GetAll()
        {
            string allAuthorsData = "";

            string selectString = "SELECT *FROM Authors";
            SqlCommand cmd = new SqlCommand(selectString, conn);

            using (SqlDataReader rdr = cmd.ExecuteReader())
            {
                for (int i = 0; i < rdr.FieldCount; i++)
                {
                    allAuthorsData += rdr.GetName(i) + " ";
                }
                allAuthorsData += "\n";

                while (rdr.Read())
                {
                    allAuthorsData += rdr["Id"] + " " + rdr["FirstName"] + " " + rdr["LastName"] + "\n";
                }
            }
            return allAuthorsData;
        }



        public string GetById(int id)
        {
            string selectString = $"SELECT * FROM Authors WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand( selectString, conn);
            using (var rdr = cmd.ExecuteReader())
            {
                if (rdr.Read())
                {
                    return rdr["Id"] + " " + rdr["FirstName"] + " " + rdr["LastName"] + "\n";
                }               
            }
            return null;

        }

        public int Insert(string firstName, string lastName)
        {
            string insertString = $"INSERT INTO Authors (FirstName, LastName) VALUES (@FirstName, @LastName)";
            SqlCommand cmd = new SqlCommand(insertString, conn);

            SqlParameter paramFirstName = new SqlParameter();
            paramFirstName.ParameterName = "@FirstName";
            paramFirstName.SqlDbType = System.Data.SqlDbType.NVarChar;
            paramFirstName.Value = firstName;
            cmd.Parameters.Add(paramFirstName);


            //SqlParameter paramLastName = new SqlParameter();
            //paramLastName.ParameterName = "@LastName";
            //paramLastName.SqlDbType = System.Data.SqlDbType.NVarChar;
            //cmd.Parameters.Add(paramLastName);

            var paramLastName = new SqlParameter("@LastName", System.Data.SqlDbType.NVarChar);
            paramLastName.Value = lastName;
            cmd.Parameters.Add(paramLastName);

            return cmd.ExecuteNonQuery();
        }

        public int Delete(int id) 
        {
            string deleteString = @"DELETE FROM Author WHERE id = @Id";
            SqlCommand cmd = new SqlCommand(deleteString, conn);

            //var paramId = new SqlParameter("@Id", System.Data.SqlDbType.Int);
            //paramId.Value = id;
            //cmd.Parameters.Add(paramId);

            cmd.Parameters
                .Add(new SqlParameter("@Id", System.Data.SqlDbType.Int))
                .Value = id;
            
            return cmd.ExecuteNonQuery();
        }

        public int Update(int id, string firstName, string lastName)
        {
            string updateString = @"UPDATE Authors SET FirstName = @FirstName, LastName = @LastName WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(updateString, conn);

            cmd.Parameters
                .Add(new SqlParameter("@FirstName", System.Data.SqlDbType.NVarChar))
                .Value = firstName;

             cmd.Parameters
                .Add(new SqlParameter("@LastName", System.Data.SqlDbType.NVarChar))
                .Value = lastName;

            cmd.Parameters
                .Add(new SqlParameter("@Id", System.Data.SqlDbType.Int))
                .Value = id;

            return cmd.ExecuteNonQuery();
        }

    }
}

