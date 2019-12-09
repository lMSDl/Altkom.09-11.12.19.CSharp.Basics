
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
            for (int i = 0; i < Collection.Count; i++)
            {
                Console.WriteLine($"{Collection[i].LastName} {Collection[i].FirstName}");
            }

            Console.ReadKey();
        }
    }
}
 