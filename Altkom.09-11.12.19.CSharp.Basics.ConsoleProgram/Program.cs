
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
                new Person() { FirstName = "Adam", LastName = "Adamski" },
                new Person() { FirstName = "Piotr", LastName = "Piotrowski" },
                new Person() };

        static void Main(string[] args)
        {
            string line;
            do
            {
                foreach (var item in Collection)
                {
                    Console.WriteLine(item);
                }
                line = Console.ReadLine();

                switch(line)
                {
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("Nieznana komenda");
                        break;
                }
            }
            while (line != "exit");
        }
    }
}
 