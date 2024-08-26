using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class EnglishRussian : Dictionary
    {

        string dictionaryFilePath = "dictionary.txt";

        EnglishRussian(string name, string path) : Dictionary base(, )


        public override void LoadDictionary(dictionaryFilePath)
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
    }
}
