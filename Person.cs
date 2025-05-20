using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOverloadsAndDefaultValue
{

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Addres { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(string name, int age, string addres)
        {
            Name = name;
            Age = age;
            Addres = addres;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Addres}");
        }
        public void PrintInfo(string extraInfo)
        {
            Console.WriteLine(Name + extraInfo);
        }
    }
}
