using System;
//using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CS_L12
{
    public static class StringExtension
    {
        public static int CharCount (this string str, char ch)
        {
            int counter = 0;
            foreach (char c in str) 
            { 
                if (c == ch) counter++;
            }
            return counter;
        }     
    }

    public static class DoubleExtension
    {
        public static double SquareNumb (this double d) 
        { 
            return d*d;
        }
    }


    internal class Program2
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3};
            //int sumOfSquares = arr.Sum ((int x) => x*x);
            ////Console.WriteLine(sumOfSquares);

            //string str = "Hello World!";
            //int count = str.CharCount('l');
            //Console.WriteLine(count);
            //Console.WriteLine();
            //Console.WriteLine(ChCt(str, 'l'));
            //Console.WriteLine();

            //double d = 5.5;
            //Console.WriteLine(d.SquareNumb());




            ArrayList list = new ArrayList();
            list.Add(2.3);
            list.Add(55);

            Console.WriteLine("list.Capacity = " + list.Capacity);

            list.AddRange(new string[] { "Hello", "world", "!" });

            Console.WriteLine("list.Capacity = " + list.Capacity);

            //перебор значений
            foreach (object o in list)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine();

            //удаляем первый элемент
            list.RemoveAt(0);
            // переворачиваем список
            list.Reverse();

            //foreach(object o in list)
            //{
            //    Console.WriteLine(o);
            //}
            //Console.WriteLine();
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);

           // list.Sort(); //   ошибка. сортировать можно только объекты одного типа

            ArrayList list2 = new ArrayList();

            list2.Add(11);
            list2.Add(5);
            list2.Add(10);

            list2.Sort();
            // Console.WriteLine(list2.Contains(11));

            foreach (int i in list2)
                Console.WriteLine(i);


            Console.ReadKey();

        }





        static int ChCt(string str, char ch)
        {
            int counter = 0;
            foreach (char c in str)
            {
                if (c == ch) counter++;
            }
            return counter;
        }


    }

    
}
