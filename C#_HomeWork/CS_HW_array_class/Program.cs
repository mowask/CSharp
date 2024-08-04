using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_array_class
{
    class Website 
    {
        private string _name;
        private string _url;
        private string _description;
        private string _ip;

        public Website(string name, string url, string description, string ip) {
            _name = name;            
            _url = url;
            _description = description;
            _ip = ip;
        }
        public string GetDescription() { return _description; }
        public string ChangeDescription (string newDescription) {  return _description = newDescription; }
        public void Print() { Console.WriteLine($"Web-site name: {_name} \nurl: {_url} \ndescription: {_description} \nip address: {_ip}"); }
    }

    internal class Program
    {
        static void PrintArr(char[,] arr, int a, char symbol)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                    Console.Write(symbol + " ");
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            Website website = new Website("Cheese-cake.ru", "https://cheese-cake.ru/", "deserts", "185.178.208.178");
            website.Print();
            Console.WriteLine();
            website.ChangeDescription("Cakes & Icecream");
            website.Print();
            Console.WriteLine("\n==============================================\n");

            Console.WriteLine("Length: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Symbol: ");
            char symbol = char.Parse(Console.ReadLine());
            char[,] array = new char[a, a];
            Console.WriteLine();
            PrintArr(array, a, symbol);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
