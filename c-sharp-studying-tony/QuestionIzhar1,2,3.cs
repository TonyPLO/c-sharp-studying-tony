using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony
{
    public class IzharQuestions
    {


        public static void Test()
        {
            NumberChecker();
            //ValidateString();

            int[] balanced = { 1, 2, -3, 4, -5, -52 };
            int[] balanced2 = { 1, 2, -2, -3 };
            int[] notBalanced = { 1, 2, 3, -4 };
            int[] notBalanced2 = { 13, -20, 5, -5, 0 };

            IsBalancedArray(balanced);
            Console.WriteLine();
            IsBalancedArray(balanced2);
            Console.WriteLine();
            IsBalancedArray(notBalanced);
            Console.WriteLine();
            IsBalancedArray(notBalanced2);
        }
        //checking if there is 3 digits
        public static void NumberChecker()
        {
            int maxNumber = 0;
            int minNumber = 0;
            Console.Write("Enter a whole number: ");
            int number = Int32.Parse(Console.ReadLine());
            //bool validInput = // Console.ReadLine();

            maxNumber = number;
            minNumber = number;
            //while (!((number >= 100 && number <= 999) || (number <= -100 && number >= -999)))
            //while (!(+number >= 100 && +number <= 999) )

            while (!(Math.Abs(number) >= 100 && Math.Abs(number) <= 999))
            {



                {
                    Console.Write("Enter another whole number: ");
                    number = Int32.Parse(Console.ReadLine());

                    if (number > maxNumber)
                    {
                        maxNumber = number;
                    }

                    if (number < minNumber)
                    {
                        minNumber = number;
                    }


                }
            }
            Console.WriteLine($"The largest number received: {maxNumber}");
            Console.WriteLine($"The smallest number received: {minNumber}");

        }

        public static void ValidateString()
        {
            int validCount = 0;
            int invalidCount = 0;

            for (int i = 0; i < 23; i++)
            {
                Console.Write("Insert Some String: ");
                string input = Console.ReadLine();

                if (IsValid(input))
                {
                    validCount++;
                }
                else
                {
                    invalidCount++;
                }
            }

            Console.WriteLine($"מספר המחרוזות התקינות: {validCount}");
            Console.WriteLine($"מספר המחרוזות הלא תקינות: {invalidCount}");
        }

        public static bool IsValid(string s)
        {
            if (s.Length % 2 == 0)
            {
                return false;
            }

            int midIndex = s.Length / 2;

            if (s[0] == s[midIndex] && s[0] == s[s.Length - 1])
            {
                return true;
            }

            return false;
        }

        public static void IsBalancedArray(int[] arr)
        {
            //int[] arr = { -3, 5, -2, 4, -1, 2 };

            int positiveCount = 0;
            int negativeCount = 0;
            bool zeroFound = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    positiveCount++;
                else if (arr[i] < 0)
                    negativeCount++;
                else
                {
                    zeroFound = true;
                    break;//break the loop. 
                }
            }


            if (positiveCount == negativeCount && !zeroFound)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            else
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    Console.Write(arr[i] + " ");
                }
            }

        }



    }
}



