using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CS_L9
{
    // интерфейс
    interface IMovable
    {
        void Move();
    }
    // применение интерфейса в классе
    class Person : IMovable
    {
        public void Move() {
            Console.WriteLine("Человек идет");
        }
    }
    // применение интерфейса в структуре
    struct Car2 : IMovable
    {
        public void Move() { Console.WriteLine("Машина едет"); }
    }



    class Week : IEnumerable
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public IEnumerator GetEnumerator()
        {
            return days.GetEnumerator();
        }
    }

    internal class Program
    {
        static void DoAction(IMovable movable)
        {
            movable.Move();
        }


        static void Main(string[] args)
        {
            Week week = new Week();
            foreach (var day in week)
            {
                Console.WriteLine(day);
            }
                       

 /////////////////////////////////////////////////////////////////////////////////////////

            //Director director = new Director
            //{
            //    LastName = "Doe",
            //    FirstName = "John",
            //    Birthday = new DateTime(1998, 10, 12),
            //    Position = "Директор",
            //    Salary = 12000
            //};

            //Iworker seller = new Seller
            //{
            //    LastName = "Beam",
            //    FirstName = "Jim",
            //    Birthday = new DateTime(1956, 5, 23),
            //    Position = "Продавец",
            //    Salary = 3780
            //};

            //if (seller is Employee)
            //{
            //    Console.WriteLine("Заработная плата продавца: "
            //        + (seller as Employee).Salary);
            //}

            //director.ListOfWorkers = new List<Iworker>
            //{
            //    seller,
            //    new Cashier
            //    {
            //        LastName = "Smith",
            //        FirstName = "Nicole",
            //        Birthday = new DateTime(1956, 5, 23),
            //        Position = "Кассир",
            //        Salary = 3780
            //    }
            //};

            //Console.WriteLine(director);

            //if (director is IManager) 
            //{
            //    director.Control();
            //}
           
            //foreach (Iworker item in director.ListOfWorkers)
            //{
            //    Console.WriteLine(item);
            //    if (item.IsWorking)
            //    {
            //        Console.WriteLine(item.Work());
            //    }
            //}

            //double sum = 0;
            //foreach (Iworker item in director.ListOfWorkers)
            //{  
            //    if (item is Employee)
            //    {
            //        sum += (item as Employee).Salary;
            //    }
            //}
            //Console.WriteLine("Зарплата рабочих: " + sum);

            //if (director is IManager)
            //{
            //    sum += director.Salary;
            //}
            //Console.WriteLine("Зарплата рабочих и директора: " + sum);


 ////////////////////////////////////////////////////////////////////

            //Transport ship = new Ship("Perl", 10010) ;
            //Transport aiccraft = new Aircraft("Fly", 1800);
            //Transport car = new Car("Ford", 23) ;
            //car.Move();
            //aiccraft.Move();
            //ship.Move();

            //Console.WriteLine();

 /////////////////////////////////////////////////////////////////////

            //Person person= new Person();
            //Car2 car2 = new Car2();
            //DoAction(car2);
            //DoAction(person);






            Console.ReadKey();
        }
    }
}
