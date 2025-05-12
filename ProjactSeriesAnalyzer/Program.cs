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
         * and check if the string input is typed integer.
         @param input: string
            @return: void - null
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
        static int[] changingNumbersToArrays(string input) 
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

        /*
         * a Method that checks if the array of numbers is positive.
         @param arr: Array of numbers
        @return: true if all numbers are positive, false if any number is negative.
         */
        static bool getNumberSeriesIsPositive(int[] arr)
        {
            // int[] arr = new int[10];
            foreach (int i in arr)
            {
                if (i < 0)
                {
                    Console.WriteLine("Input must be positive.");
                    return false;
                }
            }
            return true;
        }

        /*
         Main method
         */
        static void Main(string[] args)
        {
        }
    }
}
