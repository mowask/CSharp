using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L11_Delegate
{
    class Welcome
    {
        public static void Print()        {            Console.WriteLine("Welcome");        }
    }
    class Hello {
    public void Display() { Console.WriteLine("Привет"); }
    }

    internal class Program
    {

        public static void SayHello()
        {
            Console.WriteLine("Hello!!");
        }


        delegate void Message();
        delegate void Operation(int x, int y);
        delegate int Operation2(int x, int y);


        static void Main(string[] args)
        {
            Message message = SayHello;
            message += Welcome.Print;
            message += new Hello().Display;
            message();
            Console.WriteLine();


            Operation op = Add;
            op += Subtract;
            op += Multiply;
            op(7, 9);
            Console.WriteLine();
            op += Multiply;
            op += Multiply;
            op -= Add;
            op(5, 3);
            Console.WriteLine();


            Operation2 op2 = Add2;
            op2+= Subtract2;
            op2+= Multiply2;
            op2+= Add2;
            int result = op2 (7, 9);
            Console.WriteLine(result);    

            Console.WriteLine();    


            foreach(Operation2 item in op.GetInvocationList())
            {
                int result2 = item(7, 9);
                Console.WriteLine(result2);
            }


            Console.ReadKey();
        }

        public static void Add( int x, int y ) { Console.WriteLine($"{x}+{y} = {x+y}"); }
        public static void Subtract( int x, int y ) { Console.WriteLine($"{x}-{y} = {x-y}"); }
        public static void Multiply( int x, int y ) { Console.WriteLine($"{x}*{y} = {x*y}"); }

        public static int Add2(int x, int y) { return x + y; }
        public static int Subtract2(int x, int y) { return x - y;  }
        public static int Multiply2(int x, int y) { return x * y; }
    }
}
