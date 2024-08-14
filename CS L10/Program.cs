using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L10
{
    internal class Program
    {        
        static void Main(string[] args)
        {

            Person tom = new Person("Tom", 37);
            var bob = new Person("Bob", 41);
            var sam = new Person("Sam", 25);

            Person[] people = { tom, bob, sam };
            Array.Sort(people);

            foreach (Person person in people)
            {
                Console.WriteLine($"{ person.Name} - { person.Age}");
            }
            Console.WriteLine();

            Student[] students = new Student[]
            {
                new Student {Name = "Иван Петров", Result = 85, DateOfBirth = new DateTime(2000, 10, 15)},
                new Student {Name = "Иван Иванов", Result = 61, DateOfBirth = new DateTime(2003, 1, 5)},
                new Student {Name = "Мария Иванова", Result = 92, DateOfBirth = new DateTime(2001, 2, 13)},
                new Student {Name = "Алексей Смринов", Result = 78, DateOfBirth = new DateTime(2005, 11, 11)}
            };

            Array.Sort(students, new StudentNameComparer());
            ShowStudent("Сортировка по имени: ", students);

            Array.Sort(students, new StudentDateComparer());
            ShowStudent("Сортировка по дате: ", students);

            Array.Sort(students, new StudentResultComparer());
            ShowStudent("Сортировка по результату: ", students);         




            //int[] numbers = new int[] { 97, 45, 32, 65, 83, 23, 15 };
            //Array.Sort(numbers);
            //foreach (int n in numbers) {
            //    Console.WriteLine(n);
            //}

            Console.ReadKey();
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
