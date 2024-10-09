using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_hw_Quiz.Model
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public User(string login, string password) 
        {
            Login = login;
            Password = password;
        }

        public static List<User> GenerateUsers ()
        {
            var users = new List<User>()
           {
               new User("", ""),
               new User("User1", "1111"),
               new User("User2", "2222"),
               new User("User3", "3333")
           };
            return users;
        }

   
    }
}
