using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony.summer_work
{
    public class SchoolSystem//Question 9
    {
        public static void PrintExcellent(ReportCard[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null && array[i].IsExcellent())
                {
                    Console.WriteLine(array[i].GetStuName());
                }
            }
        }

        public static void Demo()
        {
            var subjects1 = new Subject[]
            {
                new Subject("Math", 85),
                new Subject("Science", 87),
                new Subject("History", 86),
                new Subject("Art", 45),
                new Subject("PE", 100)
            };

            var subjects2 = new Subject[]
            {
                new Subject("Math", 85),
                new Subject("Science", 85),
                new Subject("History", 86)
            };

            var subjects3 = new Subject[]
            {
                new Subject("Math", 73),
                new Subject("Science", 68),
                new Subject("History", 85),
                new Subject("Art", 60),
                new Subject("PE", 100)
            };

            var subjects4 = new Subject[]
            {
                new Subject("Math", 100),
                new Subject("Science", 100),
                new Subject("History", 100),
                new Subject("Art", 54)
            };

            var subjects5 = new Subject[]
            {
                new Subject("Math", 90),
                new Subject("Science", 85),
                new Subject("History", 100),
                new Subject("Art", 60),
                new Subject("PE", 90)
            };

            var reportCards = new ReportCard[]
            {
                new ReportCard("Alice", subjects1),
                new ReportCard("Bob", subjects2),
                new ReportCard("Charlie", subjects3),
                new ReportCard("David", subjects4),
                new ReportCard("Eve", subjects5)
            };

            PrintExcellent(reportCards);
        }
    }

    public class Subject
    {
        private string subName;
        private double grade;

        public Subject(string subName, double grade)
        {
            this.subName = subName;
            this.grade = grade;
        }

        public string GetSubName()
        {
            return subName;
        }

        public void SetSubName(string value)
        {
            subName = value;
        }

        public double GetGrade()
        {
            return grade;
        }

        public void SetGrade(double value)
        {
            grade = value;
        }
    }

    public class ReportCard
    {
        private string stuName;
        private Subject[] subArray;

        public ReportCard(string stuName, Subject[] subArray)
        {
            this.stuName = stuName;
            this.subArray = subArray;
        }

        public string GetStuName()
        {
            return stuName;
        }

        public void SetStuName(string stuName)
        {
            this.stuName = stuName;
        }

        public Subject[] GetSubArray()
        {
            return subArray;
        }

        public void SetSubArray(Subject[] subArray)
        {
            this.subArray = subArray;
        }

        public double Average()
        {
            double total = 0;
            int count = subArray.Length;
            for (int i = 0; i < count; i++)
            {
                total += subArray[i].GetGrade();
            }
            return total / count;
        }

        public bool IsExcellent()
        {
            bool hasHundred = false;
            for (int i = 0; i < subArray.Length; i++)
            {
                if (subArray[i].GetGrade() < 55)
                {
                    return false;
                }
                if (subArray[i].GetGrade() == 100)
                {
                    hasHundred = true;
                }
            }
            return Average() >= 85 && hasHundred;
        }
    }
}




