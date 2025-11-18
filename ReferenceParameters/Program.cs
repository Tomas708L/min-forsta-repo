using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int.TryParse("", out int index);
            string name = "Steve";

            Console.Write("Enter your new name: ");
            string newName = Console.ReadLine();

            if(ChangeName(ref name, newName))
            {
                Console.WriteLine($"Your new name is {name}!");
            }
            else
            {
                Console.WriteLine("New name cannot be empty or Null!");
            }
            /*
            int num = 10;
            string name2 = "Bob";
            Assign(ref num, ref name);
            Console.WriteLine(num);
            Console.WriteLine(name2);
            */
        }

        static bool ChangeName(ref string name, string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }
            return false;
                
        }

        static void Assign(ref int num, ref string name)
        {
            name = "Bob";
            num = 20;
        }
    }
}
