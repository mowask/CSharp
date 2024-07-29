using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CS_L2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] arr = { 2, 4, 6, 8 };
            // Console.WriteLine(arr.Length);
            // Console.WriteLine(arr.ToString());

            // PrintArr("arr", arr);           

            //int max = MaxArr(arr);
            // Console.WriteLine(max);


            //int[,] arr2 = new int [4,3]; 
            //for (int i = 0; i <4; i ++)
            //{
            //    for ( int j = 0; j<3; j++)
            //    {
            //        arr2[i,j] = i+j; 
            //    }
            //}
            //PrintArr2D("arr2 ", arr2);
            //Console.WriteLine("Sum = " + SumArr2D(arr2));


            //int[][] arr3 = new int[3][];
            //arr3[0] = new int[] { 2, 4 };
            //arr3[1] = new int[] { 5, 10, 15 }; 
            //arr3[2] = new int[] { 1 }; 

            //for ( int i = 0; i<arr3.Length; i ++)
            //{
            //    for (int j= 0; j< arr3[i].Length; j++)
            //        Console.Write(arr3[i][j]+ " ");
            //    Console.WriteLine();
            //}


            //int size = 5;
            //int[][] arr = new int[size][];
            //for ( int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = new int[i+1];
            //}
            //for ( int i = 0;i < arr.Length; i++)
            //{
            //    for ( int j = 0; j < arr[i].Length; j++)
            //    {
            //        arr[i][j] = i + j +1;
            //        Console.Write(arr[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //int[] arr5 = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(arr5.GetLength(0));
            //Array.Reverse(arr5);
            //PrintArr("arr5 after reverse", arr5);
            //int[] arr6 = arr5;
            //arr5[0] = 10;
            //PrintArr("arr5", arr5);
            //PrintArr("arr6", arr6);

            //int[] arr7 = (int[]) arr5.Clone();
            //arr5[0] = 7;
            //PrintArr("arr5", arr5);
            //PrintArr("arr7", arr7);


            //Console.WriteLine("Index of 4: " + Array.IndexOf(arr5, 4));

            //Array.Sort(arr5);
            //PrintArr("arr5 after sort", arr5);

            //Console.WriteLine("Contains 8: " + arr5.Contains(8));
            //Console.WriteLine("Contains 7: " + arr5.Contains(7));

            //Console.WriteLine("Sum: " + arr5.Sum());
            //Console.WriteLine("Min: " + arr5.Min());
            //Console.WriteLine("Max: " + arr5.Max());

            //foreach (int element in arr5)
            //{ 
            //    Console.Write(element + " ");
            //}
            //Console.WriteLine();


            //int[,] arr8 = { { 1, 2, 3, }, { 8, 9, 10, } };
            //foreach(int element in arr8)
            //{
            //    Console.Write(element + " ");
            //}
            //Console.WriteLine();


            //int[][] arr9 = new int[3][] 
            //{
            //    new int [3] {1, 2, 3},
            //    new int [2] {1, 2},
            //    new int [4] {1, 2, 3, 4} 
            //};

            //foreach (int[] array in arr9)
            //{
            //    foreach (int element in array)
            //        Console.Write(element + " ");
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

                     
            Random random = new Random();
            //Console.WriteLine(random.Next());
            //Console.WriteLine(random.Next(500));
            //Console.WriteLine(random.Next(-100, 100));

            int[,] arr10 = new int[5,5];
            FillRandom2D(arr10);
            PrintArr2D("arr10", arr10);

            //int iMax = 0, jMax = 0;
            //int iMin = 0, jMin = 0;
            //for (int i = 0; i < arr10.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr10.GetLength(1); j++)
            //    {
            //        if (arr10[iMax, jMax] < arr10[i, j])
            //        {
            //            iMax = i;
            //            jMax = j;
            //        }
            //        if (arr10[iMin, jMin] > arr10[i, j])
            //        {
            //            iMin = i;
            //            jMin = j;
            //        }
            //    }
            //}
            //Console.WriteLine("Min: " + arr10[iMin, jMin]);
            //Console.WriteLine("Max: " + arr10[iMax, jMax]);


            //    int min = 0;
            //    foreach (int elem in arr10)
            //         min = (elem < min) ? elem : min;
            //    Console.WriteLine("min = " + min);







            Console.ReadKey();
        }

        //=============================================================================


        static void FillRandom(int[] arr)
        {
            Random random= new Random();
            for ( int i = 0; i<arr.Length; i++) 
            {
                arr[i] = random.Next(0, 10);    // 0 - 9
            }
        }

        static void FillRandom2D (int[,] arr)
        {
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i,j] = random.Next(-100, 101);    // -100 100
            }
        }
               


        static int SumArr2D( int[,] arr)
        {
            int sum = 0;
            for ( int i = 0; i<arr.GetLength(0); i++)
                for ( int j = 0;j<arr.GetLength(1); j++)
                sum += arr[i,j];
            return sum;
        }

        static void PrintArr2D (string text, int[,] arr)
        {
            Console.WriteLine(text + ":\n");
            for ( int i = 0; i < arr.GetLength(0); i++ )
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i,j]+ " ") ;
                Console.Write('\n'); 
            }
            Console.WriteLine() ;
        }

        static int MaxArr(int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
               max = max > arr[i] ? max : arr[i];                   
            }
            return max;
        }


        static void PrintArr(string text, int[] arr)
        {
            Console.Write(text + ": ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.Write('\n');
        }
    }
}
