using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_L7
{
    internal class MultArray
    {
        int[,] array;
        public int Rows { get; set; }
        public int Cols { get; set; }
        public MultArray (int rows, int cols)
        {
            Rows= rows;
            Cols= cols;
            array = new int[rows, cols];
        }

        public int this[int r, int c]
        {
            get { return array[r, c]; }
            set { array[r, c] = value; }
        }
    }
}
