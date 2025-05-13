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
        static void Main(string[] args)
        {
        }
    }
}
