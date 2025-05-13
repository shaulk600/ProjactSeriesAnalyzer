using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjactSeriesAnalyzer
{
    internal class Program
    {
        /*
         a Method that print of array
        @param : array
        @return :  = print of Console.
         */
        static void displayArr(int[] arr)
        {
            Console.Write("this array :");
            foreach (int i in arr)
            {
                Console.Write(i);
            }
            Console.WriteLine(' ');
        }
        /*
         a Method that print of array - Revers!
        @param : array
        @return :  = print of Console.
         */
        static void displayArrRevers(int[] arr)
        {
            Console.Write("this array :");
            for(int i = (arr.Length)-1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine(' ');
            
        }
        //static void tstSort()
        //{
        //    int[] arr = { 5, 7, 3, 1 };
        //    int[] a = addArraySort(arr);
        //    displayArrRevers(a);
        //}

        /*
         a Method that Sorted of array
        @param : array
        @return : new array of sorted.
         */
        static int[] addArraySort(int[] arr)
        {
            int[] arrSort = new int[arr.Length];
            Array.Copy(arr, arrSort, arr.Length);
            Array.Sort(arrSort);
            
            return arrSort;
        }
        static void Main(string[] args)
        {
        }
    }
}
