using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony.summer_work
{
    public class ExampleUtils
    {

        public static void DemoUtils()
        {

            string str = "Hello Israel";
            Console.WriteLine("Iterate over string = " + str);

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("char - " + str[i]);
            }

            Console.WriteLine("Split by whitespace( )");


            str = "Heloo World how are you today?";

            string[] strs = str.Split(' ');




            for (int i = 0; i < strs.Length; i++)
            {

                Console.WriteLine("word " + (i + 1) + "= " + strs[i]);
            }
            Console.WriteLine("Split by wall - |");

            str = "I|Am|Separted|by|standing|wall";

            strs = str.Split('|');
            for (int i = 0; i < strs.Length; i++)
            {

                Console.WriteLine("word " + (i + 1) + "= " + strs[i]);
            }


            int[] directly = { 2, 3, 5 };
            //int[][] multiDimensional = new int[3][];
            //int[] row1 = { 2, 1, 5 };
            //int[] row2 = { 6,7,3};
            //int[] row3 = { 0, 8, 0 };
            int[,] numbers = { { 2, 1, 5 }, { 6, 7, 3 }, { 0, 8, 0 } };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {

                Console.WriteLine(i + 1 + "- row:");
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + ",");

                }
                Console.WriteLine();
            }

            Console.WriteLine("Show digits of number:");

            PrintDigitByMath(65987);
            PrintDigitByMath(65987, true);
        }

        public static void PrintDigitByMath(int number1)
        {
            Console.WriteLine("digits from the right of :" + number1);
            while (number1 > 0)
            {
                int digit = number1 % 10;
                Console.WriteLine(digit);
                number1 /= 10;
            }
        }

        public static void PrintDigitByMath(int number1, bool b)
        {
            Console.WriteLine("digits from the left of :" + number1);

            //find the first divider: 
            int tempNumber = number1;
            int multiple10 = 1;
            while (tempNumber > 10)
            {
                multiple10 *= 10;
                tempNumber /= 10;
            }

            while (multiple10 > 0)
            {
                int digit = number1 / multiple10;
                Console.WriteLine(digit);
                number1 -= (digit * multiple10);
                multiple10 /= 10;
            }
        }
    }
}
