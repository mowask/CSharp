using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dictionary
{
    internal class Dictionary
    {
        string _name {  get; set; }
        string _dictionaryFilePath { get; set; }

        Dictionary (string name)
        {
            this._name = name;            
        }

        public virtual void LoadDictionary()
        {
           
        }
    }
}
