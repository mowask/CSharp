using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L9
{
    internal class Human
    {  
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public override string ToString()
        {
            return $"\n Фамилия: {LastName} " +
                $"Имя{FirstName} " +
                $" Дата рождения{Birthday.ToLongDateString()}";
        }
    }
}
