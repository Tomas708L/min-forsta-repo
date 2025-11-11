using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Uppgift_17_Dictionary_case_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            bool running = true;

            Console.WriteLine("===== students Management Menu =====");
            Console.WriteLine("1 - Add a new student");
            Console.WriteLine("2 - Remove a student");
            Console.WriteLine("3 - Display all students");
            Console.WriteLine("4 - Exit");
            Console.Write("Choose an option (1-4): ");
            string input = Console.ReadLine();
            int numInput = Convert.ToInt32(input);

            switch(numInput)
            {
                case 1:
                    Console.Write("Enter Student ID (number): ");
                    string textID = Console.ReadLine();
                    int numberID = Convert.ToInt32(textID);
                    Console.Write("\nEnter Student Name: ");
                    string name = Console.ReadLine();
                    students.Add(numberID, name);
                    Console.WriteLine("Student has been added successfully");
                    break;
                case 2:
                    Console.Write("Enter student ID to be removed: ");
                    string studentID2 = Console.ReadLine();
                    int numberID2 = Convert.ToInt32(studentID2);
                    if(students.ContainsKey(numberID2))
                    {
                        students.Remove(numberID2);
                        Console.WriteLine($"The student {numberID2} has been removed");
                    }
                    else
                    {
                        Console.WriteLine("Student couldnt be found");
                    }
                    break;
                case 3:
                    foreach(int studentID in students.Keys)
                    {
                        Console.WriteLine($"Here are all the students currently logged {studentID}");
                    }
                    break;
                case 4:
                    while(Console.ReadKey(true).KeyChar != '4')
                    {
                        Environment.Exit(0);

                    }
                    break;



                    
            }

           

        }
    }
}
