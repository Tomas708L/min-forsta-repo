using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGrader
{
    internal class Program
    {
        class Student
        {
            private int Marks;
            private int ObtainedMarks;

            //Constructor
            public Student(int marks, int obtainedMarks)
            {
                Marks = marks;
                ObtainedMarks = obtainedMarks;
            }
            //Method to calculate the %
            public double CalculatePercentage()
            {
                return (double) ObtainedMarks / Marks * 100;
            }
            //Method to generate message
            public string GetMessage()
            {
                double percentage = CalculatePercentage();

                if (percentage >= 90)
                {
                    return $"Exellent! {percentage:F2}%";
                }
                else if (percentage >= 75)
                {
                    return $"Good job! {percentage:F2}%";
                }
                else if (percentage >= 50)
                {
                    return $"You passed with! {percentage:F2}%";
                }
                else
                {
                    return $"You scored! {percentage:F2}%. Better luck next time.";
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the totalt marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the marks obtained: ");
            int obtainedMarks = Convert.ToInt32(Console.ReadLine());

            Student student = new Student(marks, obtainedMarks);

            double percentage = student.CalculatePercentage();
            string message = student.GetMessage();

            Console.Write($"Percentage: {percentage:F2}% ");
            Console.WriteLine(message);
        }
    }
}
