﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Dictionary
{
    internal class Dictionary
    {
        //string _name {  get; set; }
        string _dictionaryFilePath { get; set; }

        Dictionary<string, List<string>> _dictionary;


        public Dictionary(string dictionaryFilePath)
        {          
            _dictionaryFilePath = dictionaryFilePath;
            _dictionary = new Dictionary<string, List<string>>();
        }

        public void LoadDictionary()
        {
            if (File.Exists(_dictionaryFilePath))
            {
                string[] lines = File.ReadAllLines(_dictionaryFilePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        var word = parts[0];
                        var translations = parts[1].Split(',');
                        _dictionary[word] = new List<string>(translations);
                       // foreach (var item in _dictionary[word])
                       //     item.Trim();
                    }
                }
            }
        }

         public void SaveDictionary()
        {
            List<string> lines = new List<string>();
            foreach (var item in _dictionary)
            {
                lines.Add($"{item.Key}:{string.Join(",", item.Value)}");
            }
            File.WriteAllLines(_dictionaryFilePath, lines);
        }

        public  void FindTranslation()
        {
            Console.Write("Введите слово для поиска: ");
            var word = Console.ReadLine();
            if (_dictionary.ContainsKey(word))
            {
                Console.WriteLine("Переводы:");
                foreach (var translation in _dictionary[word])
                {
                    Console.WriteLine($"- {translation}");
                }
            }
            else
            {
                Console.WriteLine("Слово не найдено.");
            }
        }

        public void AddWord()
        {
            Console.Write("Введите слово: ");
            var word = Console.ReadLine();
            Console.Write("Введите перевод (через запятую): ");
            var translations = Console.ReadLine().Split(',');

            if (!_dictionary.ContainsKey(word))
            {
                _dictionary[word] = new List<string>(translations);
            }
            else
            {
                _dictionary[word].AddRange(translations);
            }
        }

        public void ReplaceWordOrTranslation()
        {
            Console.Write("Введите слово для замены: ");
            var word = Console.ReadLine();

            if (_dictionary.ContainsKey(word))
            {
                Console.Write("Введите новый перевод (через запятую): ");
                var translations = Console.ReadLine().Split(',');
                _dictionary[word] = new List<string>(translations);
            }
            else
            {
                Console.WriteLine("Слово не найдено.");
            }
        }

        public void DeleteWord()
        {
            Console.Write("Введите слово для удаления: ");
            var word = Console.ReadLine();

            if (_dictionary.ContainsKey(word))
            {
                _dictionary.Remove(word);
                Console.WriteLine("Слово удалено.");
            }
            else
            {
                Console.WriteLine("Слово не найдено.");
            }
        }


    }
}
