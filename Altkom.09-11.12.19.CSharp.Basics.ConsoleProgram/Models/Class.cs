using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._09_11._12._19.CSharp.Basics.ConsoleProgram.Models
{
    public class Class : IInstructor
    {
        public Instructor Instructor { get; set; }

        public string InstructorInfo()
        {
            return $"{Instructor.LastName} {Instructor.FirstName}";
        }
    }
}
