using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_m02___5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выражение с + или - ");
            string input = Console.ReadLine();
            string[] numbersStr = input.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries );
            int[] numbers = new int[numbersStr.Length];
            for (int i = 0; i < numbersStr.Length; i++)
            {
                numbers[i] = Convert.ToInt32(numbersStr[i]);
            }

            if (input[0] == '-')
            {
                numbers[0] = - numbers[0];
            }

            int sum = numbers[0];
            int j = 1;

            //foreach (int i in input)
            //{
            //    if (i == '+')
            //    {
            //        sum += numbers[j];
            //        j++;
            //    }
            //    else if (i == '-')
            //    {
            //        sum -= numbers[j];
            //        j++;
            //    }
            //}     

            for (int i = 1; i < input.Length; i++)
            {
                char symbol = input[i];
                if (symbol == '+')
                {
                    sum += numbers[j];
                    j++;
                }
                else if (symbol == '-')
                {
                    sum -= numbers[j];
                    j++;
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
