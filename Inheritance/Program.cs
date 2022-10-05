using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{ FirstName="Max"},new Student{FirstName="Checo"}, new Person{FirstName="Christian"}  
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            
        }
    }
}
