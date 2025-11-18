using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFunctions
{
    internal class Program
    {
        class Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public string ReturnDetails()
            {
                return $"Name: {name}\nAge: {age}";
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person("Bob", 37);
            Console.WriteLine(ReturnDetails(person));
            Console.WriteLine(person.ReturnDetails());
        }
        
        static string ReturnDetails(Person person)
        {
            return $"Name: {person.name}\nAge: {person.age}";
        }
    }
}
