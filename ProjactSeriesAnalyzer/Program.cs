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
         * a Method that takes a string of numbers received from the user.
         @param input: null
            @return: a string of numbers
         */
        static string getInputNumbers()
        {
            string input;
            Console.WriteLine("Enter a series of positive numbers: ");
            input = Console.ReadLine();
            return input;
        }

        /*
         * a Method that checks if the input is empty or null.
         @param input: string
            @return: void
         */
        static void validationOfInput(string input)
        {
            if (input == "" || input == null)
            {
                Console.WriteLine("Input cannot be empty.");
                return ;
            }
        }

        /*
         * a Method that chenges the string of numbers to array.
         @param input: string
            @return: Array of numbers.
         */
        static Array changingNumbersToArrays(string input) 
        {
            string[] check = input.Split(' ');
            int[] numbers = new int[check.Length];

            for (int i = 0; i < check.Length; i++)
            {
                int num = 0;
                bool isTypeInt = int.TryParse(check[i], out num);
                if (isTypeInt)
                {
                    numbers[i] = num;
                    continue;
                }
                else
                {
                    Console.WriteLine("Input must contain only numbers.");
                    int[] empty = { 000 }; //flag for empty array.
                    return empty;
                }
            }
            return numbers;
        }
        static void getNumberSeries()
        {

        }
        static void Main(string[] args)
        {
        }
    }
}
