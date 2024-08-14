using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CS_HW_Caesar_cipher
{
    internal class Program
    {
        static string EncriptText(string text, int key)
        {            
            char[] arr = text.ToCharArray();
            string result = "";
            foreach (char i in arr)
            {                
                char ch = (char)(i + key);
                //Console.Write((char)(c+cipher));
                //Console.Write(ch);
                result += ch;
            }          
            return result;
        }

        static string Decipher (string EncriptedText, int key)
        {
            char[] arr = EncriptedText.ToCharArray();
            string result = "";
            foreach (char i in arr)
            {
                char ch = (char)(i - key);                
                result += ch;
            }
            return result;
        }

        static void Main(string[] args)
        {
            int key = 3;
            Console.Write("Строка для ширования: ");
            string text = Console.ReadLine();
                              
            string EncriptedText = EncriptText(text, key);
            Console.WriteLine("Зашифрованный текст: " + EncriptedText);
            Console.WriteLine("Расшифрованный текст: " + Decipher(EncriptedText, key));


            Console.ReadKey();
        }
    }
}
