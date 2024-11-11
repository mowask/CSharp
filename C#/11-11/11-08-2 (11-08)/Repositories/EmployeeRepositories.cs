using _11_08_2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_08_2.Repositories
{
    internal class EmployeeRepositories
    {

        private readonly SqlConnection _connection;

        public EmployeeRepositories(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<Employee> getAll()
        {
            var list = new List<Employee>();
            string selectString = @"SELECT * FROM Employees";
            var cmd = new SqlCommand(selectString, _connection);

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    {
                        list.Add(Employee.FromString(
                            reader[0].ToString(),
                            reader[1].ToString(),
                            reader[2].ToString()
                            )
                        );
                    }
                }
            }
            return list;
        }

        public int Insert(Employee employee) 
        {
            string insertString = $"INSERT INTO Employees (FirstName, LastName) VALUES (@FirstName, @LastName)";
            SqlCommand cmd = new SqlCommand(insertString, _connection);

            SqlParameter paramFirstName = new SqlParameter();
            paramFirstName.ParameterName = "@FirstName";
            paramFirstName.SqlDbType = System.Data.SqlDbType.NVarChar;
            paramFirstName.Value = employee.FirstName;
            cmd.Parameters.Add(paramFirstName);

            var paramLastName = new SqlParameter("@LastName", System.Data.SqlDbType.NVarChar);
            paramLastName.Value = employee.LastName;
            cmd.Parameters.Add(paramLastName);

            return cmd.ExecuteNonQuery();
        }


    }
}
