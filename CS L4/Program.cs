using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L4
{
    //internal class Program
    //{




    //static void Main(string[] args)
    //{

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //HW
    //Console.WriteLine("Выражение + или - : ");
    //string input = Console.ReadLine();
    //string[] numberStrings = input.Split(new char[] {'+','-'}, StringSplitOptions.RemoveEmptyEntries);
    //int[] numbers= new int[numberStrings.Length];
    //for (int i = 0; i < numberStrings.Length; i ++)     
    //{
    //    numbers[i] = Convert.ToInt32(numberStrings[i]);
    //} 

    //if (input[0] == '-') {
    //    numbers[0] = -numbers[0];                
    //}    

    //int result = numbers[0];
    //int counter = 1;

    ////for (int i = !char.IsDigit(input[0]) ? 1 : 0; i < numbers.Length; i ++) 
    //for (int i = 1; i < input.Length; i ++) 
    //{
    //    char symbol = input[i];

    //    if (symbol == '-')
    //    {
    //        result-= numbers[counter];
    //        counter++;
    //    }
    //    else if(symbol == '+')
    //    {
    //        result += numbers[counter++]; 
    //    }
    //}
    //Console.WriteLine(result);
    //Console.ReadKey();
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    //                                                                 //  enum

    //enum DaysOfWeek
    //{
    //    Monday, Tuesday, Wednesday, Friday,
    //}

    //enum Colors { Red, Orange, Green, Blue, Black };


    //static void Main(string[] args)
    //{
    //// Console.WriteLine(DaysOfWeek.Monday);

    // if (!Enum.IsDefined(typeof(Colors), "White")) 
    // {
    //     Console.WriteLine($"Значения White нет в перечислении Colors.");
    // }
    //  if (!Enum.IsDefined(typeof(Colors), "Green")) 
    // {
    //     Console.WriteLine($"Значения Green нет в перечислении Colors.");
    // }
    // Console.WriteLine(Enum.GetName(typeof(Colors), 1));

    ////
    // foreach( int i in Enum.GetValues(typeof(Colors))) 
    // Console.WriteLine($" {i}");

    //// 
    // foreach (string name in Enum.GetNames(typeof(Colors)))
    //     Console.WriteLine(name);

    // Console.WriteLine(Colors.Black.ToString());

    //foreach(ConsoleColor c in Enum.GetValues(typeof(ConsoleColor))) 
    //{
    //    Console.ForegroundColor = c;
    //    Console.WriteLine($"Color: {c}");
    //}
    //foreach(ConsoleColor c in Enum.GetValues(typeof(ConsoleColor))) 
    //{
    //    Console.ReadKey();
    //    Console.BackgroundColor = c;
    //    Console.Clear();
    //    Console.WriteLine($"Color: {c}");
    //}

    //                                                      // Structure


    //    struct Dimension
    //{
    //    public double Length;
    //    public double Width;

    //    public Dimension (double length, double width)
    //    {
    //        this.Length = length;
    //        Width = width;
    //    }

    //    public void Print()
    //    {
    //        Console.WriteLine($"Длина {Length} , Ширина {Width}.");
    //    }
    //}

    //static void ChangeArray(int[] arr)
    //{
    //    arr[0] = 10;
    //}
    // static void ChangeStruct(Dimension d)
    //{
    //    d.Length = 10;
    //}

    //static void Main(string[] args)
    //{
    //    double length = 7.342, width = 23.49;
    //    Dimension dimension = new Dimension (length, width);
    //    dimension.Print();

    //    int[] arr = { 1, 2, 3 };
    //    Console.WriteLine(arr[0]);     //1
    //    ChangeArray(arr);
    //    Console.WriteLine(arr[0]);      // 10

    //    ChangeStruct(dimension);
    //    dimension.Print();

    //    Console.ReadKey();
    //}



    //                                              //      Class    

    class Bank
    {
        public static float balance = 1000000;
        public const float creditLimit = 500000;
        public readonly float creditAmount;

        public Bank(float amount)
        {
            creditAmount -= amount; 
            }

        public void withdraw(float amount)
        {
            if (amount < creditAmount) 
            balance -= amount;
        }
    }

    class MyClass
    {
        public readonly int var = 10;
        public readonly int[] myArr = {1,2,3 };

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.Print();
            Student st2 = new Student();
            st2.Print();
            Console.WriteLine();

            Bank filial1 = new Bank(200000);
            Bank filial2 = new Bank(100000);
            Console.WriteLine($"Первому филиалу доступно {Bank.balance:N}");
            Console.WriteLine($"Второму филиалу доступно {Bank.balance:N}");
            filial1.withdraw(200000);
            Console.WriteLine($"В первом филиале взяли кредит на 200000, осталось {Bank.balance:N}");
            Console.WriteLine($"Второму филиалу доступно {Bank.balance:N}");
            filial2.withdraw(700000);
            Console.WriteLine($"Во втором филиале взяли кредит на 700000, кредит не был предоставлен, осталось {Bank.balance:N}");


            Console.WriteLine();

            MyClass obj = new MyClass();
            obj.myArr[0] = 11;
            obj.myArr[0] = 12;
            Console.WriteLine(obj.myArr[0]);


            Console.ReadKey();
        }
    }
}
