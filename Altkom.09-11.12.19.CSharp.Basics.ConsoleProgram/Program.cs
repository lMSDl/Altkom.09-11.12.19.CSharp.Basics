
using Altkom._09_11._12._19.CSharp.Basics.ConsoleProgram.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Altkom._09_11._12._19.CSharp.Basics.ConsoleProgram
{
    class Program
    {
        private static List<Person> Collection =
            new List<Person>() {
                new Person() { FirstName = "Adam", LastName = "Adamski", BirthDate = new DateTime(2000, 11, 12) },
                new Person() { FirstName = "Piotr", LastName = "Piotrowski", BirthDate = new DateTime(1967, 1, 22) } };

        static void Main(string[] args)
        {
            string line;
            do
            {
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
 