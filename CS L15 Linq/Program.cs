using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CS_L15_Linq
{

    class Animal { }
    class Dog: Animal
    {
        public string Name { get; set; }      
    }
    class Cat: Animal
    {
        public int Age { get; set; }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public string Job { get; set; }

        public Person (string name, int age, decimal salary, string job)
        {
            Name = name;
            Age = age;
            Salary = salary;
            Job = job;
        }
        public Person(string name, int age) : this(name, age, 0, "n/a") { }
        public override string ToString()
        {
            return $"{Name} {Age} {Salary} {Job}";
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {


            List <int> numbers = new List<int> { 1,2,3,4,5};
            bool conteinsEvenNumbers = numbers.Any(n => n % 2 == 0);    // true если хотя бы 1 есть
            bool allNumbersArePositive = numbers.All(n => n > 0);       // false если хотя бы 1 НЕ выполняет условие
            Console.WriteLine(conteinsEvenNumbers);
            Console.WriteLine(allNumbersArePositive);

            Console.WriteLine   ();


            int sum = numbers.Aggregate(0, (acc, num) => acc + num);   // 0 - начальное значение    асс - текущая сумма     num - текущий элемент
            Console.WriteLine (sum);

            Console.WriteLine ();

            string[] strings = { "Hello", "world", "!" };
            string total = strings.Aggregate("", (acc, str) =>
            {
                Console.WriteLine(acc + " " + str);
                if (acc == "") return str;
                return  acc + " " + str;
            });


            Console.WriteLine("\n============================================================================\n");

            List<Person> people = new List<Person>()
            {
                new Person ( "Jack", 25, 10000, "C# Programmer"),
                new Person ( "Bob", 15, 15000, "C# Programmer"),
                new Person ( "Jane", 21, 20000, "Doctor"),
                new Person ( "Nick", 35, 17500, "teacher"),
                new Person ( "Mark", 22),
                new Person ( "Mark", 19, 10000, "Pilot")
            };

            var orderNameSalaryPeople = people.OrderBy(p => p.Salary).ThenBy(p => p.Name);
            foreach (var person in orderNameSalaryPeople) { Console.WriteLine(person); }

            Console.WriteLine("\n============================================================================\n");

            //var orderPoeple = people.OrderBy(p => p.Age);
            //var desendingOrderPeople = people.OrderByDescending(p => p.Age);
            //foreach (var p in orderPoeple)
            //{
            //    Console.WriteLine($"{p.Name} {p.Age}");
            //}

            //Console.WriteLine();

            //foreach (var p in desendingOrderPeople)
            //{
            //    Console.WriteLine($"{p.Name} {p.Age}");
            //}

            //Console.WriteLine("\n============================================================================\n");


            //var names = people.Select(p => p.Name);
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.WriteLine();

            //var jobs = people.Select(p => new {Prof = p.Job, Salary = p.Salary});
            //foreach (var job in jobs)
            //{
            //    Console.WriteLine($"{job.Prof} {job.Salary}");
            //}

            //Console.WriteLine("\n============================================================================\n");


            //var jobs1 = people.GroupBy(p => p.Job);
            ////Console.WriteLine(jobs.GetType());

            //foreach (var job in jobs1)
            //{
            //    Console.WriteLine(job.Key);
            //    foreach (var person in job)
            //    {
            //        Console.WriteLine(" " + person.Salary);
            //    }
            //}

            //Console.WriteLine("\n============================================================================\n");

            //var jobsAvg = people.GroupBy(p => p.Job).Select(j => new { 
            //                                                Avg = j.Average(p => p.Salary),
            //                                                Name = j.Key 
            //                                                });

            //foreach (var job in jobsAvg)
            //{
            //    Console.WriteLine($"{job.Name}: {job.Avg}");
            //}

           // Console.WriteLine("\n============================================================================\n");

            //var anon = new { Name = "John", Age = 16 };
            //Console.WriteLine(anon.GetType());
            //Console.WriteLine(anon.Name);
            //Console.WriteLine(anon.Age);


            //Console.WriteLine("============================================================================");


            //List<string> words1 = new List<string> { "apple", "banana", "orange" };
            //var wordsLength = words1.Select(w => w.Length);
            //var shop = words1.Select( p => new {Product = p, Length = p.Length});
            
            //foreach ( var item in shop ) { Console.WriteLine($"{item.Product} {item.Length}"); };

            //Console.WriteLine("\n============================================================================\n");


            //List<Animal> animals = new List<Animal>
            //{
            //    new Cat() {Age = 10},               
            //    new Dog() {Name = "Lacy"},
            //    new Dog() {Name = "Bolt"},
            //    new Dog() {Name = "Jeff"},
            //    new Cat() {Age = 3},
            //    new Cat() {Age = 5}
            //};

            //var catsOnly = animals.OfType<Cat>();
            //int sum = catsOnly.Sum(c =>c.Age);
            //int max = catsOnly.Max(c =>c.Age);
            //int min = catsOnly.Min(c =>c.Age);
            //double averege = catsOnly.Average(c => c.Age);
            //Console.WriteLine($"sum = {sum}, min = {min}, max = {max}, avarege = {averege} ");
            

            //Console.WriteLine("\n============================================================================\n");

            //int[] numbers = new int [] { 1, 2, 3, 4, 5 };
            //var evenNumbers = numbers.Where(n => n % 2 == 0);
            //foreach (int n in evenNumbers)
            //{
            //    Console.WriteLine(n);
            //}

            //string[] strArr = new string[] { "Hello", "world", "ABC", "ABBC", "CDD","BDDCA"};

            //var strArr2 = strArr.Where(s => s.Length <=3);
            //foreach (string s in strArr2)
            //{
            //    Console.WriteLine(s);
            //}

            //Console.WriteLine(strArr2.GetType().ToString());
            
            //var strArr3 = strArr2.ToArray();
            //Console.WriteLine(strArr3.GetType().ToString());


            //string[] words = { "apple", "banana", "and", "grape", "test" };
            //var wordsStartingWithA = words.Where((string word, int index) => { return index % 2 == 0 && word.StartsWith("a"); });
            //foreach (string word in wordsStartingWithA) 
            //    { Console.WriteLine(word); }

            //Console.WriteLine("\n============================================================================\n");

            //List<object> list = new List<object> { 1, "hello", 2.5, true, 10 };
            //var integerNumber = list.OfType <int>();
            //foreach (int number in integerNumber)
            //     { Console.WriteLine(number); }

            //Console.WriteLine("\n============================================================================\n");

            





            Console.ReadKey();
        }
    }
}
