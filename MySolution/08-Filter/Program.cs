using System;
using System.Collections.Generic;

namespace _08_Filter
{

    class Program
    {
        public static void PrintPersons(List<Person> persons)
        {

            foreach (Person person in persons)
            {
                Console.WriteLine("Person : [ Name : " + person.Name + ", Gender : " + person.Gender + ", Marital Status : " + person.Marital + " ]");
            }
        }

        static void Main(string[] args) 
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Person("Robert", "Male", "Single"));
            persons.Add(new Person("John", "Male", "Married"));
            persons.Add(new Person("Laura", "Female", "Married"));
            persons.Add(new Person("Diana", "Female", "Single"));
            persons.Add(new Person("Mike", "Male", "Single"));
            persons.Add(new Person("Bobby", "Male", "Single"));

            ICriteria male = new MaleCriteria();
            ICriteria female = new FemaleCriteria();
            ICriteria single = new SingleCriteria();
            ICriteria married = new MarriedCriteria();

            Console.WriteLine("Males: ");
            PrintPersons(male.meetCriteria(persons));

            Console.WriteLine("Females: ");
            PrintPersons(female.meetCriteria(persons));

            Console.WriteLine("Singles: ");
            PrintPersons(single.meetCriteria(persons));

            Console.WriteLine("Married: ");
            PrintPersons(married.meetCriteria(persons));

            Console.WriteLine("Hello World!");
        }
    }
}

