using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L10
{
    internal class Student
    {
        public string Name { get; set; }
        public int Result { get; set; }
        public DateTime DateOfBirth { get; set; }
        public override string ToString()
        {
            return $"{Name} {DateOfBirth.ToShortDateString()}: {Result}";
        }

        public static void ShowStudent(string text, Student[] students)
        {
            Console.WriteLine(text);
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
    }
}
