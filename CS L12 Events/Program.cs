using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L12_Events
{
   
    /// <summary>
    /// 
    /// Action < >          -   void
    /// 
    /// Predicate < >       -   bool
    /// 
    /// Func < >            -   мы сами в <> указываем какой тип фунция возвращает 
    /// 
    /// </summary>



    internal class Program
    {

        // delegate bool FilterInt(int x);      // Predicate <int>

        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int sumOfEvenNumbers = Sum(arr, (int x) => x % 2 == 0);
            Console.WriteLine(sumOfEvenNumbers);

            int sumOfOddNumbers = Sum(arr, delegate (int x) { return x % 2 != 0; });
            Console.WriteLine(sumOfOddNumbers);

            int sumOfTreeDev = Sum(arr, (int x) => x % 3 == 0);
            Console.WriteLine(sumOfTreeDev);

            //////////////////////////////////////////////////////////////////////////////////////////////////////
            ///

            //BankAccount ba = new BankAccount(100000M);
            //ba.Notify += SMSService.sendMessage;
            //ba.Notify += AndroidService.showNotification;

            ////  анонимный метод
            //ba.Notify += delegate (string t) { Console.WriteLine($"Anonimus: {t}"); };
            //// то же самое через лямбда-выражение
            //ba.Notify += (string t) => Console.WriteLine($"Anonimus: {t}\n");


            //ba.Withdraw(1000);
            //ba.Withdraw(100000);
            //ba.Deposit(5000);
            //ba.Deposit(-5000);

            ///////////////////////////////////////////////////////////////////////////////////////////////////


            DoOperation(10, 6, Add);
            DoOperation(10, 6, (int x, int y) => Console.WriteLine($"{x}*{y} = {x * y}") );

            showResult(4, 2, (int x, int y) => x + y);
            showResult(4, 2, (int x, int y) => x - y);
            showResult(4, 2, (int x, int y) => x * y);


            Console.ReadKey();
        }



        static void showResult (int x, int y, Func <int, int , int> op)
        {
            Console.WriteLine("Result = " + op(x, y));
        }

        static void Add (int x, int y)
        {
            Console.WriteLine($"{x}+{y} = {x + y}");
        }

        static void DoOperation (int a, int b, Action <int, int> op)
        {
            op(a, b);
        }

        static int Sum(int[] numbers, /*  FilterInt func  =  */  Predicate <int> func )
        {
            int result = 0;
            foreach ( int i in numbers )
            {
                if (func(i))
                    result += i;
            }
            return result;
        } 
    }
}
