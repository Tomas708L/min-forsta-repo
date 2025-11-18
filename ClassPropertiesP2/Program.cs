using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPropertiesP2
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            /*
            public string Name
            {
                get => name;
                set => name = !string.IsNullOrEmpty(value) ? value : "Invalid name";
            }

            public int Age
            {
                get => age;
                set => age = value >= 0 && value <= 150 ? value : -1;
            }
            */

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public string ReturnDetails()
            {
                return $"Name: {Name}\nAge: {Age}";
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Bob", 55);
            Console.WriteLine(person.ReturnDetails());

            person.Name = "Larry";
            person.Age = 27;
            Console.WriteLine(person.ReturnDetails());

        }
    }
}
