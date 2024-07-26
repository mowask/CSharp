using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CS_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World");                        // Cout + /n
            //Console.WriteLine("Привет, Мир");                        // Cout + /n
            //Console.ReadLine();                                      // Cin (getLine)


            //Console.WriteLine("Введите ваше имя");
            //string name;
            //name = Console.ReadLine();
            //if (name == "")                    
            //Console.WriteLine("Привет, Мир");                        // Cout + /n
            //else
            //    Console.WriteLine("Привет, " + name + "!");
            //Console.ReadLine();                                      // Cin (getLine)

            //--------------------------------------------------------------------------

            //System.Int16 x = 0xf;
            //Console.WriteLine(x);
            //Console.ReadLine();

            //bool y = true;
            //Console.WriteLine(y);
            //Console.ReadLine();

            //------------------------------------------------------------------------

            //decimal x = 1M;         
            //Decimal y = 3m;
            //decimal z = x / y;
            //Console.Write("x / y = ");
            //Console.WriteLine(z);
            //Console.Write("z * y = ");
            //Console.WriteLine(z*y);

            //double x1 = 1d;
            //System.Double y1 = 3D;
            //Double z1 = x1 / y1;
            //Console.Write("x1 / y1 = ");
            //Console.WriteLine(z1);
            //Console.Write("z1 * y1 = ");
            //Console.WriteLine(z1 * y1);

            //Console.WriteLine(Environment.NewLine);
            //// ----------------------------------------------------

            //Console.WriteLine(char.IsDigit('5'));
            //Console.WriteLine(char.IsLetter('x'));
            //Console.WriteLine(char.IsLower('m'));
            //Console.WriteLine(char.IsUpper('P'));
            //Console.WriteLine(char.IsWhiteSpace(' '));
            //Console.WriteLine(char.ToLower('T'));
            //Console.WriteLine(char.ToUpper('t'));
            //Console.ReadLine();

            //Console.WriteLine(Environment.NewLine);
            //// ----------------------------------------------------

            //int? x = null;
            //string z = null;

            //int x1 = x ?? 0;                                    //     int x1 = x != null ? x : 0;
            //Console.WriteLine(x1);

            //Console.WriteLine(Environment.NewLine);
            //// ----------------------------------------------------


            //Console.Title = "Change Colnsole title";                                                    // смена названия консоли
            //Console.BackgroundColor= ConsoleColor.Green;
            //Console.ForegroundColor= ConsoleColor.Red;
            //Console.Clear();
            //Console.WriteLine("Input encoding: " + Console.InputEncoding.ToString());                   // информация о кодировке потока ввода
            //Console.WriteLine("OutputMethod encoding: " + Console.OutputEncoding.ToString());           // информация о кодировке потока вывода

            //Console.ResetColor();                                                                      // цвет по умолчанию

            //Console.WriteLine("is CAPS LOCK turned on: " + Console.CapsLock.ToString());            // проверка каплок
            //Console.Write("Enter a simple message: ");
            //string message = Console.ReadLine();
            //Console.WriteLine("Your message " + message);

            //Console.Read();

            //// ----------------------------------------------------

            //byte a = 55;
            //int b = a + 70;
            //Console.WriteLine(b);

            //int c = b;
            //byte e = (byte) (c + 70);
            //Console.WriteLine(e);

            //Console.ReadKey();

            //// ----------------------------------------------------

            //int x, y;
            //string str = Console.ReadLine();

            //x = int.Parse(str);
            //x++;
            //Console.WriteLine(x);

            //y= Convert.ToInt32(str);
            //y *= 2;
            //Console.WriteLine(y);

            //Console.ReadKey();

            //// ----------------------------------------------------


            int x = int.Parse(Console.ReadLine());
            if (x >= 0 && x <= 100)
            {
                if (x % 5 == 0 && x % 3 == 0) Console.Write("Fizz Buzz");
                else if (x % 3 == 0) Console.WriteLine("Fizz");
                else if (x % 5 == 0) Console.WriteLine("Buzz");                
                else Console.WriteLine(x);
            }            
            else Console.WriteLine("Error: integer not Correct");
            Console.ReadKey();



        }
    }
}
