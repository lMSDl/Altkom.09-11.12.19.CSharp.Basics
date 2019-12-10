using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._09_11._12._19.CSharp.Basics.ConsoleProgram.Models
{
    public class Student : Person, IStudent
    {
        public Student(string firstName, string lastName, float averageGrade) : base(firstName, lastName)
        {
            AverageGrade = averageGrade;
        }

        public float AverageGrade { get; set; }

        public string StudentInfo()
        {
            return AverageGrade.ToString();
        }


        public override string ToString()
        {
            return string.Format($"{base.ToString()} {{0, 15}}", AverageGrade.ToString("N1"));
        }
    }
}
