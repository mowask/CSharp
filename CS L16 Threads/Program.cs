using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS_L16
{
    class Animal {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Dog : Animal
    {       
        public override string ToString()
        {
            return $"Dog: {Name} {Age}";
        }
    }
    class Cat : Animal
    {
        public override string ToString()
        {
            return $"Cat: {Name} {Age}";
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {

            Animal[] animals = {
                new Cat() {Name = "Tom", Age = 1 },
                new Cat() {Name = "Tod", Age = 3 },
                new Cat() {Name = "Tor", Age = 5 },
                new Dog() {Name = "Toto", Age = 12 },
                new Dog() {Name = "Tomo", Age = 4 },
                new Dog() {Name = "Toro", Age = 6 },
                new Dog() {Name = "Toco", Age = 9 }, 
            };

            var catsOnly = animals.OfType<Cat>();
            double averageCats = catsOnly.Average(c => c.Age);
            Console.WriteLine("Cats: " + averageCats);
           // var dogsOnly = animals.OfType<Dog>();
            double averageDogs = animals.OfType<Dog>().Average(c => c.Age);
            Console.WriteLine("Dags: " + averageDogs);
            Console.WriteLine();

            var animalsYanger8 = animals.Where(a => a.Age < 8).OrderBy(a => a.Age);
            foreach (var animal in animalsYanger8)
                Console.WriteLine(animal);

            Console.WriteLine();

            var animalsFilter = animals.Where(a => //a.Age > 5 || a.Name.Contains('2');
            {
               return  a.Age > 5 || a.Name.Contains('m');
            });
            foreach (var animal in animalsFilter)
                Console.WriteLine(animal);



/////////////////////////////////////////////////////////////////////////////////////////////////////
///
            //// получаем текущий поток
            //Thread currentThread1 = Thread.CurrentThread;   //  started
            //currentThread1.Name = "метод Main";
            //// получаем имя потока
            //Console.WriteLine($"Имя потока: {currentThread1.Name}");
            //Console.WriteLine($"Приоритет потока: {currentThread1.Priority}");
            //Console.WriteLine($"Статус потока: {currentThread1.ThreadState}");
            //Console.WriteLine();

            //Thread currentThread2 = new Thread(() => { });  // unstarted
            //currentThread2.Name = "Второй поток";
            //// получаем имя потока
            //Console.WriteLine($"Имя потока: {currentThread2.Name}");
            //Console.WriteLine($"Приоритет потока: {currentThread2.Priority}");
            //Console.WriteLine($"Статус потока: {currentThread2.ThreadState}");
            //Console.WriteLine();
            

            ////for (int i = 0;i < 10; i++)
            ////{
            ////    Thread.Sleep(3000);         //  задержка выполнения 3000 силисекунд
            ////    Console.WriteLine(i);
            ////}

            //Thread myThread1 = new Thread(Print);
            //Thread myThread2 = new Thread(new ThreadStart (Print));
            //Thread myThread3 = new Thread(() => Console.WriteLine("Hello Threads"));

            //myThread1.Start();
            //myThread2.Start();
            //myThread3.Start();

            //Console.WriteLine();

            //Thread myThread = new Thread(PrintNumbers);
            //myThread.Start();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"Главный поток поток: {i}") ;
            //    Thread.Sleep(1000);
            //}

            //Console.WriteLine("=====================================================");


            ////  Первый способ создания объекта Таск и вызов у него метода Старт 
            //Task task1 = new Task(() => Console.WriteLine("Task1 is executed"));
            //task1.Start();

            //// Второй способ заключается в использовании статического метода Таск.Факстори.СтартНью()
            //// Этот метод так же в качестве параметра принимает делегат Актион, который указывает какое действие будет выполняться.
            //// При этом этот метод сразу запускает задачу
            //Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Task1 is executed"));

            //// Третий способ Task.Run()

            //Task task3 = Task.Run(() => Console.WriteLine("Task3 is executed"));


            //PrintWithDelay(1);
            //PrintWithDelay(2);
            //PrintWithDelay(3);

            //Task task1 = Task.Run(() => { PrintWithDelay(1); });
            //Task task2 = Task.Run(() => { PrintWithDelay(2); });
            //Task task3 = Task.Run(() => { PrintWithDelay(3); });

            //task1.Wait();   // ждет завершения таск1
            //task2.Wait();   // ждет завершения таск2   
            //task3.Wait();   // ждет завершения таск3

            //Console.WriteLine(" Asdafa");


            Console.ReadKey();
        }



            ////////// func

        static void PrintWithDelay(int i)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Tast {i} Finished");
        }

        static void PrintNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Второй поток: {i}");
                Thread.Sleep(1000);
            }
        }

        static void Print()
        {
            Console.WriteLine("Hello Threads!");
        }
    }
}
