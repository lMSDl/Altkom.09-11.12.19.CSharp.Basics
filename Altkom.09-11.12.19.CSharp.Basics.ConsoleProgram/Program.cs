
using Altkom._09_11._12._19.CSharp.Basics.ConsoleProgram.Models;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Altkom._09_11._12._19.CSharp.Basics.ConsoleProgram.Exceptions;
using Altkom._09_11._12._19.CSharp.Basics.ConsoleProgram.Properties;
using Altkom._09_11._12._2019.CSharp.Basics.Models;

namespace Altkom._09_11._12._19.CSharp.Basics.ConsoleProgram
{
    public class Program
    {
        enum Commands
        {
            Add = 100,
            Delete,
            Edit = 200,
            Exit
        }

        static Program() {
            var random = new Random();
            Collection = new List<Person>() {
                new Instructor(lastName: "Liu", firstName: "Kevin", specialization: "Programming"),
                new Person("Martin", lastName: "Weber"),
                new Student("Lisa", "Miller", 4.5f),
                new Student("Run", "Liu" , 4.9992f),
                new Student("Sean", "Stewart", 3.9f ),
                new Student("Olinda", "Turner", 4.25f),
                new Person() { FirstName = "Jon", LastName = "Orton" },
                new Person() { FirstName = "Toby", LastName = "Nixon" },
                new Person() { FirstName = "Daniela", LastName = "Meyer" },
                new Person() { FirstName = "Vijay", LastName = "Meyer" },
                new Person() { FirstName = "Chris", LastName = "Meyer" },
                new Person() { FirstName = "Eric", LastName = "Gruber" },
                new Student("Yuhong", "Li", 3.5f ),
                new Student("Yan", "Li", 4.5f),
                new Student("George", "Li", 4.5f),
                new Person() { FirstName = "Piotr", LastName = "Piotrowski" },
                new Person() { FirstName = "Adam", LastName = "Adamski" }};
        }
        
        private static List<Person> Collection;
            
        static void Main(string[] args)
        {
            string line;
            Commands command;
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
                var splitedLine = line.Split(' ');
                int id;


                Enum.TryParse<Commands>(splitedLine[0], true, out command);
                try
                {
                    switch (command)
                    {
                        case Commands.Delete:
                            try
                            {
                                id = int.Parse(splitedLine[1]);
                                DeletePerson(id);
                            }
                            catch (Exception e)
                            {
                                Debug.Write(e);
                                Console.WriteLine(Resources.WrongCommand);
                                Console.ReadKey();
                            }

                            break;
                        case Commands.Edit:
                            id = int.Parse(splitedLine[1]);
                            EditPerson(Collection.Single(x => x.Id == id));
                            break;
                        case Commands.Add:
                            NewPerson();
                            break;
                        case Commands.Exit:
                            break;
                        default:
                            Console.WriteLine(Resources.UnknownCommand);
                            Console.ReadKey();
                            break;
                    }
                }
                catch (InputDataException e)
                {
                    Debug.Write(e);
                    WriteLine(string.Format(Resources.InputDataFailed, e.FieldName));
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Debug.Write(e);
                }
            }
            while (command != Commands.Exit);
        }

        static void EditPerson(Person person)
        {
            WriteLine(nameof(Person.FirstName));
            SendKeys.SendWait(person.FirstName);
            person.FirstName = Console.ReadLine();

            WriteLine(nameof(Person.LastName));
            SendKeys.SendWait(person.LastName);
            person.LastName = Console.ReadLine();

            WriteLine(nameof(Person.BirthDate));
            SendKeys.SendWait(person.BirthDate.ToShortDateString());
            try
            {
                person.BirthDate = DateTime.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                throw new InputDataException(nameof(Person.BirthDate));
            }
        }



        static void NewPerson()
        {
            var person = new Person();
            EditPerson(person);
            Collection.Add(person);
        }
        
        static void DeletePerson(int id)
        {
            Collection.RemoveAll(x => x.Id == id);

            //var item = Collection.SingleOrDefault(x => x.Id == id);
            //if (item != null)
            //    Collection.Remove(item);
            
            //var itemIndex = Collection.FindIndex(x => x.Id == id);
            //if (itemIndex >= 0)
            //    Collection.RemoveAt(itemIndex);
        }

        static void WriteLine(string line)
        {
            Console.Clear();
            Console.WriteLine(line);
            Console.WriteLine();
        }
    }
}
 
