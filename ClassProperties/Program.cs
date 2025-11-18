using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProperties
{
    //Define a class named Program that contains the main exectution logic
    internal class Program
    {
        //Define a nested class named Person to represent a person
        class Person
        {
            //Private fields to store the name and age of a person
            private string name;
            private int age;

            //Constructor to initialize a new instance of the person class
            public Person(string name, int age)
            {
                //Assign the parameters to the private fields
                this.name = name;
                this.age = age;
            }

            //Method to set the name field with validations
            public void SetName(string name)
            {
                //Assign the new name if it's not null or empty, otherwise set "Invalid name"
                this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";
            }

            //Method to get the current value of the name field 
            public string GetName()
            {
                return name;
            }

            //Method to set the age field with validations
            public void SetAge(int age)
            {
                //Assign the new age if it's within a valid range 0-150, otherwise set to -1
                this.age = age >= 0 && age <= 150 ? age : -1;
            }

            //Method to get the current value of the age field
            public int GetAge()
            {
                return age;
            }

            //Method to return a string containing the person's details
            public string ReturnDetails()
            {
                //Format and return the name and age as a string 
                return $"Name: {name}\nAge: {age}";
            }

        }

        //Main method to entry point of the program
        //above code does nothing until main method calls to it
        static void Main(string[] args)
        {
            //Create a new person object with the name "Bob" and age "55"
            Person person = new Person("Bob", 55);
            
            //Display the person details in the console
            Console.WriteLine(person.ReturnDetails());

        }
    }
}
