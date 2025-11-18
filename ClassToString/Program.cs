using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassToString
{
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;

            public Person (string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public void SetName(string name)
            {
                this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";
            }

            public string GetName() 
            { 
                return name; 
            }

            public void SetAge(int age)
            {
                this.age = age >= 0 && age <= 150 ? age: -1;
            }

            public int GetAge()
            {
                return age;
            }

            public override string ToString()
            {
                return $"Name: {name}\nAge: {age}";
            }

            public override bool Equals(object obj)
            {
                if(obj is Person)
                {
                    Person person = obj as Person;
                    return name.Equals(person.name) && age == person.age;
                }
                return false;
            }
        }

        static void Main(string[] args)
        {
            Person person = new Person("Bob", 34);
            Person test = new Person("Bob", 34);

            if (person.Equals(test))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Not same");
            }
        }
    }
}
