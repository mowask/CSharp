using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        private static Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
        private const string dictionaryFilePath = "dictionary.txt";

        static void Main(string[] args)
        {
            LoadDictionary();


            //foreach (string key in dictionary.Keys)
            //{
            //    Console.WriteLine(key);
            //}
            //Console.ReadKey();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Меню:");
                Console.WriteLine("1. Найти перевод слова");
                Console.WriteLine("2. Добавить слово и перевод");
                Console.WriteLine("3. Заменить слово или перевод");
                Console.WriteLine("4. Удалить слово");
                Console.WriteLine("5. Экспортировать слово в файл");
                Console.WriteLine("6. Выйти");
                Console.Write("Выберите пункт меню: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        FindTranslation();
                        break;
                    case "2":
                        AddWord();
                        break;
                    case "3":
                        ReplaceWordOrTranslation();
                        break;
                    case "4":
                        DeleteWord();
                        break;
                    case "5":
                        //ExportDictionary();
                        break;
                    case "6":
                        SaveDictionary();
                        return;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }

        private static void LoadDictionary()
        {
            if (File.Exists(dictionaryFilePath))
            {
                string[] lines = File.ReadAllLines(dictionaryFilePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        var word = parts[0];
                        var translations = parts[1].Split(',');
                        dictionary[word] = new List<string>(translations);
                    }
                }
            }
        }

        private static void SaveDictionary()
        {
            List<string> lines = new List<string>();
            foreach (var item in dictionary)
            {
                lines.Add($"{item.Key}:{string.Join(",", item.Value)}");
            }
            File.WriteAllLines(dictionaryFilePath, lines);
        }

        private static void FindTranslation()
        {
            Console.Write("Введите слово для поиска: ");
            var word = Console.ReadLine();
            if (dictionary.ContainsKey(word))
            {
                Console.WriteLine("Переводы:");
                foreach (var translation in dictionary[word])
                {
                    Console.WriteLine($"- {translation}");
                }
            }
            else
            {
                Console.WriteLine("Слово не найдено.");
            }
        }

        private static void AddWord()
        {
            Console.Write("Введите слово: ");
            var word = Console.ReadLine();
            Console.Write("Введите перевод (через запятую): ");
            var translations = Console.ReadLine().Split(',');

            if (!dictionary.ContainsKey(word))
            {
                dictionary[word] = new List<string>(translations);
            }
            else
            {
                dictionary[word].AddRange(translations);
            }
        }

        private static void ReplaceWordOrTranslation()
        {
            Console.Write("Введите слово для замены: ");
            var word = Console.ReadLine();

            if (dictionary.ContainsKey(word))
            {
                Console.Write("Введите новый перевод (через запятую): ");
                var translations = Console.ReadLine().Split(',');
                dictionary[word] = new List<string>(translations);
            }
            else
            {
                Console.WriteLine("Слово не найдено.");
            }
        }

        private static void DeleteWord()
        {
            Console.Write("Введите слово для удаления: ");
            var word = Console.ReadLine();

            if (dictionary.ContainsKey(word))
            {
                dictionary.Remove(word);
                Console.WriteLine("Слово удалено.");
            }
            else
            {
                Console.WriteLine("Слово не найдено.");
            }
        }

       
    }
}