using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjactSeriesAnalyzer
{
    internal class Program
    {
        ///*
        // * a Method this calculate value Max of array
        // * @param: array of index Int
        // @return: int - the Max value of Array
        // */
        //static int MethodOfMaxValue(int[] arr)
        //{
        //    int numberFlagMax = 0;

        //    foreach (int i in arr) 
        //    {
        //        int num = i;
        //        if(num > numberFlagMax)
        //        {
        //            numberFlagMax = num;
        //        }
        //    }
        //    return numberFlagMax;
        //}

        ///*
        // * a Method this calculate value Min of array
        // * @param: array of index Int
        // @return: int - the Min value of Array
        // */
        //static int MethodOfMinValue(int[] arr)
        //{
        //    int numberFlagMin = 0;

        //    foreach (int i in arr)
        //    {
        //        int num = i;
        //        if (num < numberFlagMin)
        //        {
        //            numberFlagMin = num;
        //        }
        //    }
        //    return numberFlagMin;
        //}

        /*
         * a Method this calculate sum this array.
         * @param: array of index Int
         @return: int - the sum value of Array
         */
        static int MethodOfSumValue(int[] arr)
        {
            int numberSum = 0;
            
            foreach (int i in arr)
            {
                numberSum += i;
            }
            return numberSum;
        }

        /*
         * a Method this calculate Average this array.
         * @param: array of index Int
         @return: int - the Average value of Array
         */
        static int MethodOfAverageValue(int[] arr)
        {
            int sum = 0, calculate = 0;
            double cal = 0;
            
            sum = MethodOfSumValue(arr);

            cal = sum / (arr.Length);
            calculate = Convert.ToInt32(cal);
            return calculate;
        }

        /*
         @param: array of index Int
         @return: int - length of array
        */
        static int MethodOfAllIndex(int[] arr)
        {
            return arr.Length;
        }

        static void Main(string[] args)
        {
        }
    }
}
