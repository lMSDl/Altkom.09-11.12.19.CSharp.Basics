
using Altkom._09_11._12._19.CSharp.Basics.ConsoleProgram.Models;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Altkom._09_11._12._19.CSharp.Basics.ConsoleProgram
{
    class Program
    {
        public static Program() {
            var random = new Random();
            Collection = new List<Person>() {
                new Person() { FirstName = "Kevin", LastName = "Liu", BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28)) },
                new Person() { FirstName = "Martin", LastName = "Weber", BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28)) },
                new Person() { FirstName = "George", LastName = "Li", BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28)) },
                new Person() { FirstName = "Lisa", LastName = "Miller", BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28)) },
                new Person() { FirstName = "Run", LastName = "Liu", BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28)) },
                new Person() { FirstName = "Sean", LastName = "Stewart", BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28)) },
                new Person() { FirstName = "Olinda", LastName = "Turner", BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28)) },
                new Person() { FirstName = "Jon", LastName = "Orton", BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28)) },
                new Person() { FirstName = "Toby", LastName = "Nixon", BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28)) },
                new Person() { FirstName = "Daniela", LastName = "Guinot", BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28)) },
                new Person() { FirstName = "Vijay", LastName = "Sundaram", BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28)) },
                new Person() { FirstName = "Chris", LastName = "Meyer", BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28)) },
                new Person() { FirstName = "Eric", LastName = "Gruber", BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28)) },
                new Person() { FirstName = "Piotr", LastName = "Piotrowski", BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28)) },
                new Person() { FirstName = "Chris", LastName = "Meyer", BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28)) },
                new Person() { FirstName = "Yuhong", LastName = "Li", BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28)) },
                new Person() { FirstName = "Yan", LastName = "Li", BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28)) },
                new Person() { FirstName = "Piotr", LastName = "Piotrowski", BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28)) },
                new Person() { FirstName = "Adam", LastName = "Adamski", BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28)) }};
        }
        
        private static List<Person> Collection;
            
        static void Main(string[] args)
        {
            string line;
            do
            {
                //Collection.Sort();
                WriteLine(string.Join("\n", Collection.OrderBy(x => x.LastName)));
                
                line = Console.ReadLine();
                switch(line)
                {
                    case "add":
                        NewPerson();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Nieznana komenda...");
                        Console.ReadKey();
                        break;
                }
            }
            while (line != "exit");
        }

        static void NewPerson()
        {
            var person = new Person();
            WriteLine(nameof(Person.FirstName));
            person.FirstName = Console.ReadLine();

            WriteLine(nameof(Person.LastName));
            person.LastName = Console.ReadLine();

            Collection.Add(person);
        }

        static void WriteLine(string line)
        {
            Console.Clear();
            Console.WriteLine(line);
            Console.WriteLine();
        }
    }
}
 
