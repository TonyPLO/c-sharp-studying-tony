using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony
{
    public class Try1
    {
        public double x = 23.5;
        public static void PrintEvens(int numMax)
        {
            Console.WriteLine("hello tony");
            for (int i = 0; i <= numMax; i += 2)
            {
                Console.WriteLine(i);
            }
            Room.Glass(1);
            Room.price = 97.8;
            Room.Glass(3);
        }
    }
    public class Question
    {
        public static void Demno(string[] args)
        {
            List<int> grades = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter grade");
                int grade;
                if (int.TryParse(Console.ReadLine(), out grade))
                {
                    grades.Add(grade);
                }
            }

            double sum = 0;
            int count = 0;

            foreach (int grade in grades)
            {
                if (grade >= 70)
                {
                    sum += grade;
                    count++;
                }
            }

            if (count > 0)
            {
                double average = sum / count;
                Console.WriteLine("The average scores are greater than or equal to 70: " + average);
            }
            else
            {
                Console.WriteLine("No scores greater than or equal to 70 were entered.");
            }
        }
    }

    // קלט: 90, 85, 70, 60, 50, 40, 
    //פלט : ממוצע הציונים הגדולים או שווים ל-70: 81.67
    //קלט: 75, 80, 95, 100, 
    //פלט : ממוצע הציונים הגדולים או שווים ל-70: 87.5
    //קלט: 50, 65, 60, 55, 
    // פלט: לא הוזנו ציונים גדולים או שווים ל-70
    //קלט: 100, 90, 70, 80, 85, 
    //פלט : ממוצע הציונים הגדולים או שווים ל-70: 85
    //קלט: 70, 71, 72, 73, 74, 
    //פלט : ממוצע הציונים הגדולים או שווים ל-70: 72
    public class Question2
    {
        public static void PrintEvens(int numMax)
        {
            Random random = new Random();

            while (true)
            {
                int number = 10 + random.Next(90);

                Console.WriteLine("number was drawn: " + number);

                if (number == 18)
                {
                    Console.WriteLine("number 18 was drawn. End of the program.");
                    break;
                }
            }
        }
    }
    //וגרל המספר: 37
    //הוגרל המספר: 55
    //הוגרל המספר: 23
    //הוגרל המספר: 18
    //הוגרל המספר 18. סיום התוכנית.
    public class Question3
    {
        public static void Main(string[] args)
        {
            int upperCaseCount = 0;
            int lowerCaseCount = 0;

            while (true)
            {
                Console.WriteLine("הזן אות באנגלית או ספרה לסיום");
                string input = Console.ReadLine();
                char ch = input[0];

                if (char.IsDigit(ch))
                {
                    break;
                }

                if (char.IsUpper(ch))
                {
                    upperCaseCount++;
                }
                else if (char.IsLower(ch))
                {
                    lowerCaseCount++;
                }
            }

            Console.WriteLine("מספר האותיות הגדולות שנקלטו: " + upperCaseCount);
            Console.WriteLine("מספר האותיות הקטנות שנקלטו: " + lowerCaseCount);
        }
    }
}
//קלט: A, b, C, d, E, 3
//פלט : מספר האותיות הגדולות שנקלטו: 3, מספר האותיות הקטנות שנקלטו: 2
//קלט: a, b, c, d, e, 1
// פלט: מספר האותיות הגדולות שנקלטו: 0, מספר האותיות הקטנות שנקלטו: 5
//קלט: A, B, C, D, E, 2
//פלט : מספר האותיות הגדולות שנקלטו: 5, מספר האותיות הקטנות שנקלטו: 0
//קלט: A, a, B, b, C, c, 5
//פלט : מספר האותיות הגדולות שנקלטו: 3, מספר האותיות הקטנות שנקלטו: 3
//קלט: 4
//פלט : מספר האותיות הגדולות שנקלטו: 0, מספר האותיות הקטנות שנקלטו: 0


