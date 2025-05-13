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

        //static void tstOfCal()
        //{
        //    int[] arr = { 5, 4, 8, 3, 2 };
        //    menuOfCalculate("h", arr);
        //}

        static void menuOfCalculate(string txt, int[] arr) //2 Value
        {
            // G H I
            txt = txt.ToLower();
            //validetion
            if (txt == null || txt == "")
            {
                return; //Error
            }
            else if ((txt.ToLower() != "g") && (txt.ToLower() != "h") && (txt.ToLower() != "i"))
            {
                return; //Error
            }
            else
            {
                if (txt.ToLower() == "g")
                {
                    //הצג את הממוצע של הסדרה.
                    int sum = MethodOfAverageValue(arr);
                    Console.WriteLine("this Average is: " + sum);
                    return;
                }
                else if (txt.ToLower() == "h")
                {
                    // הצג את מספר האיברים בסדרה.
                    int sum = MethodOfAllIndex(arr);
                    Console.WriteLine("this index of Array is: " + sum);
                    return;
                }
                else if (txt.ToLower() == "h")
                {
                    //הצג את סכום הסדרה.
                    int sum = MethodOfSumValue(arr);
                    Console.WriteLine("this sum of Array is: " + sum);
                    return;
                }
            }//end validetion
        }
        static void Main(string[] args)
        {
        }
    }
}
