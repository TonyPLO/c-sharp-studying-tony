using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony.summer_work
{
    public class Question6
    {
        public static void TestQuestion6()
        {
            Console.WriteLine("Insert a string:");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            StringBuilder result = new StringBuilder();

            string addedChars = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    char firstChar = words[i][0];

                    if (!addedChars.Contains(firstChar))
                    {
                        addedChars += firstChar;
                        result.Append(firstChar);
                    }
                }
            }
            Console.WriteLine("New string: " + result.ToString());
        }
    }
}
