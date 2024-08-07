using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L7
{
    internal class Shop
    {
        Laptop[] laptopArr;
        public Shop(int size)
        {
            laptopArr = new Laptop[size];
        }
        public int Length
        {
            get { return laptopArr.Length; }
        }

        public Laptop this[int index]
        {
            get {
                if (index >= 0 && index < laptopArr.Length)
                {
                    return laptopArr[index];
                }
                throw new IndexOutOfRangeException();
             }
            set {
                laptopArr[index] = value;
                return;
                throw new IndexOutOfRangeException();
            }
        }

        public int this[string vendor]
        {
            get
            {
                for (int i = 0; i <laptopArr.Length; i++)
                {
                    if (laptopArr[i].Vendor == vendor)
                        return i;
                    
                        
                }
                return -1;
            }

        }
    }
}
