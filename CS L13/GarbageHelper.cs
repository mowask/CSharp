using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L13
{
    internal class GarbageHelper
    {
        // метод создающий мусор
        public void MakeGarbage ()
        {
            for ( int i = 0 ; i < 1000; i++ ) 
            { 
            Person p = new Person();
            }
        }

        class Person
        {
            string _name;
            string _surname;
            byte _age;
        }
        
    }
}
