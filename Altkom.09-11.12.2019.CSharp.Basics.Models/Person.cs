using Altkom._09_11._12._2019.CSharp.Basics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._09_11._12._19.CSharp.Basics.ConsoleProgram.Models
{
    public class Person : Base, IComparable<Person>
    {

        public Person()
        {
            var random = new Random(Id);
            BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28));
        }

        public Person(string firstName, string lastName) : this()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, DateTime birthDate) : this(firstName, lastName)
        {
            BirthDate = birthDate;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual int CompareTo(Person other)
        {
            return LastName.CompareTo(other.LastName);
        }

        public override int GetSomeInt()
        {
            return new Random().Next(1, 10);
        }

        public override string ToString()
        {
            string format = $"{{0, {3}}} {{1, -15}} {{2, -15}} {{3, -10}}";
            return string.Format(format, Id, FirstName, LastName, BirthDate.ToShortDateString());
        }

    }
}
