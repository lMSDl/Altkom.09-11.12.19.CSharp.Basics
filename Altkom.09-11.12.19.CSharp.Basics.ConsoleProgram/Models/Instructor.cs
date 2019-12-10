using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._09_11._12._19.CSharp.Basics.ConsoleProgram.Models
{
    public class Instructor : Person, IInstructor
    {
        public Instructor(string firstName, string lastName, string specialization) : base(firstName, lastName)
        {
            Specialization = specialization;
        }


        private string _specialization;

        public string Specialization
        {
            get
            {
                return _specialization;
            }
            set
            {
                if(value != null)
                    _specialization = value;
            }
        }


        public string InstructorInfo() =>  $"Spec: {Specialization}";

        public override string ToString()
        {
            return string.Format($"{base.ToString()} {{0, 15}}", Specialization);
        }

    }
}
