using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CS_L5_Class_Namespace
{
    class Car
    {
        private string _driverName;
        private int _curSpeed;           // текущая скорость
        private int _gear = 1;

        public Car() : this("Нет водителя", 0) { }             // конструктор по умолчанию

        public Car (string _driverName) : this(_driverName, 0) { }    //  Конструктор с параметрами

        public Car(string name, int speed)      //  Конструктор с параметрами
        {
            _driverName = name;
            _curSpeed = speed;
        }

        public void PrintState()                //  вывод текущих данных
        {
            Console.WriteLine($"{_driverName} едет со скоростью {_curSpeed} км/ч на {_gear} передече");
        }
        public void SpeedUp (int delta)         //  увеличение скорости
        {
            int newSpeed = _curSpeed+delta;
            if ( _gear == 1 && newSpeed > 20 ) return; 
            if ( _gear == 2 && newSpeed > 40 ) return;  
            if ( _gear == 3 && newSpeed > 60 ) return; 
            if ( _gear == 4 && newSpeed > 100 ) return; 

            _curSpeed = newSpeed;
        }
        public void SiftGear(int newGear)
        {
            if (newGear > 4 || newGear < 1 ) return;
            _gear = newGear;
        }
            
    }


    class Bank 
    {
        private double _currBalance;
        private static double _bonus;

        public Bank(double balance) 
        {
            _currBalance = balance;
        }
        static Bank()
        { 
            _bonus= 1.04;
        }
        public static void SetBonus(double newRate)
        { 
        _bonus= newRate;
        }
        public static double GetBonus() 
        {
            return _bonus;
        }
        public double GetPercents (double summa) 
        {
        if ((_currBalance - summa)>0)
            {
                double percent = summa * _bonus;
                _currBalance -= percent;
                return percent;
            }
            return -1;
        }
    
    }


    class Student 
    {
        private string _firstName;

        public Student(string _firstName)
        {
            this._firstName = _firstName;
        }
        public void Print()
        {
            Console.WriteLine(this._firstName);
        }
    }


    class Employee
    {
        public decimal _salary;
        public Employee() : this(35000) { }
        public Employee(decimal _salary)
        {
            this._salary = _salary;
        }
        public void Print()
        {
            Console.WriteLine($"Salary: {_salary:N}, Tax: {Tax.calcTax(this):N} ");
        }
    }

    class Tax 
    {
        public static decimal calcTax(Employee employee) 
        {
            return 0.13m * employee._salary;
        }
    }         



    internal class Program
    {

        private static void ChangeInt (ref int x) { 
            x = 10;
        }
        private static void ChangeArray (ref int[] x) { 
            x = new int[] {1,2,3 };
        }
        private static void PrintArray (string text, int[] arr) { 
            Console.Write(text + ": ");
            foreach (int val in arr)
                Console.Write(val + " ");
            Console.WriteLine();
        }

        private static void GetRandom (out int digit)
        {
            digit = new Random().Next(10);
        }

        static void Main(string[] args)
        {

            //int y = 100;
            //Console.WriteLine ($"Before ChangeInt, y= {y}");
            //ChangeInt(ref y);
            //Console.WriteLine($"After ChangeInt, y= {y}");
            //Console.WriteLine();

            //int[] arr = {10, 20, 30, 40}; ;
            //PrintArray("Before ChangeArray, arr", arr);
            //ChangeArray(ref arr);
            //PrintArray("After ChangeArray, arr", arr);
            //Console.WriteLine();

            //int i;
            //GetRandom (out i);
            //Console.WriteLine($"i = {i}");

            //////////////////////////////////////////////////////////////////////////////


            DateTime date = new DateTime();
            Console.WriteLine(date);
            Console.WriteLine();

            DateTime date2 = new DateTime(2001, 12, 18 );
            Console.WriteLine(date2);
            Console.WriteLine();

            DateTime date3 = DateTime.Now;
            Console.WriteLine(date3);
            Console.WriteLine();

            DateTime date4 = DateTime.UtcNow;
            Console.WriteLine(date4);
            Console.WriteLine(date4.ToLongDateString());
            Console.WriteLine(date4.ToShortDateString());
            Console.WriteLine(date4.DayOfWeek);
            Console.WriteLine(date3.TimeOfDay);

            Console.WriteLine();

            

            Console.WriteLine(date3.Subtract(date4));

            //////////////////////////////////////////////////////////////////////////////


            //Employee john= new Employee(100000);
            //Employee jane = new Employee();
            //john.Print();
            //jane.Print();
            // Console.WriteLine($"nalog John =  { Tax.calcTax(john)}");


            //////////////////////////////////////////////////////////////////////////////


            //Student s = new Student("John");
            //s.Print();


            ///////////////////////////////////////////////////////////////////////////////


            //Car myCar1= new Car();
            //Car myCar2= new Car("Рубенс Барикелло");
            //Car myCar3= new Car("Ральф Шумахер", 15);
            //myCar3.PrintState();
            //Random random= new Random();
            //myCar1.SiftGear(random.Next(1,5));           
            //myCar2.SiftGear(random.Next(1,5));           
            //myCar3.SiftGear(random.Next(1,5));           

            //for (int i = 0; i<=4; i++)
            //{
            //    myCar1.SpeedUp(10);
            //    myCar1.PrintState();
            //   // Console.WriteLine();
            //    myCar2.SpeedUp(10);
            //    myCar2.PrintState();
            //   // Console.WriteLine();
            //    myCar3.SpeedUp(10);
            //    myCar3.PrintState();
            //    Console.WriteLine();
            //}


            ////////////////////////////////////////////////////////////////////////////////


            //Bank b1 = new Bank(1000000);
            //Console.WriteLine($"Текущий бонусный процент: {Bank.GetBonus()}");
            //Console.WriteLine($"Ваш депозит на 10 000, в кассе забрать: {b1.GetPercents(10000):N}");


            Console.ReadKey();
        }
    }
}
