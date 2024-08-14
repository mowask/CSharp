using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_m02_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();            
            string[] strings = str.Split(new char[] {'.'}, StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            foreach (string s in strings)
            {
                string trimS = s.Trim();    // убираем пробелы перед строкой
                string newstr = char.ToUpper(trimS[0]) +  trimS.Substring(1) + ". ";    // собираем предложение
                // Console.Write(newstr);
                result += newstr;
            }
            
            Console.Write(result);

            Console.ReadKey();
        }
    }
}
