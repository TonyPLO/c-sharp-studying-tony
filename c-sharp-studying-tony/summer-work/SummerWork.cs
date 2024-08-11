using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony.summer_work
{
    public class SummerWork
    {
        public static void Demo()
        {
            //CalculateGradesAverageDemo();//Question 1
            //PrintEvens();//Question 2 
            //CaseCount();//Question 3
            //SchoolSystem.Demo();//Question 9
            //CarInfo();//Question 10
        }


        public static void CalculateGradesAverageDemo()//Question 1
        {
            List<int> grades = new List<int>();
            int grade = 0;
            while (grade != 101)
            {
                Console.WriteLine("insert grade");
                string userInput = Console.ReadLine();

                //string to number
                grade = Int32.Parse(userInput);

                if (grade >= 70 && grade <= 100)
                {
                    grades.Add(grade);
                }
                Console.WriteLine("grade = " + grade);
            }

            double sum = 0;

            for (int i = 0; i < grades.Count; i++)
            {
                sum += grades[i];
            }
            sum /= grades.Count;
            Console.WriteLine("average is =" + sum);
        }
        //בדיקות לשאלה 1
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

        public static void PrintEvens()//Question 2
        {
            Random random = new Random();

            while (true)
            {

                int number = random.Next(10, 99);

                Console.WriteLine("number was drawn: " + number);

                if (number == 18)
                {
                    Console.WriteLine("number 18 was drawn. End of the program.");
                    break;
                }
            }
        }
        //בדיקות לשאלה - ע"י הרצה.


        public static void CaseCount()//Question 3
        {
            int upperCaseCount = 0;
            int lowerCaseCount = 0;

            while (true)
            {
                Console.WriteLine("Enter letter or digit:");
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

            Console.WriteLine("Upper Case Letters: " + upperCaseCount);
            Console.WriteLine("Lower Case Letters: " + lowerCaseCount);
        }
        //בדיקות לשאלה 3
        //Input: A, b, C, d, E, 3
        //פלט : מספר האותיות הגדולות שנקלטו: 3, מספר האותיות הקטנות שנקלטו: 2
        //קלט: a, b, c, d, e, 1
        // פלט: מספר האותיות הגדולות שנקלטו: 0, מספר האותיות הקטנות שנקלטו: 5
        //קלט: A, B, C, D, E, 2
        //פלט : מספר האותיות הגדולות שנקלטו: 5, מספר האותיות הקטנות שנקלטו: 0
        //קלט: A, a, B, b, C, c, 5
        //פלט : מספר האותיות הגדולות שנקלטו: 3, מספר האותיות הקטנות שנקלטו: 3
        //קלט: 4
        //פלט : מספר האותיות הגדולות שנקלטו: 0, מספר האותיות הקטנות שנקלטו: 0
        public class CarInfo
        {
            private string id;
            private bool isPrivate;
            private int speed;

            public string GetId() { return id; }
            public void SetId(string value) { id = value; }

            public bool GetIsPrivate() { return isPrivate; }
            public void SetIsPrivate(bool value) { isPrivate = value; }

            public int GetSpeed() { return speed; }
            public void SetSpeed(int value) { speed = value; }

            internal bool Illegal(int maxSpeed)
            {
                return isPrivate || speed > maxSpeed;
            }
        }

        public class CameraInfo
        {
            private int city;
            private int maxSpeed;
            private CarInfo[] cars;

            public int GetCity() { return city; }
            public void SetCity(int value) { city = value; }

            public int GetMaxSpeed() { return maxSpeed; }
            public void SetMaxSpeed(int value) { maxSpeed = value; }

            public CarInfo[] GetCars() { return cars; }
            public void SetCars(CarInfo[] value) { cars = value; }


            internal bool AllGood()
            {
                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i] != null && cars[i].Illegal(maxSpeed))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public static int LegalCities(CameraInfo[] cameras)
        {
            HashSet<int> citiesWithNoViolations = new HashSet<int>();

            for (int i = 0; i < cameras.Length; i++)
            {
                if (cameras[i].AllGood())
                {
                    citiesWithNoViolations.Add(cameras[i].GetCity());
                }
            }

            return citiesWithNoViolations.Count;
        }
    }

}

