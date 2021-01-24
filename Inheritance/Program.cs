using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName = "ÖZKAN"
                },
                new Student
                {
                    FirstName= "BUSE"
                },
                new Person
                {
                    FirstName= "SİMGE"
                }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();

            
        }
    }
    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
    }

    class Customer :Person
    {
        public string  City { get; set; }
    }
    class Student : Person
    {
        public string Departmant { get; set; }
    }
}
