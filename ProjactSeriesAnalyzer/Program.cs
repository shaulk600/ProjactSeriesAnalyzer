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
         * a Method this calculate value Max of array
         * @param: array of index Int
         @return: int - the Max value of Array
         */
        static int MethodOfMaxValue(int[] arr)
        {
            int numberFlagMax = 0;

            foreach (int i in arr) 
            {
                int num = i;
                if(num > numberFlagMax)
                {
                    numberFlagMax = num;
                }
            }
            return numberFlagMax;
        }

        /*
         * a Method this calculate value Min of array
         * @param: array of index Int
         @return: int - the Min value of Array
         */
        static int MethodOfMinValue(int[] arr)
        {
            int numberFlagMin = 0;

            foreach (int i in arr)
            {
                int num = i;
                if (num < numberFlagMin)
                {
                    numberFlagMin = num;
                }
            }
            return numberFlagMin;
        }
        static void Main(string[] args)
        {
        }
    }
}
