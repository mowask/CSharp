using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L8
{
    class Animal {
        public virtual void Print()
        {
            Console.WriteLine("Animal");
        }
    }
    class Cat : Animal
    {
        public override void Print()
        {
            Console.WriteLine("Cat");
        }
    }
    class Dog: Animal
    {
        public override void Print()
        {
            Console.WriteLine("Dog");
        }
    }


    class Shape  
    { 
    public virtual void Print()
        {           
            Console.WriteLine("Shape");
        }
        public override string ToString()
        {
            return "Shape: Base Class";
        }
    }
    class Square : Shape
    {
        public override void Print()
        {
            Console.WriteLine("Square");
            base.Print();
        }

        public override string ToString()
        {
            return "Square: Child Class";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Shape s1 = new Shape();
            Shape s2 = new Square();
            s1.Print();
            s2.Print();
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine("\n//////////////////////////////////////////////");

            Animal[] animals = { 
                new Cat(), 
                new Dog(), 
                new Cat(), 
                new Animal() };
            foreach (var anim in animals) { anim.Print(); }



            //Human jonh= new Human();
            Empoloyee empoloyee1 = new Empoloyee("John", "Doe");
            Empoloyee empoloyee2 = new Empoloyee("Jim", "Bim", 1253);
            Empoloyee empoloyee3 = new Empoloyee("Jack", "Smith", DateTime.Now, 3587.43);

            //Console.WriteLine(empoloyee1);
            //Console.WriteLine(empoloyee2);
            //Console.WriteLine(empoloyee3);
            Console.WriteLine("\n//////////////////////////////////////////////");


            //empoloyee1.Print();

            Empoloyee manager = new Manager("John", "Doe", new DateTime(1995, 7, 23), 3500.43, "Продукты питания");
            Empoloyee[] empoloyees =
            {
                manager,
                new Scientist ("Jim", "Bim", new DateTime(1956, 3, 15), 4253, "история"),
                new Specialist ("Jack", "Smith", new DateTime(1996, 11, 5) , 2587.43, "физика")
            };

            foreach (Empoloyee item in empoloyees)
            {
                item.Print();


                // способ №1
                try
                {
                    ((Specialist)item).ShowSpecialist();
                }
                catch { }

                // 2
                Scientist scientist = item as Scientist;
                if (scientist != null)
                {
                    scientist.ShowScientist();
                }

                //3
                if (item is Manager)
                {
                    (item as Manager).ShowManager();
                }
            }

            Console.WriteLine("\n//////////////////////////////////////////////");


            //Human employeeHumanClass = new Empoloyee("Jack", "Smith", DateTime.Now, 3587);
            //Console.WriteLine("\nHuman Class: ");
            //employeeHumanClass.Print();

            //Empoloyee employeeEmployeeClass = new Empoloyee("Jack", "Smith", DateTime.Now, 3587);
            //Console.WriteLine("\nEmployee Class: ");
            //employeeEmployeeClass.Print();




            Console.ReadKey();
        }
    }
}

