using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CS_L6
{
    class Person
    {
        private string _name;   //  становится не нужна при наличии  public string Name { get; set; } 
        private int _age;


        public string Name { get; set; } = "Unknow";
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //    set // (string value)
        //    {
        //        _name = value;
        //    }
        //}
        public int Age { get { return _age; } set { if (value > 0 && value < 150) _age = value; } }
        //{
        //    get {return _age;}
        //    set 
        //    { 
        //        if (value > 0 && value < 150) _age = value;
        //    }
        //}

        public Company company = new Company();

        public override string ToString()                   //    переопределение (перегрузка) функции ToString() ) 
        {
            return $"name: {Name}, Age: {Age}, Company {company.Title}";
        }

    }

    class Company
    {
        public string Title { get; set; } = "Untitle";
    }



    class ClassPoint
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
    }

    struct StructPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }



        internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //  ------------------------------        HW          -------------------------------

        //    string str = "today is a good day for walking. i will try go walk naar the sea";

        //    string[] strArr= str.Split(new char[] {'.'}, StringSplitOptions.RemoveEmptyEntries);
                        
        //    foreach (string s in strArr) 
        //    {
        //        string sWitoutSpace = s.TrimStart();
        //        //Console.WriteLine(s.TrimStart());
        //        string sFirst = sWitoutSpace.Substring(0, 1);
        //        string sRest= sWitoutSpace.Substring(1);
        //        string sFirstToUpper = sFirst.ToUpper();
        //        //Console.WriteLine(sFirst);
        //        Console.Write(sFirstToUpper + sRest + ". ");                
        //    }
        //}


        static void Main(string[] args)
        {

            ClassPoint cp = new ClassPoint { X = 10, Y = 15};
            ClassPoint cp1 = new ClassPoint { X = 10, Y = 15};
            ClassPoint cp2 = cp1;

            // хотя ср и ср1 содержат одинаковые значения, они укзывают на разные адреса памяти
            Console.WriteLine($"ReferenceEquals(cp, cp1) = {ReferenceEquals(cp, cp1)}" ) ;  // false
            //  ср1 и ср2 укзывают на один и тот же адрес памяти
            Console.WriteLine($"ReferenceEquals(cp1, cp2) = {ReferenceEquals(cp1, cp2)}");  // true

            StructPoint sp = new StructPoint { X = 10, Y = 15 };
            Console.WriteLine($"ReferenceEquals(sp, sp) = {ReferenceEquals(sp, sp)}");  // false


            // работа метода Equals со ссылочными и значимыми типами
            // выполняется сравнение адресов ссылочных типов
            Console.WriteLine($"Equals(cp, cp1) = {Equals(cp, cp1)}");  // false

            // значимый тип
            StructPoint sp1 = new StructPoint { X = 10, Y = 15 };
            // выполняется сравнение значений полей
            Console.WriteLine($"Equals(sp, sp) = {Equals(sp, sp)}");  // true
            Console.WriteLine($"Equals(sp, sp1) = {Equals(sp, sp1)}");  // true



            Point p6= new Point { X = 10, Y = 15 };
            Point p7= new Point { X = 10, Y = 15 };
            Point p8= new Point { X = 10, Y = 16 };
            Console.WriteLine(Equals(p6,p7));   //  true
            Console.WriteLine(p6==p7);          //  true
            Console.WriteLine(p6 == p8);          //  false


            Point p = new Point();
            if (p)
            {
                Console.WriteLine("P is Center");
            }
            else 
            {
                Console.WriteLine("P is Not Center");
            }
            if (p7) { Console.WriteLine("P7 is Center"); }
            else { Console.WriteLine("P7 is Not Center"); }

            ///////////////////////////////////////////////////////////////////////////////

            //Point p = new Point { X = 2, Y = 3};
            //Point p2 = -p;
            //Console.WriteLine(p);
            //Console.WriteLine(p2);
            //p++;
            //Console.WriteLine(p);           
            //Console.WriteLine(p--);
            //Console.WriteLine(p - p2);
            //Point p3 = p + p2;
            //Console.WriteLine(p3);
            //Point p4 = p * 10;
            //Console.WriteLine(p4);
            //Console.WriteLine(10*p4);
            //Console.WriteLine(p4 / 5); // p4 = 20, 30


            ///////////////////////////////////////////////////////////////////////////////

            //Person bob = new Person();
            //Person tom = new Person { Name = "Tom", Age = 25 };
            //Person kate = new Person { Name = "Kate", Age = 30, company = { Title = "Microsoft"}  };
            //Console.WriteLine(bob);
            //Console.WriteLine(tom);
            //Console.WriteLine(kate);


            //Person john = new Person();
            //john.Name = "John";
            //Console.WriteLine(john.Name);
            //john.Age = 10;
            //Console.WriteLine(john.Age);
            //john.Age = -20;
            //Console.WriteLine(john.Age);
            //Console.WriteLine(john.ToString());

            //Person jane = new Person() { Name = "Jane", Age = 25 };
            //jane.Age = 20;
            //Console.WriteLine(jane.Age);


            Console.ReadKey();
        }
    }
}
