
using Altkom._09_11._12._19.CSharp.Basics.ConsoleProgram.Models;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Altkom._09_11._12._19.CSharp.Basics.ConsoleProgram
{
    public class Program
    {
        static Program() {
            var random = new Random();
            Collection = new List<Person>() {
                new Instructor(lastName: "Liu", firstName: "Kevin", specialization: "Programming"),
                new Person("Martin", lastName: "Weber"),
                new Person("George", "Li", new DateTime(1966, 3, 13)),
                new Person() { FirstName = "Lisa", LastName = "Miller" },
                new Person() { FirstName = "Run", LastName = "Liu" },
                new Person() { FirstName = "Sean", LastName = "Stewart" },
                new Person() { FirstName = "Olinda", LastName = "Turner" },
                new Person() { FirstName = "Jon", LastName = "Orton" },
                new Person() { FirstName = "Toby", LastName = "Nixon" },
                new Person() { FirstName = "Daniela", LastName = "Guinot" },
                new Person() { FirstName = "Vijay", LastName = "Sundaram" },
                new Person() { FirstName = "Chris", LastName = "Meyer" },
                new Person() { FirstName = "Eric", LastName = "Gruber" },
                new Person() { FirstName = "Yuhong", LastName = "Li" },
                new Person() { FirstName = "Yan", LastName = "Li" },
                new Person() { FirstName = "Piotr", LastName = "Piotrowski" },
                new Person() { FirstName = "Adam", LastName = "Adamski" }};
        }
        
        private static List<Person> Collection;
            
        static void Main(string[] args)
        {
            string line;
            do
            {
                Collection.Sort();
                WriteLine(string.Join("\n", Collection));
                
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
 
