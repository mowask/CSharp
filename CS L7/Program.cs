using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Net.Mime.MediaTypeNames;

namespace CS_L7
{
    internal class Program
    {
        static void Test(int[] arr)
        {
            Console.WriteLine(arr.Length);
        }

        static void Main(string[] args) {

            string s1 = "Hello";
            s1 = s1 + " World";
            s1 = s1 + "!";

            StringBuilder sb1 = new StringBuilder("Hello", 50);
            sb1.Append(" World");
            sb1.Append("!");
            sb1.Insert(12, " Hello Again");
            sb1.Replace('H', 'h');
            sb1.Replace("ello", "e11o");

            string s2 = sb1.ToString();
            Console.WriteLine(s2);



///////////////////////////////////////////////////////////////////////////////////////////////


            //MultArray ma = new MultArray(2,2);
            //for (int i = 0; i<ma.Rows;i++)
            //{
            //    for (int j = 0; j < ma.Cols; j++)
            //        Console.WriteLine(ma[i, j]);
            //    Console.WriteLine();
            //}


        //  Shop laptops = new Shop(3);
        //  laptops[0] = new Laptop { Vendor = "Samsung", Price = 5200};
        //  laptops[1] = new Laptop { Vendor = "Asus", Price = 4700};
        //  laptops[2] = new Laptop { Vendor = "LG", Price = 4300};

        //    try
        //    {
        //        for (int i = 0; i < laptops.Length; i++)
        //        {
        //            Console.WriteLine(laptops[i]);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //    int index = laptops["LG"];
        //    if (index != -1)
        //        Console.WriteLine(laptops[index]);


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        
            //BankAccount account = new BankAccount { AccauntNumber = 123, Balance = 100000, Name = "John"   };                       
            
            //decimal amount;
            //bool exit = false;
            //while (!exit)
            //{
            //    // Console.Clear();
            //    Console.WriteLine("Coose Operation");
            //    Console.WriteLine("1. Withdraw");
            //    Console.WriteLine("2. Deposit");
            //    Console.WriteLine("3. Print");
            //    Console.WriteLine("4. Exit");

            //    int choice = Convert.ToInt32(Console.ReadLine());
            //    switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine("Enter Amount");
            //            amount = Convert.ToDecimal(Console.ReadLine());
            //            account.Withdraw(amount);
            //            break;
            //        case 2:
            //            Console.WriteLine("Enter Amount");
            //            amount = Convert.ToDecimal(Console.ReadLine());
            //            account.Deposit(amount);
            //            break;
            //        case 3:
            //            Console.WriteLine(account);
            //            break;
            //        case 4:
            //            exit = true;
            //            break;
            //    }
            //    Console.WriteLine("----------------------------------");
            //}



            //try
            //{
            //    Console.WriteLine("Введите имя: ");
            //    string name = Console.ReadLine();
            //    if (name.Length < 2)
            //    {
            //        throw new Exception("Длина имени меньше 2 символов");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Ваше имя: ");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Ошибка: {e.Message}");
            //}

            //try
            //{
            //    //int[] arr = null;
            //    //Test(arr);
            //    //int x = arr[5];
            //    //int y = 0;
            //    //int z = x / y;
            //    int x = int.Parse(Console.ReadLine());
            //    int y = x/0;
            //    Console.WriteLine($"РезультатЖ {y}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Messege: " + ex.Message);
            //    Console.WriteLine("Source: " + ex.Source);
            //  //  Console.WriteLine("StackTrace: " + ex.StackTrace);
            //}
            ////catch (DivideByZeroException)
            ////{
            ////    Console.WriteLine("Error: Divide ByZero!");
            ////}
            ////catch (IndexOutOfRangeException)
            ////{
            ////    Console.WriteLine("Error: Index Out Of Range!");
            ////}
            //finally
            //{
            //Console.WriteLine("Finally");
            //}
            //Console.WriteLine("Test");


            Console.ReadKey();

        }
    }
}
