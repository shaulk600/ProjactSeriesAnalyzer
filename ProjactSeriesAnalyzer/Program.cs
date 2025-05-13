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
        //מכאן Sort

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
        if flag is true, array is Sort
        @param : array
        @return :  = print of Console.
         */
        static void displayArr(int[] arr, bool flag = false)
        {
            if (flag)//sort
            {
                addArraySort(arr);
            }

            Console.Write("this array :");
            foreach (int i in arr)
            {
                Console.Write(i);
            }
            Console.WriteLine(' ');
            return;
        }
        /*
         a Method that print of array - Revers!
        if flag is true, array is Sort
        @param : array
        @return :  = print of Console.
         */
        static void displayArrRevers(int[] arr, bool flag = false)
        {
            if (flag)//sort
            {
                addArraySort(arr);
            }
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
            txt = txt.ToLower();
            //validetion
            if(txt == null || txt == "")
            {
                return; //Error
            }
            else if ((txt == "b") && (txt == "c"))
            {
                if (txt == "b")
                {
                    displayArr(arr);
                    return;
                }
                if (txt == "c")
                {
                    displayArrRevers(arr);
                    return;
                }
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
                    displayArr(arr,true);
                        return;
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
        //עד כאן Sort


        //מכאן MethodMaxAndMin
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
        // עד כאן MethodMaxAndMin

        //מכאן menu
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
        // עד כאן menu

        // enterValue-and-Validation  כאן 

         /* a Method that takes a string of numbers received from the user.
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

        
        // enterValue-and-Validation עד כאן 

        static void Main(string[] args)
        {
        }
    }
}
