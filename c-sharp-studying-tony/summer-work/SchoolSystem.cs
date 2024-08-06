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
            foreach (var reportCard in array)
            {
                if (reportCard != null && reportCard.IsExcellent())
                {
                    Console.WriteLine(reportCard.GetSubName());
                }
            }
        }
        public static void Demo()
        {
            var subjects1 = new Subject[]
            {
            new Subject("Math", 95),
            new Subject("Science", 89)
            };

            var subjects2 = new Subject[]
            {
            new Subject("Math", 91),
            new Subject("Science", 92)
            };

            var reportCards = new ReportCard[]
            {
            new ReportCard("Alice", subjects1),
            new ReportCard("Bob", subjects2)
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
        private string subName;
        private Subject[] subArray;

        public ReportCard(string subName, Subject[] subArray)
        {
            this.subName = subName;
            this.subArray = subArray;
        }

        public string GetSubName()
        {
            return subName;
        }

        public void SetSubName(string value)
        {
            subName = value;
        }

        public Subject[] GetSubArray()
        {
            return subArray;
        }

        public void SetSubArray(Subject[] value)
        {
            subArray = value;
        }

        public double Average()
        {
            double total = 0;
            int count = subArray.Length;
            foreach (var subject in subArray)
            {
                total += subject.GetGrade();
            }
            return total / count;
        }

        public bool IsExcellent()
        {
            return Average() > 90;
        }
    }
}





