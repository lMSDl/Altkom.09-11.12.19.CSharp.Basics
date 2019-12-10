
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
                new Student("Lisa", "Miller", 4.5f),
                new Student("Run", "Liu" , 4.9992f),
                new Student("Sean", "Stewart", 3.9f ),
                new Student("Olinda", "Turner", 4.25f),
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

                //var filteredCollection = Collection.Where(x => x is Instructor).ToList();
                //var filteredCollection = Collection.OfType<Instructor>().ToList();
                //var filteredCollection = (from person in Collection where person is Instructor select person).ToList();

                //var filteredCollection = Collection.Where(x => x is Student).Cast<Student>().Where(x => x.AverageGrade > 3.5f).ToList();
                //var filteredCollection = Collection.OfType<Student>().Where(x => x.AverageGrade > 3.5f).ToList();
                //var filteredCollection = (from person in Collection where person is Student where ((Student)person).AverageGrade > 3.5f select person).ToList();

                //var filteredCollection = Collection.Where(x => x.LastName.Contains("x")).ToList();
                //var filteredCollection = (from person in Collection where person.LastName.Contains("x") select person).ToList();
                
                //WriteLine(string.Join("\n", filteredCollection));

                //Przykład krotki: var krotka = new {identifier = Collection[0].Id, Collection[0].LastName };



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
 
