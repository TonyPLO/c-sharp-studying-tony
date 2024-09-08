using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony
{
    public class NumberChecker
    {
        public static void Test1()
        {
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            while (true)
            {
                Console.Write("הכנס מספר שלם: ");
                int number = int.Parse(Console.ReadLine());

                if (number >= 100 && number <= 999)
                {
                    break;
                }

                if (number > maxNumber)
                {
                    maxNumber = number;
                }

                if (number < minNumber)
                {
                    minNumber = number;
                }
            }

            Console.WriteLine($"המספר הגדול ביותר שנקלט: {maxNumber}");
            Console.WriteLine($"המספר הקטן ביותר שנקלט: {minNumber}");
        }




        //test -330, test first number 3 digits. 
        public static void Test2()
        {
            int min = 0, max = 0, input = 0;
            Console.WriteLine("Insert inputs");
            //init - first assigning
            input = Int32.Parse(Console.ReadLine());
            min = input;
            max = input;
            while (!(Math.Abs(input) / 10 >= 10 && Math.Abs(input) / 10 <= 99))
            {

                input = Int32.Parse(Console.ReadLine());
                if (input < min)
                {
                    min = input;
                }
                if (input > max)
                {
                    max = input;
                }

            }

            Console.WriteLine($"max = {max}, min = {min}");
        }
    }
    internal class StringValidator
    {
        public static void Test2()
        {
            int validCount = 0;
            int invalidCount = 0;

            for (int i = 0; i < 23; i++)
            {
                Console.Write("הכנס מחרוזת: ");
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
    }
}

