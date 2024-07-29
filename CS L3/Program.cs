using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello World!";
            //Console.WriteLine(str1);

            //char[] chars = { 'a', 'b', 'c' };
            //string str2 = new string(chars);
            //Console.WriteLine(str2);

            string str3 = new string('$', 10);
            //Console.WriteLine(str3);
            //Console.WriteLine(str1[10]);            
            //Console.WriteLine(str2.Length);

            string str4 = "12+5+9-11";
            //for (int i = 0; i < str4.Length; i++)
            //{
            //    if (Char.IsDigit(str4[i]))
            //        Console.Write(str4[i]);
            //}
            //Console.WriteLine();

            //foreach (char chr in str4)
            //{
            //     if (!Char.IsDigit(chr))
            //    // if (char.IsSymbol(chr))                        // не покажет минус
            //            Console.Write(chr);
            //}
            //Console.WriteLine();

            string str5 = "Hello ";
            string str6 = string.Copy(str5);
            string str7 = (string) str5.Clone();
            //Console.WriteLine(str5);
            //Console.WriteLine(str6);
            //Console.WriteLine(str7);

            string str10 = "Простая строка";
            //char[] chrArr = new char[6];
            //Console.WriteLine();


            //for (int i = str8.Length - 1; i >= 0; i--)                  // Реверсирование строки с помощью индекса
            //    Console.Write(str8[i]);
            //Console.WriteLine();

            //str8.CopyTo(8, chrArr, 0, 6);          // копирование 6 символов начиная с восьмой позиции и помещаем в массив
            //Console.WriteLine(chrArr);


            string str8 = "Строка";
            string str9 = "строка";

            //Console.WriteLine(str8.Equals(str9));               // сравнение строк на идентичность

            //Console.WriteLine(String.Compare(str8,str9));       // str8 > str9  =   1
            //Console.WriteLine(String.Compare(str9,str8));       // str9 < str8  =  -1
            //Console.WriteLine(str8.CompareTo(str9));
            //Console.WriteLine(str9.CompareTo(str8));
            //Console.WriteLine(str8.CompareTo(str8));            // str8 = str8  =   0
            //Console.WriteLine("\"" + str8 + "\" == \"Строка\" : " + (str8 == "Строка"));             //  == тоже самое что Equals

            //bool equalIgnoreCase = str8.Equals(str8, StringComparison.CurrentCultureIgnoreCase);        // Сравнение без учета регистра
            //Console.WriteLine(str8 + " " + str9 +" " +  equalIgnoreCase);

            //string[] strArr = { "ШАГ", "шагаем", "бежим", "ем", "Играем" };

            //                //  Слова начинающиеся на "шаг"
            //foreach (string str in strArr) {
            //    if (str.StartsWith( "шаг", StringComparison.CurrentCultureIgnoreCase)) 
            //        Console.Write(str + " ");
            //}
            //Console.WriteLine();

            //                //  Слова заканчивающиеся на "ем"
            //foreach (string str in strArr)
            //{
            //    if (str.EndsWith("ем", StringComparison.CurrentCultureIgnoreCase)) 
            //        Console.Write(str + " ");
            //}


            string str11 = "ПолиморфизмНаследованиеИнкапсуляция";
            string str12 = "АБВГДЕЖЗИКЛМН";

            //Console.WriteLine("H" + str11.IndexOf('Н'));
            //Console.WriteLine( str11.IndexOf ("Наследование")) ;
            //Console.WriteLine(str11.LastIndexOf( 'И'));
            //Console.WriteLine("Последние вхождение любого символа из строки 12" + str11.LastIndexOfAny (str12.ToCharArray())) ;
            //Console.WriteLine();
            //Console.WriteLine(str11.Substring(11, 12));                         // подстрока 12 символов начиная с 11
            //Console.WriteLine();    

            string str13 = str9 + str10 + str11;
            //Console.WriteLine("{0 } + {1 } + {2 } = {3}", str11, str10, str9, str13 );

            //str10= str10.Insert(0, "упорно ").ToUpper();
            //Console.WriteLine(str10);
            //if (str10.Contains("упорно"))
            //    Console.WriteLine("Учу таки упорно");
            //else
            //    Console.WriteLine("Учу как могу");
            //str10 = str10.PadLeft(25);                                              // символ пробел до 25 символа
            //str10 = str10.PadRight(35, '*');                                        // символ * до 35 символа
            //Console.WriteLine(str10);


            //string str14 = "aa bb cc  ++--";
            //string[] strArr = str14.Split(" +".ToCharArray(), StringSplitOptions.RemoveEmptyEntries );
            //    foreach (string str in strArr ) 
            //        Console.WriteLine( "*" + str );
            //string str15 =String.Join( " _=", strArr );
            //Console.WriteLine(str15);


            int number = 5;
            Console.WriteLine($"Number: {number, 20}.");
            double number2 = 5.22164;
            Console.WriteLine($"Number: {number2, -20 :F3}.");
            double number3 = 0.24;
            Console.WriteLine($"Number: {number3,-20 :P}.");
            double number4 = 9999999.96;
            Console.WriteLine($"Number: {number4:N}.");
            double number5 = 10;
            Console.WriteLine($"Number: {(number5 == 10 ? "ten" : "not ten")}.");



            Console.ReadKey();
        }
    }
}
