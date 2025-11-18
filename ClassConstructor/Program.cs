using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassConstructor
{
    class Person
    {
        //Properties of the class 
        public string Name { get; set; }
        public int Age { get; set; }

        //Constructor to initialize Name and Age
        public Person(string name, int age)
        {
            Name = name; //Set the Name property
            Age = age; //Set the Age property
        }

        //Method to display details about a person
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of the "Person"-class using the constructor
            Person person = new Person("Alice", 25);

            //Cal the method to display
            person.DisplayInfo();
        }
    }
}
