using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._09_11._12._19.CSharp.Basics.ConsoleProgram.Models
{
    public class Person : IComparable<Person>
    {
        private static int Counter = 0;

        public Person()
        {
            Id = ++Counter;
            var random = new Random();
            BirthDate = new DateTime(random.Next(1950, 2000), random.Next(1, 12), random.Next(1, 28));
        }

        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public int CompareTo(Person other)
        {
            return LastName.CompareTo(other.LastName);
        }

        public override string ToString()
        {
            return string.Format("{0, -3} {1, -15} {2, -15} {3, -10}", Id, FirstName, LastName, BirthDate.ToShortDateString());
        }
    }
}
