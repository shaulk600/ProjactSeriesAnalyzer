using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace ProjactSeriesAnalyzer
{
    internal class Program
    {
        /*
         * a Method Menu of the Projact Series Analyzer.
         @param : arr of string.
         */
        static string nenuDefult()
        {
            string choice = "";

            Console.WriteLine("Welcome to the Projact Series Analyzer!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("a. Input a Series. (Replace the current series)");
            Console.WriteLine("b. Display the series in the order it was entered.");
            Console.WriteLine("c. Display the series in the reversed order it was entered.");
            Console.WriteLine("d. Display the series in sorted order (from low to high).");
            Console.WriteLine("e. Display the Max value of the series.");
            Console.WriteLine("f. Display the Min value of the series.");
            Console.WriteLine("g. Display the Average of the series.");
            Console.WriteLine("h. Display the Number of elements in the series.");
            Console.WriteLine("i. Display the Sum of the series.");
            Console.WriteLine("j. Exit");
            
            choice = Console.ReadLine();

            //switch (choice) 
            //{
            //    case "a":
            //        break;
            //    case "b":
            //        break;
            //    case "c":
            //        break;
            //    case "d":
            //        break;
            //    case "e":
            //        break;
            //    case "f":
            //        break;
            //    case "g":
            //        break;
            //    case "h":
            //        break;
            //    case "i":
            //        break;
            //    case "j":
            //        break;
            //}
            return choice;
        }
        static void nenuMain(string input)
        {
            bool flag = true;
            while (flag)
            {
                //input request
                string returnString;
                string returnMenu;
                returnString = menuInputIsNotEmpty(input);

                //Selection menu
                returnMenu = nenuDefult();
                returnMenu = returnMenu.ToLower();
                //בדיקת יציאה
                if(returnMenu == "j")
                {
                    flag = false;
                }

                //בדיקת ערך תקין בערך שהוכנס
                int[] arr = { 0 };
                arr = menuCheckingIfPositive(returnString);
                if ((arr.Length == 1) && (arr[0] <= 0))//Error
                {
                    continue;
                }
            }
            

        }
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
         * a Method BOOL that checks if the input is empty or null.
         * and check if the string input is typed integer.
         @param input: string
            @return: void - null
         */
        static bool validationOfInputIsNoEmpty(string input)
        {
            if (input == "" || input == null)
            {
                Console.WriteLine("Input cannot be empty.");
                return false;
            }
            return true;
        }
        /*
         a method Checking if input is Empty and ask your user input again
        @param: string
        @return: string not input
         */
        static string menuInputIsNotEmpty(string input)
        {
            string value = input;
            while (!validationOfInputIsNoEmpty(value))
            {
                value = getInputNumbers();
            }
            return input;
        }



        /*
         * a Method that chenges the string of numbers to array.
         @param input: string
            @return: Array of numbers.
         */
        static int[] changingNumbersToArrays(string input) 
        {
            if(!validationOfInputIsNoEmpty(input))
            {
                int[] empty = { -1 }; //flag for empty array.
                return empty;
            }
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
                    Console.WriteLine("Input must contain only numbers. (Error Type). ");
                    int[] empty = { -1 }; //flag for empty array.
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
            foreach (int i in arr)
            {
                if (i < 0)
                {
                    Console.WriteLine("Input must be positive. (Error Negative). ");
                    return false;
                }
            }
            return true;
        }



        /*
         A menu Method that Checks whether values ​​in a string -
        before converting them to an array are positive.
        @params: string from user
        @return: int[] of numbers including a sanity check
        EX: if return array {<0} - is Error
         */
        static int[] menuCheckingIfPositive(string input)//מופעל אחרי קליטת ערך תפריט
        {
            int[] arr = { 0 };
            
            arr = changingNumbersToArrays(input);

            //validation to return from "changingNumbersToArrays"
            if (arr[0] == -1) 
            {
                return arr; //Error (type char) | arr = -1
            }
            else
            {
                if(!getNumberSeriesIsPositive(arr))
                {
                    return arr; //Error (negative) |arr = 0
                }
                else
                {
                    //v
                    return arr; // arr = value
                }
            }     
        }

        //static void tstOfEnterValue()
        //{
        //}

        /*
         Main method
         */
        static void Main(string[] args)
        {
        }
    }
}
