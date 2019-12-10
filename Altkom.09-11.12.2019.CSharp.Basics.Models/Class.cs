using Altkom._09_11._12._2019.CSharp.Basics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._09_11._12._19.CSharp.Basics.ConsoleProgram.Models
{
    public class Class : Base, IInstructor, IStudent
    {
        public Instructor Instructor { get; set; }
        public List<Student> Students { get; set; }

        public override int GetSomeInt()
        {
            return 0;
        }

        public string InstructorInfo()
        {
            return $"{Instructor.LastName} {Instructor.FirstName}";
        }

        public string StudentInfo()
        {
            var averageGrage = (from student in Students
                            select student.AverageGrade).Average();
            //averageGrage = Students.Select(x => x.AverageGrade).Average();

            return averageGrage.ToString("N1");
        }
        
    
    }
}
