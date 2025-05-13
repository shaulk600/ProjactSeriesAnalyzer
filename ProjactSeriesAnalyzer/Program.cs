using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjactSeriesAnalyzer
{
    internal class Program
    {
        static int MethodOfMaxValueOfSorted(int[] arr)
        {
            addArraySort(arr);
            return arr[(arr.Length)-1];
        }
        static int MethodOfMinValueOfSorted(int[] arr)
        {
            addArraySort(arr);
            return (arr[0]);
        }

        /*
         a Method that print of array
        @param : array
        @return :  = print of Console.
         */
        static void displayArr(int[] arr)
        {
            addArraySort(arr);
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
            addArraySort(arr);
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
        //    menuOfSorted("e", arr);
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

        /*
         A guided method Sorted (Menu option D,E,F).
        @param: 1. string of Menu, 2. array of numbers(int).
         */
        static void menuOfSorted(string txt , int[] arr) //2 Value
        {
            
            //validetion
            if(txt == null || txt == "")
            {
                return; //Error
            }
            else if ( (txt.ToLower() != "d") && (txt.ToLower() != "e") && (txt.ToLower() != "f"))
            {
                return; //Error
            }
            else 
            {
                if (txt.ToLower() == "d")
                {
                    // הצג את הסדרה בסדר ממוין(מהנמוך לגבוה).
                    displayArr(arr);
                }
                else if (txt.ToLower() == "e")
                {
                    // הצג את הערך המקסימלי של הסדרה.
                    int ressponse = MethodOfMaxValueOfSorted(arr);
                    Console.WriteLine("this Max Value is: " + ressponse);
                    return;
                }
                else if (txt.ToLower() == "f")
                {
                    // הצג את הערך המינימלי של הסדרה.
                    int ressponse = MethodOfMinValueOfSorted(arr);
                    Console.WriteLine("this Min Value is: " + ressponse);
                    return;
                }
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
