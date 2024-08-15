using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony.summer_work
{
    public class Question4
    {
        static void testQuestion4()
        {
            Console.WriteLine("Enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            string firstNumberStr = firstNumber.ToString();
            string secondNumberStr = secondNumber.ToString();

            string result = "";

            for (int i = 0; i < firstNumberStr.Length; i++)
            {
                int count = int.Parse(firstNumberStr[i].ToString());
                char digit = secondNumberStr[i];

                for (int j = 0; j < count; j++)
                {
                    result += digit;

                    if (result.Length == 9) 
                        break;
                }

                if (result.Length == 9)
                    break;
            }

            int finalResult = int.Parse(result);
            Console.WriteLine("The resulting number is: " + finalResult);
        }
    }
}
